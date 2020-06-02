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
            this.btnRescueWindow = new System.Windows.Forms.Button();
            this.lbWindows = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRescueWindow
            // 
            this.btnRescueWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRescueWindow.Location = new System.Drawing.Point(26, 1026);
            this.btnRescueWindow.Name = "btnRescueWindow";
            this.btnRescueWindow.Size = new System.Drawing.Size(2411, 79);
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
            this.lbWindows.ItemHeight = 37;
            this.lbWindows.Location = new System.Drawing.Point(26, 27);
            this.lbWindows.Name = "lbWindows";
            this.lbWindows.Size = new System.Drawing.Size(2407, 929);
            this.lbWindows.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2487, 1146);
            this.Controls.Add(this.lbWindows);
            this.Controls.Add(this.btnRescueWindow);
            this.Name = "Main";
            this.Text = "Off Screen Window Rescuer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRescueWindow;
        private System.Windows.Forms.ListBox lbWindows;
    }
}

