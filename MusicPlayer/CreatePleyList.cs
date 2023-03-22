using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class CreatePleyList : Form
    {
        public CreatePleyList()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.CheckFileExists)
                pictureBox.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }

        private void labelMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreatePleyList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.form1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
