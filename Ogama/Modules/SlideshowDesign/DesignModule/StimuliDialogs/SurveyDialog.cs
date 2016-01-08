//----------------------------------------------
// He-Arc
// Claudia Gheorghe
//----------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ogama.Modules.Common.SlideCollections;
using VectorGraphics.Elements.ElementCollections;
using System.Diagnostics;
using System.Security;
using VectorGraphics.StopConditions;

namespace Ogama.Modules.SlideshowDesign.DesignModule.StimuliDialogs
{
    /// <summary>
    /// This dialog <see cref="Form"/> is used to define a post-test survey using a Google Form. 
    /// The Googel from account: 
    ///     - userName = "ergocrowd@gmail.com";             
    ///     - password = "ErgoCrowd2016";
    /// </summary>
    public partial class SurveyDialog : Form
    {
        #region fields
        /// <summary>
        /// The base URL to the Google Form survey: 
        ///  surveyUrlBase + /edit =  edit the from
        ///  surveyUrlBase + /viewform = view live form
        /// </summary>
        private string surveyUrlBase;

        /// <summary>
        /// Saves the designed browser tree node that can be 
        /// adapted in this form.
        /// </summary>
        private BrowserTreeNode surveyNode;

       
        #endregion

        /// <summary>
        /// This dialog <see cref="Form"/> is used to initially and define a google 
        /// survey form that can be added to a slide.
        /// </summary>
        public SurveyDialog()
        {            
            InitializeComponent();

            //fill the stop condition
            SlideDesignModule.FillKeyCombo(this.cbbKeys);
            this.rdbKey.Checked = true;
            this.nudTime.Value = SlideDesignModule.SLIDEDURATIONINS;
            if (this.lsbStopConditions.Items.Count == 0)
            {
                this.lsbStopConditions.Items.Add(new KeyStopCondition(Keys.Space, false, null));
            }
            surveyUrlBase = getBaseUrlForGoogleForm(urlText.Text);
        }

        /// <summary>
        /// Gets or sets the surveyNode for this design form.
        /// </summary>
        /// <value>The current used <see cref="BrowserTreeNode"/>.</value>
        /// <exception cref="ArgumentNullException">Thrown when value is null.</exception>
        public BrowserTreeNode SurveyNode 
        {
            get
            {
                return this.GetSurveySlide();
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Setting 'null' for a browser Slide is not allowed in BrowserDialog");
                }
                this.PopulateDialogWithSurveyValue(value);
            }
        }

        /// <summary>
        /// Update the dialog forms fields with the content from the given <see cref="BrowserTreeNode"/>.
        /// </summary>
        /// <param name="browserTreeNode">The <see cref="BrowserTreeNode"/> whichs content should
        /// be shown in the dialog.</param>
        private void PopulateDialogWithSurveyValue(BrowserTreeNode currentBrowserNode)
        {
            this.surveyNode = currentBrowserNode;

            this.txbLiveForm.Text = currentBrowserNode.OriginURL;
            this.txbName.Text = currentBrowserNode.Text;

            // Tab Timing
            foreach (StopCondition condition in currentBrowserNode.Slide.StopConditions)
            {
                this.lsbStopConditions.Items.Add(condition);
            }
        }                

        /// <summary>
        /// Get the base Url for the template google form
        /// example: 
        /// for the edit form https://docs.google.com/forms/d/13fmh6ddlNNFpjM-626B8nZXSOI4SDXRpBMb6TjF9qns/edit
        /// base = https://docs.google.com/forms/d/13fmh6ddlNNFpjM-626B8nZXSOI4SDXRpBMb6TjF9qns/
        /// </summary>
        /// <returns></returns>
        private string getBaseUrlForGoogleForm(string defautUrl)
        {
            if (String.IsNullOrEmpty(defautUrl) || defautUrl == "about:blank")
            {
                defautUrl = "";
            }
            else
            {
                if (defautUrl.Contains("edit"))
                {
                    int baseIndex = defautUrl.IndexOf("edit", StringComparison.Ordinal);
                    defautUrl = defautUrl.Remove(baseIndex);
                    Console.Out.WriteLine("modif anchor " + defautUrl);
                }          
            }
            return defautUrl;
        }

