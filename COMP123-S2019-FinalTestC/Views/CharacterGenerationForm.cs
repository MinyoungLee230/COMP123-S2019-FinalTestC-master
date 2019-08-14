using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME:Minyoung Lee
 * STUDENT ID:300983741
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void LastNameDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void StrengthDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            int randomNumber1 = new Random().Next(1, 15) + 1;
            StrengthDataLabel.Text = randomNumber1.ToString();
            int randomNumber2 = new Random().Next(1, 15) + 1;
            DexterityDataLabel.Text = randomNumber2.ToString();
            int randomNumber3 = new Random().Next(1, 15) + 1;
            EnduranceDataLabel.Text = randomNumber3.ToString();
            int randomNumber4 = new Random().Next(1, 15) + 1;
            IntellectDataLabel.Text = randomNumber4.ToString();
            int randomNumber5 = new Random().Next(1, 15) + 1;
            EducationDataLabel.Text = randomNumber5.ToString();
            int randomNumber6 = new Random().Next(1, 15) + 1;
            SocialStandingDataLabel.Text = randomNumber6.ToString();
        }
    }
}
