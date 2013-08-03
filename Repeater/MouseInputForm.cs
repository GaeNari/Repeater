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

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (MoveRadioButton.Checked)
            {
                try
                {
                    MouseInputEvent(
                        (int)System.Convert.ToUInt32(pos_X.Text),
                        (int)System.Convert.ToUInt32(pos_Y.Text),
                        "이동");
                    this.Close();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("올바른 좌표를 입력하십시오.");
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("uint32 범위의 정수만 입력 가능합니다");
                }
            }
            else if (LeftClickRadioButton.Checked)
            {
                MouseInputEvent(-1, -1, "왼쪽 클릭");
                this.Close();
            }
            else if (LeftDownRadioButton.Checked)
            {
                MouseInputEvent(-1, -1, "왼쪽 누름");
                this.Close();
            }
            else if (LeftUpRadioButton.Checked)
            {
                MouseInputEvent(-1, -1, "왼쪽 뗌");
                this.Close();
            }
            else if (RightClickRadioButton.Checked)
            {
                MouseInputEvent(-1, -1, "오른쪽 클릭");
                this.Close();
            }
            else if (RightDownRadioButton.Checked)
            {
                MouseInputEvent(-1, -1, "오른쪽 누름");
                this.Close();
            }
            else if (RightUpRadioButton.Checked)
            {
                MouseInputEvent(-1, -1, "오른쪽 뗌");
                this.Close();
            }
            else
            {
                MessageBox.Show("동작을 체크하십시오");
            }
        }
    }
}
