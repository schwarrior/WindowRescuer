using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var windows = WindowTools.GetOpenWindows();
            foreach (KeyValuePair<IntPtr, string> window in windows)
            {
                IntPtr handle = window.Key;
                string title = window.Value;
                lbWindows.Items.Add(window);
            }
        }

        private void RescueWindow()
        {
            var r = new SimpleRect();
            var thisWindowHandle = this.GetCurrentWindowInfo(ref r);

            var selWindow = lbWindows.SelectedItem as Nullable<KeyValuePair<IntPtr, string>>;
            if (!selWindow.HasValue) return;
            var w = selWindow.Value;
            var h = w.Key;
            //first move might not fit new monitor, if scaling is different
            WindowTools.MoveWindow(h, r.Left + 30, r.Top + 30, this.Width, this.Height, true);
            //re-move with current monitor scale
            WindowTools.MoveWindow(h, r.Left + 30, r.Top + 30, this.Width, this.Height, true);
            WindowTools.SetForegroundWindow(h);
        }

        private IntPtr GetCurrentWindowInfo(ref SimpleRect thisWindowRect)
        {
            var thisProcess = Process.GetCurrentProcess();
            var thisWindowHandle = thisProcess.MainWindowHandle;
            thisWindowRect = new SimpleRect();
            WindowTools.GetWindowRect(thisWindowHandle, ref thisWindowRect);
            return thisWindowHandle;
        }
    }
}
