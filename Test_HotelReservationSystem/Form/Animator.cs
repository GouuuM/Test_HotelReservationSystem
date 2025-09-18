using System;
using System.Windows.Forms;

public static class Animator
{
    public static void SmoothScroll(Panel panel, int targetY)
    {
        Timer timer = new Timer();
        timer.Interval = 10; // speed of animation
        int step = 10;       // pixels per tick

        timer.Tick += (s, e) =>
        {
            int currentY = panel.VerticalScroll.Value;
            if (Math.Abs(currentY - targetY) < step)
            {
                panel.VerticalScroll.Value = targetY;
                timer.Stop();
                timer.Dispose();
            }
            else
            {
                panel.VerticalScroll.Value += (currentY < targetY ? step : -step);
            }
        };
        timer.Start();
    }

    public static void SlideIn(Control ctrl, int targetX)
    {
        Timer timer = new Timer();
        timer.Interval = 15;
        int step = 5;

        timer.Tick += (s, e) =>
        {
            if (ctrl.Left < targetX)
            {
                ctrl.Left += step;
            }
            else
            {
                ctrl.Left = targetX;
                timer.Stop();
                timer.Dispose();
            }
        };
        timer.Start();
    }
}