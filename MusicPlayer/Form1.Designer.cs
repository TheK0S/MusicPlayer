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
            this.playListsTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listName1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchFieldWrapper = new MusicPlayer.RoundButton();
            this.songTimeLine = new System.Windows.Forms.TrackBar();
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItem)).BeginInit();
            this.playListsTable.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songTimeLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
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
            // playListsTable
            // 
            this.playListsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playListsTable.ColumnCount = 7;
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.playListsTable.Controls.Add(this.panel3, 2, 0);
            this.playListsTable.Controls.Add(this.panel1, 0, 0);
            this.playListsTable.Controls.Add(this.panel2, 1, 0);
            this.playListsTable.Location = new System.Drawing.Point(195, 0);
            this.playListsTable.Name = "playListsTable";
            this.playListsTable.RowCount = 3;
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playListsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.playListsTable.Size = new System.Drawing.Size(1709, 900);
            this.playListsTable.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(508, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 252);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(18, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 130);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.listName1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 252);
            this.panel1.TabIndex = 2;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // listName1
            // 
            this.listName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listName1.ForeColor = System.Drawing.Color.LightGray;
            this.listName1.Location = new System.Drawing.Point(16, 163);
            this.listName1.Name = "listName1";
            this.listName1.Size = new System.Drawing.Size(170, 73);
            this.listName1.TabIndex = 2;
            this.listName1.Text = "Name";
            this.listName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(264, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 252);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(17, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 130);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // searchFieldWrapper
            // 
            this.searchFieldWrapper.BackColor = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.BackColor2 = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonBorderColor = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonHighlightColor = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonHighlightColor2 = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonHighlightForeColor = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonPressedColor = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonPressedColor2 = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonPressedForeColor = System.Drawing.Color.LightGray;
            this.searchFieldWrapper.ButtonRoundRadius = 30;
            this.searchFieldWrapper.Location = new System.Drawing.Point(247, 1);
            this.searchFieldWrapper.Name = "searchFieldWrapper";
            this.searchFieldWrapper.Size = new System.Drawing.Size(342, 34);
            this.searchFieldWrapper.TabIndex = 6;
            this.searchFieldWrapper.Visible = false;
            this.searchFieldWrapper.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // songTimeLine
            // 
            this.songTimeLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songTimeLine.AutoSize = false;
            this.songTimeLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songTimeLine.LargeChange = 1;
            this.songTimeLine.Location = new System.Drawing.Point(378, 987);
            this.songTimeLine.Maximum = 180;
            this.songTimeLine.Name = "songTimeLine";
            this.songTimeLine.Size = new System.Drawing.Size(1347, 27);
            this.songTimeLine.SmallChange = 5;
            this.songTimeLine.TabIndex = 14;
            this.songTimeLine.TickStyle = System.Windows.Forms.TickStyle.None;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBoxSearchIcon);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.songTimeLine);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.labelMyMedia);
            this.Controls.Add(this.playListsTable);
            this.Controls.Add(this.labelFavoriteTracks);
            this.Controls.Add(this.searchFieldWrapper);
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
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItem)).EndInit();
            this.playListsTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songTimeLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
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
        private TableLayoutPanel playListsTable;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label listName1;
        private TextBox searchField;
        private RoundButton searchFieldWrapper;
        private TrackBar songTimeLine;
        private PictureBox pictureBoxSearchIcon;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
    }
}