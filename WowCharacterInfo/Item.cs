﻿using System.Collections.Generic;

namespace WowCharacterInfo
{
    public class Item
    {
        #pragma warning disable 0649
        public int id;
        public string name;
        public string icon;
        public int quality;
        public TooltipParams tooltipParams;
        #pragma warning disable 0649
    }

    public class TooltipParams
    {
        public int gem0;
        public int gem1;
        public int enchant;
        public List<int> set;
        public int reforge;
        public bool extraSocket;
    }
}
