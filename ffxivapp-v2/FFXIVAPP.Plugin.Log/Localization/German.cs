﻿// FFXIVAPP.Plugin.Log
// German.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

using System.Windows;

namespace FFXIVAPP.Plugin.Log.Localization
{
    public abstract class German
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("loc_", "*PH*");
            return Dictionary;
        }
    }
}