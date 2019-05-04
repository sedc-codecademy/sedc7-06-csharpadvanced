using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WorldCup
{
    public partial class WorldCupForm : Form
    {
        private string selectedTeam;

        public WorldCupForm()
        {
            InitializeComponent();
        }

        private void WorldCupForm_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string teamsString = wc.DownloadString("https://us-central1-sedc-world-cup.cloudfunctions.net/webApi/team-list");
            var teams = JsonConvert.DeserializeObject<string[]>(teamsString);
            cbxTeams.DataSource = teams;
        }

        private async void cbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = cbxTeams.SelectedItem as string;
            lblSelectedTeam.Text = $"You selected {selectedTeam}";
            WebClient wc = new WebClient();
            Uri uri = new Uri($"https://us-central1-sedc-world-cup.cloudfunctions.net/webApi/team/{selectedTeam}");

            string teamString = await wc.DownloadStringTaskAsync(uri);
            var team = JsonConvert.DeserializeObject<Team>(teamString);

            var badgeImageTask = new WebClient().DownloadDataTaskAsync(team.BadgeImageUrl);
            var teamImageTask = new WebClient().DownloadDataTaskAsync(team.TeamImageUrl);

            var results = await Task.WhenAll(badgeImageTask, teamImageTask);

            using (var ms = new MemoryStream(results[0]))
            {
                pboxBadge.Image = Image.FromStream(ms);
            }

            using (var ms = new MemoryStream(results[1]))
            {
                pboxTeam.Image = Image.FromStream(ms);
            }

            foreach (var player in team.Players)
            {
                if (string.IsNullOrEmpty(player.ImageUrl))
                {
                    continue;
                }
                var playerImage = await wc.DownloadDataTaskAsync(player.ImageUrl);
                using (var ms = new MemoryStream(playerImage))
                {
                    pboxPlayer.Image = Image.FromStream(ms);
                }
            }
            //wc.DownloadStringAsync(uri);
            //wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
        }

        //private async void cbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    selectedTeam = cbxTeams.SelectedItem as string;
        //    lblSelectedTeam.Text = $"You selected {selectedTeam}";
        //    WebClient wc = new WebClient();
        //    Uri uri = new Uri($"https://us-central1-sedc-world-cup.cloudfunctions.net/webApi/team/{selectedTeam}");

        //    string teamString = await wc.DownloadStringTaskAsync(uri);
        //    var team = JsonConvert.DeserializeObject<Team>(teamString);

        //    var badgeImage = await wc.DownloadDataTaskAsync(team.BadgeImageUrl);
        //    using (var ms = new MemoryStream(badgeImage))
        //    {
        //        pboxBadge.Image = Image.FromStream(ms);
        //    }

        //    var teamImage = await wc.DownloadDataTaskAsync(team.TeamImageUrl);
        //    using (var ms = new MemoryStream(teamImage))
        //    {
        //        pboxTeam.Image = Image.FromStream(ms);
        //    }

        //    foreach (var player in team.Players)
        //    {
        //        if (string.IsNullOrEmpty(player.ImageUrl))
        //        {
        //            continue;
        //        }
        //        var playerImage = await wc.DownloadDataTaskAsync(player.ImageUrl);
        //        using (var ms = new MemoryStream(playerImage))
        //        {
        //            pboxPlayer.Image = Image.FromStream(ms);
        //        }
        //    }
        //    //wc.DownloadStringAsync(uri);
        //    //wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
        //}

        //private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        //{
        //    var result = JsonConvert.DeserializeObject<Team>(e.Result);
        //    WebClient wc = new WebClient();
        //    Uri uri = new Uri(result.BadgeImageUrl);
        //    wc.DownloadDataAsync(uri);
        //    wc.DownloadDataCompleted += Wc_DownloadDataCompleted;
        //    uri = new Uri(result.TeamImageUrl);
        //    WebClient wc2 = new WebClient();
        //    wc2.DownloadDataAsync(uri);
        //    wc2.DownloadDataCompleted += Wc_DownloadDataCompleted1;
        //}

        //private void Wc_DownloadDataCompleted1(object sender, DownloadDataCompletedEventArgs e)
        //{
        //    using (var ms = new MemoryStream(e.Result))
        //    {
        //        pboxTeam.Image = Image.FromStream(ms);
        //    }
        //}

        //private void Wc_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        //{
        //    using (var ms = new MemoryStream(e.Result))
        //    {
        //        pboxBadge.Image = Image.FromStream(ms);
        //    }
        //}
    }
}
