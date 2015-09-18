using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDC_3000
{
    public partial class Settings : Form
    {
        public MainWindow mMain;
        private TimerData CurrentData = new TimerData();

        public Settings()
        {
            InitializeComponent();
        }

        public Settings(MainWindow Main)
        {
            InitializeComponent();

            mMain = Main;
            this.ShowDialog();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            try
            {
                mMain.StartTime(CurrentData);
                this.Close();
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog dlgFonts = new FontDialog();

                dlgFonts.ShowColor = false;
                dlgFonts.ShowEffects = false;
                dlgFonts.ShowApply = false;

                if (dlgFonts.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CurrentData.TimerFont = dlgFonts.Font;
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void cmdForecolor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog dlgColors = new ColorDialog();

                if (dlgColors.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CurrentData.ForegroundColor = dlgColors.Color;
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void cmdBackgroundColor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog dlgColors = new ColorDialog();
                
                if (dlgColors.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CurrentData.BackgroundColor = dlgColors.Color;
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void udHours_ValueChanged(object sender, EventArgs e)
        {
            CurrentData.Hours = Convert.ToByte(udHours.Value);
        }

        private void udMinutes_ValueChanged(object sender, EventArgs e)
        {
            CurrentData.Minutes = Convert.ToByte(udMinutes.Value);
        }

        private void udSeconds_ValueChanged(object sender, EventArgs e)
        {
            CurrentData.Seconds = Convert.ToByte(udSeconds.Value);
        }

        private void txtEndMessage_TextChanged(object sender, EventArgs e)
        {
            CurrentData.EndMessage = txtEndMessage.Text;
        }

        private void chkFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            CurrentData.FullScreen = chkFullScreen.Checked;
        }

        private void chkAnimate_CheckedChanged(object sender, EventArgs e)
        {
            CurrentData.Animate = chkAnimate.Checked;
        }

        private void LogException(Exception ex)
        {
            Console.WriteLine("Settings Error: " + ex.Message);
        }
    }
}
