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
            RescueWindow();   
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadWindows();
        }

        private void LoadWindows()
        {
            lbWindows.Items.Clear();
            var windows = OpenWindowGetter.GetOpenWindows();
            foreach (KeyValuePair<IntPtr, string> window in windows)
            {
                IntPtr handle = window.Key;
                string title = window.Value;

                //Console.WriteLine("{0}: {1}", handle, title);
                //var windowItem = title;

                lbWindows.Items.Add(window);
            }
        }

        private void RescueWindow()
        {
            var r = new WindowMover.Rect();
            var thisWindowHandle = this.GetCurrentWindowInfo(ref r);

            var selWindow = lbWindows.SelectedItem as Nullable<KeyValuePair<IntPtr, string>>;
            if (!selWindow.HasValue) return;
            var w = selWindow.Value;
            var h = w.Key;
            WindowMover.MoveWindow(h, r.Left + 10, r.Top + 10, this.Width, this.Height, true);
        }

        private IntPtr GetCurrentWindowInfo(ref WindowMover.Rect thisWindowRect)
        {
            var thisProcess = Process.GetCurrentProcess();
            var thisWindowHandle = thisProcess.MainWindowHandle;
            thisWindowRect = new WindowMover.Rect();
            WindowMover.GetWindowRect(thisWindowHandle, ref thisWindowRect);
            return thisWindowHandle;
        }
    }
}
