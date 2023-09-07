namespace CarParkingManagementSystem
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCarList = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblReport);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblCarList);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 453);
            this.panel1.TabIndex = 0;
            // 
            // lblCarList
            // 
            this.lblCarList.AutoSize = true;
            this.lblCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCarList.Location = new System.Drawing.Point(75, 90);
            this.lblCarList.Name = "lblCarList";
            this.lblCarList.Size = new System.Drawing.Size(59, 18);
            this.lblCarList.TabIndex = 0;
            this.lblCarList.Text = "Car List";
            this.lblCarList.Click += new System.EventHandler(this.lblCarList_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogout.Location = new System.Drawing.Point(77, 423);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(57, 18);
            this.lblLogout.TabIndex = 1;
            this.lblLogout.Text = "LogOut";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReport.Location = new System.Drawing.Point(75, 186);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(53, 18);
            this.lblReport.TabIndex = 2;
            this.lblReport.Text = "Report";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCarList;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblReport;
    }
}