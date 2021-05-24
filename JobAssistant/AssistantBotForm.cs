using System;
using System.Drawing;
using System.Windows.Forms;

namespace JobAssistant
{
    public partial class AssistantBotForm : Form
    {
        XmlOperations xml = new XmlOperations();
        static ChatBot MyBot;
        string english, position, school;
        // Old bubble for save old location.
        UserControlBubble oldSpeechBaloon = new UserControlBubble();
        public AssistantBotForm()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void AssistantBotForm_Load(object sender, EventArgs e)
        {
            // Create new Chatbot
            MyBot = new ChatBot();

            // Sets Position for the first bubble on the top
            oldSpeechBaloon.Top = 0 - oldSpeechBaloon.Height;

            userControlBubble1.Visible = false;
        }
        private void TakeEmployeeInfo(string input)
        {
            string info = input.ToLower();
            // school
            if (info == "odtu" || info == "boun" || info == "esogu")
            {
                school = info;
            }
            // english
            else if (info == "a1" || info == "a2" || info == "b1" || info == "b2" || info == "c1" || info == "c2")
            {
                english = info;
            }
            // position
            else if (info == "software" || info == "hardware" || info == "networking" || info == "security")
            {
                position = info;
            }
        }
        private void ShowOutput()
        {
            // To avoid empty input
            if (!String.IsNullOrEmpty(textBoxText.Text))
            {
                string input = textBoxText.Text;
                CreateHumanBubble(input);

                TakeEmployeeInfo(input);
                
                // Take Bot's output
                string output = MyBot.getOutput(input);
                if (output == "Thanks for using JobAssistant!")
                {
                    xml.GenerateBaseEmployeeXML(LoginedUser.Instance().Employee,school,english,position);
                }

                CreateRobotBubble(output);
            }
            // Reset textbox
            textBoxText.Text = "";
        }
        private void CreateHumanBubble(string message)
        {
            UserControlBubble speechBaloon = new UserControlBubble(message);
            speechBaloon.Location = userControlBubble1.Location;
            speechBaloon.Left += 155;
            speechBaloon.Size = userControlBubble1.Size;
            speechBaloon.Top = oldSpeechBaloon.Bottom + 10;
            
            panelDialog.Controls.Add(speechBaloon);

            oldSpeechBaloon = speechBaloon;
        }
        private void CreateRobotBubble(string message)
        {
            UserControlBubble speechBaloon = new UserControlBubble(message);
            speechBaloon.Location = userControlBubble1.Location;
            speechBaloon.Size = userControlBubble1.Size;
            speechBaloon.Top = oldSpeechBaloon.Bottom + 10;
            speechBaloon.BackColor = Color.LightGray;
            panelDialog.Controls.Add(speechBaloon);

            oldSpeechBaloon = speechBaloon;
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxSent_Click(object sender, EventArgs e)
        {
            ShowOutput();
        }

        private void textBoxText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxSent_Click(sender, e);
            }
        }
    }
}
