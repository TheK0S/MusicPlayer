using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class CreatePleyList : Form
    {
        string[] songs;
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

        private void label3_Click(object sender, EventArgs e)
        {
            
            Data.CreateSQLDataBase();
            Data.CreateTableForMainList();
            Data.CreateTableForSongsList(listName.Text);
            Data.AddToMainList(listName.Text);
            Data.AddToSongsList(listName.Text, songs);
            
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                labelDragDrop.Text = "Отпусти мышь";
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            labelDragDrop.Text = "Перетащи файл сюда";
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            songs = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in songs)
                if(Regex.IsMatch(file, @"\w*wav$"))
                    songsShow.Text += file + "\n";                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
