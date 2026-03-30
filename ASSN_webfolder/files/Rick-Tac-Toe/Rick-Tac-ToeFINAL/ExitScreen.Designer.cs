namespace CSC240_ProjectTicTacToe_LDM
{
    partial class ExitScreen
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
            this.components = new System.ComponentModel.Container();
            this.picExitImage = new System.Windows.Forms.PictureBox();
            this.lblGoodbye = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.exitTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picExitImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picExitImage
            // 
            this.picExitImage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picExitImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picExitImage.Location = new System.Drawing.Point(0, 0);
            this.picExitImage.Name = "picExitImage";
            this.picExitImage.Size = new System.Drawing.Size(500, 400);
            this.picExitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExitImage.TabIndex = 0;
            this.picExitImage.TabStop = false;
            // 
            // lblGoodbye
            // 
            this.lblGoodbye.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodbye.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodbye.ForeColor = System.Drawing.Color.White;
            this.lblGoodbye.Location = new System.Drawing.Point(0, 150);
            this.lblGoodbye.Name = "lblGoodbye";
            this.lblGoodbye.Size = new System.Drawing.Size(500, 50);
            this.lblGoodbye.TabIndex = 1;
            this.lblGoodbye.Text = "Thanks for Playing!";
            this.lblGoodbye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountdown
            // 
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.LightGray;
            this.lblCountdown.Location = new System.Drawing.Point(0, 210);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(500, 30);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "Closing in 20 seconds...";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitTimer
            // 
            this.exitTimer.Interval = 1000;
            this.exitTimer.Tick += new System.EventHandler(this.exitTimer_Tick);
            // 
            // ExitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblGoodbye);
            this.Controls.Add(this.picExitImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rick-Tac-Toe - Goodbye";
            this.Load += new System.EventHandler(this.ExitScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExitImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picExitImage;
        private System.Windows.Forms.Label lblGoodbye;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer exitTimer;
    }
}
