﻿// FFXIVAPP.Common
// ChatEntry.cs
//  
// Created by Ryan Wilson.
// Copyright © 2007-2012 Ryan Wilson - All Rights Reserved

using System;

namespace FFXIVAPP.Common.Chat
{
    public struct ChatEntry
    {
        public DateTime TimeStamp { get; set; }
        public string Code { get; set; }
        public string Line { get; set; }
        public string Combined { get; set; }
        public string Raw { get; set; }
        public byte[] Bytes { get; set; }
        public bool JP { get; set; }
    }
}