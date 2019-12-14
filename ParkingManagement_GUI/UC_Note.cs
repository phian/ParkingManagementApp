using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ParkingManagement_GUI
{
    public partial class UC_Note : UserControl
    {
        Process proc;
        public UC_Note()
        {
            InitializeComponent();
            open_NotePad();
           
        }
        private const int WM_SYSCOMMAND = 274; private const int SC_MAXIMIZE = 61488;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]

        public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void open_NotePad()
        {
            proc = Process.Start("notepad.exe");
            proc.WaitForInputIdle();
            SetParent(proc.MainWindowHandle, Note_Panel.Handle);
        }
    }
}
