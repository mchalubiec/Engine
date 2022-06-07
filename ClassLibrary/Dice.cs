using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Dice
    {
        private static Dice dice;
        public static Dice GetInstance()
        {
            if (dice == null)
            {
                dice = new Dice();
            }
            return dice;
        }
        Random random;
        private Dice()
        {
            random = new Random();
        }
        public int RollK6()
        {
            return random.Next(1, 7);
        }
    }
}
