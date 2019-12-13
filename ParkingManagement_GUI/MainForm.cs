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

        int inCamPosition = -1, outCamPosition = -1, scanCamPosition = -1;


        public MainForm()
        {
            InitializeComponent();

            ManageForm.StartInCamera += ManageForm_StartInCamera;
            ManageForm.StartOutCamera += ManageForm_StartOutCamera;
            ManageForm.StartScanCamera += ManageForm_StartScanCamera;
        }

        // event when user click start in camera button in set up form
        private void ManageForm_StartInCamera(int CamIndex, int CamPosition, bool IsStartCamButClicked)
        {
            inCamPosition = CamPosition;

            if (CaptureImg.IsRunning)
            {
                MessageBox.Show("Camera is running please close it before start agin", "Warning!", MessageBoxButtons.OK);

                return;
            }
            else if (CamIndex == 0 && IsStartCamButClicked && CaptureImg.IsRunning == false)
            {
                // create view for in vehicle camera
                CaptureImg = new VideoCaptureDevice(CaptureDevice[ActionModeCB.SelectedIndex].MonikerString);
                CaptureImg.Start();
                CaptureImg.NewFrame += CaptureImg_NewFrame;
            }
            if (PhoneCamStream.IsRunning)
            {
                MessageBox.Show("Camera is running please close it before start agin", "Warning!", MessageBoxButtons.OK);

                return;
            }
            else if (CamIndex == 1 && IsStartCamButClicked && PhoneCamStream.IsRunning == false)
            {
                // create view for out vehicle camera
                PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                PhoneCamStream.Start();
            }
            
            else if (CamIndex == 2 && IsStartCamButClicked)
            {
                
            }
        }

        // event when user click start out camera button in set up form
        private void ManageForm_StartOutCamera(int CamIndex, int CamPosition, bool IsStartCamButClicked)
        {
            outCamPosition = CamPosition;

            if (CaptureImg.IsRunning)
            {
                MessageBox.Show("Camera is running please close it before start agin", "Warning!", MessageBoxButtons.OK);

                return;
            }
            else if (CamIndex == 0 && IsStartCamButClicked && CaptureImg.IsRunning == false)
            {
                // create view for in vehicle camera
                CaptureImg = new VideoCaptureDevice(CaptureDevice[ActionModeCB.SelectedIndex].MonikerString);
                CaptureImg.Start();
                CaptureImg.NewFrame += CaptureImg_NewFrame;
            }
            if (PhoneCamStream.IsRunning)
            {
                MessageBox.Show("Camera is running please close it before start agin", "Warning!", MessageBoxButtons.OK);

                return;
            }
            else if (CamIndex == 1 && IsStartCamButClicked && PhoneCamStream.IsRunning == false)
            {
                // create view for out vehicle camera
                PhoneCamStream = new MJPEGStream("http://192.168.43.1:8080/video");
                PhoneCamStream.NewFrame += PhoneCamStream_NewFrame;
                PhoneCamStream.Start();
            }
            else if (CamIndex == 2 && IsStartCamButClicked)
            {

            }
        }

        // event when user click start scan camera button in set up form
        private void ManageForm_StartScanCamera(int CamIndex, int CamPosition, bool IsStartCamButClicked)
        {
        }

        // event when MainForm was loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateItemForActionModeCB();

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice); // set up input type
            PhoneCamStream = new MJPEGStream("http://192.168.43.179:8080/video");

            CaptureImg = new VideoCaptureDevice();
        }

        // In vehicle camera
        // event to update frame for picturebox view in vehicle camera
        private void CaptureImg_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (inCamPosition == 1)
            {
                InputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            if (outCamPosition == 2)
            {
                OutputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        // Out vehicle camera
        // event to update frame for picturebox view out vehicle camera
        private void PhoneCamStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (inCamPosition == 1)
            {
                InputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            if (outCamPosition == 2)
            {
                OutputCameraPB.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        // event when user click button to cap the image from camera
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            if (ActionModeCB.SelectedIndex == 0)
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
            if (ActionModeCB.SelectedIndex == 0 && InVehiclePB.Image  != null)
            {
                InVehiclePB.Image = null;
            }
            else if (ActionModeCB.SelectedIndex == 1 && OutVehiclePB.Image != null)
            {
                OutVehiclePB.Image = null;
            }
        }

        // method to add action that user can use
        public void CreateItemForActionModeCB()
        {
            ActionModeCB.Items.Add("Set up camera");
            ActionModeCB.Items.Add("Action 1");
            ActionModeCB.Items.Add("Action 2");
        }

        // event when user 
        private void ActionModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActionModeCB.SelectedIndex == 0)
            {
                ManageForm.Show();
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
