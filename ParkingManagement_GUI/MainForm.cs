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

namespace ParkingManagement_GUI
{
    public partial class MainForm : Form
    {
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice CaptureImg;
        MJPEGStream PhoneCamStream;
        CameraManageForm ManageForm = new CameraManageForm();

        bool isInCam1 = false, isOutCam1 = false, isInCam2 = false, isOutCam2 = false;


        public MainForm()
        {
            InitializeComponent();

            ManageForm.StartCamera += ManageForm_StartCamera;
        }

        // event when MainForm was loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            ManageForm.Show();

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice); // set up input type
            PhoneCamStream = new MJPEGStream("http://192.168.43.179:8080/video");

            foreach (FilterInfo item in CaptureDevice) // Add available web cam for combobox
            {
                CaptureCB.Items.Add(item.Name);
            }

            CaptureCB.Items.Add("Phone Camera");
            CaptureCB.SelectedIndex = 0;
            CaptureImg = new VideoCaptureDevice();
        }

        private void ManageForm_StartCamera(int InCamIndex, int OutCamIndex, bool IsStartInCamButClicked, bool IsStartOutCamButClicked)
        {
            if (IsStartInCamButClicked && IsStartOutCamButClicked == false)
            {
                if (InCamIndex == 0)
                {
                    // create view for in vehicle camera
                    CaptureImg = new VideoCaptureDevice(CaptureDevice[CaptureCB.SelectedIndex].MonikerString);
                    CaptureImg.Start();
                    CaptureImg.NewFrame += CaptureImg_NewFrame;

                    isInCam1 = true;
                    isOutCam1 = false;
                    isInCam2 = false;
                    isOutCam2 = false;
                }
                else
                {
                    // create view for out vehicle camera
                    PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                    PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                    PhoneCamStream.Start();

                    isInCam2 = true;
                    isOutCam2 = false;
                    isInCam1 = false;
                    isOutCam1 = false;
                }
            }
            else if (IsStartInCamButClicked && IsStartOutCamButClicked)
            {
                if (InCamIndex == 0)
                {
                    // create view for in vehicle camera
                    CaptureImg = new VideoCaptureDevice(CaptureDevice[CaptureCB.SelectedIndex].MonikerString);
                    CaptureImg.Start();
                    CaptureImg.NewFrame += CaptureImg_NewFrame;

                    // create view for out vehicle camera
                    PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                    PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                    PhoneCamStream.Start();

                    isInCam1 = true;
                    isOutCam1 = false;
                    isOutCam2 = true;
                    isInCam2 = false;
                }
                else
                {
                    // create view for out vehicle camera
                    PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                    PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                    PhoneCamStream.Start();

                    // create view for in vehicle camera
                    CaptureImg = new VideoCaptureDevice(CaptureDevice[CaptureCB.SelectedIndex].MonikerString);
                    CaptureImg.Start();
                    CaptureImg.NewFrame += CaptureImg_NewFrame;

                    isInCam2 = true;
                    isOutCam2 = false;
                    isOutCam1 = true;
                    isInCam1 = false;
                }
            }
            else if (IsStartInCamButClicked == false && IsStartOutCamButClicked)
            {
                // create view for out vehicle camera
                PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                PhoneCamStream.Start();

                isOutCam2 = true;
                isInCam2 = false;
                isInCam1 = false;
                isOutCam1 = false;
            }
        }

        // event when user click button to start camera
        private void StartCameraButton_Click(object sender, EventArgs e)
        {
            if (CaptureCB.SelectedIndex == 0)
            {
                if (PhoneCamStream.IsRunning)
                {
                    PhoneCamStream.Stop(); // remove phone camera screen view on picturebox
                    OutputCameraPB.Image = null;
                }

                // create view for in vehicle camera
                CaptureImg = new VideoCaptureDevice(CaptureDevice[CaptureCB.SelectedIndex].MonikerString);
                CaptureImg.Start();
                CaptureImg.NewFrame += CaptureImg_NewFrame;
            }
            else
            {
                if (CaptureImg.IsRunning)
                {
                    CaptureImg.Stop(); // remove phone camera screen view on picturebox
                    InputCameraPB.Image = null;
                }

                // create view for out vehicle camera
                PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                PhoneCamStream.Start();
            }
        }

        // In vehicle camera
        private void CaptureImg_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isInCam1 && isOutCam2)
            {
                InputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();

                Bitmap phoneCam = (Bitmap)eventArgs.Frame.Clone();
                OutputCameraPB.Image = phoneCam;
            }
            else if (isInCam1 && isOutCam2 == false)
            {
                InputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        // event when user click button to cap the image from camera
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            if (CaptureCB.SelectedIndex == 0)
            {
                InVehiclePB.Image = InputCameraPB.Image;
            }
            else
            {
                OutVehiclePB.Image = OutputCameraPB.Image;
            }
        }

        // event when user click button to clear the current captured img
        private void ClearImgButton_Click(object sender, EventArgs e)
        {
            if (CaptureCB.SelectedIndex == 0 && InVehiclePB.Image  != null)
            {
                InVehiclePB.Image = null;
            }
            else if (CaptureCB.SelectedIndex == 1 && OutVehiclePB.Image != null)
            {
                OutVehiclePB.Image = null;
            }
        }

        // Out vehicle camera
        // event to update frame for picturebox view out vehicle camera
        private void PhoneCamStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isInCam2 && isOutCam1 == false)
            {
                InputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        // event when user out the main form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CaptureImg.Stop();
            PhoneCamStream.Stop();
        }
    }
}
