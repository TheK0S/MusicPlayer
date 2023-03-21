using System.Drawing.Drawing2D;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.Region = GetRoundedRegion(panel1.ClientRectangle, 20);
            panel2.Region = GetRoundedRegion(panel1.ClientRectangle, 20);
            panel3.Region = GetRoundedRegion(panel1.ClientRectangle, 20);


            //Form2 form2 = new Form2();
            //form2.Focus();
            //form2.Show();

        }

        public static Region GetRoundedRegion(Rectangle rect, int d)
        {
            var gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            gp.CloseFigure();

            return new Region(gp);
        }

        public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
        {
            var gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            gp.CloseFigure();

            return gp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMain_Click(object sender, EventArgs e)
        {
            playListsTable.Visible = true;
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            if(playListsTable.Location.Y < 50)
            {
                playListsTable.Location = new Point(playListsTable.Location.X, 50);
                searchField.Visible = true;
                searchFieldWrapper.Visible = true;
                pictureBoxSearchIcon.Visible = true;
            }
            else
            {
                playListsTable.Location = new Point(playListsTable.Location.X, 0);
                searchField.Visible = false;
                searchFieldWrapper.Visible = false;
                pictureBoxSearchIcon.Visible = false;
            }
        }

        private void labelMyMedia_Click(object sender, EventArgs e)
        {
            playListsTable.Visible = false;

            searchField.Visible = false;
            searchFieldWrapper.Visible = false;
            pictureBoxSearchIcon.Visible = false;
        }

        private void labelCreatePlayList_Click(object sender, EventArgs e)
        {

        }

        private void labelFavoriteTracks_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(25,25,25);
        }

        private void labelMain_MouseHover(object sender, EventArgs e)
        {
            homeIcon.Width = 30;
            homeIcon.Height = 30;
            labelMain.ForeColor = Color.White;
        }

        private void labelMain_MouseLeave(object sender, EventArgs e)
        {
            homeIcon.Width = 25;
            homeIcon.Height = 25;
            labelMain.ForeColor = Color.LightGray;
        }

        private void labelSearch_MouseHover(object sender, EventArgs e)
        {
            searchIcon.Width = 30;
            searchIcon.Height = 30;
            labelSearch.ForeColor = Color.White;
        }

        private void labelSearch_MouseLeave(object sender, EventArgs e)
        {
            searchIcon.Width = 25;
            searchIcon.Height = 25;
            labelSearch.ForeColor = Color.LightGray;
        }

        private void labelMyMedia_MouseHover(object sender, EventArgs e)
        {
            mediaItem.Width = 30;
            mediaItem.Height = 30;
            labelMyMedia.ForeColor = Color.White;
        }

        private void labelMyMedia_MouseLeave(object sender, EventArgs e)
        {
            mediaItem.Width = 25;
            mediaItem.Height = 25;
            labelMyMedia.ForeColor = Color.LightGray;
        }

        private void labelCreatePlayList_MouseHover(object sender, EventArgs e)
        {
            createItem.Width = 30;
            createItem.Height = 30;
            labelCreatePlayList.ForeColor = Color.White;
        }

        private void labelCreatePlayList_MouseLeave(object sender, EventArgs e)
        {
            createItem.Width = 25;
            createItem.Height = 25;
            labelCreatePlayList.ForeColor = Color.LightGray;
        }

        private void labelFavoriteTracks_MouseHover(object sender, EventArgs e)
        {
            favoriteSongs.Width = 30;
            favoriteSongs.Height = 30;
            labelFavoriteTracks.ForeColor = Color.White;
        }

        private void labelFavoriteTracks_MouseLeave(object sender, EventArgs e)
        {
            favoriteSongs.Width = 25;
            favoriteSongs.Height = 25;
            labelFavoriteTracks.ForeColor = Color.LightGray;
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearchIcon_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}