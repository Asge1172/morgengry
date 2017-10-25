using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgenry
{

    public enum Level
    {
        low,
        medium,
        high
    };
   public class Amulet
    { //Property
        public string ItemId { get; set; }

        public string Design { get; set; }

        public Level Quality { get; set; }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }


        public Amulet(string itemId) :
            this (itemId, Level.medium, "")
        {
        }

        public Amulet (string itemId, Level quality) :
            this (itemId, quality, "")
        {
        }

        public Amulet () :
            this ("", Level.medium, "")
        {
        }

        public override string ToString() { return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design; }
    }
}
