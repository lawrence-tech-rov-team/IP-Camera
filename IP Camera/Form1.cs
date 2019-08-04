using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;

namespace IP_Camera {
	public partial class Form1 : Form {

		UriBuilder deviceUri;
		Media.Ver10.MediaClient media;
		Media.Ver10.Profile[] profiles;

		//TODO media 20;
		//Media.Ver20.Media2Client media;
		//Media.Ver20.MediaProfile[] profiles;

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			CameraTimer.Start();
			//webBrowser1.Navigate("http://192.168.0.101/cgi-bin/hi3510/snap.cgi?&-getstream&-chn=1");
			//Process.Start("chrome.exe", "http://www.YourUrl.com");
		}

		private void ConnectBtn_Click(object sender, EventArgs e) {
			ProfilesListBox.Items.Clear();
			InfoLabel.Text = "";

			deviceUri = new UriBuilder("http:/onvif/device_service");
			string[] addr = IpAdressTextBox.Text.Split(':');
			deviceUri.Host = addr[0];
			if (addr.Length == 2)
				deviceUri.Port = Convert.ToInt16(addr[1]);

			System.ServiceModel.Channels.Binding binding;
			HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
			httpTransport.AuthenticationScheme = System.Net.AuthenticationSchemes.Digest;
			binding = new CustomBinding(new TextMessageEncodingBindingElement(MessageVersion.Soap12WSAddressing10, Encoding.UTF8), httpTransport);


			Device.DeviceClient device = new Device.DeviceClient(binding, new EndpointAddress(deviceUri.ToString()));
			Device.Service[] services = device.GetServices(false);

			//TODO media 20
			//Device.Service xmedia = services.FirstOrDefault(s => s.Namespace == "http://www.onvif.org/ver20/media/wsdl");
			Device.Service xmedia = services.FirstOrDefault(s => s.Namespace == "http://www.onvif.org/ver10/media/wsdl");
			if (xmedia != null) {
				//TODO media 20
				//media = new Media.Ver20.Media2Client(binding, new EndpointAddress(deviceUri.ToString()));
				media = new Media.Ver10.MediaClient(binding, new EndpointAddress(deviceUri.ToString()));
				media.ClientCredentials.HttpDigest.ClientCredential.UserName = UsernameTextBox.Text;
				media.ClientCredentials.HttpDigest.ClientCredential.Password = PasswordTextBox.Text;
				media.ClientCredentials.HttpDigest.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

				//TODO media 20
				//profiles = media.GetProfiles(null, null);
				profiles = media.GetProfiles();
				if (profiles != null)
					foreach (var p in profiles)
						ProfilesListBox.Items.Add(p.Name);
			} else {
				MessageBox.Show("No media was found.");
			}

			VideoPlayer.EndInit();
		}

		private void VideoPlayer_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e) {
			if(IntPtr.Size == 4) {
				e.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC"); //The folder where VLC is installed
			}
		}

		private void ProfilesListBox_SelectedIndexChanged(object sender, EventArgs e) {
			if(profiles != null && ProfilesListBox.SelectedIndex > 0) {
				//TODO media 20
				//UriBuilder uri = new UriBuilder(media.GetStreamUri("RtspOverHttp", profiles[ProfilesListBox.SelectedIndex].token));
				//Media.Ver10.Transport tunnel = new Media.Ver10.Transport();
				//tunnel.Protocol = Media.Ver10.TransportProtocol.HTTP;

				Media.Ver10.Transport transport = new Media.Ver10.Transport();
				transport.Protocol = Media.Ver10.TransportProtocol.RTSP;
				//transport.Tunnel = tunnel;

				Media.Ver10.StreamSetup streamSetup = new Media.Ver10.StreamSetup();
				streamSetup.Transport = transport;

				UriBuilder uri = new UriBuilder(media.GetStreamUri(streamSetup, profiles[ProfilesListBox.SelectedIndex].token).Uri);
				uri.Host = deviceUri.Host;
				uri.Port = deviceUri.Port;
				uri.Scheme = "rtsp";
				InfoLabel.Text = uri.Path;

				string[] options = { ":rtsp-http", ":rtsp-http-port=" + uri.Port, ":rtsp-user=" + UsernameTextBox.Text, ":rtsp-pwd=" + PasswordTextBox.Text, };

				VideoPlayer.VlcMediaPlayer.Play(uri.Uri, options);
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			//string[] options = { ":rtsp-http", ":rtsp-http-port=" + uri.Port, ":rtsp-user=" + UsernameTextBox.Text, ":rtsp-pwd=" + PasswordTextBox.Text, };
			//VideoPlayer.VlcMediaPlayer.Play(new Uri("rtsp://192.168.0.100/11"), options);
			VideoPlayer.VlcMediaPlayer.Play(new Uri("rtsp://192.168.0.100/11"));
			//VideoPlayer.VlcMediaPlayer.Play(new Uri("http://192.168.0.100/cgi-bin/hi3510/snap.cgi?&-getstream&-chn=1"));
		}
	}

}
