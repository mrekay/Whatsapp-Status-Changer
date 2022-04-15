namespace WPAC.forms
{
    partial class Controller
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_header_whatsapp = new FontAwesome.Sharp.IconPictureBox();
            this.l_header_title = new System.Windows.Forms.Label();
            this.lbl_header_titlealt = new System.Windows.Forms.Label();
            this.btn_header_run = new FontAwesome.Sharp.IconButton();
            this.lb_controller_main = new System.Windows.Forms.ListBox();
            this.lbl_controller_info = new System.Windows.Forms.Label();
            this.lbl_controller_tab = new System.Windows.Forms.Label();
            this.pnl_controller_buttons = new System.Windows.Forms.Panel();
            this.btn_lb_remove = new FontAwesome.Sharp.IconButton();
            this.btn_lb_add = new FontAwesome.Sharp.IconButton();
            this.lbl_controller_version = new System.Windows.Forms.Label();
            this.lbl_controller_messages = new System.Windows.Forms.Label();
            this.wpManWatcher = new System.Windows.Forms.Timer(this.components);
            this.btn_controller_edit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_header_whatsapp)).BeginInit();
            this.pnl_controller_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btn_header_run);
            this.panel1.Controls.Add(this.lbl_header_titlealt);
            this.panel1.Controls.Add(this.l_header_title);
            this.panel1.Controls.Add(this.pb_header_whatsapp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 48);
            this.panel1.TabIndex = 0;
            // 
            // pb_header_whatsapp
            // 
            this.pb_header_whatsapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pb_header_whatsapp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.pb_header_whatsapp.IconChar = FontAwesome.Sharp.IconChar.WhatsappSquare;
            this.pb_header_whatsapp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.pb_header_whatsapp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pb_header_whatsapp.IconSize = 50;
            this.pb_header_whatsapp.Location = new System.Drawing.Point(12, 6);
            this.pb_header_whatsapp.Name = "pb_header_whatsapp";
            this.pb_header_whatsapp.Size = new System.Drawing.Size(54, 42);
            this.pb_header_whatsapp.TabIndex = 1;
            this.pb_header_whatsapp.TabStop = false;
            // 
            // l_header_title
            // 
            this.l_header_title.AutoSize = true;
            this.l_header_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_header_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.l_header_title.Location = new System.Drawing.Point(56, 5);
            this.l_header_title.Name = "l_header_title";
            this.l_header_title.Size = new System.Drawing.Size(56, 21);
            this.l_header_title.TabIndex = 2;
            this.l_header_title.Text = "WPAC";
            // 
            // lbl_header_titlealt
            // 
            this.lbl_header_titlealt.AutoSize = true;
            this.lbl_header_titlealt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_header_titlealt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.lbl_header_titlealt.Location = new System.Drawing.Point(57, 26);
            this.lbl_header_titlealt.Name = "lbl_header_titlealt";
            this.lbl_header_titlealt.Size = new System.Drawing.Size(181, 13);
            this.lbl_header_titlealt.TabIndex = 3;
            this.lbl_header_titlealt.Text = "Whatsapp Auto \"Status\" Changer";
            // 
            // btn_header_run
            // 
            this.btn_header_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_header_run.FlatAppearance.BorderSize = 0;
            this.btn_header_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_header_run.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btn_header_run.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btn_header_run.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_header_run.IconSize = 30;
            this.btn_header_run.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_header_run.Location = new System.Drawing.Point(348, 8);
            this.btn_header_run.Name = "btn_header_run";
            this.btn_header_run.Size = new System.Drawing.Size(32, 32);
            this.btn_header_run.TabIndex = 4;
            this.btn_header_run.UseVisualStyleBackColor = true;
            this.btn_header_run.Click += new System.EventHandler(this.btn_header_run_Click);
            // 
            // lb_controller_main
            // 
            this.lb_controller_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_controller_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(123)))), ((int)(((byte)(125)))));
            this.lb_controller_main.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_controller_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.lb_controller_main.FormattingEnabled = true;
            this.lb_controller_main.ItemHeight = 17;
            this.lb_controller_main.Location = new System.Drawing.Point(28, 181);
            this.lb_controller_main.Name = "lb_controller_main";
            this.lb_controller_main.Size = new System.Drawing.Size(336, 276);
            this.lb_controller_main.TabIndex = 1;
            // 
            // lbl_controller_info
            // 
            this.lbl_controller_info.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_controller_info.AutoSize = true;
            this.lbl_controller_info.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_controller_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.lbl_controller_info.Location = new System.Drawing.Point(27, 104);
            this.lbl_controller_info.Name = "lbl_controller_info";
            this.lbl_controller_info.Size = new System.Drawing.Size(339, 15);
            this.lbl_controller_info.TabIndex = 5;
            this.lbl_controller_info.Text = "Save the Status Messages You Want to Appear on Whatsapp";
            // 
            // lbl_controller_tab
            // 
            this.lbl_controller_tab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_controller_tab.AutoSize = true;
            this.lbl_controller_tab.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_controller_tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.lbl_controller_tab.Location = new System.Drawing.Point(23, 67);
            this.lbl_controller_tab.Name = "lbl_controller_tab";
            this.lbl_controller_tab.Size = new System.Drawing.Size(188, 37);
            this.lbl_controller_tab.TabIndex = 6;
            this.lbl_controller_tab.Text = "Management";
            // 
            // pnl_controller_buttons
            // 
            this.pnl_controller_buttons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_controller_buttons.Controls.Add(this.btn_controller_edit);
            this.pnl_controller_buttons.Controls.Add(this.lbl_controller_messages);
            this.pnl_controller_buttons.Controls.Add(this.btn_lb_remove);
            this.pnl_controller_buttons.Controls.Add(this.btn_lb_add);
            this.pnl_controller_buttons.Location = new System.Drawing.Point(28, 141);
            this.pnl_controller_buttons.Name = "pnl_controller_buttons";
            this.pnl_controller_buttons.Size = new System.Drawing.Size(336, 38);
            this.pnl_controller_buttons.TabIndex = 8;
            // 
            // btn_lb_remove
            // 
            this.btn_lb_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lb_remove.FlatAppearance.BorderSize = 0;
            this.btn_lb_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lb_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btn_lb_remove.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_lb_remove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btn_lb_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_lb_remove.IconSize = 30;
            this.btn_lb_remove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_lb_remove.Location = new System.Drawing.Point(296, 3);
            this.btn_lb_remove.Name = "btn_lb_remove";
            this.btn_lb_remove.Size = new System.Drawing.Size(32, 32);
            this.btn_lb_remove.TabIndex = 9;
            this.btn_lb_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lb_remove.UseVisualStyleBackColor = true;
            this.btn_lb_remove.Click += new System.EventHandler(this.btn_lb_remove_Click);
            // 
            // btn_lb_add
            // 
            this.btn_lb_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lb_add.FlatAppearance.BorderSize = 0;
            this.btn_lb_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lb_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btn_lb_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_lb_add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btn_lb_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_lb_add.IconSize = 30;
            this.btn_lb_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_lb_add.Location = new System.Drawing.Point(220, 3);
            this.btn_lb_add.Name = "btn_lb_add";
            this.btn_lb_add.Size = new System.Drawing.Size(32, 32);
            this.btn_lb_add.TabIndex = 8;
            this.btn_lb_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_lb_add.UseVisualStyleBackColor = true;
            this.btn_lb_add.Click += new System.EventHandler(this.btn_lb_add_Click);
            // 
            // lbl_controller_version
            // 
            this.lbl_controller_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_controller_version.AutoSize = true;
            this.lbl_controller_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.lbl_controller_version.Location = new System.Drawing.Point(9, 466);
            this.lbl_controller_version.Name = "lbl_controller_version";
            this.lbl_controller_version.Size = new System.Drawing.Size(94, 13);
            this.lbl_controller_version.TabIndex = 9;
            this.lbl_controller_version.Text = "Version : {Version}";
            // 
            // lbl_controller_messages
            // 
            this.lbl_controller_messages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_controller_messages.AutoSize = true;
            this.lbl_controller_messages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_controller_messages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.lbl_controller_messages.Location = new System.Drawing.Point(3, 12);
            this.lbl_controller_messages.Name = "lbl_controller_messages";
            this.lbl_controller_messages.Size = new System.Drawing.Size(104, 15);
            this.lbl_controller_messages.TabIndex = 10;
            this.lbl_controller_messages.Text = "Status Messages :";
            // 
            // wpManWatcher
            // 
            this.wpManWatcher.Enabled = true;
            this.wpManWatcher.Interval = 50;
            this.wpManWatcher.Tick += new System.EventHandler(this.wpManWatcher_Tick);
            // 
            // btn_controller_edit
            // 
            this.btn_controller_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_controller_edit.FlatAppearance.BorderSize = 0;
            this.btn_controller_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_controller_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.btn_controller_edit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_controller_edit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btn_controller_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_controller_edit.IconSize = 30;
            this.btn_controller_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_controller_edit.Location = new System.Drawing.Point(258, 3);
            this.btn_controller_edit.Name = "btn_controller_edit";
            this.btn_controller_edit.Size = new System.Drawing.Size(32, 32);
            this.btn_controller_edit.TabIndex = 11;
            this.btn_controller_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_controller_edit.UseVisualStyleBackColor = true;
            this.btn_controller_edit.Click += new System.EventHandler(this.btn_controller_edit_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(392, 488);
            this.Controls.Add(this.lbl_controller_version);
            this.Controls.Add(this.pnl_controller_buttons);
            this.Controls.Add(this.lbl_controller_tab);
            this.Controls.Add(this.lbl_controller_info);
            this.Controls.Add(this.lb_controller_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Controller";
            this.Text = "WPAC Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_FormClosing);
            this.Load += new System.EventHandler(this.Controller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_header_whatsapp)).EndInit();
            this.pnl_controller_buttons.ResumeLayout(false);
            this.pnl_controller_buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_header_run;
        private System.Windows.Forms.Label lbl_header_titlealt;
        private System.Windows.Forms.Label l_header_title;
        private FontAwesome.Sharp.IconPictureBox pb_header_whatsapp;
        private System.Windows.Forms.ListBox lb_controller_main;
        private System.Windows.Forms.Label lbl_controller_info;
        private System.Windows.Forms.Label lbl_controller_tab;
        private System.Windows.Forms.Panel pnl_controller_buttons;
        private FontAwesome.Sharp.IconButton btn_lb_remove;
        private FontAwesome.Sharp.IconButton btn_lb_add;
        private System.Windows.Forms.Label lbl_controller_version;
        private System.Windows.Forms.Label lbl_controller_messages;
        private System.Windows.Forms.Timer wpManWatcher;
        private FontAwesome.Sharp.IconButton btn_controller_edit;
    }
}
