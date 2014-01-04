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
    public partial class Repeater : Form
    {
        bool isModified = false;

        public Repeater()
        {
            InitializeComponent();
        }

        private void KeyboardInput_Click(object sender, EventArgs e)
        {
            KeyBoardInputForm keyInputForm = new KeyBoardInputForm();
            keyInputForm.KeyInputEvent += new KeyBoardInputForm.KeyInputHandler(keyInputForm_KeyInputEvent);
            keyInputForm.ShowDialog();
            isModified = true;
        }

        void keyInputForm_KeyInputEvent(String text)
        {
            Instructions.Items.Add(text);
        }

        private void MouseInput_Click(object sender, EventArgs e)
        {
            MouseInputForm mouseInputForm = new MouseInputForm();
            mouseInputForm.MouseInputEvent += new MouseInputForm.MouseInputHandler(mouseInputForm_MouseInputEvent);
            mouseInputForm.ShowDialog();
            isModified = true;
        }

        void mouseInputForm_MouseInputEvent(int X, int Y, String behavior)
        {
            if(behavior=="이동")
                Instructions.Items.Add(X.ToString() + "," + Y.ToString() + " " + behavior);
            else
                Instructions.Items.Add(behavior);
        }

        private void Delay_Click(object sender, EventArgs e)
        {
            DelayInputForm delayInputForm = new DelayInputForm();
            delayInputForm.DelayInputEvent += new DelayInputForm.DelayInputHandler(delayInputForm_DelayInputEvent);
            delayInputForm.ShowDialog();
            isModified = true;
        }

        void delayInputForm_DelayInputEvent(uint miliseconds)
        {
            Instructions.Items.Add(miliseconds.ToString() + "ms 대기");
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Instructions.Items.RemoveAt(Instructions.SelectedIndex);
                isModified = true;
            }
            catch
            {
            }
        }

        private void NewMacroMenuItem_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                DialogResult answer = MessageBox.Show("매크로가 변경되었습니다. 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    MessageBox.Show("저장을 선택했다");
                    isModified = false;
                }
                else if (answer == DialogResult.No)
                {
                    Instructions.Items.Clear();
                    isModified = false;
                }
            }
        }

        private void ManualMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("반복할 매크로 작업을 해당 버튼을 눌러서 만든 후에 반복 횟수를 입력하고 시작 버튼을 누르면 2초 후 매크로가 시작됩니다.");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int n = Instructions.Items.Count;
            Instructions.SelectedIndex = -1;
            if (n != 0)
            {
                while (n-- > 0)
                {
                    Instructions.SelectedIndex++;
                    String todo = Instructions.SelectedItem.ToString();
                    MessageBox.Show(todo);
                }
            }
        }
    }
}
