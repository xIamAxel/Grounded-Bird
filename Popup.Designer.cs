namespace TwitterProject
{
    partial class Popup
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
            this.SuspendLayout();
            // 
            // TwitterThing
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "TwitterThing";
            this.Load += new System.EventHandler(this.TwitterThing_Load_1);
            this.ResumeLayout(false);

        
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.tweetbox = new System.Windows.Forms.TextBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tweetbox
            // 
            this.tweetbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tweetbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tweetbox.Location = new System.Drawing.Point(81, 22);
            this.tweetbox.MaxLength = 140;
            this.tweetbox.Multiline = true;
            this.tweetbox.Name = "New Tweet!";
            this.tweetbox.ReadOnly = true;
            this.tweetbox.Size = new System.Drawing.Size(248, 54);
            this.tweetbox.TabIndex = 1;
            this.tweetbox.Text = "";
            //// 
            //// avatar
            //// 
            //this.avatar.Image = global::TwitterProject.Properties.Resources.twitter;
            this.avatar.Location = new System.Drawing.Point(2, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(73, 73);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.DoubleClick += new System.EventHandler(this.avatar_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            //// 
            //// notifyIcon1
            //// 
            //this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            //this.notifyIcon1.Text = "Twitter Thing";
            //this.notifyIcon1.Visible = true;
            // 
            // TwitterThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tweetbox);
            this.Controls.Add(this.avatar);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwitterThing";
            this.Text = "TwitterThing";
            this.Load += new System.EventHandler(this.TwitterThing_Load);
            this.Resize += new System.EventHandler(this.TwitterThing_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tweetbox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;


    }
}

