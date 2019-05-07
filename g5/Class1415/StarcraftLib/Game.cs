using StarcraftLib.Responses;
using StarcraftLib.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarcraftLib
{
    public class Game
    {
        public const int MaxPlayers = 8;

        public GameType Type
        {
            get
            {
                return GameType.Melee;
            }
        }

        public string MapName { get; set; }

        private List<Player> players = new List<Player>();
        public IEnumerable<Player> Players
        {
            get
            {
                return players.AsReadOnly();
            }
        }

        public bool IsStarted { get; private set; } = false;

        public StartGameResponse StartGame()
        {
            var validation = ValidateGame();
            if (validation.Success)
            {
                IsStarted = true;
                foreach (var player in players)
                {
                    // add starting units to player
                    var worker = UnitFactory.CreateWorker(player.Race);
                    player.Units.Add(worker);
                }
            }
            return validation;
        }

        public bool AddPlayer(Player player)
        {
            if (players.Count == 8)
            {
                return false;
            }
            players.Add(player);
            return true;
        }

        public bool AddPlayer(string name, Race? race = null)
        {
            if (players.Count == 8)
            {
                return false;
            }

            var player = new Player { Name = name };

            var colors = Enum.GetValues(typeof(Color)).OfType<Color>();
            var playerColors = players.Select(p => p.Color);
            player.Color = colors.First(color => !playerColors.Contains(color));
            if (race == null)
            {
                Random r = new Random();
                race = (Race)r.Next(3);
            }
            player.Race = race.Value;
            players.Add(player);
            return true;
        }

        private StartGameResponse ValidateGame()
        {
            if (string.IsNullOrEmpty(MapName))
            {
                return StartGameResponse.Error("Map not selected");
            }
            if (players.Count <= 1)
            {
                return StartGameResponse.Error("Not enough players");
            }
            var colors = players.Select(p => p.Color).Distinct();
            if (colors.Count() != players.Count)
            {
                return StartGameResponse.Error("Clashing player colors");
            }
            return StartGameResponse.Ok();
        }
    }
}
