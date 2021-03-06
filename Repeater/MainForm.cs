﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Repeater
{
    public partial class Repeater : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint ABSOLUTE = 0x8000;
        private const uint MOUSEMOVE = 0x0001;
        private const uint LBUTTONDOWN = 0x0002;
        private const uint LBUTTONUP = 0x0004;
        private const uint RBUTTONDOWN = 0x0008;
        private const uint RBUTTONUP = 0x0010;

        bool isModified = false;

        public Repeater()
        {
            InitializeComponent();
        }

        private void LClick(Point pos)
        {
            mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
            mouse_event(LBUTTONUP, 0, 0, 0, 0);
        }

        private void RClick(Point pos)
        {
            mouse_event(RBUTTONDOWN, 0, 0, 0, 0);
            mouse_event(RBUTTONUP, 0, 0, 0, 0);
        }

        private void KeyboardInput_Click(object sender, EventArgs e)
        {
            int locationY = (this.Top + this.Bottom) / 2;
            int locationX = (this.Left + this.Right) / 2;
            KeyBoardInputForm keyInputForm = new KeyBoardInputForm{StartPosition = FormStartPosition.Manual, Location = new Point(locationX,locationY)};
            keyInputForm.KeyInputEvent += new KeyBoardInputForm.KeyInputHandler(keyInputForm_KeyInputEvent);
            keyInputForm.ShowDialog();
            isModified = true;
        }

        void keyInputForm_KeyInputEvent(String text)
        {
            Instructions.Items.Add("키보드 " + text);
        }

        private void MouseInput_Click(object sender, EventArgs e)
        {
            int locationY = (this.Top + this.Bottom) / 2;
            int locationX = (this.Left + this.Right) / 2;
            MouseInputForm mouseInputForm = new MouseInputForm { StartPosition = FormStartPosition.Manual, Location = new Point(locationX, locationY) };
            mouseInputForm.MouseInputEvent += new MouseInputForm.MouseInputHandler(mouseInputForm_MouseInputEvent);
            mouseInputForm.ShowDialog();
            isModified = true;
        }

        void mouseInputForm_MouseInputEvent(int X, int Y, String behavior)
        {
            if(behavior=="이동")
                Instructions.Items.Add("마우스 " + behavior + " " + X.ToString() + "," + Y.ToString());
            else
                Instructions.Items.Add("마우스 " + behavior);
        }

        private void Delay_Click(object sender, EventArgs e)
        {
            int locationY = (this.Top + this.Bottom) / 2;
            int locationX = (this.Left + this.Right) / 2;
            DelayInputForm delayInputForm = new DelayInputForm { StartPosition = FormStartPosition.Manual, Location = new Point(locationX, locationY) };
            delayInputForm.DelayInputEvent += new DelayInputForm.DelayInputHandler(delayInputForm_DelayInputEvent);
            delayInputForm.ShowDialog();
            isModified = true;
        }

        void delayInputForm_DelayInputEvent(uint miliseconds)
        {
            Instructions.Items.Add("딜레이 " + miliseconds.ToString());
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
                System.Threading.Thread.Sleep(2000);
                while (n-- > 0)
                {
                    Instructions.SelectedIndex++;
                    String instructionType = Instructions.SelectedItem.ToString().Substring(0,3);
                    String instructionContent = Instructions.SelectedItem.ToString().Substring(4);
                    switch (instructionType)
                    {
                        case "키보드":
                            if (instructionContent.Length != 1)
                            {
                                SendKeys.Send("{" + instructionContent + "}");
                            }
                            else
                            {
                                SendKeys.Send(instructionContent);
                            }
                            break;
                        case "마우스":
                            MessageBox.Show("마우스");
                            MessageBox.Show(instructionContent);
                            break;
                        case "딜레이":
                            MessageBox.Show("딜레이");
                            MessageBox.Show(instructionContent);
                            break;
                        default:
                            break;
                    }
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
    }
}
