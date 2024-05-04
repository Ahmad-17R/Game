using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.BL
{
    public class Factorypattern
    {
        private int Enemies;
        private int Players;

        public static int GetPlayers()
        {
            return Players;
        }

        public static int GetEnemies()
        {
            return Enemies;
        }

        public static void SetPlayers(int players)
        {
            this.Players = players;
        }

        public static void SetEnemies(int enemies)
        {
            this.Enemies = enemies;
        }
    }
}
