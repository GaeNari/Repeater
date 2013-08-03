using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeater
{
    public partial class MouseInputForm : Form
    {
        public delegate void MouseInputHandler(int X, int Y, String behavior);
        public event MouseInputHandler MouseInputEvent;

        public MouseInputForm()
        {
            InitializeComponent();
        }

        private void MouseInputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                pos_X.Text = Control.MousePosition.X.ToString();
                pos_Y.Text = Control.MousePosition.Y.ToString();
            }
        }

        private void MouseInputForm_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.Focus();
        }
    }
}
