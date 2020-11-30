using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.Entities
{
    public class HintButton : Button
    {
        string _messageText;
        int _size = 20;
        public HintButton(int left, int top, string messageText)
        {
            Width = _size;
            Height = _size;
            Left = left;
            Top = top;
            Text = "?";
            _messageText = messageText;
            BackColor = Color.FromArgb(105,135,200);
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            MouseClick += HintButton_MouseClick;
        }

        private void HintButton_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(_messageText);
        }
    }
}
