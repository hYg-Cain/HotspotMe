﻿using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using System.Windows.Threading;

namespace HotspotMe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        private DateTime _startTime = DateTime.MinValue;
        DispatcherTimer _timer = new DispatcherTimer();
        hotSpotlogic hl = new hotSpotlogic();
        NetworkTraffic nt;
        JumpThings jt = new JumpThings();
        JumpList jList = new JumpList();

        System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();

        public MainWindow()
        {
            InitializeComponent();
            /*------------------Generate + Set JumpList------------------*/
            JumpList.SetJumpList(System.Windows.Application.Current, jt.creatList());

            /*------------------Start Netwrok Monitor------------------*/
            startnetworktraffic();            
            
            nt = new NetworkTraffic();

            /*------------------Load usersettings------------------*/
            #region
            txt_ssid.Text = Properties.Settings.Default.userssID;
            txt_password.Password = Properties.Settings.Default.userpassword;
            txt_confirmpassword.Password = Properties.Settings.Default.userpassword;
            loadtheme();          
            #endregion
            /*------------------Static Path for the GIF. Somehow doesn't work dynamically------------------*/
            #region
            Uri path = new Uri(Directory.GetCurrentDirectory() + "/WLAN.gif");
            mE_wlangif.Source = path;
            #endregion

            /*------------------ Hiding in Sysbar------------------*/
            #region
            ni.Icon = new System.Drawing.Icon(Directory.GetCurrentDirectory() +"/Icon.ico");
            ni.Visible = true;
            ni.MouseDown += new System.Windows.Forms.MouseEventHandler(mousedown);
            ni.DoubleClick +=
                delegate (object sender, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                };


            #endregion
        }

        private void mousedown(object sender , System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
           {
                //Here Show JumpList
            }
        }
        #region hotspot
        private void btn_setHotspot_Click(object sender, RoutedEventArgs e)
        {
            if (txt_ssid.Text != null && txt_ssid.Text != "")
            {
                if (txt_password.Password != txt_confirmpassword.Password)
                {
                    System.Windows.Forms.MessageBox.Show("Die Passwörter stimmen nicht überein");
                }
                else if(txt_password.Password.Length < 8)
                {
                    System.Windows.Forms.MessageBox.Show("Das Passwort muss mindestens 8 Zeichen lang sein");
                }
               else
                {
                    hl.sethotspot(txt_ssid.Text, txt_password.Password,cb_persistent.IsChecked.Value);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Bitte geben Sie eine gültige SSID(Netzwerkname) an.");
            }

        }

        private void btn_startHotspot_Click(object sender, RoutedEventArgs e)
        {
            hl.starthotspot();
            mE_wlangif.Visibility = Visibility.Visible;            

        }

        private void btn_stopHotspot_Click(object sender, RoutedEventArgs e)
        {
            hl.stophotspot();
            mE_wlangif.Visibility = Visibility.Hidden;
        }
        #endregion

        #region networktraffic
        private void startnetworktraffic()
        {
            _timer.Start();
            _timer.Tick += new EventHandler(tickevent);
        }

        private void tickevent(object sender, EventArgs e)
        {
            UserSettings.GetterSetter gs = new UserSettings.GetterSetter();
            lbl_monitor.Content = nt.getConnectionInfo(gs.networkindex);
        }
        #endregion

        #region hover in/out
        private void MouseHoverEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try { (sender as Canvas).Background = Brushes.LightBlue; }
            catch (Exception) { }
        }

        private void MouseHoverLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            try { (sender as Canvas).Background = Brushes.White; }
            catch (Exception) { }
        }
        #endregion

        #region Bullshittery
        private void loadtheme()
        {
            if (Properties.Settings.Default.Theme == "dark")
            {
                AppearanceManager.Current.ThemeSource = AppearanceManager.DarkThemeSource;
            }
            else
            {
                AppearanceManager.Current.ThemeSource = AppearanceManager.LightThemeSource;
            }
        }

        private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            mE_wlangif.Position = new TimeSpan(0, 0, 1);
            mE_wlangif.Play();
        }

        private void Explanation_Click(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("If not checked device needs to login with password everytime");
        }

        private void txt_confirmpassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txt_password.Password != txt_confirmpassword.Password)
            {
                txt_confirmpassword.BorderBrush = Brushes.Red;
            }
            else
            {
                txt_confirmpassword.BorderBrush = Brushes.LightGreen;
            }
        }
        #endregion

        /// <summary>
        /// Opens Settings Window as Dialog --> Disable Mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settings_Click(object sender, RoutedEventArgs e)
        {
            UserSettings.UserSettingsView usv = new UserSettings.UserSettingsView();
            usv.ShowDialog();
        }
        /// <summary>
        /// Save Usersettings when window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModernWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UserSettings.GetterSetter gs = new UserSettings.GetterSetter();
            if (Properties.Settings.Default.dontShowAgain == false)
            {
                UserSettings.ClosingWindow cw = new UserSettings.ClosingWindow(gs);
                cw.ShowDialog();

                if (gs.save == true && gs.cancel == false)
                {
                    Properties.Settings.Default.Save();
                    ni.Icon = null;
                }
                else if (gs.cancel == true)
                {
                    e.Cancel = true;
                }
                else
                {
                    ni.Icon = null;
                }                
            }
            else 
            {
                if (Properties.Settings.Default.saveAlways == true)
                {
                    Properties.Settings.Default.Save();
                }
                ni.Icon = null;

            }


        }

        private void btn_help_Click(object sender, RoutedEventArgs e)
        {
            Help helpwindow = new Help();
            helpwindow.ShowDialog();
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
            {
                //this.Hide();
            }
                
            
            base.OnStateChanged(e);
        }    


    }
}
