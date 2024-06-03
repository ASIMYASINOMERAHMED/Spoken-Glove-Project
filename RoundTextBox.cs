using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoken_Gloves_Project
{
    public partial class RoundTextBox : TextBox
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
  int nLeftRect, // X-coordinate of upper-left corner or padding at start
  int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
  int nRightRect, // X-coordinate of lower-right corner or Width of the object
  int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                  //RADIUS, how round do you want it to be?
  int nheightRect, //height of ellipse 
  int nweightRect //width of ellipse
);

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Create a region with rounded corners and assign it to the textbox
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
        }

    }
}
