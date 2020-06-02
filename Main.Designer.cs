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
            this.btnRescueWindows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRescueWindows
            // 
            this.btnRescueWindows.Location = new System.Drawing.Point(291, 236);
            this.btnRescueWindows.Name = "btnRescueWindows";
            this.btnRescueWindows.Size = new System.Drawing.Size(658, 231);
            this.btnRescueWindows.TabIndex = 0;
            this.btnRescueWindows.Text = "Rescue Windows";
            this.btnRescueWindows.UseVisualStyleBackColor = true;
            this.btnRescueWindows.Click += new System.EventHandler(this.btnRescueWindows_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 837);
            this.Controls.Add(this.btnRescueWindows);
            this.Name = "Main";
            this.Text = "Off Screen Window Rescuer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRescueWindows;
    }
}

