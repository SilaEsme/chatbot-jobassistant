using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class UserControlBubble : UserControl
    {
        public UserControlBubble()
        {
        }

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