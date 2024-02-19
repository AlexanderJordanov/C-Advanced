using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            Players = new List<Player>();
        }
        public List<Player> Players; 
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }

        public int Count { get { return Players.Count; } }
        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            Players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }
        public bool RemovePlayer(string name)
        {
            Player playerToRemove = Players.FirstOrDefault(p => p.Name == name);
            if (playerToRemove != null)
            {                
                Players.Remove(playerToRemove);
                OpenPositions++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemovePlayerByPosition(string position)
        {
            List<Player> removedPlayers = new List<Player>();
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Position == position)
                {
                    removedPlayers.Add(Players[i]);
                    Players.Remove(Players[i]);
                    OpenPositions++;
                    i--;
                }
            }
            if (removedPlayers.Count > 0)
            {
                return removedPlayers.Count;
            }
            else
            {
                return 0;
            }
        }
        public Player RetirePlayer(string name)
        {
            Player playerToRetire = Players.FirstOrDefault(p => p.Name == name);
            if (playerToRetire != null)
            {
                playerToRetire.Retired = true;
                return playerToRetire;
            }
            else
            {
                return null;
            }
        }
        public List<Player> AwardPlayers(int games)
        {
            List<Player> playerList = new List<Player>();
            foreach (Player player in Players)
            {
                if (player.Games >= games)
                {
                    playerList.Add(player);
                }
            }
            return playerList;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}");
            foreach (Player player in Players)
            {
                if (player.Retired == false)
                {
                    sb.AppendLine(player.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
