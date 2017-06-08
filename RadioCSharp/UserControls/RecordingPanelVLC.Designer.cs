namespace RadioCSharp
{
    partial class RecordingPanelVLC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingPanel));
            this.btnRecord = new ns1.BunifuImageButton();
            this.btnOpenFolder = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnRecord.Image = global::RadioCSharp.Properties.Resources.UnRec;
            this.btnRecord.ImageActive = null;
            this.btnRecord.Location = new System.Drawing.Point(3, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(32, 24);
            this.btnRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecord.TabIndex = 2;
            this.btnRecord.TabStop = false;
            this.btnRecord.Zoom = 10;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFolder.Image")));
            this.btnOpenFolder.ImageActive = null;
            this.btnOpenFolder.Location = new System.Drawing.Point(3, 27);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(32, 24);
            this.btnOpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.TabStop = false;
            this.btnOpenFolder.Zoom = 10;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // RecordingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnRecord);
            this.Name = "RecordingPanel";
            this.Size = new System.Drawing.Size(39, 56);
            this.Load += new System.EventHandler(this.RecordingPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuImageButton btnRecord;
        private ns1.BunifuImageButton btnOpenFolder;
    }
}
