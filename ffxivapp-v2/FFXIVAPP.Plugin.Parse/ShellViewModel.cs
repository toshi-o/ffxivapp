﻿// FFXIVAPP.Plugin.Parse
// ShellViewModel.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FFXIVAPP.Plugin.Parse
{
    public sealed class ShellViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static ShellViewModel _instance;

        public static ShellViewModel Instance
        {
            get { return _instance ?? (_instance = new ShellViewModel()); }
        }

        #endregion

        #region Declarations

        #endregion

        public ShellViewModel()
        {
            Initializer.LoadSettings();
        }

        internal static void Loaded(object sender, RoutedEventArgs e)
        {
            Initializer.ApplyTheming();
            PluginViewModel.Instance.MemoryHandler = Plugin.PHost.MemoryHandler();
        }

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Command Bindings

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}