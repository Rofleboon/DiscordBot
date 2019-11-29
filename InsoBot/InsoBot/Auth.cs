using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;
using RestSharp;
using RestSharp.Authenticators;

namespace InsoBot
{
    public partial class Auth : Form
    {


        public Auth()
        {
            InitializeComponent();
        }

        public static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }



        private DiscordSocketClient _client;
        private string authLink = "https://discordapp.com/api/oauth2/authorize?client_id=649900073286631434&redirect_uri=https%3A%2F%2Fdepleto.com%2Fredirect%2F&response_type=code&scope=webhook.incoming%20messages.read";



        public async Task Test ()
        {
            _client = new DiscordSocketClient();
            await _client.LoginAsync(TokenType.Webhook, "577fctqeaG31QU3OFluR9SB2LNKRhsEP");
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private void linkDiscordAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(authLink);
        }

        private void btnDiscordAuth_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://discordapp.com/api/oauth2/token");
            var request = new RestRequest(Method.POST);
            request.AddParameter("grant_type", "client_credentials");
            request.AddHeader("Connection", "keep-alive");    
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            client.Authenticator = new HttpBasicAuthenticator("649900073286631434", "577fctqeaG31QU3OFluR9SB2LNKRhsEP");
            IRestResponse response = client.Execute(request);
        }
    }
}
