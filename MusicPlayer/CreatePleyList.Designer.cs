namespace MusicPlayer
{
    partial class CreatePleyList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePleyList));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelMyMedia = new System.Windows.Forms.Label();
            this.labelFavoriteTracks = new System.Windows.Forms.Label();
            this.labelCreatePlayList = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.mediaItem = new System.Windows.Forms.PictureBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.createItem = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.favoriteSongs = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(608, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(835, 54);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "Мой плейлист №";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(608, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Плейлист";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(219, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 350);
            this.pictureBox.TabIndex = 42;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
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
            this.logo.TabIndex = 34;
            this.logo.TabStop = false;
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
            this.labelMyMedia.TabIndex = 40;
            this.labelMyMedia.Text = "Моя медиатека";
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
            this.labelFavoriteTracks.TabIndex = 39;
            this.labelFavoriteTracks.Text = "Любимые треки";
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
            this.labelCreatePlayList.TabIndex = 38;
            this.labelCreatePlayList.Text = "Создать плейлист";
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
            this.labelSearch.TabIndex = 37;
            this.labelSearch.Text = "Поиск";
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
            this.mediaItem.TabIndex = 31;
            this.mediaItem.TabStop = false;
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
            this.labelMain.TabIndex = 36;
            this.labelMain.Text = "Главная";
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
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
            this.createItem.TabIndex = 32;
            this.createItem.TabStop = false;
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
            this.labelLogo.TabIndex = 35;
            this.labelLogo.Text = "MyPlayer";
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
            this.searchIcon.TabIndex = 30;
            this.searchIcon.TabStop = false;
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
            this.homeIcon.TabIndex = 29;
            this.homeIcon.TabStop = false;
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
            this.favoriteSongs.TabIndex = 33;
            this.favoriteSongs.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 1041);
            this.label1.TabIndex = 41;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // CreatePleyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelMyMedia);
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
            this.Name = "CreatePleyList";
            this.Text = "CreatePleyList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatePleyList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox;
        private PictureBox logo;
        private Label labelMyMedia;
        private Label labelFavoriteTracks;
        private Label labelCreatePlayList;
        private Label labelSearch;
        private PictureBox mediaItem;
        private Label labelMain;
        private PictureBox createItem;
        private Label labelLogo;
        private PictureBox searchIcon;
        private PictureBox homeIcon;
        private PictureBox favoriteSongs;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}