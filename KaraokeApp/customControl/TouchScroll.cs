using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeApp.customControl
{
    class TouchScroll
    {
        private Point mouseDownPoint;
        private FlowLayoutPanel parentPanel;

        public TouchScroll(FlowLayoutPanel panel)
        {
            parentPanel = panel;
            AssignEvent(panel);
        }

        private void AssignEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            foreach (Control child in control.Controls)
            {
                AssignEvent(child);
            }
        }

        private void MouseMove(Object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            Point pointDifference = new Point(Cursor.Position.X - mouseDownPoint.X, Cursor.Position.Y + mouseDownPoint.Y);
            if (mouseDownPoint.X == Cursor.Position.X && mouseDownPoint.Y == Cursor.Position.Y)
                return;

            Point curAutoS = parentPanel.AutoScrollPosition;
            parentPanel.AutoScrollPosition = new Point(Math.Abs(curAutoS.X) - pointDifference.X, Math.Abs(curAutoS.Y) - pointDifference.Y);
            mouseDownPoint = Cursor.Position;
        }

        private void MouseDown(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mouseDownPoint = Cursor.Position;
            }
        }
    }
}
