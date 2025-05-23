﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_PLAYER_ADVANCED
{
    public partial class Form2 : Form
    {
        public string Artista { get; set; }
        public string Titolo { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            Artista = tbArtista.Text.Trim();
            Titolo = tbTitolo.Text.Trim();

            if (string.IsNullOrWhiteSpace(Artista) || string.IsNullOrWhiteSpace(Titolo))
            {
                MessageBox.Show("Inserisci sia l'artista che il titolo del brano.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();


        }
    }
}
