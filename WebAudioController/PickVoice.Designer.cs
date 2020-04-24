namespace DJ3
{
    partial class PickVoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSetVoice = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxSelectVoiceAudio = new System.Windows.Forms.ListBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetVoice
            // 
            this.buttonSetVoice.Location = new System.Drawing.Point(414, 500);
            this.buttonSetVoice.Name = "buttonSetVoice";
            this.buttonSetVoice.Size = new System.Drawing.Size(160, 75);
            this.buttonSetVoice.TabIndex = 0;
            this.buttonSetVoice.Text = "Set To Slot ";
            this.buttonSetVoice.UseVisualStyleBackColor = true;
            this.buttonSetVoice.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(600, 500);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(168, 75);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxSelectVoiceAudio
            // 
            this.listBoxSelectVoiceAudio.FormattingEnabled = true;
            this.listBoxSelectVoiceAudio.ItemHeight = 24;
            this.listBoxSelectVoiceAudio.Location = new System.Drawing.Point(12, 12);
            this.listBoxSelectVoiceAudio.Name = "listBoxSelectVoiceAudio";
            this.listBoxSelectVoiceAudio.Size = new System.Drawing.Size(759, 460);
            this.listBoxSelectVoiceAudio.TabIndex = 2;
            this.listBoxSelectVoiceAudio.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectVoiceAudio_SelectedIndexChanged);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 478);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(118, 46);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // PickVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxSelectVoiceAudio);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSetVoice);
            this.Name = "PickVoice";
            this.Text = "PickVoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PickVoice_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetVoice;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxSelectVoiceAudio;
        private System.Windows.Forms.Button buttonPlay;
    }
}