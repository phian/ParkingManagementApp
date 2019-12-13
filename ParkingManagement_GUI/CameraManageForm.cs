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

        public CameraManageForm()
        {
            InitializeComponent();
        }

        private void CameraManageForm_Load(object sender, EventArgs e)
        {
            foreach (FilterInfo item in CaptureDevice) // Add available web cam for combobox
            {
                SelectInCamCB.Items.Add(item.Name);
                SelectOutCamCB.Items.Add(item.Name);
            }

            SelectInCamCB.Items.Add("Phone Camera");
            SelectInCamCB.SelectedIndex = 0;

            SelectOutCamCB.Items.Add("PHONE CAMERA");
            SelectOutCamCB.SelectedIndex = 0;

            CaptureImg = new VideoCaptureDevice();
        }

        // event when user click button to start in camera
        private void StartInCamButton_Click(object sender, EventArgs e)
        {
            if (SelectInCamCB.SelectedIndex != SelectOutCamCB.SelectedIndex)
            {
                if (SelectInCamCB.SelectedIndex == 0)
                {
                    MainForm.inCameraIndex = 0;
                }
                else
                {
                    MainForm.inCameraIndex = 1;
                }
            }
        }

        // event when user click to start out camera
        private void StartOutCamButton_Click(object sender, EventArgs e)
        {
            if (SelectInCamCB.SelectedIndex != SelectOutCamCB.SelectedIndex)
            {
                if (SelectOutCamCB.SelectedIndex == 0)
                {
                    MainForm.outCameraIndex = 0;
                }
                else
                {
                    MainForm.outCameraIndex = 1;
                }
            }
        }
    }
}
