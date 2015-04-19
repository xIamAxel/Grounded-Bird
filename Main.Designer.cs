namespace TwitterProject
{
    partial class twitterProject
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usersTweets = new System.Windows.Forms.TabPage();
            this.tweetSearcherTab = new System.Windows.Forms.TabPage();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputDisplay = new System.Windows.Forms.TextBox();
            this.tickerBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.tweetBoxControler = new System.Windows.Forms.TabControl();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu.SuspendLayout();
            this.tweetSearcherTab.SuspendLayout();
            this.tweetBoxControler.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inputsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1032, 24);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputsToolStripMenuItem
            // 
            this.inputsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.inputsToolStripMenuItem.Name = "inputsToolStripMenuItem";
            this.inputsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.inputsToolStripMenuItem.Text = "Inputs";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // usersTweets
            // 
            this.usersTweets.AutoScroll = true;
            this.usersTweets.BackColor = System.Drawing.Color.Gainsboro;
            this.usersTweets.Location = new System.Drawing.Point(4, 22);
            this.usersTweets.Name = "usersTweets";
            this.usersTweets.Padding = new System.Windows.Forms.Padding(3);
            this.usersTweets.Size = new System.Drawing.Size(1024, 533);
            this.usersTweets.TabIndex = 2;
            this.usersTweets.Text = "My Tweets";
            // 
            // tweetSearcherTab
            // 
            this.tweetSearcherTab.BackColor = System.Drawing.Color.Gainsboro;
            this.tweetSearcherTab.Controls.Add(this.inputBox);
            this.tweetSearcherTab.Controls.Add(this.inputDisplay);
            this.tweetSearcherTab.Controls.Add(this.tickerBox);
            this.tweetSearcherTab.Controls.Add(this.inputButton);
            this.tweetSearcherTab.Location = new System.Drawing.Point(4, 22);
            this.tweetSearcherTab.Name = "tweetSearcherTab";
            this.tweetSearcherTab.Padding = new System.Windows.Forms.Padding(3);
            this.tweetSearcherTab.Size = new System.Drawing.Size(1024, 533);
            this.tweetSearcherTab.TabIndex = 1;
            this.tweetSearcherTab.Text = "Tweet Searcher";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(801, 339);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(167, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // inputDisplay
            // 
            this.inputDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputDisplay.Location = new System.Drawing.Point(708, 370);
            this.inputDisplay.Multiline = true;
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(260, 95);
            this.inputDisplay.TabIndex = 6;
            this.inputDisplay.DoubleClick += new System.EventHandler(this.inputDisplay_DoubleClick);
            // 
            // tickerBox
            // 
            this.tickerBox.Location = new System.Drawing.Point(11, 11);
            this.tickerBox.Multiline = true;
            this.tickerBox.Name = "tickerBox";
            this.tickerBox.Size = new System.Drawing.Size(681, 454);
            this.tickerBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(708, 336);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 23);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Enter";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // tweetBoxControler
            // 
            this.tweetBoxControler.Controls.Add(this.usersTweets);
            this.tweetBoxControler.Controls.Add(this.tweetSearcherTab);
            this.tweetBoxControler.Location = new System.Drawing.Point(0, 27);
            this.tweetBoxControler.Name = "tweetBoxControler";
            this.tweetBoxControler.SelectedIndex = 0;
            this.tweetBoxControler.Size = new System.Drawing.Size(1032, 559);
            this.tweetBoxControler.TabIndex = 6;
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "Twitter";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // twitterProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 584);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.tweetBoxControler);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "twitterProject";
            this.Text = "Twitter Project";
            this.Resize += new System.EventHandler(this.twitterProject_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tweetSearcherTab.ResumeLayout(false);
            this.tweetSearcherTab.PerformLayout();
            this.tweetBoxControler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage usersTweets;
        private System.Windows.Forms.TabPage tweetSearcherTab;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox inputDisplay;
        private System.Windows.Forms.TextBox tickerBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TabControl tweetBoxControler;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

