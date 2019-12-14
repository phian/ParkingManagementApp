using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using BasselTech_CamCapture;

namespace ParkingManagement_GUI
{
    public partial class MainForm : Form
    {
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice CamIN,CamOUT,CamScan;

        Camera camera;
        BackgroundWorker background;
        Bitmap captureImg;


        int inCamPosition = -1, outCamPosition = -1, scanCamPosition = -1;

        public MainForm()
        {
            InitializeComponent();
            StartScanCamera();
        }

        public void StartScanCamera()
        {
            camera = new Camera(ScanCameraPB);
            background = new BackgroundWorker();
            background.DoWork += Background_DoWork;

            try
            {
                camera.Start();
                ScanCamTimer.Start();
            }
            catch (Exception)
            {
                camera.Stop();
                ScanCamTimer.Stop();
            }
        }

        private void Background_DoWork(object sender, DoWorkEventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();

            try
            {
                MessageBox.Show(decoder.decode(new QRCodeBitmapImage(captureImg)));
            }
            catch (Exception)
            {

            }
        }

        private void ScanCamTimer_Tick(object sender, EventArgs e)
        {
            captureImg = camera.GetBitmap();

            if (captureImg != null && !background.IsBusy)
            {
                background.RunWorkerAsync();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice); // set up input type
        }

        // event when user click start in camera button in set up form
        private void ManageForm_StartCamera(int inCam,int outCam,int scanCam)
        {
            inCamPosition = inCam;
            outCamPosition = outCam;
            scanCamPosition = scanCam;

            if (CamIN == null || CamIN.IsRunning == false)
            {
                CamIN = new VideoCaptureDevice(CaptureDevice[inCam].MonikerString);
                CamIN.Start();
                CamIN.NewFrame += CamIN_NewFrame;
                
                CamOUT = new VideoCaptureDevice(CaptureDevice[outCam].MonikerString);
                CamOUT.Start();
                CamOUT.NewFrame += CamOUT_NewFrame;

                CamScan = new VideoCaptureDevice(CaptureDevice[scanCam].MonikerString);
                CamScan.Start();
                CamScan.NewFrame += CamScan_NewFrame;

                return;
            }
        }

        // In vehicle camera
        // event to update frame for picturebox view in vehicle camera
        private void CamIN_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            InputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CamOUT_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            OutputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CamScan_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //ScanCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();

           
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            CameraManageForm ManageForm = new CameraManageForm(inCamPosition, outCamPosition, scanCamPosition);

            ManageForm.Show();

            ManageForm.StartCamera += ManageForm_StartCamera;
            ManageForm.StopCamera += ManageForm_StopCamera;
        }

        private void ManageForm_StopCamera()
        {
            CamIN.SignalToStop();
            CamIN.WaitForStop();
            CamOUT.SignalToStop();
            CamOUT.WaitForStop();
            CamScan.SignalToStop();
            CamScan.WaitForStop();

            inCamPosition = -1;
            outCamPosition = -1;
            scanCamPosition = -1;

            InputCameraPB.Image = null;
            OutputCameraPB.Image = null;
            ScanCameraPB.Image = null;
        }


        // event when user out the main form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CamIN != null)
            {
                CamIN.SignalToStop();
                CamIN.WaitForStop();
                CamOUT.SignalToStop();
                CamOUT.WaitForStop();
                CamScan.SignalToStop();
                CamScan.WaitForStop();
            }
        }

    }
}
