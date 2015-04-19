using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.Controllers;
using Tweetinvi.Core.Interfaces.DTO;
using Tweetinvi.Core.Interfaces.DTO.QueryDTO;
using Tweetinvi.Core.Interfaces.Models;
using Tweetinvi.Core.Interfaces.Models.Parameters;
using Tweetinvi.Core.Interfaces.oAuth;
using Tweetinvi.Core.Interfaces.Streaminvi;
using Tweetinvi.Json;
using Tweetinvi.Streams;
using Stream = Tweetinvi.Stream;


namespace TwitterProject
{
    public partial class twitterProject : Form
    {
        public List<String> inputArray = new List<string>(); //string array for holding inputs
        public static twitterProject formMain;
        public List<TweetObj> tweetFeed = new List<TweetObj>();
        public int count = 0;
        public twitterProject()
        {
            InitializeComponent();
            formMain = this; //this lets us use the objects in this file in other forms
            setSettings();

            //Popup inputWindow = new Popup(); //Open input form
            //inputWindow.ShowDialog();        
    
            Thread recieverThread = new Thread(() => apiSetup());
            recieverThread.Start();
        }

        private void apiSetup()
        {
            Process twitterAPI = new Process();
            twitterAPI.StartInfo.FileName = @"C:\Users\Axel\Documents\Visual Studio 2012\Projects\Because FUCK\bin\Debug\Because FUCK.exe";
            twitterAPI.StartInfo.RedirectStandardOutput = true;
            twitterAPI.StartInfo.UseShellExecute = false;
            twitterAPI.Start();

            while (true)
            {
                string messageConsole = twitterAPI.StandardOutput.ReadLine();
                string usernameConsole = twitterAPI.StandardOutput.ReadLine();
                string pictureConsole = twitterAPI.StandardOutput.ReadLine();

                if (!messageConsole.IsEmpty())
                {
                    tweetFeed.Add(new TweetObj() { username = usernameConsole, message = messageConsole, picture = pictureConsole });
                    Popup inputWindow = new Popup(tweetFeed[count]); //Open input form
                    inputWindow.Show();
                    tweetElement(tweetFeed[count], count);
                    count++;
                }
            }

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process[] localByName = Process.GetProcessesByName("Because FUCK");
            foreach (var process in localByName)
            {
                process.Kill();
            }
        }
     

        private void tweetElement(TweetObj twitterObject, int location)
        {
            if (this.InvokeRequired)
            {
                
                this.Invoke( 
                    new MethodInvoker(delegate {
                    formMain.IsMdiContainer = true;
                    Form frmchild = new Form();
                    frmchild.MdiParent = this;
                    frmchild.Show();
                    frmchild.Size = new Size(980, 170);
                    frmchild.Location = new System.Drawing.Point(10, 10+160*location);
                    frmchild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                    PictureBox userPicture = new PictureBox();
                    userPicture.Load(twitterObject.picture);
                    

                    //userPicture.Image = image;
                    userPicture.Size = new System.Drawing.Size(90, 90);
                    userPicture.Location = new System.Drawing.Point(10, 10);
                    userPicture.SizeMode = PictureBoxSizeMode.StretchImage;

                    Label usernameLabel = new Label();
                    usernameLabel.Location = new System.Drawing.Point(10, 105);
                    usernameLabel.Text = "@" + twitterObject.username;
                    usernameLabel.Size = new Size(usernameLabel.PreferredWidth, usernameLabel.PreferredHeight);
                    usernameLabel.TextAlign = ContentAlignment.MiddleCenter;

                    TextBox messageBox = new TextBox();
                    messageBox.Size = new System.Drawing.Size(850, 110);
                    messageBox.Location = new System.Drawing.Point(110, 10);
                    messageBox.Text = twitterObject.message;
                    messageBox.Multiline = true;
                    messageBox.Font = new Font(messageBox.Font.FontFamily, 16);

                    formMain.usersTweets.Controls.Add(frmchild);
                    frmchild.Controls.Add(userPicture);
                    frmchild.Controls.Add(usernameLabel);
                    frmchild.Controls.Add(messageBox); 
                } ));
            }
            else
            {
                formMain.IsMdiContainer = true;
                Form frmchild = new Form();
                frmchild.MdiParent = this;
                frmchild.Show();
                frmchild.Size = new Size(980, 170);
                frmchild.Location = new System.Drawing.Point(10, 10+160*location);
                frmchild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                PictureBox userPicture = new PictureBox();
                userPicture.Load(twitterObject.picture);
                    
                //userPicture.Image = image;
                userPicture.Size = new System.Drawing.Size(90, 90);
                userPicture.Location = new System.Drawing.Point(10, 10);
                userPicture.SizeMode = PictureBoxSizeMode.StretchImage;

                Label usernameLabel = new Label();
                usernameLabel.Location = new System.Drawing.Point(10, 105);
                usernameLabel.Text = "@" + twitterObject.username;
                usernameLabel.Size = new Size(usernameLabel.PreferredWidth, usernameLabel.PreferredHeight);
                usernameLabel.TextAlign = ContentAlignment.MiddleCenter;

                TextBox messageBox = new TextBox();
                messageBox.Size = new System.Drawing.Size(850, 110);
                messageBox.Location = new System.Drawing.Point(110, 10);
                messageBox.Text = twitterObject.message;
                messageBox.Multiline = true;
                messageBox.Font = new Font(messageBox.Font.FontFamily, 16);

                formMain.usersTweets.Controls.Add(frmchild);
                frmchild.Controls.Add(userPicture);
                frmchild.Controls.Add(usernameLabel);
                frmchild.Controls.Add(messageBox); 
            }
            
        }

        private void setSettings()
        {
            //Make boxes readonly and set color
            inputDisplay.ReadOnly = true;
            inputDisplay.BackColor = Color.White;
            tickerBox.Enabled = false;
            tickerBox.BackColor = Color.White;
            //-------------------------------

        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            inputArray.Add(inputBox.Text); //add the text in inputBox to inputArray
            inputDisplay.Text += inputBox.Text + Environment.NewLine;
            inputBox.Clear();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputs inputWindow = new Inputs(); //Open input form
            inputWindow.ShowDialog();
        }


        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputButton.PerformClick();
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = inputButton;
        }

        private void inputDisplay_DoubleClick(object sender, System.EventArgs e)
        {
            Inputs inputWindow = new Inputs(); //Open input form
            inputWindow.ShowDialog();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void twitterProject_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

    }


    public class TweetObj
    {
        public string message { get; set; }
        public string username { get; set; }
        public string picture { get; set; }
        public TweetObj() { }
        public TweetObj(string username, string message, string picture)
        {
            this.username = username;
            this.message = message;
            this.picture = picture;
        }
    }
    
}
