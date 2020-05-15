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
    public partial class Search : Form
    {
        DataController results;

        public Search()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            results = new DataController(InputBox.Text);

            for (int i = 0; i < results.list.Length; i++)
            {
                LinkListBox.Items.Add(results.list[i][0]);
            }

            InfoPage info = new InfoPage();

            //info.Create_InfoPage();
            //info.Show();
            //this.Hide();
        }

        private void LinkListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InfoPage info = new InfoPage();

            info.Create_InfoPage(results.list[LinkListBox.SelectedIndex][0], results.list[LinkListBox.SelectedIndex][1]);
            info.Show();
            this.Hide();
        }
    }
}
