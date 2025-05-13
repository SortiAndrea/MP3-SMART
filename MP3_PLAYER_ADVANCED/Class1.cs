using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_PLAYER_ADVANCED
{
    public class Canzone
    {
        public string Nome { get; set; }
        public string Percorso { get; set; }

        public override string ToString()
        {
            return Nome; // Mostra solo il nome nella ListBox
        }
    }
}
