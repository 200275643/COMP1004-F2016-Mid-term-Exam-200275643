﻿
/// <summary>
/// App name: Midterm
/// Author's name:Chandra Gundam(200275643)
/// App	Creation Date:20-OCT-2016
/// App description: AbilityGeneratorForm is about generating random names with pictures
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_term_Exam_200275643
{
    public partial class GenerateNameForm : Form
    {
        public SplashForm previousForm;

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method randomly picks a first name and last name from the 
        /// FirstNameListBox and LastNameListBox and sets the FirstNameText box
        /// and LastNameTextBox to the values picked
        /// </summary>
        public void GenerateNames()
        {
            //pick a random first name from the name list and put the name in the text box
            Random random = new Random();
            int randomNumberFName = random.Next(1, FirstNameListBox.Items.Count);
            FirstNameListBox.Select();
            FirstNameListBox.SelectedItem = FirstNameListBox.Items[randomNumberFName];
            FirstNameTextBox.Text = FirstNameListBox.SelectedItem.ToString();

            //pick a random last name from the name list and put the name in the text box
            int randomNumberLName = random.Next(1, LastNameListBox.Items.Count);
            LastNameListBox.Select();
            LastNameListBox.SelectedItem = LastNameListBox.Items[randomNumberLName];
            LastNameTextBox.Text = LastNameListBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Call the GenerateName method when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        /// <summary>
        /// Call the GenerateNames method when the generate button is clicked
        /// and assign the names to the character object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

            // Set the names in the character object
            Character character = Program.character;
            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
        }

        /// <summary>
        /// Open the next form when the next button is clicked and hide this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //Instantiate a new abilityGeneratorForm object
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            //hide this form
            this.Hide();
            //show next form
            abilityGeneratorForm.Show();

        }
    }
}
