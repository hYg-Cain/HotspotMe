﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotspotMe
{
    class hotSpotlogic
    {
        string argument;


        private ProcessStartInfo getstartInfo(string _argument)
        {

            var p = new ProcessStartInfo();
            p.WindowStyle = ProcessWindowStyle.Normal;

            p.UseShellExecute = true;
            p.WorkingDirectory = @"C:\Windows\System32";

            p.FileName = @"C:\Windows\System32\cmd.exe";
            p.Verb = "runas";
            p.Arguments = _argument;
            return p;
        }

        public void sethotspot(string _ssid, string _password, bool _presitent)
        {
            try
            {
                Properties.Settings.Default.userssID = _ssid;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            if (_password == null || _password == "")
            {

                if (MessageBox.Show("Ich würde ein Passwort empfehlen.\nTrotzdem fortfahren?", "Sicherheitsmeldung?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //do no stuff
                }
                else
                {
                    try
                    {
                        Properties.Settings.Default.userpassword = "";

                        if (_presitent == false)
                        {
                            argument = "/c netsh wlan set hostednetwork mode=allow ssid= " + Properties.Settings.Default.userssID + " key=" + Properties.Settings.Default.userpassword + " keyUsage=temporaray";
                        }
                        else
                        {
                            argument = "/c netsh wlan set hostednetwork mode=allow ssid= " + Properties.Settings.Default.userssID + " key=" + Properties.Settings.Default.userpassword + " keyUsage=persistent";
                        }

                        Process.Start(getstartInfo(argument));

                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                }
            }
            else
            {
                Properties.Settings.Default.userpassword = _password;

                if (_presitent == false)
                {
                    argument = "/c netsh wlan set hostednetwork mode=allow ssid=" + Properties.Settings.Default.userssID + " key=" + Properties.Settings.Default.userpassword + " keyUsage=temporaray";
                }
                else
                {
                    argument = "/c netsh wlan set hostednetwork mode=allow ssid=" + Properties.Settings.Default.userssID + " key=" + Properties.Settings.Default.userpassword + " keyUsage=persistent";
                }

                try
                {
                    Process.Start(getstartInfo(argument));
                }
                catch (Exception) { permissionDenied pd = new permissionDenied("set"); pd.ShowDialog(); }

                
            }

        }

        public void starthotspot()
        {
            try
            {
                string argument = "/c netsh wlan start hostednetwork";
                Process.Start(getstartInfo(argument));
            }
            catch (Exception) { permissionDenied pd = new permissionDenied("started"); pd.ShowDialog(); }

        }

        public void stophotspot()
        {
            try
            {
                string argument = "/c netsh wlan stop hostednetwork";
                Process.Start(getstartInfo(argument));
            }
            catch (Exception) { permissionDenied pd = new permissionDenied("stopped"); pd.ShowDialog(); }

        }

    }
}

