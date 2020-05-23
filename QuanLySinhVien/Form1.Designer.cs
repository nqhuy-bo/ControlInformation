namespace QuanLySinhVien
{
    partial class Form1
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
            this.textBoxNameSQL = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.userControlInformation1 = new InformationStudent.UserControlInformation();
            this.SuspendLayout();
            // 
            // textBoxNameSQL
            // 
            this.textBoxNameSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNameSQL.Location = new System.Drawing.Point(97, 8);
            this.textBoxNameSQL.Name = "textBoxNameSQL";
            this.textBoxNameSQL.Size = new System.Drawing.Size(173, 26);
            this.textBoxNameSQL.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tên DB :";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonConnect.Location = new System.Drawing.Point(318, 7);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(136, 29);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // userControlInformation1
            // 
            this.userControlInformation1.Location = new System.Drawing.Point(16, 78);
            this.userControlInformation1.Name = "userControlInformation1";
            this.userControlInformation1.Size = new System.Drawing.Size(684, 238);
            this.userControlInformation1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 318);
            this.Controls.Add(this.userControlInformation1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBoxNameSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameSQL;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button buttonConnect;
        private InformationStudent.UserControlInformation userControlInformation1;
    }
}

