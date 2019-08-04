namespace IP_Camera {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ConnectBtn = new System.Windows.Forms.Button();
			this.CameraTimer = new System.Windows.Forms.Timer(this.components);
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.ProfilesListBox = new System.Windows.Forms.ListBox();
			this.IpAdressTextBox = new System.Windows.Forms.TextBox();
			this.InfoLabel = new System.Windows.Forms.Label();
			this.VideoPlayer = new Vlc.DotNet.Forms.VlcControl();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// ConnectBtn
			// 
			this.ConnectBtn.Location = new System.Drawing.Point(12, 12);
			this.ConnectBtn.Name = "ConnectBtn";
			this.ConnectBtn.Size = new System.Drawing.Size(86, 31);
			this.ConnectBtn.TabIndex = 1;
			this.ConnectBtn.Text = "Connect";
			this.ConnectBtn.UseVisualStyleBackColor = true;
			this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
			// 
			// CameraTimer
			// 
			this.CameraTimer.Interval = 1000;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Location = new System.Drawing.Point(210, 21);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(100, 22);
			this.UsernameTextBox.TabIndex = 2;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(210, 49);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(100, 22);
			this.PasswordTextBox.TabIndex = 3;
			// 
			// ProfilesListBox
			// 
			this.ProfilesListBox.FormattingEnabled = true;
			this.ProfilesListBox.ItemHeight = 16;
			this.ProfilesListBox.Location = new System.Drawing.Point(12, 49);
			this.ProfilesListBox.Name = "ProfilesListBox";
			this.ProfilesListBox.Size = new System.Drawing.Size(142, 260);
			this.ProfilesListBox.TabIndex = 4;
			this.ProfilesListBox.SelectedIndexChanged += new System.EventHandler(this.ProfilesListBox_SelectedIndexChanged);
			// 
			// IpAdressTextBox
			// 
			this.IpAdressTextBox.Location = new System.Drawing.Point(104, 21);
			this.IpAdressTextBox.Name = "IpAdressTextBox";
			this.IpAdressTextBox.Size = new System.Drawing.Size(100, 22);
			this.IpAdressTextBox.TabIndex = 5;
			// 
			// InfoLabel
			// 
			this.InfoLabel.AutoSize = true;
			this.InfoLabel.Location = new System.Drawing.Point(12, 316);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new System.Drawing.Size(31, 17);
			this.InfoLabel.TabIndex = 6;
			this.InfoLabel.Text = "info";
			// 
			// VideoPlayer
			// 
			this.VideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VideoPlayer.BackColor = System.Drawing.Color.Black;
			this.VideoPlayer.Location = new System.Drawing.Point(316, 20);
			this.VideoPlayer.Name = "VideoPlayer";
			this.VideoPlayer.Size = new System.Drawing.Size(643, 418);
			this.VideoPlayer.Spu = -1;
			this.VideoPlayer.TabIndex = 7;
			this.VideoPlayer.Text = "vlcControl1";
			this.VideoPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("VideoPlayer.VlcLibDirectory")));
			this.VideoPlayer.VlcMediaplayerOptions = null;
			this.VideoPlayer.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VideoPlayer_VlcLibDirectoryNeeded);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(226, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(971, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.VideoPlayer);
			this.Controls.Add(this.InfoLabel);
			this.Controls.Add(this.IpAdressTextBox);
			this.Controls.Add(this.ProfilesListBox);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.ConnectBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button ConnectBtn;
		private System.Windows.Forms.Timer CameraTimer;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.ListBox ProfilesListBox;
		private System.Windows.Forms.TextBox IpAdressTextBox;
		private System.Windows.Forms.Label InfoLabel;
		private Vlc.DotNet.Forms.VlcControl VideoPlayer;
		private System.Windows.Forms.Button button1;
	}
}

