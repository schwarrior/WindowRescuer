namespace OffScreenWindowRescuer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnRescueWindow = new System.Windows.Forms.Button();
            this.lbWindows = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRescueWindow
            // 
            this.btnRescueWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRescueWindow.Location = new System.Drawing.Point(23, 23);
            this.btnRescueWindow.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnRescueWindow.Name = "btnRescueWindow";
            this.btnRescueWindow.Size = new System.Drawing.Size(291, 28);
            this.btnRescueWindow.TabIndex = 0;
            this.btnRescueWindow.Text = "Rescue Selected Window";
            this.btnRescueWindow.UseVisualStyleBackColor = true;
            this.btnRescueWindow.Click += new System.EventHandler(this.btnRescueWindows_Click);
            // 
            // lbWindows
            // 
            this.lbWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWindows.FormattingEnabled = true;
            this.lbWindows.Location = new System.Drawing.Point(23, 69);
            this.lbWindows.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lbWindows.Name = "lbWindows";
            this.lbWindows.Size = new System.Drawing.Size(413, 225);
            this.lbWindows.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(352, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 28);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 333);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbWindows);
            this.Controls.Add(this.btnRescueWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Main";
            this.Text = "Off Screen Window Rescuer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRescueWindow;
        private System.Windows.Forms.ListBox lbWindows;
        private System.Windows.Forms.Button btnRefresh;
    }
}

