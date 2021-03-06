﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PomodoroWP
{
    public partial class GetNewTask : PhoneApplicationPage
    {
        public GetNewTask()
        {
            InitializeComponent();
            OK.Click += new RoutedEventHandler( Button_Click );
            Cancel.Click += new RoutedEventHandler( Button_Click );
        }

        void Button_Click( object sender, RoutedEventArgs e )
        {
            Button btn = sender as Button;
            string msg = string.Empty;
            if (btn.Name == "OK")
            {
                msg = NewTask.Text;
            }
            NavigationService.Navigate( new Uri( "/MainPage.xaml?NewTask=" + msg, UriKind.Relative ) );
            
        }


    }
}