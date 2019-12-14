using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement_GUI
{
    public partial class CameraManageForm : Form
    {
        FilterInfoCollection CaptureDevice;

        public delegate void OpenCameraMessage(int inCam,int outCam, int scanCam);
        public event OpenCameraMessage StartCamera;
        public delegate void StopCameraMessage();
        public event StopCameraMessage StopCamera;
        

        public CameraManageForm()
        {
            InitializeComponent();


        }

        public CameraManageForm(int inCam, int outCam, int scanCam)
        {
            InitializeComponent();

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice); // set up input type

            foreach (FilterInfo item in CaptureDevice) // Add available web cam for combobox
            {
                SelectInCamCB.Items.Add(item.Name);
                SelectOutCamCB.Items.Add(item.Name);
                SelectScanCamCB.Items.Add(item.Name);
            }

            StopInCamButton.Enabled = false;
            StartCamButton.Enabled = true;
            SelectInCamCB.Enabled = true;
            SelectOutCamCB.Enabled = true;
            SelectScanCamCB.Enabled = true;

            SelectInCamCB.SelectedIndex = -1;
            SelectOutCamCB.SelectedIndex = -1;
            SelectScanCamCB.SelectedIndex = -1;


            if (inCam != -1)
            {
                StartCamButton.Enabled = false;
                StopInCamButton.Enabled = true;
                SelectInCamCB.Enabled = false;
                SelectOutCamCB.Enabled = false;
                SelectScanCamCB.Enabled = false;
                
                
                SelectInCamCB.SelectedIndex = inCam;
                SelectOutCamCB.SelectedIndex = outCam;
                SelectScanCamCB.SelectedIndex = scanCam;
            }
        }

        // event when user finish the form and want to hide the form
        private void HideFormButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // event when user click to start out camera
        private void StartCamButton_Click(object sender, EventArgs e)
        {
            if (SelectInCamCB.SelectedIndex < 0 || SelectOutCamCB.SelectedIndex < 0 || SelectScanCamCB.SelectedIndex < 0)
            {
                MessageBox.Show("Please set up all camera before start", "Warning!", MessageBoxButtons.OK);

                return;
            }
            else if (SelectInCamCB.SelectedIndex == SelectOutCamCB.SelectedIndex || SelectInCamCB.SelectedIndex == SelectScanCamCB.SelectedIndex 
                || SelectOutCamCB.SelectedIndex == SelectScanCamCB.SelectedIndex)
            {
                MessageBox.Show("Camera has conflicted! Please check again!", "Warning!", MessageBoxButtons.OK);

                return;
            }
            if (StartCamera!=null)
            {
                StartCamera(SelectInCamCB.SelectedIndex, SelectOutCamCB.SelectedIndex, SelectScanCamCB.SelectedIndex);

                StartCamButton.Enabled = false;
                StopInCamButton.Enabled = true;
                SelectInCamCB.Enabled = false;
                SelectOutCamCB.Enabled = false;
                SelectScanCamCB.Enabled = false;

            }
        }

        // event when user close all camera
        private void StopInCamButton_Click(object sender, EventArgs e)
        {
            if (StopCamera != null)
            {
                StopCamera();

                StopInCamButton.Enabled = false;
                StartCamButton.Enabled = true;
                SelectInCamCB.Enabled = true;
                SelectOutCamCB.Enabled = true;
                SelectScanCamCB.Enabled = true;

                SelectInCamCB.SelectedIndex = -1;
                SelectOutCamCB.SelectedIndex = -1;
                SelectScanCamCB.SelectedIndex = -1;
            }
        }
    }
}
