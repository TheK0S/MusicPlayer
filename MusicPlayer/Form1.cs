using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Media;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        int songIndex = 0;
        int listIndex = 0;
        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel01.Region = GetRoundedRegion(flowLayoutPanel01.ClientRectangle, 20);
            flowLayoutPanel02.Region = GetRoundedRegion(flowLayoutPanel02.ClientRectangle, 20);
            flowLayoutPanel03.Region = GetRoundedRegion(flowLayoutPanel03.ClientRectangle, 20);
            flowLayoutPanel04.Region = GetRoundedRegion(flowLayoutPanel04.ClientRectangle, 20);
            flowLayoutPanel05.Region = GetRoundedRegion(flowLayoutPanel05.ClientRectangle, 20);
            flowLayoutPanel06.Region = GetRoundedRegion(flowLayoutPanel06.ClientRectangle, 20);
            flowLayoutPanel07.Region = GetRoundedRegion(flowLayoutPanel07.ClientRectangle, 20);
            activeList.Region = GetRoundedRegion(activeList.ClientRectangle, 20);
            prev.Region = GetRoundedRegion(prev.ClientRectangle, 20);
            play.Region = GetRoundedRegion(play.ClientRectangle, 20);
            stop.Region = GetRoundedRegion(stop.ClientRectangle, 20);
            next.Region = GetRoundedRegion(next.ClientRectangle, 20);
            CurrentSong.Region = GetRoundedRegion(CurrentSong.ClientRectangle, 20);

        }

        List<FlowLayoutPanel> GetPanelsList()
        {
            List<FlowLayoutPanel> list = new List<FlowLayoutPanel>();
            list.Add(flowLayoutPanel01);
            list.Add(flowLayoutPanel02);
            list.Add(flowLayoutPanel03);
            list.Add(flowLayoutPanel04);
            list.Add(flowLayoutPanel05);
            list.Add(flowLayoutPanel06);
            list.Add(flowLayoutPanel07);
            return list;
        }

        List<Label> GetLabelsList()
        {
            List<Label> list = new List<Label>();
            list.Add(label01);
            list.Add(label02);
            list.Add(label03);
            list.Add(label04);
            list.Add(label05);
            list.Add(label06);
            list.Add(label07);
            return list;
        }

        void SetVisibleFromPanels()
        {
            List<FlowLayoutPanel> list = GetPanelsList();
            for (int i = 0; i < Data.MainList.Count; i++)              
                list[i].Visible = true;
        }

        void SetNameListPanels()
        {
            List<Label> list = GetLabelsList();
            for (int i = 0; i < Data.MainList.Count; i++)                
                list[i].Text = Data.MainList[i].Name;
        }

        string CutSongName(string songPath)
        {
            int i = songPath.Length - 3;
            while (i > 0)
                if(songPath[--i] == '\\')
                    return songPath.Remove(0, i+1);

            return songPath;
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
            //Data.MainList = new List<SongList>();

            Data.ReadDataFromDB();

            SetVisibleFromPanels();

            SetNameListPanels();

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
                pictureBoxSearchIcon.Visible = true;
            }
            else
            {
                playListsTable.Location = new Point(playListsTable.Location.X, 0);
                searchField.Visible = false;
                pictureBoxSearchIcon.Visible = false;
            }
        }

        private void labelMyMedia_Click(object sender, EventArgs e)
        {
            playListsTable.Visible = false;

            searchField.Visible = false;
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
            flowLayoutPanel03.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel03.BackColor = Color.FromArgb(25,25,25);
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
            flowLayoutPanel03.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel03.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void playListsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            if(songIndex < Data.MainList[listIndex].Songs.Count)
            {
                Data.player.SoundLocation = Data.MainList[listIndex].Songs[songIndex];
                Data.player.Load();
                Data.player.Play();
                CurrentSong.Text = CutSongName(Data.MainList[listIndex].Songs[songIndex]);
            }            
        }

        private void listName1_Click(object sender, EventArgs e)
        {
            Data.player.SoundLocation = Data.MainList[0].Songs[0];
            Data.player.Load();
            Data.player.Play();
            CurrentSong.Text = CutSongName(Data.MainList[0].Songs[0]);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Data.player.Stop();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(++songIndex >= Data.MainList.Count)
                songIndex = 0;
            Data.player.SoundLocation = Data.MainList[listIndex].Songs[songIndex];
            Data.player.Load();
            Data.player.Play();
            CurrentSong.Text = CutSongName(Data.MainList[listIndex].Songs[songIndex]);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (--songIndex < 0)
                songIndex = Data.MainList.Count - 1;
            Data.player.SoundLocation = Data.MainList[listIndex].Songs[songIndex];
            Data.player.Load();
            Data.player.Play();
            CurrentSong.Text = CutSongName(Data.MainList[listIndex].Songs[songIndex]);
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            Data.ReadDataFromDB();
            SetVisibleFromPanels();
            SetNameListPanels();
        }

        private void label01_Click(object sender, EventArgs e)
        {
            listIndex = 0;
            activeList.Text = label01.Text;
        }

        private void label02_Click(object sender, EventArgs e)
        {
            listIndex = 1;
            activeList.Text = label02.Text;
        }

        private void label03_Click(object sender, EventArgs e)
        {
            listIndex = 2;
            activeList.Text = label03.Text;
        }

        private void label04_Click(object sender, EventArgs e)
        {
            listIndex = 3;
            activeList.Text = label04.Text;
        }

        private void label05_Click(object sender, EventArgs e)
        {
            listIndex = 4;
            activeList.Text = label05.Text;
        }

        private void label06_Click(object sender, EventArgs e)
        {
            listIndex = 5;
            activeList.Text = label06.Text;
        }

        private void label07_Click(object sender, EventArgs e)
        {
            listIndex = 6;
            activeList.Text = label07.Text;
        }

        private void label01_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel01.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void label01_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel01.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void label02_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel02.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void label02_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel02.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void label03_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel03.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void label03_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel03.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void label04_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel05.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void label04_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel04.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void label05_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel05.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void label05_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel05.BackColor = Color.FromArgb(25, 25, 25);
        }
    }
}