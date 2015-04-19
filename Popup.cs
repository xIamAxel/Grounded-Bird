using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Core;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.Controllers;
using Tweetinvi.Core.Interfaces.DTO;
using Tweetinvi.Core.Interfaces.Models;
using Tweetinvi.Core.Interfaces.Models.Parameters;
using Tweetinvi.Core.Interfaces.oAuth;
using Tweetinvi.Core.Interfaces.Streaminvi;
using Tweetinvi.Json;
using Stream = Tweetinvi.Stream;

namespace TwitterProject
{
    public partial class Popup : Form
    {
   
        private Timer timer;
        private int startPosX;
        private int startPosY;
        //private Tweet theTweet;
        
        
        //private Object tweets = Search.SearchTweets("hackru");

        public Popup(TweetObj twitterObject)
        {
            InitializeComponent();
            // We want our window to be the top most
            TopMost = true;
            // Pop doesn't need to be shown in task bar
            ShowInTaskbar = false;
            //Border style
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            BackColor = Color.White;
            // Create and run timer for animation
            timer = new Timer();
            timer.Interval = 2;
            timer.Tick += timer_Tick;
            //tweetbox.Enabled = false;

            avatar.Load(twitterObject.picture);

            tweetbox.Text = twitterObject.message;
            label1.Text = twitterObject.username;

            //TwitterCredentials.SetCredentials("UMEqCSDmN1g0fWFGvMDJRFmU9", "Oijm3yEu3msMqVfsAuCZJY2QmdboaaTfVj5E4gouHRkfr8idkt", "3180092943-4as7GXzJjyPNpqKXJL2OFQGDPAIUE3EbfqIc8ZI", "2Bc0BtaWzZauJC8r2btjyi9nQyTcTb6m4U7zv4LX01w9Q");

            
        }

        protected override void OnLoad(EventArgs e)
        {
            // Move window out of screen
            startPosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
            startPosY = Screen.PrimaryScreen.WorkingArea.Height;
            SetDesktopLocation(startPosX, startPosY);
            base.OnLoad(e);
            // Begin animation
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //Lift window by 5 pixels
            startPosY -= 5;
            //If window is fully visible stop the timer
            if (startPosY < Screen.PrimaryScreen.WorkingArea.Height - Height)
                timer.Stop();
               
            else
                SetDesktopLocation(startPosX, startPosY);
        }


        // Double click avatar to go to twitter url
        private void avatar_DoubleClick(object sender, EventArgs e)
        {
           //Console.WriteLine("THAT'S NOT READY YET!");
           //tweetbox.Text = "NOT YET!";
            //System.Diagnostics.Process.Start("https://twitter.com/");


            // Access the filtered stream
            //var filteredStream = Stream.CreateFilteredStream();
            //filteredStream.AddTrack("pie");
            //filteredStream.MatchingTweetReceived += (sender1, args) => { tweetbox.Text = args.Tweet.Text; };
            //filteredStream.StartStreamMatchingAllConditions();


        }


        // This code block prevents the user from dragging the window
        protected override void WndProc(ref System.Windows.Forms.Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        //// Hides the form if minimized, so that it only appears in system tray
        private void TwitterThing_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TwitterThing_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void TwitterThing_Load_1(object sender, EventArgs e)
        {

        }

    }


}
