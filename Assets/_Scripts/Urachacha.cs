﻿using UnityEngine;

namespace Photon.Pun.Urachacha
{
    public class Urachacha
    {
        public const string PLAYER_READY = "IsPlayerReady";
        public const string PLAYER_LOADED_LEVEL = "PlayerLoadedLevel";

        public const string FIRST_ROUND_MISSION = "목표지점에 먼저 도달해라";

        public static Color GetColor(int colorChoice)
        {
            switch (colorChoice)
            {
                case 0: return Color.red;
                case 1: return Color.green;
                case 2: return Color.blue;
                case 3: return Color.yellow;
                case 4: return Color.cyan;
                case 5: return Color.grey;
                case 6: return Color.magenta;
                case 7: return Color.white;
            }

            return Color.black;
        }
    }
}