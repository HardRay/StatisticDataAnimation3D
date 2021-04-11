using System;
using System.Windows.Forms;
using System.Drawing;

namespace Program
{
    class SettingsControl
    {
        private const int step = 10;
        private const int maxBurgerWidth = 40;
        private const int maxPanelWidth = 200;
        internal bool isSettingsFocus;
        private Panel settingsPanel;
        private Button burger;
        private Timer settingsTimer;
        public Color MainColor;

        internal SettingsControl(Panel panel, Button button, Timer timer)
        {
            isSettingsFocus = false;
            //Search for the main color of the Windows theme
            MainColor = Color.FromArgb(56, 89, 135);
            settingsPanel = panel;
            burger = button;
            settingsTimer = timer;
            burger.BackColor = MainColor;
            settingsPanel.BackColor = MainColor;
            foreach (Control control in settingsPanel.Controls)
            {
                if (control is Label)
                    control.ForeColor = Color.FromArgb(Math.Abs(255 - MainColor.R), Math.Abs(255 - MainColor.G), Math.Abs(255 - MainColor.B));
                if (control is Button || control is RadioButton)
                {
                    control.ForeColor = MainColor;
                    control.BackColor = Color.FromArgb(Math.Abs(255 - MainColor.R), Math.Abs(255 - MainColor.G), Math.Abs(255 - MainColor.B));
                }
                if (control is Panel)
                    foreach (Control ctr in control.Controls)
                        if (ctr is Label)
                            control.ForeColor = Color.FromArgb(Math.Abs(255 - MainColor.R), Math.Abs(255 - MainColor.G), Math.Abs(255 - MainColor.B));
            }
            //Set the initial position
            settingsPanel.SetBounds(0, 0, 0, settingsPanel.Height);
            burger.SetBounds(0, 0, 40, 40);
        }

        internal void Timer_tick()
        {
            if (isSettingsFocus)
            {
                if (burger.Size.Width > 0 && settingsPanel.Width == 0)
                {
                    burger.Width -= step;
                    return;
                }
                if (settingsPanel.Size.Width < maxPanelWidth)
                {
                    settingsPanel.Width += step;
                    if (burger.Width < maxBurgerWidth)
                        burger.Width += step;
                    burger.Location = new Point(settingsPanel.Width, burger.Location.Y);
                }
                else
                    settingsTimer.Stop();
            }
            else
            {
                if (settingsPanel.Size.Width > 0)
                {
                    settingsPanel.Width -= step;
                    if (burger.Width > 0)
                        burger.Width -= step;
                    burger.Location = new Point(settingsPanel.Width, burger.Location.Y);
                    return;
                }
                if (burger.Size.Width < maxBurgerWidth)
                    burger.Width += step;
                else
                    settingsTimer.Stop();
            }
        }
    }
}
