using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSC240_ProjectTicTacToe_LDM
{
    /// <summary>
    /// Manages player data, scores, and leaderboard persistence
    /// </summary>
    public class PlayerStats
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public PlayerStats(string name)
        {
            Name = name;
            Wins = 0;
            Losses = 0;
        }

        public override string ToString()
        {
            return $"{Name},{Wins},{Losses}";
        }

        public static PlayerStats FromString(string data)
        {
            var parts = data.Split(',');
            if (parts.Length >= 3)
            {
                return new PlayerStats(parts[0])
                {
                    Wins = int.TryParse(parts[1], out int w) ? w : 0,
                    Losses = int.TryParse(parts[2], out int l) ? l : 0
                };
            }
            return new PlayerStats(parts[0]);
        }
    }

    /// <summary>
    /// Static class to manage game state across forms
    /// </summary>
    public static class GameData
    {
        // Current game settings
        public static bool IsCPUMode { get; set; } = false;
        public static string Player1Name { get; set; } = "Player 1";
        public static string Player2Name { get; set; } = "Player 2";
        public static string CurrentStartingPlayer { get; set; } = "O"; // O = Player 1

        // Current session stats
        public static PlayerStats Player1Stats { get; set; } = new PlayerStats("Player 1");
        public static PlayerStats Player2Stats { get; set; } = new PlayerStats("Player 2");
        public static PlayerStats CPUStats { get; set; } = new PlayerStats("CPU");

        // Leaderboard
        private static List<PlayerStats> leaderboard = new List<PlayerStats>();
        private static string leaderboardPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "leaderboard.txt");

        /// <summary>
        /// Load leaderboard from file
        /// </summary>
        public static void LoadLeaderboard()
        {
            leaderboard.Clear();
            if (File.Exists(leaderboardPath))
            {
                try
                {
                    var lines = File.ReadAllLines(leaderboardPath);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            leaderboard.Add(PlayerStats.FromString(line));
                        }
                    }
                }
                catch
                {
                    // If file is corrupted, start fresh
                    leaderboard.Clear();
                }
            }
        }

        /// <summary>
        /// Save leaderboard to file
        /// </summary>
        public static void SaveLeaderboard()
        {
            try
            {
                var lines = leaderboard.Select(p => p.ToString()).ToArray();
                File.WriteAllLines(leaderboardPath, lines);
            }
            catch
            {
                // Silently fail if can't save
            }
        }

        /// <summary>
        /// Update leaderboard with player stats
        /// </summary>
        public static void UpdateLeaderboard(PlayerStats player)
        {
            if (player.Name == "CPU") return; // Don't add CPU to leaderboard

            var existing = leaderboard.FirstOrDefault(p => p.Name.Equals(player.Name, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                existing.Wins = player.Wins;
                existing.Losses = player.Losses;
            }
            else
            {
                leaderboard.Add(new PlayerStats(player.Name) { Wins = player.Wins, Losses = player.Losses });
            }

            // Sort by wins descending
            leaderboard = leaderboard.OrderByDescending(p => p.Wins).ThenBy(p => p.Losses).ToList();
            SaveLeaderboard();
        }

        /// <summary>
        /// Get sorted leaderboard
        /// </summary>
        public static List<PlayerStats> GetLeaderboard()
        {
            return leaderboard.OrderByDescending(p => p.Wins).ThenBy(p => p.Losses).ToList();
        }

        /// <summary>
        /// Reset current session (but keep leaderboard)
        /// </summary>
        public static void ResetSession()
        {
            Player1Stats = new PlayerStats(Player1Name);
            Player2Stats = new PlayerStats(Player2Name);
            CPUStats = new PlayerStats("CPU");
        }

        /// <summary>
        /// Initialize game data
        /// </summary>
        public static void Initialize()
        {
            LoadLeaderboard();
        }
    }
}
