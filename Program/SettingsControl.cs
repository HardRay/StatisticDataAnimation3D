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

        internal SettingsControl(Panel panel, Button button, Timer timer)
        {
            isSettingsFocus = false;
            //Search for the main color of the Windows theme
            Color MainColor = Color.FromArgb((int)Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null));
            settingsPanel = panel;
            burger = button;
            settingsTimer = timer;
            burger.BackColor = MainColor;
            settingsPanel.BackColor = MainColor;
            foreach (Control control in settingsPanel.Controls)
            {
                if (control is Label)
                    control.ForeColor = Color.FromArgb(Math.Abs(255 - MainColor.R), Math.Abs(255 - MainColor.G), Math.Abs(255 - MainColor.B));
                if (control is Button)
                {
                    control.ForeColor = MainColor;
                    control.BackColor = Color.FromArgb(Math.Abs(255 - MainColor.R), Math.Abs(255 - MainColor.G), Math.Abs(255 - MainColor.B));
                }
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
