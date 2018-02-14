using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    // For making items to pick up.
    public class HoldableItem
    {
        public string ItemName { get; set; }
        public double ItemWeight { get; set; }

        public HoldableItem(string itemName, double itemWeight)
        {
            ItemName = itemName;
            ItemWeight = itemWeight;
        }

    }
}
