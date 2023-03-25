namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMyMedia = new System.Windows.Forms.Label();
            this.labelFavoriteTracks = new System.Windows.Forms.Label();
            this.labelCreatePlayList = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.favoriteSongs = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.createItem = new System.Windows.Forms.PictureBox();
            this.mediaItem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.play = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.playListsTable = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel05 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox05 = new System.Windows.Forms.PictureBox();
            this.label05 = new System.Windows.Forms.Label();
            this.flowLayoutPanel06 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox06 = new System.Windows.Forms.PictureBox();
            this.label06 = new System.Windows.Forms.Label();
            this.flowLayoutPanel07 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox07 = new System.Windows.Forms.PictureBox();
            this.label07 = new System.Windows.Forms.Label();
            this.flowLayoutPanel04 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox04 = new System.Windows.Forms.PictureBox();
            this.label04 = new System.Windows.Forms.Label();
            this.flowLayoutPanel01 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox01 = new System.Windows.Forms.PictureBox();
            this.label01 = new System.Windows.Forms.Label();
            this.flowLayoutPanel02 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox02 = new System.Windows.Forms.PictureBox();
            this.label02 = new System.Windows.Forms.Label();
            this.flowLayoutPanel03 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox03 = new System.Windows.Forms.PictureBox();
            this.label03 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activeList = new System.Windows.Forms.Label();
            this.CurrentSong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
            this.playListsTable.SuspendLayout();
            this.flowLayoutPanel05.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox05)).BeginInit();
            this.flowLayoutPanel06.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox06)).BeginInit();
            this.flowLayoutPanel07.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox07)).BeginInit();
            this.flowLayoutPanel04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox04)).BeginInit();
            this.flowLayoutPanel01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).BeginInit();
            this.flowLayoutPanel02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).BeginInit();
            this.flowLayoutPanel03.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox03)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMyMedia
            // 
            this.labelMyMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMyMedia.AutoSize = true;
            this.labelMyMedia.BackColor = System.Drawing.Color.Black;
            this.labelMyMedia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMyMedia.ForeColor = System.Drawing.Color.LightGray;
            this.labelMyMedia.Location = new System.Drawing.Point(55, 240);
            this.labelMyMedia.Name = "labelMyMedia";
            this.labelMyMedia.Size = new System.Drawing.Size(108, 19);
            this.labelMyMedia.TabIndex = 11;
            this.labelMyMedia.Text = "Моя медиатека";
            this.labelMyMedia.Click += new System.EventHandler(this.labelMyMedia_Click);
            this.labelMyMedia.MouseLeave += new System.EventHandler(this.labelMyMedia_MouseLeave);
            this.labelMyMedia.MouseHover += new System.EventHandler(this.labelMyMedia_MouseHover);
            // 
            // labelFavoriteTracks
            // 
            this.labelFavoriteTracks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFavoriteTracks.AutoSize = true;
            this.labelFavoriteTracks.BackColor = System.Drawing.Color.Black;
            this.labelFavoriteTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFavoriteTracks.ForeColor = System.Drawing.Color.LightGray;
            this.labelFavoriteTracks.Location = new System.Drawing.Point(57, 369);
            this.labelFavoriteTracks.Name = "labelFavoriteTracks";
            this.labelFavoriteTracks.Size = new System.Drawing.Size(115, 19);
            this.labelFavoriteTracks.TabIndex = 10;
            this.labelFavoriteTracks.Text = "Любимые треки";
            this.labelFavoriteTracks.Click += new System.EventHandler(this.labelFavoriteTracks_Click);
            this.labelFavoriteTracks.MouseLeave += new System.EventHandler(this.labelFavoriteTracks_MouseLeave);
            this.labelFavoriteTracks.MouseHover += new System.EventHandler(this.labelFavoriteTracks_MouseHover);
            // 
            // labelCreatePlayList
            // 
            this.labelCreatePlayList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCreatePlayList.AutoSize = true;
            this.labelCreatePlayList.BackColor = System.Drawing.Color.Black;
            this.labelCreatePlayList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCreatePlayList.ForeColor = System.Drawing.Color.LightGray;
            this.labelCreatePlayList.Location = new System.Drawing.Point(55, 320);
            this.labelCreatePlayList.Name = "labelCreatePlayList";
            this.labelCreatePlayList.Size = new System.Drawing.Size(124, 19);
            this.labelCreatePlayList.TabIndex = 9;
            this.labelCreatePlayList.Text = "Создать плейлист";
            this.labelCreatePlayList.Click += new System.EventHandler(this.labelCreatePlayList_Click);
            this.labelCreatePlayList.MouseLeave += new System.EventHandler(this.labelCreatePlayList_MouseLeave);
            this.labelCreatePlayList.MouseHover += new System.EventHandler(this.labelCreatePlayList_MouseHover);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Black;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.ForeColor = System.Drawing.Color.LightGray;
            this.labelSearch.Location = new System.Drawing.Point(55, 189);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(49, 19);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Поиск";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            this.labelSearch.MouseLeave += new System.EventHandler(this.labelSearch_MouseLeave);
            this.labelSearch.MouseHover += new System.EventHandler(this.labelSearch_MouseHover);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Black;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMain.ForeColor = System.Drawing.Color.LightGray;
            this.labelMain.Location = new System.Drawing.Point(55, 141);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(60, 19);
            this.labelMain.TabIndex = 7;
            this.labelMain.Text = "Главная";
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
            this.labelMain.MouseLeave += new System.EventHandler(this.labelMain_MouseLeave);
            this.labelMain.MouseHover += new System.EventHandler(this.labelMain_MouseHover);
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Black;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelLogo.ForeColor = System.Drawing.Color.LightGray;
            this.labelLogo.Location = new System.Drawing.Point(56, 53);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(127, 31);
            this.labelLogo.TabIndex = 6;
            this.labelLogo.Text = "MyPlayer";
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.Black;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(10, 10);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(55, 88);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // favoriteSongs
            // 
            this.favoriteSongs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favoriteSongs.BackColor = System.Drawing.Color.Black;
            this.favoriteSongs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favoriteSongs.BackgroundImage")));
            this.favoriteSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favoriteSongs.Location = new System.Drawing.Point(10, 366);
            this.favoriteSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.favoriteSongs.Name = "favoriteSongs";
            this.favoriteSongs.Size = new System.Drawing.Size(25, 25);
            this.favoriteSongs.TabIndex = 4;
            this.favoriteSongs.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeIcon.BackColor = System.Drawing.Color.Black;
            this.homeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeIcon.BackgroundImage")));
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeIcon.Location = new System.Drawing.Point(10, 136);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(25, 25);
            this.homeIcon.TabIndex = 0;
            this.homeIcon.TabStop = false;
            // 
            // searchIcon
            // 
            this.searchIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIcon.BackColor = System.Drawing.Color.Black;
            this.searchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchIcon.BackgroundImage")));
            this.searchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchIcon.Location = new System.Drawing.Point(10, 186);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(25, 25);
            this.searchIcon.TabIndex = 1;
            this.searchIcon.TabStop = false;
            // 
            // createItem
            // 
            this.createItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createItem.BackColor = System.Drawing.Color.Black;
            this.createItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createItem.BackgroundImage")));
            this.createItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createItem.Location = new System.Drawing.Point(10, 316);
            this.createItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createItem.Name = "createItem";
            this.createItem.Size = new System.Drawing.Size(25, 25);
            this.createItem.TabIndex = 3;
            this.createItem.TabStop = false;
            // 
            // mediaItem
            // 
            this.mediaItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mediaItem.BackColor = System.Drawing.Color.Black;
            this.mediaItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mediaItem.BackgroundImage")));
            this.mediaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mediaItem.Location = new System.Drawing.Point(10, 236);
            this.mediaItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mediaItem.Name = "mediaItem";
            this.mediaItem.Size = new System.Drawing.Size(25, 25);
            this.mediaItem.TabIndex = 2;
            this.mediaItem.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 1041);
            this.label1.TabIndex = 12;
            // 
            // searchField
            // 
            this.searchField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchField.BackColor = System.Drawing.Color.LightGray;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchField.Location = new System.Drawing.Point(286, 20);
            this.searchField.Name = "searchField";
            this.searchField.PlaceholderText = "  Поиск";
            this.searchField.Size = new System.Drawing.Size(277, 20);
            this.searchField.TabIndex = 13;
            this.searchField.Text = "  ";
            this.searchField.Visible = false;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // pictureBoxSearchIcon
            // 
            this.pictureBoxSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSearchIcon.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxSearchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchIcon.BackgroundImage")));
            this.pictureBoxSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSearchIcon.Location = new System.Drawing.Point(255, 17);
            this.pictureBoxSearchIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSearchIcon.Name = "pictureBoxSearchIcon";
            this.pictureBoxSearchIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSearchIcon.TabIndex = 15;
            this.pictureBoxSearchIcon.TabStop = false;
            this.pictureBoxSearchIcon.Visible = false;
            this.pictureBoxSearchIcon.Click += new System.EventHandler(this.pictureBoxSearchIcon_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(1017, 901);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 40);
            this.play.TabIndex = 16;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(1227, 901);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 40);
            this.next.TabIndex = 17;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(909, 901);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 40);
            this.prev.TabIndex = 18;
            this.prev.Text = "Prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(1125, 901);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 40);
            this.stop.TabIndex = 19;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // playListsTable
            // 
            this.playListsTable.ColumnCount = 7;
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.Controls.Add(this.flowLayoutPanel05, 0, 0);
            this.playListsTable.Controls.Add(this.flowLayoutPanel06, 0, 0);
            this.playListsTable.Controls.Add(this.flowLayoutPanel07, 0, 0);
            this.playListsTable.Controls.Add(this.flowLayoutPanel04, 0, 0);
            this.playListsTable.Controls.Add(this.flowLayoutPanel01, 0, 0);
            this.playListsTable.Controls.Add(this.flowLayoutPanel02, 0, 0);
            this.playListsTable.Controls.Add(this.flowLayoutPanel03, 0, 0);
            this.playListsTable.Location = new System.Drawing.Point(203, 0);
            this.playListsTable.Name = "playListsTable";
            this.playListsTable.RowCount = 1;
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playListsTable.Size = new System.Drawing.Size(1709, 299);
            this.playListsTable.TabIndex = 1;
            this.playListsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.playListsTable_Paint);
            // 
            // flowLayoutPanel05
            // 
            this.flowLayoutPanel05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel05.Controls.Add(this.pictureBox05);
            this.flowLayoutPanel05.Controls.Add(this.label05);
            this.flowLayoutPanel05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel05.Location = new System.Drawing.Point(1001, 25);
            this.flowLayoutPanel05.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel05.Name = "flowLayoutPanel05";
            this.flowLayoutPanel05.Size = new System.Drawing.Size(194, 249);
            this.flowLayoutPanel05.TabIndex = 12;
            this.flowLayoutPanel05.Visible = false;
            // 
            // pictureBox05
            // 
            this.pictureBox05.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox05.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox05.BackgroundImage")));
            this.pictureBox05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox05.Location = new System.Drawing.Point(15, 15);
            this.pictureBox05.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox05.Name = "pictureBox05";
            this.pictureBox05.Size = new System.Drawing.Size(164, 130);
            this.pictureBox05.TabIndex = 1;
            this.pictureBox05.TabStop = false;
            // 
            // label05
            // 
            this.label05.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label05.ForeColor = System.Drawing.Color.LightGray;
            this.label05.Location = new System.Drawing.Point(15, 160);
            this.label05.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(164, 73);
            this.label05.TabIndex = 2;
            this.label05.Text = "Name";
            this.label05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label05.Click += new System.EventHandler(this.label05_Click);
            this.label05.MouseLeave += new System.EventHandler(this.label05_MouseLeave);
            this.label05.MouseHover += new System.EventHandler(this.label05_MouseHover);
            // 
            // flowLayoutPanel06
            // 
            this.flowLayoutPanel06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel06.Controls.Add(this.pictureBox06);
            this.flowLayoutPanel06.Controls.Add(this.label06);
            this.flowLayoutPanel06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel06.Location = new System.Drawing.Point(1245, 25);
            this.flowLayoutPanel06.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel06.Name = "flowLayoutPanel06";
            this.flowLayoutPanel06.Size = new System.Drawing.Size(194, 249);
            this.flowLayoutPanel06.TabIndex = 11;
            this.flowLayoutPanel06.Visible = false;
            // 
            // pictureBox06
            // 
            this.pictureBox06.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox06.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox06.BackgroundImage")));
            this.pictureBox06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox06.Location = new System.Drawing.Point(15, 15);
            this.pictureBox06.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox06.Name = "pictureBox06";
            this.pictureBox06.Size = new System.Drawing.Size(164, 130);
            this.pictureBox06.TabIndex = 1;
            this.pictureBox06.TabStop = false;
            // 
            // label06
            // 
            this.label06.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label06.ForeColor = System.Drawing.Color.LightGray;
            this.label06.Location = new System.Drawing.Point(15, 160);
            this.label06.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(164, 73);
            this.label06.TabIndex = 2;
            this.label06.Text = "Name";
            this.label06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label06.Click += new System.EventHandler(this.label06_Click);
            // 
            // flowLayoutPanel07
            // 
            this.flowLayoutPanel07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel07.Controls.Add(this.pictureBox07);
            this.flowLayoutPanel07.Controls.Add(this.label07);
            this.flowLayoutPanel07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel07.Location = new System.Drawing.Point(1489, 25);
            this.flowLayoutPanel07.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel07.Name = "flowLayoutPanel07";
            this.flowLayoutPanel07.Size = new System.Drawing.Size(195, 249);
            this.flowLayoutPanel07.TabIndex = 10;
            this.flowLayoutPanel07.Visible = false;
            // 
            // pictureBox07
            // 
            this.pictureBox07.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox07.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox07.BackgroundImage")));
            this.pictureBox07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox07.Location = new System.Drawing.Point(15, 15);
            this.pictureBox07.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox07.Name = "pictureBox07";
            this.pictureBox07.Size = new System.Drawing.Size(164, 130);
            this.pictureBox07.TabIndex = 1;
            this.pictureBox07.TabStop = false;
            // 
            // label07
            // 
            this.label07.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label07.ForeColor = System.Drawing.Color.LightGray;
            this.label07.Location = new System.Drawing.Point(15, 160);
            this.label07.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(164, 73);
            this.label07.TabIndex = 2;
            this.label07.Text = "Name";
            this.label07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label07.Click += new System.EventHandler(this.label07_Click);
            // 
            // flowLayoutPanel04
            // 
            this.flowLayoutPanel04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel04.Controls.Add(this.pictureBox04);
            this.flowLayoutPanel04.Controls.Add(this.label04);
            this.flowLayoutPanel04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel04.Location = new System.Drawing.Point(757, 25);
            this.flowLayoutPanel04.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel04.Name = "flowLayoutPanel04";
            this.flowLayoutPanel04.Size = new System.Drawing.Size(194, 249);
            this.flowLayoutPanel04.TabIndex = 9;
            this.flowLayoutPanel04.Visible = false;
            // 
            // pictureBox04
            // 
            this.pictureBox04.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox04.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox04.BackgroundImage")));
            this.pictureBox04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox04.Location = new System.Drawing.Point(15, 15);
            this.pictureBox04.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox04.Name = "pictureBox04";
            this.pictureBox04.Size = new System.Drawing.Size(164, 130);
            this.pictureBox04.TabIndex = 1;
            this.pictureBox04.TabStop = false;
            // 
            // label04
            // 
            this.label04.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label04.ForeColor = System.Drawing.Color.LightGray;
            this.label04.Location = new System.Drawing.Point(15, 160);
            this.label04.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(164, 73);
            this.label04.TabIndex = 2;
            this.label04.Text = "Name";
            this.label04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label04.Click += new System.EventHandler(this.label04_Click);
            this.label04.MouseLeave += new System.EventHandler(this.label04_MouseLeave);
            this.label04.MouseHover += new System.EventHandler(this.label04_MouseHover);
            // 
            // flowLayoutPanel01
            // 
            this.flowLayoutPanel01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel01.Controls.Add(this.pictureBox01);
            this.flowLayoutPanel01.Controls.Add(this.label01);
            this.flowLayoutPanel01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel01.Location = new System.Drawing.Point(25, 25);
            this.flowLayoutPanel01.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel01.Name = "flowLayoutPanel01";
            this.flowLayoutPanel01.Size = new System.Drawing.Size(194, 249);
            this.flowLayoutPanel01.TabIndex = 8;
            this.flowLayoutPanel01.Visible = false;
            // 
            // pictureBox01
            // 
            this.pictureBox01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox01.BackgroundImage")));
            this.pictureBox01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox01.Location = new System.Drawing.Point(15, 15);
            this.pictureBox01.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox01.Name = "pictureBox01";
            this.pictureBox01.Size = new System.Drawing.Size(164, 130);
            this.pictureBox01.TabIndex = 1;
            this.pictureBox01.TabStop = false;
            // 
            // label01
            // 
            this.label01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label01.ForeColor = System.Drawing.Color.LightGray;
            this.label01.Location = new System.Drawing.Point(15, 160);
            this.label01.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(164, 74);
            this.label01.TabIndex = 2;
            this.label01.Text = "Name";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label01.Click += new System.EventHandler(this.label01_Click);
            this.label01.MouseLeave += new System.EventHandler(this.label01_MouseLeave);
            this.label01.MouseHover += new System.EventHandler(this.label01_MouseHover);
            // 
            // flowLayoutPanel02
            // 
            this.flowLayoutPanel02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel02.Controls.Add(this.pictureBox02);
            this.flowLayoutPanel02.Controls.Add(this.label02);
            this.flowLayoutPanel02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel02.Location = new System.Drawing.Point(269, 25);
            this.flowLayoutPanel02.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel02.Name = "flowLayoutPanel02";
            this.flowLayoutPanel02.Size = new System.Drawing.Size(194, 249);
            this.flowLayoutPanel02.TabIndex = 7;
            this.flowLayoutPanel02.Visible = false;
            // 
            // pictureBox02
            // 
            this.pictureBox02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox02.BackgroundImage")));
            this.pictureBox02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox02.Location = new System.Drawing.Point(15, 15);
            this.pictureBox02.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox02.Name = "pictureBox02";
            this.pictureBox02.Size = new System.Drawing.Size(164, 130);
            this.pictureBox02.TabIndex = 1;
            this.pictureBox02.TabStop = false;
            // 
            // label02
            // 
            this.label02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label02.ForeColor = System.Drawing.Color.LightGray;
            this.label02.Location = new System.Drawing.Point(15, 160);
            this.label02.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(164, 73);
            this.label02.TabIndex = 2;
            this.label02.Text = "Name";
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label02.Click += new System.EventHandler(this.label02_Click);
            this.label02.MouseLeave += new System.EventHandler(this.label02_MouseLeave);
            this.label02.MouseHover += new System.EventHandler(this.label02_MouseHover);
            // 
            // flowLayoutPanel03
            // 
            this.flowLayoutPanel03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel03.Controls.Add(this.pictureBox03);
            this.flowLayoutPanel03.Controls.Add(this.label03);
            this.flowLayoutPanel03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel03.Location = new System.Drawing.Point(513, 25);
            this.flowLayoutPanel03.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel03.Name = "flowLayoutPanel03";
            this.flowLayoutPanel03.Size = new System.Drawing.Size(194, 249);
            this.flowLayoutPanel03.TabIndex = 6;
            this.flowLayoutPanel03.Visible = false;
            // 
            // pictureBox03
            // 
            this.pictureBox03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox03.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox03.BackgroundImage")));
            this.pictureBox03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox03.Location = new System.Drawing.Point(15, 15);
            this.pictureBox03.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox03.Name = "pictureBox03";
            this.pictureBox03.Size = new System.Drawing.Size(164, 130);
            this.pictureBox03.TabIndex = 1;
            this.pictureBox03.TabStop = false;
            // 
            // label03
            // 
            this.label03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label03.ForeColor = System.Drawing.Color.LightGray;
            this.label03.Location = new System.Drawing.Point(15, 160);
            this.label03.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(164, 73);
            this.label03.TabIndex = 2;
            this.label03.Text = "Name";
            this.label03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label03.Click += new System.EventHandler(this.label03_Click);
            this.label03.MouseLeave += new System.EventHandler(this.label03_MouseLeave);
            this.label03.MouseHover += new System.EventHandler(this.label03_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(25, 65);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1, 10);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(15, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 130);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(25, 25);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(25);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1, 250);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(15, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 130);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activeList
            // 
            this.activeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.activeList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activeList.ForeColor = System.Drawing.Color.DarkGray;
            this.activeList.Location = new System.Drawing.Point(909, 757);
            this.activeList.Name = "activeList";
            this.activeList.Size = new System.Drawing.Size(393, 33);
            this.activeList.TabIndex = 20;
            this.activeList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentSong
            // 
            this.CurrentSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CurrentSong.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentSong.ForeColor = System.Drawing.Color.DarkGray;
            this.CurrentSong.Location = new System.Drawing.Point(731, 826);
            this.CurrentSong.Name = "CurrentSong";
            this.CurrentSong.Size = new System.Drawing.Size(770, 33);
            this.CurrentSong.TabIndex = 21;
            this.CurrentSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.CurrentSong);
            this.Controls.Add(this.activeList);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pictureBoxSearchIcon);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.labelMyMedia);
            this.Controls.Add(this.playListsTable);
            this.Controls.Add(this.labelFavoriteTracks);
            this.Controls.Add(this.labelCreatePlayList);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.mediaItem);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.createItem);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.favoriteSongs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
            this.playListsTable.ResumeLayout(false);
            this.flowLayoutPanel05.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox05)).EndInit();
            this.flowLayoutPanel06.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox06)).EndInit();
            this.flowLayoutPanel07.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox07)).EndInit();
            this.flowLayoutPanel04.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox04)).EndInit();
            this.flowLayoutPanel01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).EndInit();
            this.flowLayoutPanel02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).EndInit();
            this.flowLayoutPanel03.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox03)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelMyMedia;
        private Label labelFavoriteTracks;
        private Label labelCreatePlayList;
        private Label labelSearch;
        private Label labelMain;
        private Label labelLogo;
        private PictureBox logo;
        private PictureBox favoriteSongs;
        private PictureBox homeIcon;
        private PictureBox searchIcon;
        private PictureBox createItem;
        private PictureBox mediaItem;
        private Label label1;
        private TextBox searchField;
        private RoundButton searchFieldWrapper;
        private PictureBox pictureBoxSearchIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button play;
        private Button next;
        private Button prev;
        private Button stop;
        private TableLayoutPanel playListsTable;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox3;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel05;
        private PictureBox pictureBox05;
        private Label label05;
        private FlowLayoutPanel flowLayoutPanel06;
        private PictureBox pictureBox06;
        private Label label06;
        private FlowLayoutPanel flowLayoutPanel07;
        private PictureBox pictureBox07;
        private Label label07;
        private FlowLayoutPanel flowLayoutPanel04;
        private PictureBox pictureBox04;
        private Label label04;
        private FlowLayoutPanel flowLayoutPanel01;
        private PictureBox pictureBox01;
        private Label label01;
        private FlowLayoutPanel flowLayoutPanel02;
        private PictureBox pictureBox02;
        private Label label02;
        private FlowLayoutPanel flowLayoutPanel03;
        private PictureBox pictureBox03;
        private Label label03;
        private Label activeList;
        private Label CurrentSong;
    }
}