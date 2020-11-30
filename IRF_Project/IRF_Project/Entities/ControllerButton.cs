using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.Entities
{
    public class ControllerButton : Button
    {
        #region properties
        Color color = Color.Transparent;
        #endregion

        public ControllerButton(int width, int height, int left, int top, string text)
        {
            Width = width;
            Height = height;
            Left = left;
            Top = top;
            Text = text;
            Color color = this.BackColor;
            this.MouseEnter += FileButton_MouseEnter;
            this.MouseLeave += FileButton_MouseLeave;
        }

        private void FileButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void FileButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = color;
        }
    }
}
