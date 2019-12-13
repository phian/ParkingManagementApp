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

        public delegate void OpenCameraMessage(int CamIndex, int CamPosition, bool IsStartCamButClicked);
        public event OpenCameraMessage StartInCamera;
        public event OpenCameraMessage StartOutCamera;
        public event OpenCameraMessage StartScanCamera;

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
                SelectScanCamCB.Items.Add(item.Name);
            }

            SelectInCamCB.Items.Add("PHONE CAMERA");
            SelectInCamCB.Items.Add("PHONE CAMERA1");

            SelectOutCamCB.Items.Add("PHONE CAMERA");
            SelectOutCamCB.Items.Add("PHONE CAMERA1");

            SelectScanCamCB.Items.Add("PHONE CAMERA");
            SelectScanCamCB.Items.Add("PHONE CAMERA1");

            SelectInCamCB.SelectedIndex = 0;
            SelectOutCamCB.SelectedIndex = 0;
            SelectScanCamCB.SelectedIndex = 0;
        }

        // event when user click button to start in camera
        private void StartInCamButton_Click(object sender, EventArgs e)
        {
            int inx = SelectInCamCB.SelectedIndex;

            if (StartInCamera != null)
            {
                if ((SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) && StartOutCamButton.Enabled 
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled)
                    || (SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) && StartOutCamButton.Enabled
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) == false)
                    || (SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) == false
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled))
                {
                    StartInCamera(inx, 1, true);

                    SelectInCamCB.Enabled = false;
                    StartInCamButton.Enabled = false;
                }
                else if ((SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) && StartOutCamButton.Enabled == false)
                          || (SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled == false))
                {
                    MessageBox.Show("Input camera has conflicted with another camera! Please check again");

                    SelectInCamCB.Enabled = true;
                    StartInCamButton.Enabled = true;

                    return;
                }
            }
        }

        // event when user click to start out camera
        private void StartOutCamButton_Click(object sender, EventArgs e)
        {
            int inx = SelectOutCamCB.SelectedIndex;

            if (StartInCamera != null)
            {
                if ((SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) && StartInCamButton.Enabled
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled)
                    || (SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) && StartInCamButton.Enabled
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) == false)
                    || (SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) == false
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && SelectScanCamCB.Enabled))
                {
                    StartOutCamera(inx, 2, true);

                    SelectOutCamCB.Enabled = false;
                    StartOutCamButton.Enabled = false;
                }
                else if ((SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) && StartInCamButton.Enabled == false)
                || (SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled == false))
                {
                    MessageBox.Show("Output camera has conflicted with another camera! Please check again");

                    SelectOutCamCB.Enabled = true;

                    return;
                }
            }
        }

        // event when user click to start scan camera
        private void StartScanCamBut_Click(object sender, EventArgs e)
        {

        }

        // event when user change the camera index in in cam combobox
        private void SelectInCamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectInCamCB.SelectedIndex >= 1)
            {
                InCamIPAddLB.Visible = true;
                InCamIPAddTxb.Visible = true;
            }
            else
            {
                InCamIPAddLB.Visible = false;
                InCamIPAddTxb.Visible = false;
            }
        }

        // event when user change the camera index in out cam combobox
        private void SelectOutCamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectOutCamCB.SelectedIndex >= 1)
            {
                OutCamIPAddLB.Visible = true;
                OutCamIPAddTxb.Visible = true;
            }
            else
            {
                OutCamIPAddLB.Visible = false;
                OutCamIPAddTxb.Visible = false;
            }
        }

        // event when user change the camera index in scan cam combobox
        private void SelectScanCamCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectScanCamCB.SelectedIndex >= 1)
            {
                ScanCamIPAddLB.Visible = true;
                ScanCamIPAddTxb.Visible = true;
            }
            else
            {
                ScanCamIPAddLB.Visible = false;
                ScanCamIPAddTxb.Visible = false;
            }
        }
    }
}
