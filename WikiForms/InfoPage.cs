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
    public partial class InfoPage : Form
    {
        //public Label titlelabel = TitleLabel;
        public InfoPage()
        {
            InitializeComponent();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }
        public void Create_InfoPage(string Title, string Content)
        {
            TitleLabel.Text = Title;
            InfoLabel.Text = Content;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
