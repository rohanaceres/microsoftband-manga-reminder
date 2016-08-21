﻿using RedBeard.App.Job;
using System.Windows;

namespace RedBeard.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            PaniniCrawlerJob.Run(10);
        }
    }
}