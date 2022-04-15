using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPAC.forms
{
    public partial class AddStatus : Form
    {
        int editingID;
        public AddStatus(string editingText = "",int _editingID = -1)
        {
            InitializeComponent();
            if (_editingID > 0) editingID = _editingID;
            rt_addstatus_main.Text = editingText;
        }

        private void rt_addstatus_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rt_addstatus_main.Text)) { MessageBox.Show("Please Write A Status Message.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Properties.Settings.Default.StatusMessages == null) Properties.Settings.Default.StatusMessages = new System.Collections.Specialized.StringCollection();

            /* Save When Editing */
            if (editingID > 0) Properties.Settings.Default.StatusMessages[editingID] = rt_addstatus_main.Text;
            else Properties.Settings.Default.StatusMessages.Add(rt_addstatus_main.Text);

            /* Save Settings */
            Properties.Settings.Default.Save();
            MessageBox.Show("Status added successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
