namespace MazeGame
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.NavigationLable = new System.Windows.Forms.Label();
            this.LableCurPos = new System.Windows.Forms.Label();
            this.CurrentPositionLable = new System.Windows.Forms.Label();
            this.MissionTextLable = new System.Windows.Forms.Label();
            this.YouHave_listBox = new System.Windows.Forms.ListBox();
            this.theRoomContains_listbox = new System.Windows.Forms.ListBox();
            this.HaveLable = new System.Windows.Forms.Label();
            this.ContainLable = new System.Windows.Forms.Label();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.buttonUse = new System.Windows.Forms.Button();
            this.timer_timeBar = new System.Windows.Forms.Timer(this.components);
            this.lblMyTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonN
            // 
            this.buttonN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonN.Location = new System.Drawing.Point(633, 246);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(50, 47);
            this.buttonN.TabIndex = 0;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonS
            // 
            this.buttonS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonS.Location = new System.Drawing.Point(633, 334);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(50, 47);
            this.buttonS.TabIndex = 1;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonW
            // 
            this.buttonW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonW.Location = new System.Drawing.Point(586, 290);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(50, 47);
            this.buttonW.TabIndex = 2;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonE
            // 
            this.buttonE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonE.Location = new System.Drawing.Point(680, 290);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(50, 47);
            this.buttonE.TabIndex = 3;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // NavigationLable
            // 
            this.NavigationLable.AutoSize = true;
            this.NavigationLable.Location = new System.Drawing.Point(620, 227);
            this.NavigationLable.Name = "NavigationLable";
            this.NavigationLable.Size = new System.Drawing.Size(69, 15);
            this.NavigationLable.TabIndex = 4;
            this.NavigationLable.Text = "Navigation";
            // 
            // LableCurPos
            // 
            this.LableCurPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LableCurPos.AutoSize = true;
            this.LableCurPos.Location = new System.Drawing.Point(78, 250);
            this.LableCurPos.Name = "LableCurPos";
            this.LableCurPos.Size = new System.Drawing.Size(126, 15);
            this.LableCurPos.TabIndex = 5;
            this.LableCurPos.Text = "You are currently in:";
            // 
            // CurrentPositionLable
            // 
            this.CurrentPositionLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentPositionLable.AutoSize = true;
            this.CurrentPositionLable.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CurrentPositionLable.ForeColor = System.Drawing.Color.Blue;
            this.CurrentPositionLable.Location = new System.Drawing.Point(212, 245);
            this.CurrentPositionLable.Name = "CurrentPositionLable";
            this.CurrentPositionLable.Size = new System.Drawing.Size(128, 20);
            this.CurrentPositionLable.TabIndex = 6;
            this.CurrentPositionLable.Text = "Current Room";
            // 
            // MissionTextLable
            // 
            this.MissionTextLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MissionTextLable.AutoSize = true;
            this.MissionTextLable.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MissionTextLable.Location = new System.Drawing.Point(78, 34);
            this.MissionTextLable.Name = "MissionTextLable";
            this.MissionTextLable.Size = new System.Drawing.Size(466, 150);
            this.MissionTextLable.TabIndex = 7;
            this.MissionTextLable.Text = resources.GetString("MissionTextLable.Text");
            // 
            // YouHave_listBox
            // 
            this.YouHave_listBox.FormattingEnabled = true;
            this.YouHave_listBox.ItemHeight = 15;
            this.YouHave_listBox.Location = new System.Drawing.Point(81, 334);
            this.YouHave_listBox.Name = "YouHave_listBox";
            this.YouHave_listBox.Size = new System.Drawing.Size(141, 124);
            this.YouHave_listBox.TabIndex = 8;
            // 
            // theRoomContains_listbox
            // 
            this.theRoomContains_listbox.FormattingEnabled = true;
            this.theRoomContains_listbox.ItemHeight = 15;
            this.theRoomContains_listbox.Location = new System.Drawing.Point(379, 334);
            this.theRoomContains_listbox.Name = "theRoomContains_listbox";
            this.theRoomContains_listbox.Size = new System.Drawing.Size(141, 124);
            this.theRoomContains_listbox.TabIndex = 9;
            // 
            // HaveLable
            // 
            this.HaveLable.AutoSize = true;
            this.HaveLable.Location = new System.Drawing.Point(78, 312);
            this.HaveLable.Name = "HaveLable";
            this.HaveLable.Size = new System.Drawing.Size(69, 15);
            this.HaveLable.TabIndex = 10;
            this.HaveLable.Text = "You have: ";
            // 
            // ContainLable
            // 
            this.ContainLable.AutoSize = true;
            this.ContainLable.Location = new System.Drawing.Point(379, 311);
            this.ContainLable.Name = "ContainLable";
            this.ContainLable.Size = new System.Drawing.Size(121, 15);
            this.ContainLable.TabIndex = 11;
            this.ContainLable.Text = "The room contains: ";
            // 
            // buttonDrop
            // 
            this.buttonDrop.Location = new System.Drawing.Point(265, 358);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(75, 30);
            this.buttonDrop.TabIndex = 12;
            this.buttonDrop.Text = "Drop >";
            this.buttonDrop.UseVisualStyleBackColor = true;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Location = new System.Drawing.Point(265, 405);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(75, 32);
            this.buttonPickUp.TabIndex = 13;
            this.buttonPickUp.Text = "< Pick up";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // buttonUse
            // 
            this.buttonUse.Location = new System.Drawing.Point(112, 463);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(75, 22);
            this.buttonUse.TabIndex = 14;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // timer_timeBar
            // 
            this.timer_timeBar.Enabled = true;
            this.timer_timeBar.Interval = 1000;
            this.timer_timeBar.Tick += new System.EventHandler(this.timer_timeBar_Tick);
            // 
            // lblMyTime
            // 
            this.lblMyTime.AutoSize = true;
            this.lblMyTime.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMyTime.Location = new System.Drawing.Point(128, 207);
            this.lblMyTime.Name = "lblMyTime";
            this.lblMyTime.Size = new System.Drawing.Size(98, 20);
            this.lblMyTime.TabIndex = 15;
            this.lblMyTime.Text = "300 seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MazeGame.Properties.Resources.Princess;
            this.pictureBox1.Location = new System.Drawing.Point(587, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMyTime);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.buttonPickUp);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.ContainLable);
            this.Controls.Add(this.HaveLable);
            this.Controls.Add(this.theRoomContains_listbox);
            this.Controls.Add(this.YouHave_listBox);
            this.Controls.Add(this.MissionTextLable);
            this.Controls.Add(this.CurrentPositionLable);
            this.Controls.Add(this.LableCurPos);
            this.Controls.Add(this.NavigationLable);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonN);
            this.MaximumSize = new System.Drawing.Size(800, 565);
            this.MinimumSize = new System.Drawing.Size(777, 476);
            this.Name = "MainWindow";
            this.Text = "Maze Game";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Label NavigationLable;
        private System.Windows.Forms.Label LableCurPos;
        private System.Windows.Forms.Label CurrentPositionLable;
        private System.Windows.Forms.Label MissionTextLable;
        private System.Windows.Forms.ListBox YouHave_listBox;
        private System.Windows.Forms.ListBox theRoomContains_listbox;
        private System.Windows.Forms.Label HaveLable;
        private System.Windows.Forms.Label ContainLable;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.Button buttonPickUp;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Timer timer_timeBar;
        private System.Windows.Forms.Label lblMyTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

