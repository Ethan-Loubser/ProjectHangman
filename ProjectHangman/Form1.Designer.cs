namespace ProjectHangman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label12 = new System.Windows.Forms.Label();
            this.lblStrike1 = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStrike2 = new System.Windows.Forms.Label();
            this.lblStrike6 = new System.Windows.Forms.Label();
            this.lblStrike7 = new System.Windows.Forms.Label();
            this.lblStrike3 = new System.Windows.Forms.Label();
            this.lblStrike8 = new System.Windows.Forms.Label();
            this.lblStrike4 = new System.Windows.Forms.Label();
            this.lblStrike5 = new System.Windows.Forms.Label();
            this.lblStrike9 = new System.Windows.Forms.Label();
            this.lblStrike10 = new System.Windows.Forms.Label();
            this.YourScoreBoard = new System.Windows.Forms.GroupBox();
            this.BestScoreBoard = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter4 = new System.Windows.Forms.Label();
            this.lblLetter5 = new System.Windows.Forms.Label();
            this.lblLetter6 = new System.Windows.Forms.Label();
            this.lblLetter7 = new System.Windows.Forms.Label();
            this.HangManPB = new System.Windows.Forms.PictureBox();
            this.QuitGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.YourScoreBoard.SuspendLayout();
            this.BestScoreBoard.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangManPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Sienna;
            this.label12.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(414, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 40);
            this.label12.TabIndex = 16;
            this.label12.Text = "A";
            // 
            // lblStrike1
            // 
            this.lblStrike1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike1.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike1.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike1.Location = new System.Drawing.Point(6, 50);
            this.lblStrike1.Name = "lblStrike1";
            this.lblStrike1.Size = new System.Drawing.Size(29, 40);
            this.lblStrike1.TabIndex = 18;
            // 
            // lblYourScore
            // 
            this.lblYourScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYourScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYourScore.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYourScore.Location = new System.Drawing.Point(64, 67);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(30, 40);
            this.lblYourScore.TabIndex = 26;
            // 
            // lblBestScore
            // 
            this.lblBestScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBestScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBestScore.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBestScore.Location = new System.Drawing.Point(42, 67);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(48, 40);
            this.lblBestScore.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImage = global::ProjectHangman.Properties.Resources.Screenshot_2023_09_09_223552;
            this.groupBox1.Controls.Add(this.lblStrike2);
            this.groupBox1.Controls.Add(this.lblStrike6);
            this.groupBox1.Controls.Add(this.lblStrike7);
            this.groupBox1.Controls.Add(this.lblStrike3);
            this.groupBox1.Controls.Add(this.lblStrike8);
            this.groupBox1.Controls.Add(this.lblStrike4);
            this.groupBox1.Controls.Add(this.lblStrike5);
            this.groupBox1.Controls.Add(this.lblStrike9);
            this.groupBox1.Controls.Add(this.lblStrike10);
            this.groupBox1.Controls.Add(this.lblStrike1);
            this.groupBox1.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(362, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 140);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strikes:";
            // 
            // lblStrike2
            // 
            this.lblStrike2.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike2.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike2.Location = new System.Drawing.Point(41, 50);
            this.lblStrike2.Name = "lblStrike2";
            this.lblStrike2.Size = new System.Drawing.Size(29, 40);
            this.lblStrike2.TabIndex = 27;
            // 
            // lblStrike6
            // 
            this.lblStrike6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike6.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike6.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike6.Location = new System.Drawing.Point(6, 90);
            this.lblStrike6.Name = "lblStrike6";
            this.lblStrike6.Size = new System.Drawing.Size(29, 40);
            this.lblStrike6.TabIndex = 26;
            // 
            // lblStrike7
            // 
            this.lblStrike7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike7.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike7.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike7.Location = new System.Drawing.Point(41, 90);
            this.lblStrike7.Name = "lblStrike7";
            this.lblStrike7.Size = new System.Drawing.Size(29, 40);
            this.lblStrike7.TabIndex = 25;
            // 
            // lblStrike3
            // 
            this.lblStrike3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike3.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike3.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike3.Location = new System.Drawing.Point(74, 50);
            this.lblStrike3.Name = "lblStrike3";
            this.lblStrike3.Size = new System.Drawing.Size(29, 40);
            this.lblStrike3.TabIndex = 24;
            // 
            // lblStrike8
            // 
            this.lblStrike8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike8.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike8.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike8.Location = new System.Drawing.Point(74, 90);
            this.lblStrike8.Name = "lblStrike8";
            this.lblStrike8.Size = new System.Drawing.Size(29, 40);
            this.lblStrike8.TabIndex = 23;
            // 
            // lblStrike4
            // 
            this.lblStrike4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike4.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike4.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike4.Location = new System.Drawing.Point(109, 50);
            this.lblStrike4.Name = "lblStrike4";
            this.lblStrike4.Size = new System.Drawing.Size(29, 40);
            this.lblStrike4.TabIndex = 22;
            // 
            // lblStrike5
            // 
            this.lblStrike5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike5.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike5.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike5.Location = new System.Drawing.Point(144, 50);
            this.lblStrike5.Name = "lblStrike5";
            this.lblStrike5.Size = new System.Drawing.Size(29, 40);
            this.lblStrike5.TabIndex = 21;
            // 
            // lblStrike9
            // 
            this.lblStrike9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike9.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike9.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike9.Location = new System.Drawing.Point(109, 90);
            this.lblStrike9.Name = "lblStrike9";
            this.lblStrike9.Size = new System.Drawing.Size(29, 40);
            this.lblStrike9.TabIndex = 20;
            // 
            // lblStrike10
            // 
            this.lblStrike10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStrike10.BackColor = System.Drawing.Color.Transparent;
            this.lblStrike10.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrike10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrike10.Location = new System.Drawing.Point(144, 90);
            this.lblStrike10.Name = "lblStrike10";
            this.lblStrike10.Size = new System.Drawing.Size(29, 40);
            this.lblStrike10.TabIndex = 19;
            // 
            // YourScoreBoard
            // 
            this.YourScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YourScoreBoard.BackgroundImage = global::ProjectHangman.Properties.Resources.Screenshot_2023_09_09_223552;
            this.YourScoreBoard.Controls.Add(this.lblYourScore);
            this.YourScoreBoard.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourScoreBoard.ForeColor = System.Drawing.Color.Snow;
            this.YourScoreBoard.Location = new System.Drawing.Point(141, 353);
            this.YourScoreBoard.Name = "YourScoreBoard";
            this.YourScoreBoard.Size = new System.Drawing.Size(145, 140);
            this.YourScoreBoard.TabIndex = 0;
            this.YourScoreBoard.TabStop = false;
            this.YourScoreBoard.Text = "Your Score:";
            // 
            // BestScoreBoard
            // 
            this.BestScoreBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BestScoreBoard.BackgroundImage = global::ProjectHangman.Properties.Resources.Screenshot_2023_09_09_223552;
            this.BestScoreBoard.Controls.Add(this.lblBestScore);
            this.BestScoreBoard.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScoreBoard.ForeColor = System.Drawing.Color.Snow;
            this.BestScoreBoard.Location = new System.Drawing.Point(1, 353);
            this.BestScoreBoard.Name = "BestScoreBoard";
            this.BestScoreBoard.Size = new System.Drawing.Size(141, 140);
            this.BestScoreBoard.TabIndex = 38;
            this.BestScoreBoard.TabStop = false;
            this.BestScoreBoard.Text = "Best Score:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::ProjectHangman.Properties.Resources.Screenshot_2023_09_10_171722;
            this.groupBox4.Controls.Add(this.lblLetter1);
            this.groupBox4.Controls.Add(this.lblLetter2);
            this.groupBox4.Controls.Add(this.lblLetter3);
            this.groupBox4.Controls.Add(this.lblLetter4);
            this.groupBox4.Controls.Add(this.lblLetter5);
            this.groupBox4.Controls.Add(this.lblLetter6);
            this.groupBox4.Controls.Add(this.lblLetter7);
            this.groupBox4.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(62, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 78);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // lblLetter1
            // 
            this.lblLetter1.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter1.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter1.Location = new System.Drawing.Point(31, 14);
            this.lblLetter1.Name = "lblLetter1";
            this.lblLetter1.Size = new System.Drawing.Size(56, 68);
            this.lblLetter1.TabIndex = 40;
            this.lblLetter1.Text = " ";
            // 
            // lblLetter2
            // 
            this.lblLetter2.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter2.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter2.Location = new System.Drawing.Point(92, 12);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(50, 68);
            this.lblLetter2.TabIndex = 15;
            this.lblLetter2.Text = " ";
            // 
            // lblLetter3
            // 
            this.lblLetter3.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter3.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter3.Location = new System.Drawing.Point(148, 12);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(51, 68);
            this.lblLetter3.TabIndex = 14;
            this.lblLetter3.Text = " ";
            // 
            // lblLetter4
            // 
            this.lblLetter4.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter4.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter4.Location = new System.Drawing.Point(204, 12);
            this.lblLetter4.Name = "lblLetter4";
            this.lblLetter4.Size = new System.Drawing.Size(55, 68);
            this.lblLetter4.TabIndex = 13;
            this.lblLetter4.Text = " ";
            // 
            // lblLetter5
            // 
            this.lblLetter5.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter5.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter5.Location = new System.Drawing.Point(265, 12);
            this.lblLetter5.Name = "lblLetter5";
            this.lblLetter5.Size = new System.Drawing.Size(51, 68);
            this.lblLetter5.TabIndex = 12;
            this.lblLetter5.Text = " ";
            // 
            // lblLetter6
            // 
            this.lblLetter6.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter6.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter6.Location = new System.Drawing.Point(322, 12);
            this.lblLetter6.Name = "lblLetter6";
            this.lblLetter6.Size = new System.Drawing.Size(51, 68);
            this.lblLetter6.TabIndex = 11;
            this.lblLetter6.Text = " ";
            // 
            // lblLetter7
            // 
            this.lblLetter7.BackColor = System.Drawing.Color.Transparent;
            this.lblLetter7.Font = new System.Drawing.Font("Niagara Engraved", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter7.Location = new System.Drawing.Point(379, 11);
            this.lblLetter7.Name = "lblLetter7";
            this.lblLetter7.Size = new System.Drawing.Size(51, 69);
            this.lblLetter7.TabIndex = 10;
            this.lblLetter7.Text = " ";
            // 
            // HangManPB
            // 
            this.HangManPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HangManPB.BackColor = System.Drawing.Color.Transparent;
            this.HangManPB.Location = new System.Drawing.Point(221, 34);
            this.HangManPB.Name = "HangManPB";
            this.HangManPB.Size = new System.Drawing.Size(176, 173);
            this.HangManPB.TabIndex = 36;
            this.HangManPB.TabStop = false;
            // 
            // QuitGameButton
            // 
            this.QuitGameButton.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitGameButton.ForeColor = System.Drawing.Color.Snow;
            this.QuitGameButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitGameButton.Image")));
            this.QuitGameButton.Location = new System.Drawing.Point(30, 114);
            this.QuitGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuitGameButton.Name = "QuitGameButton";
            this.QuitGameButton.Size = new System.Drawing.Size(92, 57);
            this.QuitGameButton.TabIndex = 1;
            this.QuitGameButton.Text = "Quit";
            this.QuitGameButton.UseVisualStyleBackColor = true;
            this.QuitGameButton.Click += new System.EventHandler(this.QuitGameButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.ForeColor = System.Drawing.Color.Snow;
            this.NewGameButton.Image = ((System.Drawing.Image)(resources.GetObject("NewGameButton.Image")));
            this.NewGameButton.Location = new System.Drawing.Point(30, 27);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(92, 58);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ProjectHangman.Properties.Resources.HangManBGI3;
            this.ClientSize = new System.Drawing.Size(596, 493);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.YourScoreBoard);
            this.Controls.Add(this.BestScoreBoard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HangManPB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.QuitGameButton);
            this.Controls.Add(this.NewGameButton);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "HangMan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.YourScoreBoard.ResumeLayout(false);
            this.BestScoreBoard.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HangManPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button QuitGameButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStrike1;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.PictureBox HangManPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox YourScoreBoard;
        private System.Windows.Forms.Label lblStrike2;
        private System.Windows.Forms.Label lblStrike6;
        private System.Windows.Forms.Label lblStrike7;
        private System.Windows.Forms.Label lblStrike3;
        private System.Windows.Forms.Label lblStrike8;
        private System.Windows.Forms.Label lblStrike4;
        private System.Windows.Forms.Label lblStrike5;
        private System.Windows.Forms.Label lblStrike9;
        private System.Windows.Forms.Label lblStrike10;
        private System.Windows.Forms.GroupBox BestScoreBoard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLetter1;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter4;
        private System.Windows.Forms.Label lblLetter5;
        private System.Windows.Forms.Label lblLetter6;
        private System.Windows.Forms.Label lblLetter7;
    }
}

