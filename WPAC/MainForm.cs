using WPAC.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPAC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            var _controller = new Controller() { Dock = DockStyle.Fill, TopLevel = false };
            Controls.Add(_controller);
            _controller.Show();
            Text = _controller.Text;
        }
    }
}
