namespace WPAC.forms
{
    partial class AddStatus
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
            this.rt_addstatus_main = new System.Windows.Forms.RichTextBox();
            this.rt_addstatus_save = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rt_addstatus_main
            // 
            this.rt_addstatus_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rt_addstatus_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(95)))));
            this.rt_addstatus_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rt_addstatus_main.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rt_addstatus_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.rt_addstatus_main.Location = new System.Drawing.Point(12, 34);
            this.rt_addstatus_main.Name = "rt_addstatus_main";
            this.rt_addstatus_main.Size = new System.Drawing.Size(356, 146);
            this.rt_addstatus_main.TabIndex = 0;
            this.rt_addstatus_main.Text = "";
            // 
            // rt_addstatus_save
            // 
            this.rt_addstatus_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rt_addstatus_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rt_addstatus_save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.rt_addstatus_save.IconColor = System.Drawing.Color.Black;
            this.rt_addstatus_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rt_addstatus_save.IconSize = 18;
            this.rt_addstatus_save.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rt_addstatus_save.Location = new System.Drawing.Point(293, 181);
            this.rt_addstatus_save.Name = "rt_addstatus_save";
            this.rt_addstatus_save.Size = new System.Drawing.Size(75, 28);
            this.rt_addstatus_save.TabIndex = 1;
            this.rt_addstatus_save.Text = "Save";
            this.rt_addstatus_save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rt_addstatus_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rt_addstatus_save.UseVisualStyleBackColor = true;
            this.rt_addstatus_save.Click += new System.EventHandler(this.rt_addstatus_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write a Status Message";
            // 
            // AddStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(380, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_addstatus_save);
            this.Controls.Add(this.rt_addstatus_main);
            this.Name = "AddStatus";
            this.Text = "Add/Edit Status Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_addstatus_main;
        private FontAwesome.Sharp.IconButton rt_addstatus_save;
        private System.Windows.Forms.Label label1;
    }
}