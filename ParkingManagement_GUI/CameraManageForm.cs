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

        public delegate void OpenCameraMessage(int CamIndex, int CamPosition, bool IsStartCamButClicked, string CamIPAddress);
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
                if (InCamIPAddTxb.Visible == true && (@InCamIPAddTxb.Text).Length == 27)
                {
                    string temp = (@InCamIPAddTxb.Text).Substring(7, 15);

                    if (ValidateIPv4(temp) == false)
                    {
                        MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                        return;
                    }
                }
                else if ((@InCamIPAddTxb.Text).Length < 27 && OutCamIPAddTxb.Visible)
                {
                    MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                    return;
                }
                else if (InCamIPAddTxb.Visible == true && string.IsNullOrEmpty(InCamIPAddTxb.Text) && string.IsNullOrWhiteSpace(InCamIPAddTxb.Text))
                {
                    MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                    return;
                }
                else if (InCamIPAddTxb.Visible == true && InCamIPAddTxb.Text.Contains("http://") == false 
                    && InCamIPAddTxb.Text.Contains("https://") == false)
                {
                    MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                    return;
                }
                if ((SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) && StartOutCamButton.Enabled 
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled)
                    || (SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) && StartOutCamButton.Enabled
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) == false)
                    || (SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) == false
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled)
                    || (SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) == false
                    && SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) == false))
                {
                    if (InCamIPAddTxb.Visible == true)
                    {
                        StartInCamera(inx, 1, true, (@InCamIPAddTxb.Text.ToLower() + @"/video").Trim());
                    }
                    else
                    {
                        StartInCamera(inx, 1, true, "");
                    }

                    SelectInCamCB.Enabled = false;
                    StartInCamButton.Enabled = false;
                    InCamIPAddTxb.Enabled = false;
                }
                else if ((SelectInCamCB.SelectedIndex.Equals(SelectOutCamCB.SelectedIndex) && StartOutCamButton.Enabled == false)
                          || (SelectInCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled == false))
                {
                    MessageBox.Show("Input camera has conflicted with another camera! Please check again", "Warning!", MessageBoxButtons.OK);

                    SelectInCamCB.Enabled = true;
                    StartInCamButton.Enabled = true;
                    InCamIPAddTxb.Enabled = true;

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
                if (OutCamIPAddTxb.Visible == true && (@OutCamIPAddTxb.Text).Length == 27)
                {
                    string temp = (@OutCamIPAddTxb.Text).Substring(7, 15);

                    if (ValidateIPv4(temp) == false)
                    {
                        MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                        return;
                    }
                }
                else if ((@OutCamIPAddTxb.Text).Length < 27 && OutCamIPAddTxb.Visible)
                {
                    MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                    return;
                }
                else if (OutCamIPAddTxb.Visible == true && string.IsNullOrEmpty(OutCamIPAddTxb.Text) && string.IsNullOrWhiteSpace(OutCamIPAddTxb.Text))
                {
                    MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                    return;
                }
                else if (OutCamIPAddTxb.Visible == true && OutCamIPAddTxb.Text.Contains("http://") == false && OutCamIPAddTxb.Text.Contains("https://") == false)
                {
                    MessageBox.Show("Please enter camera IP address to start camera", "Warning!", MessageBoxButtons.OK);

                    return;
                }

                if ((SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) && StartInCamButton.Enabled
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled)
                    || (SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) && StartInCamButton.Enabled
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) == false)
                    || (SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) == false
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && SelectScanCamCB.Enabled)
                    || (SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) == false
                    && SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) == false))
                {
                    if (OutCamIPAddTxb.Visible == true)
                    {
                        StartOutCamera(inx, 2, true, (@OutCamIPAddTxb.Text.ToLower() + @"/video").Trim());
                    }
                    else
                    {
                        StartOutCamera(inx, 2, true, "");
                    }

                    SelectOutCamCB.Enabled = false;
                    StartOutCamButton.Enabled = false;
                    OutCamIPAddTxb.Enabled = false;
                }
                else if ((SelectOutCamCB.SelectedIndex.Equals(SelectInCamCB.SelectedIndex) && StartInCamButton.Enabled == false)
                || (SelectOutCamCB.SelectedIndex.Equals(SelectScanCamCB.SelectedIndex) && StartScanCamBut.Enabled == false))
                {
                    MessageBox.Show("Output camera has conflicted with another camera! Please check again");

                    SelectOutCamCB.Enabled = true;
                    StartOutCamButton.Enabled = true;
                    OutCamIPAddTxb.Enabled = true;

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

        // event when user finish the form and want to hide the form
        private void HideFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool ValidateIPv4(string IPString)
        {
            if (string.IsNullOrWhiteSpace(IPString))
            {
                return false;
            }

            string[] splitValues = IPString.Split('.');

            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
    }
}
