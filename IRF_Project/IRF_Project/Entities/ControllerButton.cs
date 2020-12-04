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
        #region Variables
        Color _originalColor;
        Color _hovercolor;
        #endregion

        public ControllerButton(int width, int height, int left, int top, string text, Color HoverColor)
        {
            Width = width;
            Height = height;
            Left = left;
            Top = top;
            Text = text;
            Font = new Font(Font.FontFamily, 9);
            _originalColor = Button.DefaultBackColor;
            BackColor = _originalColor;
            FlatStyle = FlatStyle.Flat;
            _hovercolor = HoverColor;
            MouseEnter += FileButton_MouseEnter;
            MouseLeave += FileButton_MouseLeave;
            MouseHover += ControllerButton_MouseHover;
        }

        private void ControllerButton_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void FileButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = _hovercolor;
        }

        private void FileButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = _originalColor;
        }
    }
}
