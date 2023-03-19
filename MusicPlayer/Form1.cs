using System.Drawing.Drawing2D;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var btn = new RoundButton();
            btn.Text = "asdadsads";
            btn.Location = new Point(230, 5);
            btn.Width = 277;
            btn.Height = 30;
            this.Controls.Add(btn);
            btn.BackColor = Color.White;

            Graphics gr = searchField.CreateGraphics();
            gr.DrawPath(new Pen(Color.Red,1 ), RoundButton.GetRoundedRectangle(searchField.ClientRectangle, 20));
            searchField.Region = new Region(RoundButton.GetRoundedRectangle(searchField.ClientRectangle, 20));
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void labelMyMedia_Click(object sender, EventArgs e)
        {

        }

        private void labelCreatePlayList_Click(object sender, EventArgs e)
        {

        }

        private void labelFavoriteTracks_Click(object sender, EventArgs e)
        {

        }
    }
}