
namespace PlayMusicFromFolder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_info_selectMusicFolder = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lv_fileList = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fbd_musicFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_fbd_path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_info_selectMusicFolder
            // 
            this.lbl_info_selectMusicFolder.AutoSize = true;
            this.lbl_info_selectMusicFolder.Location = new System.Drawing.Point(13, 13);
            this.lbl_info_selectMusicFolder.Name = "lbl_info_selectMusicFolder";
            this.lbl_info_selectMusicFolder.Size = new System.Drawing.Size(100, 13);
            this.lbl_info_selectMusicFolder.TabIndex = 0;
            this.lbl_info_selectMusicFolder.Text = "Select Music Folder";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(16, 30);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(97, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lv_fileList
            // 
            this.lv_fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_time});
            this.lv_fileList.GridLines = true;
            this.lv_fileList.HideSelection = false;
            this.lv_fileList.Location = new System.Drawing.Point(16, 87);
            this.lv_fileList.Name = "lv_fileList";
            this.lv_fileList.Size = new System.Drawing.Size(350, 250);
            this.lv_fileList.TabIndex = 2;
            this.lv_fileList.UseCompatibleStateImageBehavior = false;
            this.lv_fileList.View = System.Windows.Forms.View.Details;
            this.lv_fileList.DoubleClick += new System.EventHandler(this.lv_fileList_DoubleClick);
            // 
            // ch_name
            // 
            this.ch_name.Text = "Name";
            this.ch_name.Width = 270;
            // 
            // ch_time
            // 
            this.ch_time.Text = "Time";
            this.ch_time.Width = 75;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_play.Location = new System.Drawing.Point(16, 344);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_stop.Location = new System.Drawing.Point(291, 343);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_fbd_path
            // 
            this.lbl_fbd_path.AutoSize = true;
            this.lbl_fbd_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fbd_path.ForeColor = System.Drawing.Color.Red;
            this.lbl_fbd_path.Location = new System.Drawing.Point(16, 60);
            this.lbl_fbd_path.Name = "lbl_fbd_path";
            this.lbl_fbd_path.Size = new System.Drawing.Size(8, 12);
            this.lbl_fbd_path.TabIndex = 5;
            this.lbl_fbd_path.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 387);
            this.Controls.Add(this.lbl_fbd_path);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lv_fileList);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.lbl_info_selectMusicFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PlayMusicFromFolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info_selectMusicFolder;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.ListView lv_fileList;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_time;
        private System.Windows.Forms.FolderBrowserDialog fbd_musicFolder;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_fbd_path;
    }
}

