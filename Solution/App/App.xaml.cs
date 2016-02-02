﻿using Windows.ApplicationModel.Activation;
using App.Infrastructure;
using App.ViewModels;

namespace App
{
    /// <summary>
    ///     Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App
    {
        private readonly UWPBootstrapper _bootstrapper;

        /// <summary>
        ///     Initializes the singleton application object.  This is the first line of authored code
        ///     executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            this._bootstrapper = new UWPBootstrapper(this.DisplayRootViewFor<ShellViewModel>);
        }

        /// <summary>
        ///     Invoked when the application is launched normally by the end user.  Other entry points
        ///     will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">
        ///     Details about the launch request and process.
        /// </param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            this._bootstrapper.Run(e);
        }
    }
}