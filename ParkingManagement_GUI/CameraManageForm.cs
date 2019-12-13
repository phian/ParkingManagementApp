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
                }
                else
                {
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
                }
                else
                {
                }
            }
        }
    }
}
