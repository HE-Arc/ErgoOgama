using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ogama.Modules.SlideshowDesign.DesignModule.StimuliDialogs
{
    public partial class InstractionDialog : Form
    {
        SlideshowModule mainForm = null;
        public InstractionDialog(SlideshowModule mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string Text
        {
            get { return this.textBoxInstraction.Text; }
            set { this.textBoxInstraction.Text = value; }
        }

        private void InstractionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //((SlideshowModule)this.MdiParent).SaveToExperimentSettings(false);
            mainForm.SaveToExperimentSettings(true);
        }

        private void InstractionDialog_Load(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Document.ActiveDocument.ExperimentSettings.ExperimentInstruction))
            {
                this.textBoxInstraction.Text = Document.ActiveDocument.ExperimentSettings.ExperimentInstruction;
            }
        }
    }

}
