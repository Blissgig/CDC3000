using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CDC_3000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class TimerData
    {
        public Int16 Hours = 0;
        public Int16 Minutes = 0;
        public Int16 Seconds = 0;
        public bool FullScreen = false;
        public bool Animate = false;
        public System.Drawing.Color BackgroundColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);  //Default: Black
        public System.Drawing.Color ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255, 255); //Default: White
        public System.Drawing.Font TimerFont = new System.Drawing.Font("Ariel", 50);
        public string EndMessage = "";
    }



    public partial class MainWindow : Window
    {
        private TimerData mCurrentData;
        private DispatcherTimer mClockTimer = null; 
        public MainWindow()
        {
            InitializeComponent();
        }

        public void StartTime(TimerData CurrentData)
        {
            try
            {
                mCurrentData = CurrentData;

                //Set Colors
                this.TimerGrid.Background = new SolidColorBrush(Color.FromArgb(CurrentData.BackgroundColor.A, CurrentData.BackgroundColor.R, CurrentData.BackgroundColor.G, CurrentData.BackgroundColor.B));
                this.Hours.Foreground = new SolidColorBrush(Color.FromArgb(CurrentData.ForegroundColor.A, CurrentData.ForegroundColor.R, CurrentData.ForegroundColor.G, CurrentData.ForegroundColor.B));
                this.Minutes.Foreground = new SolidColorBrush(Color.FromArgb(CurrentData.ForegroundColor.A, CurrentData.ForegroundColor.R, CurrentData.ForegroundColor.G, CurrentData.ForegroundColor.B));
                this.Seconds.Foreground = new SolidColorBrush(Color.FromArgb(CurrentData.ForegroundColor.A, CurrentData.ForegroundColor.R, CurrentData.ForegroundColor.G, CurrentData.ForegroundColor.B));

                //Set Font
                this.Hours.FontFamily = new FontFamily(mCurrentData.TimerFont.Name);

                this.Minutes.FontFamily = new FontFamily(mCurrentData.TimerFont.Name);
                this.Minutes.Text = mCurrentData.Minutes.ToString("00:");

                this.Seconds.FontFamily = new FontFamily(mCurrentData.TimerFont.Name);
                this.Seconds.Text = mCurrentData.Seconds.ToString("00");

                //Reset Column Width
                GridLengthConverter myGridLengthConverter = new GridLengthConverter();
                GridLength gl = (GridLength)myGridLengthConverter.ConvertFromString("*");
                this.HourColumn.Width = gl;
                this.SecondsColumn.Width = gl;

                if (mCurrentData.FullScreen == true)
                {
                    this.WindowStyle = System.Windows.WindowStyle.None;
                    this.WindowState = System.Windows.WindowState.Maximized;
                }
                else
                {
                    this.WindowStyle = System.Windows.WindowStyle.ToolWindow;
                }

                this.Cursor = Cursors.None;

                DisplayTime();

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }
        
        private void DisplayTime()
        {
            try
            { 
                if (mClockTimer != null)
                {
                    mClockTimer.Stop();
                    mClockTimer = null;
                }

                if (mCurrentData.Hours > 0)
                {
                    if (mCurrentData.Animate == true)
                    {

                    }
                    else
                    {
                        this.Hours.Text = mCurrentData.Hours.ToString("00:");
                        this.Minutes.Text = mCurrentData.Minutes.ToString("00:");
                        this.Seconds.Text = mCurrentData.Seconds.ToString("00 ");
                    }
                }
                else
                {
                    //Only Minutes and Seconds
                    GridLengthConverter myGridLengthConverter = new GridLengthConverter();
                    GridLength gl = (GridLength)myGridLengthConverter.ConvertFromString("0");
                    this.HourColumn.Width = gl;
                    this.Hours.Text = "";

                    if (mCurrentData.Animate == true)
                    {
                        Storyboard sbSecondsOut = new Storyboard();
                        DoubleAnimation animSecondsOut = new DoubleAnimation();
                        animSecondsOut.From = 1.0;
                        animSecondsOut.To = 0.0;
                        animSecondsOut.Duration = new TimeSpan(0, 0, 0, 0, 200);
                        Storyboard.SetTarget(animSecondsOut, this.Seconds);
                        Storyboard.SetTargetProperty(animSecondsOut, new PropertyPath(TextBlock.OpacityProperty));
                        sbSecondsOut.Children.Add(animSecondsOut);
                        sbSecondsOut.Completed +=
                               (sndr, evtArgs) =>
                               {
                                   this.Minutes.Text = mCurrentData.Minutes.ToString("00:");
                                   this.Seconds.Text = mCurrentData.Seconds.ToString("00 ");

                                   Storyboard sbSecondIn = new Storyboard();
                                   DoubleAnimation animSecondsIn = new DoubleAnimation();
                                   animSecondsIn.From = 0.0;
                                   animSecondsIn.To = 1.0;
                                   animSecondsIn.Duration = new TimeSpan(0, 0, 0, 0, 200);
                                   Storyboard.SetTarget(animSecondsIn, this.Seconds);
                                   Storyboard.SetTargetProperty(animSecondsIn, new PropertyPath(TextBlock.OpacityProperty));
                                   sbSecondIn.Children.Add(animSecondsIn);
                                   sbSecondIn.Begin();
                               };
                        sbSecondsOut.Begin();
                    }
                    else
                    {
                        this.Minutes.Text = mCurrentData.Minutes.ToString("00:");
                        this.Seconds.Text = mCurrentData.Seconds.ToString("00 ");
                    }
                }


                //Subtract Values:
                mCurrentData.Seconds -= 1;

                if (mCurrentData.Seconds < 0)
                {
                    mCurrentData.Minutes -= 1;
                    mCurrentData.Seconds = 59;
                }

                if (mCurrentData.Minutes < 0)
                {
                    mCurrentData.Minutes = 59;
                    mCurrentData.Hours -= 1;
                }
                
                if (mCurrentData.Hours == 0 && mCurrentData.Minutes == 0 && mCurrentData.Seconds == 0)
                {
                    this.Seconds.Text = "";
                    this.Minutes.Text = mCurrentData.EndMessage;

                    GridLengthConverter myGridLengthConverter = new GridLengthConverter();
                    GridLength gl = (GridLength)myGridLengthConverter.ConvertFromString("0");
                    this.SecondsColumn.Width = gl;

                    this.Cursor = Cursors.Arrow;
                }
                else
                {
                    mClockTimer = new DispatcherTimer();
                    mClockTimer.Interval = TimeSpan.FromSeconds(1);
                    mClockTimer.Tick += new EventHandler(Clock_Tick);
                    mClockTimer.Start();
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void Clock_Tick(object sender, object args)
        {
            DisplayTime();
        }

        private void BackgroundSelected(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    //What should this do?
                }
                else
                {
                    //Right button, Settings
                    Settings dlgSettings = new Settings(this);                    
                }

            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void LogException(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
