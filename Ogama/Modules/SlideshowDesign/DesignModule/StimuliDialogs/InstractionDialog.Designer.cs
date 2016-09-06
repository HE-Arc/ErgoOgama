namespace Ogama.Modules.SlideshowDesign.DesignModule.StimuliDialogs
{
    partial class InstractionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstractionDialog));
            this.textBoxInstraction = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dialogTop1 = new Ogama.Modules.Common.Controls.DialogTop();
            this.SuspendLayout();
            // 
            // textBoxInstraction
            // 
            this.textBoxInstraction.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInstraction.Location = new System.Drawing.Point(0, 60);
            this.textBoxInstraction.Multiline = true;
            this.textBoxInstraction.Name = "textBoxInstraction";
            this.textBoxInstraction.Size = new System.Drawing.Size(558, 176);
            this.textBoxInstraction.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(390, 247);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dialogTop1
            // 
            this.dialogTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dialogTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dialogTop1.BackgroundImage")));
            this.dialogTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dialogTop1.Description = "Please enter any instruction you may have for the user";
            this.dialogTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogTop1.Location = new System.Drawing.Point(0, 0);
            this.dialogTop1.Logo = ((System.Drawing.Image)(resources.GetObject("dialogTop1.Logo")));
            this.dialogTop1.Name = "dialogTop1";
            this.dialogTop1.Size = new System.Drawing.Size(558, 60);
            this.dialogTop1.TabIndex = 0;
            // 
            // InstractionDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 282);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxInstraction);
            this.Controls.Add(this.dialogTop1);
            this.Name = "InstractionDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstractionDialog_FormClosing);
            this.Load += new System.EventHandler(this.InstractionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Controls.DialogTop dialogTop1;
        private System.Windows.Forms.TextBox textBoxInstraction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}