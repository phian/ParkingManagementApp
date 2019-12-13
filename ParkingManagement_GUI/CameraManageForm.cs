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
        VideoCaptureDevice CaptureImg;

        bool isInCamClicked = false, isOutCamClicked =  false;

        public delegate void OpenCameraMessage(int InCamIndex, int OutCamIndex, bool IsStartInCamButClicked, bool IsStartOutCamButClicked);
        public event OpenCameraMessage StartCamera; 

        public CameraManageForm()
        {
            InitializeComponent();
        }

        private void CameraManageForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice); // set up input type

            foreach (FilterInfo item in CaptureDevice) // Add available web cam for combobox
            {
                SelectInCamCB.Items.Add(item.Name);
                SelectOutCamCB.Items.Add(item.Name);
            }

            SelectInCamCB.Items.Add("PHONE CAMERA");
            SelectOutCamCB.Items.Add("PHONE CAMERA");

            SelectInCamCB.SelectedIndex = 0;

            CaptureImg = new VideoCaptureDevice();
        }

        // event when user click button to start in camera
        private void StartInCamButton_Click(object sender, EventArgs e)
        {
            isInCamClicked = true;

            if (SelectInCamCB.SelectedIndex == 0)
            {
                if (StartCamera != null && isOutCamClicked == false)
                {
                    StartCamera(0, 1, true, false);
                }
            }
            else if (StartCamera != null && isOutCamClicked == true)
            {
                if (StartCamera != null)
                {
                    StartCamera(1, 0, true, true);
                }
            }
        }

        // event when user click to start out camera
        private void StartOutCamButton_Click(object sender, EventArgs e)
        {
            isOutCamClicked = true;

            if (SelectOutCamCB.SelectedIndex == 0)
            {
                if (StartCamera != null && isInCamClicked)
                {
                    StartCamera(1, 0, true, true);
                }
            }
            else
            {
                if (StartCamera != null && isInCamClicked == false)
                {
                    StartCamera(0, 1, false, true);
                }
            }
        }

        // event if user change the index of in camera
        private void SelectInCamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectInCamCB.SelectedIndex == 0)
            {
                SelectOutCamCB.SelectedIndex = 1;
            }
            else
            {
                SelectOutCamCB.SelectedIndex = 0;
            }
        }

        // event if user change the index of out camera
        private void SelectOutCamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectOutCamCB.SelectedIndex == 0)
            {
                SelectInCamCB.SelectedIndex = 1;
            }
            else
            {
                SelectInCamCB.SelectedIndex = 0;
            }
        }
    }
}
