namespace DJ3
{
    partial class ConfirmPlaylistDelete
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(17, 59);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(202, 41);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Remove Playlist";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(298, 59);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(147, 41);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Cancel";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(138, 25);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Are you Sure?";
            // 
            // ConfirmPlaylistDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 117);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonDelete);
            this.Name = "ConfirmPlaylistDelete";
            this.Text = "ConfirmPlaylistDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmPlaylistDelete_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Label labelMessage;
    }
}