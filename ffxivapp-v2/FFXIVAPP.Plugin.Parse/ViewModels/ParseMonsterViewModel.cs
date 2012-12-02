﻿// FFXIVAPP.Plugin.Parse
// ParseMonsterViewModel.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FFXIVAPP.Plugin.Parse.ViewModels
{
    internal sealed class ParseMonsterViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static ParseMonsterViewModel _instance;

        public static ParseMonsterViewModel Instance
        {
            get { return _instance ?? (_instance = new ParseMonsterViewModel()); }
        }

        #endregion

        #region Declarations

        #endregion

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