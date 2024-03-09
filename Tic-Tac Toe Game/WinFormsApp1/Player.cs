using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    internal class Player
    {
        private char choice;

        public Player() {
            this.choice = ' ';
        }
        public Player(char choice)
        {
            this.choice = choice;
        }

        public char Choice { get => choice; set => choice = value; }
    }
}
