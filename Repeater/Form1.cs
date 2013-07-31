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
        public Repeater()
        {
            InitializeComponent();
        }

        private void KeyboardInput_Click(object sender, EventArgs e)
        {
            Instructions.Items.Add("키보드");
        }

        private void MouseInput_Click(object sender, EventArgs e)
        {
            Instructions.Items.Add("마우스");
        }

        private void Delay_Click(object sender, EventArgs e)
        {
            Instructions.Items.Add("딜레이");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selected = Instructions.SelectedIndex;
            Instructions.Items.RemoveAt(selected);
        }
    }
}
