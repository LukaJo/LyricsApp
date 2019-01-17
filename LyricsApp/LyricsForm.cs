﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using YoutubeSearch;

namespace LyricsApp
{
    public partial class LyricsForm : Form
    {
        public LyricsForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tbLyrics.Clear();

            if (string.IsNullOrEmpty(tbArtist.Text) || string.IsNullOrEmpty(tbSong.Text))
            {
                MessageBox.Show("Please enter artist and title!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string url = "https://api.lyrics.ovh/v1/" + tbArtist.Text + "/" + tbSong.Text;



            using (WebClient wc = new WebClient() { Encoding = Encoding.UTF8 })
            {
                try
                {
                    var json = wc.DownloadString(url).Replace("\\n", Environment.NewLine).ToLower();

                    var result = JsonConvert.DeserializeObject<Lyrics>(json);

                    tbLyrics.Text = result.lyrics;
                }
                catch (Exception)
                {
                    if (MessageBox.Show("No lyrics found!Do you want to listen song on YouTube?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) !=
              DialogResult.Yes)
                        return;

                    string url1 = TrailerUrl();
                    System.Diagnostics.Process.Start(url1);

                }

            }
        }

        private void linkSong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbArtist.Text) || string.IsNullOrEmpty(tbSong.Text))
            {
                MessageBox.Show("Please enter artist and title!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string url = TrailerUrl();
            System.Diagnostics.Process.Start(url);
        }

        private string TrailerUrl()
        {
            string querystring = tbArtist.Text + "" + tbSong.Text;

            int querypages = 1;

            List<string> trailer = new List<string>();

            var items = new VideoSearch();

            foreach (var item in items.SearchQuery(querystring, querypages))
            {
                trailer.Add(item.Url);
                if (trailer.Count == 1)
                {
                    break;
                }

            }

            string url = trailer[0].ToString();
            return url;

        }

        public static string PreslovljavanjeCirilica(string latinica)
        {
            //uppercase
            latinica = latinica.Replace("LJ", "Љ");
            latinica = latinica.Replace("NJ", "Њ");
            latinica = latinica.Replace("DŽ", "Џ");
            latinica = latinica.Replace("DJ", "Ђ");
            latinica = latinica.Replace("Đ", "Ђ");
            latinica = latinica.Replace("Lj", "Љ");
            latinica = latinica.Replace("Nj", "Њ");
            latinica = latinica.Replace("Dž", "Џ");
            latinica = latinica.Replace("Dj", "Ђ");
            latinica = latinica.Replace("A", "А");
            latinica = latinica.Replace("B", "Б");
            latinica = latinica.Replace("V", "В");
            latinica = latinica.Replace("G", "Г");
            latinica = latinica.Replace("D", "Д");
            latinica = latinica.Replace("E", "Е");
            latinica = latinica.Replace("Ž", "Ж");
            latinica = latinica.Replace("Z", "З");
            latinica = latinica.Replace("I", "И");
            latinica = latinica.Replace("J", "Ј");
            latinica = latinica.Replace("K", "К");
            latinica = latinica.Replace("L", "Л");
            latinica = latinica.Replace("M", "М");
            latinica = latinica.Replace("N", "Н");
            latinica = latinica.Replace("O", "О");
            latinica = latinica.Replace("P", "П");
            latinica = latinica.Replace("R", "Р");
            latinica = latinica.Replace("S", "С");
            latinica = latinica.Replace("T", "Т");
            latinica = latinica.Replace("Ć", "Ћ");
            latinica = latinica.Replace("U", "У");
            latinica = latinica.Replace("F", "Ф");
            latinica = latinica.Replace("H", "Х");
            latinica = latinica.Replace("C", "Ц");
            latinica = latinica.Replace("Č", "Ч");
            latinica = latinica.Replace("Š", "Ш");

            //lowercase
            latinica = latinica.Replace("lj", "љ");
            latinica = latinica.Replace("nj", "њ");
            latinica = latinica.Replace("dž", "џ");
            latinica = latinica.Replace("dj", "ђ");
            latinica = latinica.Replace("đ", "ђ");
            latinica = latinica.Replace("a", "а");
            latinica = latinica.Replace("b", "б");
            latinica = latinica.Replace("v", "в");
            latinica = latinica.Replace("g", "г");
            latinica = latinica.Replace("d", "д");
            latinica = latinica.Replace("e", "е");
            latinica = latinica.Replace("ž", "ж");
            latinica = latinica.Replace("z", "з");
            latinica = latinica.Replace("i", "и");
            latinica = latinica.Replace("j", "ј");
            latinica = latinica.Replace("k", "к");
            latinica = latinica.Replace("l", "л");
            latinica = latinica.Replace("m", "м");
            latinica = latinica.Replace("n", "н");
            latinica = latinica.Replace("o", "о");
            latinica = latinica.Replace("p", "п");
            latinica = latinica.Replace("r", "р");
            latinica = latinica.Replace("s", "с");
            latinica = latinica.Replace("t", "т");
            latinica = latinica.Replace("ć", "ћ");
            latinica = latinica.Replace("u", "у");
            latinica = latinica.Replace("f", "ф");
            latinica = latinica.Replace("h", "х");
            latinica = latinica.Replace("c", "ц");
            latinica = latinica.Replace("č", "ч");
            latinica = latinica.Replace("š", "ш");

            return latinica;
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLyrics.Text))
            {
                MessageBox.Show("There are no lyrics!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Clipboard.Clear();          
            Clipboard.SetText(tbLyrics.Text); 
            string strClip = Clipboard.GetText();         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbArtist.Text = tbSong.Text = tbLyrics.Text = string.Empty;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tbLyrics.Text, new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Black, new System.Drawing.PointF(100, 100));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLyrics.Text))
            {
                MessageBox.Show("There are no lyrics!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLyrics.Text))
            {
                MessageBox.Show("There are no lyrics!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Artist: ");
            sb.Append(tbArtist.Text);
            sb.Append(" ");
            sb.Append("Song: ");
            sb.Append(tbSong.Text);
            sb.Append(" ");
            sb.Append("Lyrics: ");
            sb.Append(tbLyrics.Text);

            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=yourphonehere&text=" + sb.ToString());
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            var cir = PreslovljavanjeCirilica(tbLyrics.Text);
            tbLyrics.Clear();
            tbLyrics.Text = cir;
        }
    }
}
