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
    public partial class KeyBoardInputBox : Form
    {
        public KeyBoardInputBox()
        {
            InitializeComponent();
        }

        private void KeyBoardInputBox_Shown(object sender, EventArgs e)
        {
            this.Activate();
            InputKey.Focus();
        }

        private void InputKey_KeyDown(object sender, KeyEventArgs e)
        {
            InputKey.Text = e.KeyCode.ToString();
        }
    }
}
