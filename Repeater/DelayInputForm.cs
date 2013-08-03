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
    public partial class DelayInputForm : Form
    {
        public delegate void DelayInputHandler(uint miliseconds);
        public event DelayInputHandler DelayInputEvent;

        public DelayInputForm()
        {
            InitializeComponent();
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                DelayInputEvent(System.Convert.ToUInt32(DelayTime.Text));
                this.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("올바른 시간을 입력하십시오");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("양의 정수만 입력하십시오");
            }
        }
    }
}