        /// <summary>
        /// <see cref="Control.Click"/> event handler 
        /// for the <see cref="Button"/> <see cref="btnOK"/>
        /// Sets the <see cref="Form.DialogResult"/> property to <see cref="DialogResult.OK"/>.
        /// Set it manually, because otherwise hitting "enter" in TextBox will
        /// finish dialog.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">A empty <see cref="EventArgs"/></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txbLiveForm.Text))
            {
                MessageBox.Show("Please enter the url of the live form");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Creates a new <see cref="Slide"/> 
        /// </summary>
        /// <returns>The new <see cref="Slide"/> to be added to the slideshow.</returns>
        private BrowserTreeNode GetSurveySlide()
        {
            if(this.surveyNode== null)
            {
                this.surveyNode = new BrowserTreeNode();
            }

            //store category, name and url of the default node
            this.surveyNode.Category = this.txbCategory.Text;
            this.surveyNode.Text = this.txbName.Text;
            if (!String.IsNullOrEmpty(this.txbLiveForm.Text))
                this.surveyNode.OriginURL = this.txbLiveForm.Text;           
            Console.WriteLine(this.surveyNode.OriginURL);    
            this.surveyNode.BrowseDepth = 300;

            //create a slide
            Slide surveySlide = new Slide();
            surveySlide.Category = this.txbCategory.Text;
            surveySlide.Modified = true;
            surveySlide.Name = this.txbName.Text;
            surveySlide.PresentationSize = Document.ActiveDocument.PresentationSize;
            surveySlide.MouseCursorVisible = true;

            // add stop conditions           
            foreach (StopCondition cond in this.lsbStopConditions.Items)
            {
                surveySlide.StopConditions.Add(cond);
            }

            //add the slide to the node 
            this.surveyNode.Slide = surveySlide;
            return surveyNode;
        }


        /// <summary>
        /// Open the user default browser with a template Google Form survey 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefault_Click(object sender, EventArgs e)
        {
            Process defaultBrowser = new Process();
            
            defaultBrowser.StartInfo.FileName = this.urlText.Text;
            //defaultBrowser.StartInfo.UseShellExecute = false;  
            //defaultBrowser.StartInfo.UserName = "ergocrowd@gmail.com";
            ////set password "ErgoCrowd2016";
            //SecureString p = new SecureString();
            //p.AppendChar('E');
            //p.AppendChar('r');
            //p.AppendChar('g');
            //p.AppendChar('o');
            //p.AppendChar('C');
            //p.AppendChar('r');
            //p.AppendChar('o');
            //p.AppendChar('w');
            //p.AppendChar('d');
            //p.AppendChar('2');
            //p.AppendChar('0');
            //p.AppendChar('1');
            //p.AppendChar('6');
            //defaultBrowser.StartInfo.Password = p;
            defaultBrowser.Start();           
        }

        /// <summary>
        /// <see cref="Control.Click"/> event handler 
        /// for the <see cref="btnAddCondition"/> <see cref="Button"/>
        /// Updates the <see cref="lsbStopConditions"/> items with the new 
        /// stop condition, resp. response.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">An empty <see cref="EventArgs"/></param>
        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            if(this.rdbTime.Checked)
            {
                TimeStopCondition tsc = new TimeStopCondition((int)(this.nudTime.Value * 1000));

                // Remove existing TimeConditions, because only one can be valid...
                TimeStopCondition oldTimeCondition = null;
                foreach (object condition in this.lsbStopConditions.Items)
                {
                    if (condition is TimeStopCondition)
                    {
                        oldTimeCondition = (TimeStopCondition)condition;
                    }
                }

                if (oldTimeCondition != null)
                {
                    this.lsbStopConditions.Items.Remove(oldTimeCondition);
                }

                this.lsbStopConditions.Items.Add(tsc);

            }
            else if (this.rdbKey.Checked)
            {
                string selectedItemKeys = (string)this.cbbKeys.SelectedItem;
                KeyStopCondition ksc = new KeyStopCondition();
                if (selectedItemKeys == "Any")
                {
                    ksc.CanBeAnyInputOfThisType = true;
                }
                else
                {
                    ksc.StopKey = (Keys)Enum.Parse(typeof(Keys), selectedItemKeys);
                }

                if (!this.lsbStopConditions.Items.Contains(ksc))
                {
                    this.lsbStopConditions.Items.Add(ksc);
                }

            }

        }

        /// <summary>
        /// <see cref="Control.Click"/> event handler 
        /// for the <see cref="btnRemoveCondition"/> <see cref="Button"/>
        /// Removes the selected <see cref="StopCondition"/> items from
        /// the <see cref="lsbStopConditions"/> list.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="e">An empty <see cref="EventArgs"/></param>
        private void btnRemoveCondition_Click(object sender, EventArgs e)
        {
            SlideDesignModule.DeleteSelectedItems(this.lsbStopConditions);
        }
    }
}
