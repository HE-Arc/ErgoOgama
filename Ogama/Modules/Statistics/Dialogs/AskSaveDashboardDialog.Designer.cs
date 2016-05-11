namespace Ogama.Modules.Statistics.Dialogs
{
    partial class AskSaveDashboardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskSaveDashboardDialog));
            this.btnNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.dialogTop1 = new Ogama.Modules.Common.Controls.DialogTop();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(288, 112);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "&Cancel";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you want to save data to dashboard table ?";
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnYes.Location = new System.Drawing.Point(204, 112);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "&Ok";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // dialogTop1
            // 
            this.dialogTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dialogTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dialogTop1.BackgroundImage")));
            this.dialogTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dialogTop1.Description = "Save data to dashboard table";
            this.dialogTop1.Location = new System.Drawing.Point(-2, 1);
            this.dialogTop1.Logo = ((System.Drawing.Image)(resources.GetObject("dialogTop1.Logo")));
            this.dialogTop1.Name = "dialogTop1";
            this.dialogTop1.Size = new System.Drawing.Size(453, 62);
            this.dialogTop1.TabIndex = 2;
            // 
            // AskSaveDashboardDialog
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(450, 147);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dialogTop1);
            this.Controls.Add(this.btnNo);
            this.Name = "AskSaveDashboardDialog";
            this.Text = "AskSaveDashboardDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private Common.Controls.DialogTop dialogTop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
    }
}