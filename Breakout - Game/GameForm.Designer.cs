namespace Breakout_Game
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.timerGameClock = new System.Windows.Forms.Timer(this.components);
            this.labelLoser = new System.Windows.Forms.Label();
            this.panelEndGame = new System.Windows.Forms.Panel();
            this.buttonEndNewGame = new System.Windows.Forms.Button();
            this.buttonEndQuit = new System.Windows.Forms.Button();
            this.buttonEndMainMenu = new System.Windows.Forms.Button();
            this.panelPause = new System.Windows.Forms.Panel();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.labelPause = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.labelUpateLevel = new System.Windows.Forms.Label();
            this.labelUpdateScore = new System.Windows.Forms.Label();
            this.labelUpdateLives = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGamesPlayed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStaticLevel = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.labelUpdateGamesPlayed = new System.Windows.Forms.Label();
            this.labelUpdateGamesWon = new System.Windows.Forms.Label();
            this.panelEndGame.SuspendLayout();
            this.panelPause.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGameClock
            // 
            this.timerGameClock.Enabled = true;
            this.timerGameClock.Interval = 10;
            this.timerGameClock.Tick += new System.EventHandler(this.timerGameClock_Tick);
            // 
            // labelLoser
            // 
            this.labelLoser.Image = global::Breakout_Game.Properties.Resources.labelLoser_bkg;
            this.labelLoser.Location = new System.Drawing.Point(29, 12);
            this.labelLoser.Name = "labelLoser";
            this.labelLoser.Size = new System.Drawing.Size(201, 60);
            this.labelLoser.TabIndex = 16;
            this.labelLoser.Visible = false;
            // 
            // panelEndGame
            // 
            this.panelEndGame.BackgroundImage = global::Breakout_Game.Properties.Resources.winner_bkg;
            this.panelEndGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEndGame.Controls.Add(this.labelLoser);
            this.panelEndGame.Controls.Add(this.buttonEndNewGame);
            this.panelEndGame.Controls.Add(this.buttonEndQuit);
            this.panelEndGame.Controls.Add(this.buttonEndMainMenu);
            this.panelEndGame.Location = new System.Drawing.Point(370, 220);
            this.panelEndGame.Name = "panelEndGame";
            this.panelEndGame.Size = new System.Drawing.Size(257, 258);
            this.panelEndGame.TabIndex = 15;
            this.panelEndGame.Visible = false;
            // 
            // buttonEndNewGame
            // 
            this.buttonEndNewGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEndNewGame.FlatAppearance.BorderSize = 0;
            this.buttonEndNewGame.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEndNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEndNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEndNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndNewGame.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonEndNewGame.Location = new System.Drawing.Point(39, 100);
            this.buttonEndNewGame.Name = "buttonEndNewGame";
            this.buttonEndNewGame.Size = new System.Drawing.Size(176, 27);
            this.buttonEndNewGame.TabIndex = 14;
            this.buttonEndNewGame.Text = "NEW GAME";
            this.buttonEndNewGame.UseVisualStyleBackColor = false;
            this.buttonEndNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            this.buttonEndNewGame.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonEndNewGame.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // buttonEndQuit
            // 
            this.buttonEndQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEndQuit.FlatAppearance.BorderSize = 0;
            this.buttonEndQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEndQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEndQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEndQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndQuit.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndQuit.ForeColor = System.Drawing.Color.White;
            this.buttonEndQuit.Location = new System.Drawing.Point(39, 166);
            this.buttonEndQuit.Name = "buttonEndQuit";
            this.buttonEndQuit.Size = new System.Drawing.Size(176, 27);
            this.buttonEndQuit.TabIndex = 13;
            this.buttonEndQuit.Text = "QUIT";
            this.buttonEndQuit.UseVisualStyleBackColor = false;
            this.buttonEndQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonEndQuit.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonEndQuit.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // buttonEndMainMenu
            // 
            this.buttonEndMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEndMainMenu.FlatAppearance.BorderSize = 0;
            this.buttonEndMainMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonEndMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEndMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEndMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndMainMenu.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndMainMenu.ForeColor = System.Drawing.Color.White;
            this.buttonEndMainMenu.Location = new System.Drawing.Point(39, 133);
            this.buttonEndMainMenu.Name = "buttonEndMainMenu";
            this.buttonEndMainMenu.Size = new System.Drawing.Size(176, 27);
            this.buttonEndMainMenu.TabIndex = 12;
            this.buttonEndMainMenu.Text = "MAIN MENU";
            this.buttonEndMainMenu.UseVisualStyleBackColor = false;
            this.buttonEndMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            this.buttonEndMainMenu.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonEndMainMenu.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // panelPause
            // 
            this.panelPause.BackgroundImage = global::Breakout_Game.Properties.Resources.pause_bkg;
            this.panelPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPause.Controls.Add(this.buttonNewGame);
            this.panelPause.Controls.Add(this.buttonQuit);
            this.panelPause.Controls.Add(this.buttonResume);
            this.panelPause.Controls.Add(this.buttonMainMenu);
            this.panelPause.Controls.Add(this.buttonSettings);
            this.panelPause.Location = new System.Drawing.Point(367, 223);
            this.panelPause.Name = "panelPause";
            this.panelPause.Size = new System.Drawing.Size(257, 258);
            this.panelPause.TabIndex = 3;
            this.panelPause.Visible = false;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Location = new System.Drawing.Point(39, 112);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(176, 27);
            this.buttonNewGame.TabIndex = 14;
            this.buttonNewGame.Text = "NEW GAME";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            this.buttonNewGame.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonNewGame.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.White;
            this.buttonQuit.Location = new System.Drawing.Point(39, 211);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(176, 27);
            this.buttonQuit.TabIndex = 13;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonResume.FlatAppearance.BorderSize = 0;
            this.buttonResume.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.ForeColor = System.Drawing.Color.White;
            this.buttonResume.Location = new System.Drawing.Point(39, 79);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(176, 27);
            this.buttonResume.TabIndex = 10;
            this.buttonResume.Text = "RESUME";
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            this.buttonResume.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonResume.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMainMenu.FlatAppearance.BorderSize = 0;
            this.buttonMainMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainMenu.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMainMenu.Location = new System.Drawing.Point(39, 178);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(176, 27);
            this.buttonMainMenu.TabIndex = 12;
            this.buttonMainMenu.Text = "MAIN MENU";
            this.buttonMainMenu.UseVisualStyleBackColor = false;
            this.buttonMainMenu.Click += new System.EventHandler(this.buttonMainMenu_Click);
            this.buttonMainMenu.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonMainMenu.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(39, 145);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(176, 27);
            this.buttonSettings.TabIndex = 11;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonSettings.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackgroundImage = global::Breakout_Game.Properties.Resources.btm_bar_bkg1;
            this.panelBottomBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBottomBar.Controls.Add(this.labelPause);
            this.panelBottomBar.Location = new System.Drawing.Point(0, 689);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1009, 46);
            this.panelBottomBar.TabIndex = 2;
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPause.ForeColor = System.Drawing.Color.Gold;
            this.labelPause.Location = new System.Drawing.Point(12, 15);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(168, 16);
            this.labelPause.TabIndex = 0;
            this.labelPause.Text = "(P) Pause / Menu";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackgroundImage = global::Breakout_Game.Properties.Resources.top_bar_bkg1;
            this.panelTopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTopBar.Controls.Add(this.labelUpdateGamesWon);
            this.panelTopBar.Controls.Add(this.labelUpdateGamesPlayed);
            this.panelTopBar.Controls.Add(this.labelUpateLevel);
            this.panelTopBar.Controls.Add(this.labelUpdateScore);
            this.panelTopBar.Controls.Add(this.labelUpdateLives);
            this.panelTopBar.Controls.Add(this.label4);
            this.panelTopBar.Controls.Add(this.labelGamesPlayed);
            this.panelTopBar.Controls.Add(this.label3);
            this.panelTopBar.Controls.Add(this.label2);
            this.panelTopBar.Controls.Add(this.labelStaticLevel);
            this.panelTopBar.Controls.Add(this.labelUserName);
            this.panelTopBar.Location = new System.Drawing.Point(0, 2);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1009, 75);
            this.panelTopBar.TabIndex = 1;
            // 
            // labelUpateLevel
            // 
            this.labelUpateLevel.AutoSize = true;
            this.labelUpateLevel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpateLevel.ForeColor = System.Drawing.Color.White;
            this.labelUpateLevel.Location = new System.Drawing.Point(151, 28);
            this.labelUpateLevel.Name = "labelUpateLevel";
            this.labelUpateLevel.Size = new System.Drawing.Size(40, 37);
            this.labelUpateLevel.TabIndex = 10;
            this.labelUpateLevel.Text = "1";
            // 
            // labelUpdateScore
            // 
            this.labelUpdateScore.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateScore.ForeColor = System.Drawing.Color.White;
            this.labelUpdateScore.Location = new System.Drawing.Point(927, 29);
            this.labelUpdateScore.Name = "labelUpdateScore";
            this.labelUpdateScore.Size = new System.Drawing.Size(69, 37);
            this.labelUpdateScore.TabIndex = 9;
            this.labelUpdateScore.Text = "0";
            this.labelUpdateScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdateLives
            // 
            this.labelUpdateLives.AutoSize = true;
            this.labelUpdateLives.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateLives.ForeColor = System.Drawing.Color.White;
            this.labelUpdateLives.Location = new System.Drawing.Point(519, 27);
            this.labelUpdateLives.Name = "labelUpdateLives";
            this.labelUpdateLives.Size = new System.Drawing.Size(40, 37);
            this.labelUpdateLives.TabIndex = 8;
            this.labelUpdateLives.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(857, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "GAMES WON";
            // 
            // labelGamesPlayed
            // 
            this.labelGamesPlayed.AutoSize = true;
            this.labelGamesPlayed.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamesPlayed.ForeColor = System.Drawing.Color.White;
            this.labelGamesPlayed.Location = new System.Drawing.Point(403, 6);
            this.labelGamesPlayed.Name = "labelGamesPlayed";
            this.labelGamesPlayed.Size = new System.Drawing.Size(128, 16);
            this.labelGamesPlayed.TabIndex = 6;
            this.labelGamesPlayed.Text = "GAMES PLAYED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "LIVES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(793, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCORE";
            // 
            // labelStaticLevel
            // 
            this.labelStaticLevel.AutoSize = true;
            this.labelStaticLevel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticLevel.ForeColor = System.Drawing.Color.White;
            this.labelStaticLevel.Location = new System.Drawing.Point(24, 27);
            this.labelStaticLevel.Name = "labelStaticLevel";
            this.labelStaticLevel.Size = new System.Drawing.Size(132, 37);
            this.labelStaticLevel.TabIndex = 3;
            this.labelStaticLevel.Text = "LEVEL";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(34, 6);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(98, 16);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User Name";
            // 
            // buttonBegin
            // 
            this.buttonBegin.BackColor = System.Drawing.Color.Transparent;
            this.buttonBegin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBegin.FlatAppearance.BorderSize = 0;
            this.buttonBegin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonBegin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBegin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBegin.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBegin.ForeColor = System.Drawing.Color.White;
            this.buttonBegin.Location = new System.Drawing.Point(0, 83);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(1009, 600);
            this.buttonBegin.TabIndex = 17;
            this.buttonBegin.Text = "< CLICK TO START >";
            this.buttonBegin.UseVisualStyleBackColor = false;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            this.buttonBegin.MouseEnter += new System.EventHandler(this.pauseMenuButton_Enter);
            this.buttonBegin.MouseLeave += new System.EventHandler(this.pauseMenuButton_Leave);
            // 
            // labelUpdateGamesPlayed
            // 
            this.labelUpdateGamesPlayed.AutoSize = true;
            this.labelUpdateGamesPlayed.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateGamesPlayed.ForeColor = System.Drawing.Color.White;
            this.labelUpdateGamesPlayed.Location = new System.Drawing.Point(533, 6);
            this.labelUpdateGamesPlayed.Name = "labelUpdateGamesPlayed";
            this.labelUpdateGamesPlayed.Size = new System.Drawing.Size(18, 16);
            this.labelUpdateGamesPlayed.TabIndex = 11;
            this.labelUpdateGamesPlayed.Text = "1";
            // 
            // labelUpdateGamesWon
            // 
            this.labelUpdateGamesWon.AutoSize = true;
            this.labelUpdateGamesWon.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateGamesWon.ForeColor = System.Drawing.Color.White;
            this.labelUpdateGamesWon.Location = new System.Drawing.Point(957, 7);
            this.labelUpdateGamesWon.Name = "labelUpdateGamesWon";
            this.labelUpdateGamesWon.Size = new System.Drawing.Size(18, 16);
            this.labelUpdateGamesWon.TabIndex = 12;
            this.labelUpdateGamesWon.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelEndGame);
            this.Controls.Add(this.panelPause);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.buttonBegin);
            this.Name = "GameForm";
            this.Text = "James\' Breakout";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.panelEndGame.ResumeLayout(false);
            this.panelPause.ResumeLayout(false);
            this.panelBottomBar.ResumeLayout(false);
            this.panelBottomBar.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGameClock;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStaticLevel;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGamesPlayed;
        private System.Windows.Forms.Label labelUpdateScore;
        private System.Windows.Forms.Label labelUpdateLives;
        private System.Windows.Forms.Label labelUpateLevel;
        private System.Windows.Forms.Panel panelEndGame;
        private System.Windows.Forms.Button buttonEndNewGame;
        private System.Windows.Forms.Button buttonEndQuit;
        private System.Windows.Forms.Button buttonEndMainMenu;
        private System.Windows.Forms.Label labelLoser;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Label labelUpdateGamesPlayed;
        private System.Windows.Forms.Label labelUpdateGamesWon;
    }
}

