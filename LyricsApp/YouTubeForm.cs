using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsApp
{
    public partial class YouTubeForm : Form
    {
        public YouTubeForm()
        {
            InitializeComponent();
        }

        public YouTubeForm(List<string>songInfo)
        {
            InitializeComponent();
            tbTitle.Text = songInfo[0].ToString();
            tbDuration.Text = songInfo[1].ToString();
            tbUrl.Text = songInfo[2].ToString();
            pbArtist.ImageLocation = songInfo[3].ToString();

        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUrl.Text))
            {
                MessageBox.Show("URL is empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start(tbUrl.Text);
        }
    }
}
