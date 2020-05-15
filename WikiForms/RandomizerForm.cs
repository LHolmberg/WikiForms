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

        DataController[] datas = new DataController[10];
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
                datas[i] = new DataController(Randomizer(2));

            for(int i = 0; i < datas.Length; i++)
                LinkListBox.Items.Add(datas[i].list[datas[i].list.Length - 1][0]);

            LoadLabel.Text = "";
        }

        private void LinkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = LinkListBox.SelectedIndex;
        }

        private void LinkListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InfoPage info = new InfoPage();
            
            info.Create_InfoPage(datas[selectedIndex].list[datas[selectedIndex].list.Length - 1][0], datas[selectedIndex].list[datas[selectedIndex].list.Length - 1][1]);
            info.Show();
            this.Hide();
        }

        private void GoToLinkButton_Click(object sender, EventArgs e)
        {
        }

        private string Randomizer(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length).Select(s => s[randomValue.Next(s.Length)]).ToArray());
        }

    }
}
