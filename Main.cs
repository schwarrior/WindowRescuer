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

namespace OffScreenWindowRescuer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnRescueWindows_Click(object sender, EventArgs e)
        {
            var windows = OpenWindowGetter.GetOpenWindows();
            var sb = new StringBuilder();
            foreach (KeyValuePair<IntPtr, string> window in windows)
            {
                IntPtr handle = window.Key;
                string title = window.Value;

                Console.WriteLine("{0}: {1}", handle, title);
                sb.AppendFormat("{0}: {1}\n", handle, title);
            }

            //MessageBox.Show(sb.ToString());
            
            //var winForms = Application.OpenForms;
            //var currentWindowHandle = winForms[0].Handle;
            
            var thisProcess = Process.GetCurrentProcess();
            var thisWindowHandle = thisProcess.MainWindowHandle;
            var thisWindowRect = new WindowMover.Rect();
            WindowMover.GetWindowRect(thisWindowHandle, ref thisWindowRect);
            Console.WriteLine();
        }
    }
}
