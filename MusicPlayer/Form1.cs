using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Media;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel1.Region = GetRoundedRegion(flowLayoutPanel1.ClientRectangle, 20);
            

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
            List<string> mainList = Data.ReadFromMainList();

            foreach (var item in mainList)
                Data.dictLists.Add(item, Data.ReadFromSongsList(item));

            //PictureBox pictureBox1 = new PictureBox()
            //{
            //    BackColor = Color.FromArgb(25, 25, 25),
            //    Margin = new Padding(10, 10, 10, 10),
            //    Size = new Size(170, 130),
            //    Dock = DockStyle.Top,
            //    Anchor = AnchorStyles.Top
            //};

            //Label label1 = new Label()
            //{
            //    BackColor = Color.FromArgb(25, 25, 25),
            //    Margin = new Padding(10, 10, 10, 10),
            //    ForeColor = Color.LightGray,
            //    Text = "List_1",
            //    AutoSize = false,
            //    Dock = DockStyle.Bottom,
            //    Anchor = AnchorStyles.Bottom
            //};

            //FlowLayoutPanel panel1 = new FlowLayoutPanel()
            //{
            //    Padding = new Padding(10, 10, 10, 10),
            //    Dock = DockStyle.None,
            //    Anchor = AnchorStyles.None
            //};
            //panel1.Controls.Add(pictureBox1);
            //panel1.Controls.Add(label1);

            //foreach (var item in Data.dictLists)
            //{

            //}

            //playListsTable.Controls.Add(panel1, 0, 0);



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
            Data.formCreatePlayList = new CreatePleyList();
            Data.formCreatePlayList.Show();
            this.Visible = false;
        }

        private void labelFavoriteTracks_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(25,25,25);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void playListsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            Data.player.SoundLocation = Data.dictLists["myList"][1];
        }

        private void listName1_Click(object sender, EventArgs e)
        {
            Data.player.SoundLocation = Data.dictLists["myList"].FirstOrDefault();
            Data.player.Load();
            Data.player.Play();
            songTimeLine.Maximum = 19;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Data.player.Stop();
        }
    }
}