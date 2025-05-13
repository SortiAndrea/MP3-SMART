using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AxWMPLib;
using Newtonsoft.Json.Linq;

namespace MP3_PLAYER_ADVANCED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region CARICA FILE AUDIO

        private void btnCarica_Click(object sender, EventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();
            apri.Multiselect = true;
            apri.Filter = "File audio (*.mp3;*.wav)|*.mp3;*.wav";

            if (apri.ShowDialog() == DialogResult.OK)
            {
                foreach (string percorso in apri.FileNames)
                {
                    string nome = Path.GetFileName(percorso);
                    lbCanzoni.Items.Add(new Canzone { Nome = nome, Percorso = percorso });
                }
            }

            bool giàPresente = false;
            foreach (string percorso in apri.FileNames)
            {
                string nome = Path.GetFileName(percorso);
                giàPresente = false;

                foreach (Canzone item in lbCanzoni.Items)
                {
                    if (item.Percorso == percorso)
                    {
                        giàPresente = true;
                        break;
                    }
                }

                if (!giàPresente)
                {
                    lbCanzoni.Items.Add(new Canzone { Nome = nome, Percorso = percorso });
                }
            }
        }

        #endregion

        #region CARICA PLAYLIST

        private void btnCaricaPlaylist_Click_1(object sender, EventArgs e)
        {
            //OpenFileDialog apri = new OpenFileDialog();
            //apri.Filter = "File Playlist (*.m3u)|*.m3u";

            //if (apri.ShowDialog() == DialogResult.OK)
            //{
            //    string[] righe = File.ReadAllLines(apri.FileName);
            //    foreach (string riga in righe)
            //    {
            //        if (File.Exists(riga))
            //        {
            //            string nome = Path.GetFileName(riga);
            //            lbCanzoni.Items.Add(new Canzone { Nome = nome, Percorso = riga });
            //        }
            //    }
            //}

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Seleziona la cartella contenente i brani";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] fileAudio = Directory.GetFiles(fbd.SelectedPath)
                                                  .Where(f => f.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase)
                                                           || f.EndsWith(".wav", StringComparison.OrdinalIgnoreCase))
                                                  .ToArray();

                    lbCanzoni.Items.Clear();

                    foreach (string path in fileAudio)
                    {
                        Canzone c = new Canzone
                        {
                            Nome = Path.GetFileNameWithoutExtension(path),
                            Percorso = path
                        };

                        lbCanzoni.Items.Add(c);
                    }

                    if (lbCanzoni.Items.Count == 0)
                    {
                        MessageBox.Show("Nessun file audio trovato nella cartella selezionata.");
                    }
                }
            }
        }

        #endregion

        //----------------------------------------------------------------------------------------------------------

        #region ELIMINA FILE AUDIO

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lbCanzoni.SelectedItem != null)
            {
                lbCanzoni.Items.Remove(lbCanzoni.SelectedItem);

                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = string.Empty; // Ferma la riproduzione

                lbLyrics.Items.Clear(); // Pulisce la lista dei testi

                MessageBox.Show("Canzone rimossa dalla playlist.", "MP3-SMART");
            }
            else
            {
                MessageBox.Show("Seleziona una canzone da rimuovere.", "MP3-SMART");
            }
        }

        #endregion

        //----------------------------------------------------------------------------------------------------------

        #region SALVA PLAYLIST

        private void btnSalva_Click(object sender, EventArgs e)
        {
            //SaveFileDialog salva = new SaveFileDialog();
            //salva.Filter = "File Playlist (*.m3u)|*.m3u";
            //if (salva.ShowDialog() == DialogResult.OK)
            //{
            //    using (StreamWriter writer = new StreamWriter(salva.FileName))
            //    {
            //        foreach (Canzone c in lbCanzoni.Items)
            //        {
            //            writer.WriteLine($"{c.Nome}|{c.Percorso}");
            //        }
            //    }
            //    MessageBox.Show("Playlist salvata con successo.");
            //}

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Scegli la cartella dove salvare la playlist";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string cartellaDestinazione = fbd.SelectedPath;

                    foreach (Canzone c in lbCanzoni.Items)
                    {
                        try
                        {
                            string fileDestinazione = Path.Combine(cartellaDestinazione, Path.GetFileName(c.Percorso));
                            File.Copy(c.Percorso, fileDestinazione, true); // sovrascrive se esiste
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore nel copiare il file: " + ex.Message);
                        }
                    }

                    MessageBox.Show("Playlist salvata nella cartella:\n" + cartellaDestinazione);
                }
            }
        }

        #endregion

        //----------------------------------------------------------------------------------------------------------

        private void lbCanzoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCanzoni.SelectedItem is Canzone canzone)
            {
                axWindowsMediaPlayer1.URL = canzone.Percorso;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                // Prova a ottenere artista e titolo
                string fileName = Path.GetFileNameWithoutExtension(canzone.Nome);
                string[] parts = fileName.Split('-');

                if (parts.Length >= 2)
                {
                    string artista = parts[0].Trim();
                    string titolo = parts[1].Trim();

                     CaricaLyricsAsync(artista, titolo);
                }
                else
                {
                    Form2 inputForm = new Form2();
                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                         CaricaLyricsAsync(inputForm.Artista, inputForm.Titolo);
                    }
                    else
                    {
                        lbLyrics.Items.Clear();
                        lbLyrics.Items.Add("Testo non disponibile (inserimento annullato).");
                    }

                }
            }
        }

        private async void CaricaLyricsAsync(string artista, string titolo)
        {
            lbLyrics.Items.Clear();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://api.lyrics.ovh/v1/{Uri.EscapeDataString(artista)}/{Uri.EscapeDataString(titolo)}";

                    string response = await client.GetStringAsync(url);
                    JObject json = JObject.Parse(response);

                    if (json["lyrics"] != null)
                    {
                        string testo = json["lyrics"].ToString();
                        string[] righe = testo.Split('\n');
                        foreach (string riga in righe)
                        {
                            lbLyrics.Items.Add(riga.Trim());
                        }
                    }
                    else
                    {
                        lbLyrics.Items.Add("Testo non trovato.");
                    }
                }
                catch
                {
                    lbLyrics.Items.Add("Errore nel recupero dei testi.");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult risultato = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (risultato == DialogResult.Yes)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = string.Empty; // Ferma la riproduzione

                lbLyrics.Items.Clear(); // Pulisce la lista dei testi
            }
            if (risultato == DialogResult.No)
            {
                e.Cancel = true; // annulla la chiusura
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Grazie per aver usato il mio programma!", "MP3-SMART");
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void btnApriForm2_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //if (form2.ShowDialog() == DialogResult.OK)
            //{
            //    string artista = form2.ArtistaInserito;
            //    string titolo = form2.TitoloInserito;

            //    // Puoi usarli come preferisci, per esempio:
            //    await CaricaLyricsAsync(artista, titolo);

            //    // Oppure aggiungerli alla playlist:
            //    Canzone nuova = new Canzone
            //    {
            //        Nome = $"{artista} - {titolo}",
            //        Percorso = "" // se non c'è un file associato
            //    };
            //    lbLyrics.Items.Add(nuova);
            //}

            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                string artista = form2.Artista;
                string titolo = form2.Titolo;

                // ✅ Qui richiami direttamente l’API per caricare i lyrics
                CaricaLyricsAsync(artista, titolo);
            }
        }
    }
}
