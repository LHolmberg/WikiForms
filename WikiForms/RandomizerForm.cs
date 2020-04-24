using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiForms
{
    public partial class RandomizerForm : Form
    {
        int[] randomizedArray = new int[20];
        Random randomValue = new Random();
        int selectedIndex;

        public RandomizerForm()
        {
            InitializeComponent();
        }

        private void RandomizerForm_Load(object sender, EventArgs e)
        {
            GoToLinkButton.Enabled = false;
            TestBox.Enabled = false;
        }

        private void RandomizerButton_Click(object sender, EventArgs e)
        {
            LinkListBox.Items.Clear();
            TestBox.Clear();
            GoToLinkButton.Enabled = false;

            for(int i = 0; i < randomizedArray.Length; i++)
            {
                randomizedArray[i] = randomValue.Next();
                LinkListBox.Items.Add(randomizedArray[i]);
            }
        }

        private void LinkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoToLinkButton.Enabled = true;
            TestBox.Text = LinkListBox.SelectedIndex.ToString();
            selectedIndex = LinkListBox.SelectedIndex;
        }

        private void GoToLinkButton_Click(object sender, EventArgs e)
        {
            //Go to link and such
        }

    }//MAKE THE PROGRAM PAGE SAY "SEARCH" BEFORE PUSHING!!!!!
}
