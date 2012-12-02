﻿// FFXIVAPP.Client
// ThemeHelper.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

using System;
using System.Linq;
using FFXIVAPP.Common.Utilities;
using MahApps.Metro;
using NLog;
using ThemeManager = FFXIVAPP.Client.Utilities.ThemeManager;

namespace FFXIVAPP.Client.Helpers
{
    internal static class ThemeHelper
    {
        /// <summary>
        /// </summary>
        /// <param name="t"> </param>
        public static void ChangeTheme(string t)
        {
            try
            {
                var split = t.Split('|');
                var accent = split[0];
                var theme = split[1];
                switch (theme)
                {
                    case "Dark":
                        ThemeManager.ChangeTheme(ShellView.View, ThemeManager.DefaultAccents.First(a => a.Name == accent), Theme.Dark);
                        break;
                    case "Light":
                        ThemeManager.ChangeTheme(ShellView.View, ThemeManager.DefaultAccents.First(a => a.Name == accent), Theme.Light);
                        break;
                }
            }
            catch (Exception ex)
            {
                //Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
            }
        }
    }
}