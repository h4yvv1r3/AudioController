using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAudioController
{
    public partial class ConfirmPlaylistDelete : Form
    {
        MainForm parent;

        public ConfirmPlaylistDelete(MainForm parentForm)
        {
            InitializeComponent();

            parent = parentForm;

            labelMessage.Text = $"Remove playlist named {MainForm.currentPlaylistName}?";

            if (MainForm.currentPreference.Playlists.Count <= 1)
            {
                this.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MainForm.currentPreference.Playlists.Remove(MainForm.currentPlaylistName);

            //var nextPlaylistPair = MainForm.currentPreference.Playlists.FirstOrDefault();

            //MainForm.currentPlaylist = nextPlaylistPair.Value;
            //MainForm.currentPlaylistName = nextPlaylistPair.Key;

            parent.RefreshPlaylists();

            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmPlaylistDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.buttonState.EnableAllButtons();
        }
    }
}
