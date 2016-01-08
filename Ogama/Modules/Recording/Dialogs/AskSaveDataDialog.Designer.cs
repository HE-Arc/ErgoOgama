namespace Ogama.Modules.Recording.Dialogs
{
  using Ogama.Modules.Common.Controls;

  partial class AskSaveDataDialog
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
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskSaveDataDialog));
            this.btnYes = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.dialogTop1 = new Ogama.Modules.Common.Controls.DialogTop();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYes.AutoSize = true;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnYes.Location = new System.Drawing.Point(218, 164);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(53, 23);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "&Ok";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(24, 80);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(499, 37);
            this.lblInformation.TabIndex = 4;
            this.lblInformation.Text = "En cliquant sur Ok vous acceptez que vos données soient enregistrées dans la base" +
    " de données.";
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNo.AutoSize = true;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(292, 163);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(60, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "&Je refuze";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // dialogTop1
            // 
            this.dialogTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dialogTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dialogTop1.BackgroundImage")));
            this.dialogTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dialogTop1.Description = "Le test est maintenant terminé.  Nous vous remercions de votre participation.";
            this.dialogTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogTop1.Location = new System.Drawing.Point(0, 0);
            this.dialogTop1.Logo = global::Ogama.Properties.Resources.DatabaseLogo;
            this.dialogTop1.Name = "dialogTop1";
            this.dialogTop1.Size = new System.Drawing.Size(523, 60);
            this.dialogTop1.TabIndex = 5;
            // 
            // AskSaveDataDialog
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(523, 198);
            this.Controls.Add(this.dialogTop1);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskSaveDataDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnYes;
    private System.Windows.Forms.Label lblInformation;
    private System.Windows.Forms.Button btnNo;
    private DialogTop dialogTop1;
  }
}