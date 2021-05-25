using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class UserControlBubble : UserControl
    {
        public UserControlBubble() { }
        public UserControlBubble(string message)
        {
            InitializeComponent();

            labelText.Text = message;

            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(labelText.Text, labelText.Font, labelText.Width);

            labelText.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
        }
    }
}
