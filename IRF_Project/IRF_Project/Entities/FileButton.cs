using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project.Entities
{
    class FileButton : Button
    {
        public FileButton(int width, int height, int left, int top, string text)
        {
            Width = width;
            Height = height;
            Left = left;
            Top = top;
            Text = text;
            this.MouseHover += FileButton_MouseHover;
        }
        

        ///summary
        //Following function is currently just for testing 
        ///End of summary

        private void FileButton_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }
}
