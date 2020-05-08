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
        DataController data;
        Random randomValue = new Random();
        int selectedIndex;

        public RandomizerForm()
        {
            InitializeComponent();
        }

        private void RandomizerForm_Load(object sender, EventArgs e)
        {
            LoadLabel.Text = "";
            
        }

        private void RandomizerButton_Click(object sender, EventArgs e)
        {
            LinkListBox.Items.Clear();

            LoadLabel.Text = "loading...";
            for (int i = 0; i < 10; i++)
            {
                data = new DataController(Randomizer(randomValue.Next(1, 3)));
                LinkListBox.Items.Add(data.list.ElementAt(randomValue.Next(data.list.Count)).First());
            }

            LoadLabel.Text = "";
        }

        private void LinkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = LinkListBox.SelectedIndex;
        }

        private void LinkListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadLabel.Text = "mep";
        }

        private void GoToLinkButton_Click(object sender, EventArgs e)
        {
        }

        private string Randomizer(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length).Select(s => s[randomValue.Next(s.Length)]).ToArray());
        }

    }//MAKE THE PROGRAM PAGE SAY "SEARCH" BEFORE PUSHING TO GIT!!!!!
}
