using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DJ3
{
    public partial class PickVoice : Form
    {
        private MainForm mainForm { get; set; }

        private Button targetButton { get; set; }

        private int targetSlot { get; set; }

        private WaveOutEvent audioOut { get; set; }
        private AudioFileReader afr { get; set; }

        public PickVoice(Button voiceButton, int voiceSlot, MainForm parent)
        {
            InitializeComponent();

            mainForm = parent;
            targetButton = voiceButton;
            targetSlot = voiceSlot;

            buttonSetVoice.Enabled = false;

            buttonSetVoice.Text = $"Set To Slot {targetSlot + 1}";

            LoadFiles(MainForm.recordedAudioFolder);
        }

        private void LoadFiles(string outputFolder)
        {
            List<string> files = Directory.GetFiles(outputFolder).Select(x => { return x.Substring(x.LastIndexOf('\\') + 1); }).Where(x => x.EndsWith(".wav")).ToList();

            listBoxSelectVoiceAudio.Items.AddRange(files.ToArray());
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (listBoxSelectVoiceAudio.SelectedItem != null)
            {
                if(MainForm.currentPreference.SelectedVoiceClips[targetSlot] == null)
                {
                    MainForm.currentPreference.SelectedVoiceClips[targetSlot] = new AudioPlayerVoiceClip();
                }

                MainForm.currentPreference.SelectedVoiceClips[targetSlot].VoiceClipFullFileName = Path.Combine(MainForm.recordedAudioFolder, (string)listBoxSelectVoiceAudio.SelectedItem);
                MainForm.currentPreference.SelectedVoiceClips[targetSlot].VoiceClipFileName = (string)listBoxSelectVoiceAudio.SelectedItem;

                targetButton.Enabled = true;
                targetButton.Text = listBoxSelectVoiceAudio.Text;

                MainForm.SavePreferences();

                this.Close();
            }
        }

        private void PickVoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in mainForm.Controls.Find("groupBoxNoiseAndVoice", false)[0].Controls)
            {
                if (MainForm.currentPreference.SelectedVoiceClips[targetSlot] != null && ((Button)item).Name.Contains("buttonVoice") && !((Button)item).Name.Contains("Add"))
                {
                    if (((Button)item).Text != "empty")
                    {
                        ((Button)item).Enabled = true;
                    }
                }

                if(((Button)item).Name.Contains("buttonVoiceAdd"))
                {
                    ((Button)item).Enabled = true;
                }

            }

            if (afr != null)
            {
                afr.Close();
                afr.Dispose();
                afr = null;
            }

            if (audioOut != null)
            {
                audioOut.Stop();
                audioOut.Dispose();
                audioOut = null;
            }
        }

        private void listBoxSelectVoiceAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSelectVoiceAudio.SelectedItem != null)
            {
                buttonSetVoice.Enabled = true;
            }
            else
            {
                buttonSetVoice.Enabled = false;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBoxSelectVoiceAudio.SelectedItem != null)
            {
                if(afr != null)
                {
                    afr.Close();
                    afr.Dispose();
                    afr = null;
                }

                if(audioOut != null)
                {
                    audioOut.Stop();
                    audioOut.Dispose();
                    audioOut = null;
                    audioOut = new WaveOutEvent();
                }
                else
                {
                    audioOut = new WaveOutEvent();
                }

                afr = new AudioFileReader(Path.Combine(MainForm.recordedAudioFolder, (string)listBoxSelectVoiceAudio.SelectedItem));

                audioOut.Init(afr);
                audioOut.PlaybackStopped += audioOut_PlaybackStopped;
                audioOut.Play();

                buttonPlay.Enabled = false;
            }
        }

        private void audioOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (afr != null)
            {
                afr.Close();
                afr.Dispose();
                afr = null;
            }

            audioOut.Dispose();
            audioOut = null;
            audioOut = new WaveOutEvent();

            buttonPlay.Enabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}