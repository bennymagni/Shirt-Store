using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TShirtApp
{
    internal class ClothSelected
    {
        
        private string size;
        private int amount;

        //Default Constructor
        public ClothSelected()
        {

        }

        //Second Constructor
        public ClothSelected(string itemSize, int number)
        {
            size = itemSize;
            amount = number;
        }

        //Properties
        public string Size
        {
            get 
            {
                return size; 
            }
            set
            {
                size = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public double TotalCost(int numberOfPieces, int itemId)
        {
            double cost;

            int[] clothPrices = new int[6] { 40, 75, 30, 60, 80, 55 };

            cost = numberOfPieces * clothPrices[itemId];

            return cost;
        }
    }
}
