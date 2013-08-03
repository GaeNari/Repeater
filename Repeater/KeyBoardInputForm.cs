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
    public partial class KeyBoardInputForm : Form
    {
        public delegate void KeyInputHandler(String keyInput);
        public event KeyInputHandler KeyInputEvent;

        public KeyBoardInputForm()
        {
            InitializeComponent();
        }

        private void KeyBoardInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    InputKey.Text = "Enter";
                    break;
                case Keys.Back:
                    InputKey.Text = "Backspace";
                    break;
                case Keys.Escape:
                    InputKey.Text = "ESC";
                    break;
                case Keys.ShiftKey:
                    InputKey.Text = "Shift";
                    break;
                case Keys.ControlKey:
                    InputKey.Text = "Control";
                    break;
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    InputKey.Text = e.KeyCode.ToString()[1].ToString();
                    this.Focus();
                    break;
                default:
                    InputKey.Text = e.KeyCode.ToString();
                    this.Focus();
                    break;
            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            KeyInputEvent(InputKey.Text);
            this.Close();
        }
    }
}
