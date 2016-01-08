namespace Ogama.Modules.Recording.Dialogs
{
  using Ogama.Modules.Common.Controls;

  partial class SubjectDetailsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectDetailsDialog));
            this.txbSubjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbComments = new System.Windows.Forms.TextBox();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboLight = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboAmbiance = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboLangue = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbWomen = new System.Windows.Forms.RadioButton();
            this.rdbMen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbLeft = new System.Windows.Forms.RadioButton();
            this.rdbRight = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbOui = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.txbParam3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbParam2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbParam1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dialogTop1 = new Ogama.Modules.Common.Controls.DialogTop();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSubjectName
            // 
            this.txbSubjectName.Location = new System.Drawing.Point(156, 72);
            this.txbSubjectName.Name = "txbSubjectName";
            this.txbSubjectName.Size = new System.Drawing.Size(288, 20);
            this.txbSubjectName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quel est votre nom?";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(211, 531);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(302, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quel est votre âge ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Êtes-vous un homme ou une femme?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Êtes-vous plutôt droitier ou gaucher lorsque vous manipulez une souris d\'ordinate" +
    "ur?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Avez-vous d\'autre précisions à apporter sur vous-même ou sur le contexte environn" +
    "ant?";
            // 
            // txbComments
            // 
            this.txbComments.Location = new System.Drawing.Point(156, 478);
            this.txbComments.Multiline = true;
            this.txbComments.Name = "txbComments";
            this.txbComments.Size = new System.Drawing.Size(288, 47);
            this.txbComments.TabIndex = 5;
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(156, 100);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(120, 20);
            this.txbAge.TabIndex = 2;
            this.txbAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAge_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Portez-vous des lunettes ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(438, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Comment pouvez-vous décrire la luminosité de l\'endroit où vous vous trouvez actue" +
    "llement?";
            // 
            // comboLight
            // 
            this.comboLight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLight.FormattingEnabled = true;
            this.comboLight.Items.AddRange(new object[] {
            "faible",
            "moyenne",
            "forte"});
            this.comboLight.Location = new System.Drawing.Point(156, 374);
            this.comboLight.Name = "comboLight";
            this.comboLight.Size = new System.Drawing.Size(121, 21);
            this.comboLight.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Comment pouvez-vous décrire l\'ambiance environnante?";
            // 
            // comboAmbiance
            // 
            this.comboAmbiance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAmbiance.FormattingEnabled = true;
            this.comboAmbiance.Items.AddRange(new object[] {
            "calme",
            "agité"});
            this.comboAmbiance.Location = new System.Drawing.Point(156, 430);
            this.comboAmbiance.Name = "comboAmbiance";
            this.comboAmbiance.Size = new System.Drawing.Size(121, 21);
            this.comboAmbiance.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Quelle est votre langue maternelle ? \r\n";
            // 
            // comboLangue
            // 
            this.comboLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLangue.FormattingEnabled = true;
            this.comboLangue.Items.AddRange(new object[] {
            "français",
            "allemand",
            "italien",
            "anglais",
            "espagnol",
            "portugais",
            "roumain",
            "polonais",
            "autre"});
            this.comboLangue.Location = new System.Drawing.Point(156, 313);
            this.comboLangue.Name = "comboLangue";
            this.comboLangue.Size = new System.Drawing.Size(121, 21);
            this.comboLangue.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbWomen);
            this.groupBox1.Controls.Add(this.rdbMen);
            this.groupBox1.Location = new System.Drawing.Point(156, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 31);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rdbWomen
            // 
            this.rdbWomen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbWomen.AutoSize = true;
            this.rdbWomen.Location = new System.Drawing.Point(98, 10);
            this.rdbWomen.Name = "rdbWomen";
            this.rdbWomen.Size = new System.Drawing.Size(56, 17);
            this.rdbWomen.TabIndex = 1;
            this.rdbWomen.Text = "femme";
            this.rdbWomen.UseVisualStyleBackColor = true;
            // 
            // rdbMen
            // 
            this.rdbMen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbMen.AutoSize = true;
            this.rdbMen.Checked = true;
            this.rdbMen.Location = new System.Drawing.Point(6, 10);
            this.rdbMen.Name = "rdbMen";
            this.rdbMen.Size = new System.Drawing.Size(59, 17);
            this.rdbMen.TabIndex = 0;
            this.rdbMen.TabStop = true;
            this.rdbMen.Text = "homme";
            this.rdbMen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLeft);
            this.groupBox2.Controls.Add(this.rdbRight);
            this.groupBox2.Location = new System.Drawing.Point(156, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 31);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // rdbLeft
            // 
            this.rdbLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbLeft.AutoSize = true;
            this.rdbLeft.Location = new System.Drawing.Point(98, 10);
            this.rdbLeft.Name = "rdbLeft";
            this.rdbLeft.Size = new System.Drawing.Size(64, 17);
            this.rdbLeft.TabIndex = 1;
            this.rdbLeft.TabStop = true;
            this.rdbLeft.Text = "gaucher";
            this.rdbLeft.UseVisualStyleBackColor = true;
            // 
            // rdbRight
            // 
            this.rdbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbRight.AutoSize = true;
            this.rdbRight.Checked = true;
            this.rdbRight.Location = new System.Drawing.Point(7, 8);
            this.rdbRight.Name = "rdbRight";
            this.rdbRight.Size = new System.Drawing.Size(56, 17);
            this.rdbRight.TabIndex = 0;
            this.rdbRight.TabStop = true;
            this.rdbRight.Text = "droitier";
            this.rdbRight.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbOui);
            this.groupBox3.Controls.Add(this.rdbNo);
            this.groupBox3.Location = new System.Drawing.Point(156, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 31);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // rdbOui
            // 
            this.rdbOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOui.AutoSize = true;
            this.rdbOui.Location = new System.Drawing.Point(98, 10);
            this.rdbOui.Name = "rdbOui";
            this.rdbOui.Size = new System.Drawing.Size(39, 17);
            this.rdbOui.TabIndex = 1;
            this.rdbOui.Text = "oui";
            this.rdbOui.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbNo.AutoSize = true;
            this.rdbNo.Checked = true;
            this.rdbNo.Location = new System.Drawing.Point(6, 8);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(37, 17);
            this.rdbNo.TabIndex = 0;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "no";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // txbParam3
            // 
            this.txbParam3.Location = new System.Drawing.Point(481, 425);
            this.txbParam3.Name = "txbParam3";
            this.txbParam3.Size = new System.Drawing.Size(100, 20);
            this.txbParam3.TabIndex = 8;
            this.txbParam3.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Param3";
            this.label9.Visible = false;
            // 
            // txbParam2
            // 
            this.txbParam2.Location = new System.Drawing.Point(481, 399);
            this.txbParam2.Name = "txbParam2";
            this.txbParam2.Size = new System.Drawing.Size(100, 20);
            this.txbParam2.TabIndex = 7;
            this.txbParam2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Param2";
            this.label10.Visible = false;
            // 
            // txbParam1
            // 
            this.txbParam1.Location = new System.Drawing.Point(481, 374);
            this.txbParam1.Name = "txbParam1";
            this.txbParam1.Size = new System.Drawing.Size(100, 20);
            this.txbParam1.TabIndex = 6;
            this.txbParam1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Param1";
            this.label8.Visible = false;
            // 
            // dialogTop1
            // 
            this.dialogTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.dialogTop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dialogTop1.BackgroundImage")));
            this.dialogTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dialogTop1.Description = "Veuillez remplir le formulaire suivant :";
            this.dialogTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogTop1.Location = new System.Drawing.Point(0, 0);
            this.dialogTop1.Logo = global::Ogama.Properties.Resources.user1;
            this.dialogTop1.Name = "dialogTop1";
            this.dialogTop1.Size = new System.Drawing.Size(581, 60);
            this.dialogTop1.TabIndex = 11;
            // 
            // SubjectDetailsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(581, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboLangue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboAmbiance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboLight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dialogTop1);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.txbComments);
            this.Controls.Add(this.txbParam3);
            this.Controls.Add(this.txbParam2);
            this.Controls.Add(this.txbParam1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSubjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectDetailsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Please enter subject details ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAskForSubjectName_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txbSubjectName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txbComments;
    private System.Windows.Forms.TextBox txbAge;
    private DialogTop dialogTop1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox comboLight;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox comboAmbiance;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.ComboBox comboLangue;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rdbWomen;
    private System.Windows.Forms.RadioButton rdbMen;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rdbLeft;
    private System.Windows.Forms.RadioButton rdbRight;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.RadioButton rdbOui;
    private System.Windows.Forms.RadioButton rdbNo;
    private System.Windows.Forms.TextBox txbParam3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txbParam2;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox txbParam1;
    private System.Windows.Forms.Label label8;
  }
}