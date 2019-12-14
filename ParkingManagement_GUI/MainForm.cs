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
using ZXing;
using ZXing.Aztec;

namespace ParkingManagement_GUI
{
    public partial class MainForm : Form
    {
        FilterInfoCollection CaptureDevice; // variable use to get all webcam from device
        VideoCaptureDevice CamIN,CamOUT,CamScan; // Camera for in and out vehicle and scan QR code

        int inCamPosition = -1, outCamPosition = -1, scanCamPosition = -1;
        string previousCode = ""; // save previous code to use for event tick of scan timer

        public MainForm()
        {
            InitializeComponent();
        }

        // event when MainForm starting
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

        // Out vehicle camera
        // event to update frame for picturebox view out vehicle camera
        private void CamOUT_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            OutputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        // Scan camera
        // event to update frame for picturebox scan QR code from vehicle ticket
        private void CamScan_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScanCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        // event to start scan camera timer
        private void StartScanCodeBut_Click(object sender, EventArgs e)
        {
            if (ScanCameraPB.Image != null)
            {
                ScanCamTimer.Enabled = true;
                ScanCamTimer.Start();
            }
        }

        // event for timer to scan QR code on vehicle ticket
        private void ScanCamTimer_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result finalCode = Reader.Decode((Bitmap)ScanCameraPB.Image);

            try
            {
                string decodedCode = finalCode.ToString().Trim();

                if (string.IsNullOrEmpty(decodedCode) == false && string.IsNullOrWhiteSpace(decodedCode) == false && decodedCode.Equals(previousCode) == false)
                {
                    ScanCamTimer.Stop();
                    MessageBox.Show(decodedCode);

                    previousCode = decodedCode;

                    ScanCamTimer.Start();
                }
            }
            catch (Exception)
            {

            }
        }

        // event for set up camera button click
        private void btnConfig_Click(object sender, EventArgs e)
        {
            CameraManageForm ManageForm = new CameraManageForm(inCamPosition, outCamPosition, scanCamPosition);

            ManageForm.Show();

            ManageForm.StartCamera += ManageForm_StartCamera;
            ManageForm.StopCamera += ManageForm_StopCamera;
        }

        // method use for stop and reset camera position in choose camera combobox
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
            if (CamIN != null || CamOUT != null || CamScan != null)
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
