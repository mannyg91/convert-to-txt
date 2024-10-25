using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeToTxt
{
    public class CustomCheckedListBox : CheckedListBox
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_LBUTTONDOWN = 0x0201;

            if (m.Msg == WM_LBUTTONDOWN)
            {
                Point point = this.PointToClient(Cursor.Position);
                int index = this.IndexFromPoint(point);

                if (index != -1)
                {
                    Rectangle itemRect = this.GetItemRectangle(index);
                    Rectangle checkboxRect = new Rectangle(itemRect.Location, new Size(16, 16));
                    checkboxRect.X += 3; // Adjust as needed based on checkbox position
                    checkboxRect.Y += (itemRect.Height - 16) / 2;

                    if (!checkboxRect.Contains(point))
                    {
                        // Ignore clicks outside the checkbox
                        return;
                    }
                }
            }

            base.WndProc(ref m);
        }
    }
}
