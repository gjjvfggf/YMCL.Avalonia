﻿using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using YMCL.Main.Views.Main;

namespace YMCL.Main.Public
{
    internal class Const
    {
        public class Window
        {
            public static MainWindow main = new MainWindow();
        }
        public static Platform Platform { get; set; }
        public static string AppTitle { get; } = "Yu Minecraft Launcher";
        public static WindowNotificationManager notification { get; set; }
        public static string UserDataRootPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DaiYu.Platform.YMCL");
        public static string SettingDataPath { get; } = Path.Combine(UserDataRootPath, "YMCL.Setting.DaiYu");
        public static string MinecraftFolderDataPath { get; } = Path.Combine(UserDataRootPath, "YMCL.MinecraftFolder.DaiYu");
    }
}
