﻿//-----------------------------------------------------------------------
// <copyright file="DefaultSettings.cs" company="Gavin Kendall">
//     Copyright (c) 2020 Gavin Kendall
// </copyright>
// <author>Gavin Kendall</author>
// <summary>The default application settings and default user settings are defined here.</summary>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.
//-----------------------------------------------------------------------
using System;
using System.Reflection;

namespace AutoScreenCapture
{
    /// <summary>
    /// The default settings for the application and the user.
    /// </summary>
    public static class DefaultSettings
    {
        /// <summary>
        /// The name of this application.
        /// </summary>
        public static readonly string ApplicationName = "Auto Screen Capture";

        /// <summary>
        /// The version of this application. This is acquired from the application's assembly.
        /// </summary>
        public static readonly string ApplicationVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        // Default application settings.
        internal static readonly bool DebugMode = false;
        internal static readonly bool ExitOnError = false;
        internal static readonly bool Logging = false;
        internal static readonly string EmailServerHost = "smtp.office365.com";
        internal static readonly int EmailServerPort = 587;
        internal static readonly bool EmailServerEnableSSL = true;
        internal static readonly string EmailClientUsername = string.Empty;
        internal static readonly string EmailClientPassword = string.Empty;
        internal static readonly string EmailMessageFrom = string.Empty;
        internal static readonly string EmailMessageTo = string.Empty;
        internal static readonly string EmailMessageCC = string.Empty;
        internal static readonly string EmailMessageBCC = string.Empty;
        internal static readonly string EmailMessageSubject = string.Empty;
        internal static readonly string EmailMessageBody = string.Empty;
        internal static readonly bool EmailPrompt = true;
        internal static readonly int LowDiskPercentageThreshold = 1;
        internal static readonly int ScreenshotsLoadLimit = 5000;
        internal static readonly bool AutoStartFromCommandLine = false;
        internal static readonly bool ShowStartupError = true;
        internal static readonly int FilepathLengthLimit = 2000;
        internal static readonly bool StopOnLowDiskError = true;

        // Default user settings.
        internal static readonly int IntScreenCaptureInterval = 60000;
        internal static readonly int IntCaptureLimit = 0;
        internal static readonly bool BoolCaptureLimit = false;
        internal static readonly bool BoolTakeInitialScreenshot = false;
        internal static readonly bool BoolShowSystemTrayIcon = true;
        internal static readonly string StringPassphrase = string.Empty;
        internal static readonly int IntKeepScreenshotsForDays = 30;
        internal static readonly string StringScreenshotLabel = string.Empty;
        internal static readonly bool BoolApplyScreenshotLabel = false;
        internal static readonly string StringDefaultEditor = string.Empty;
        internal static readonly bool BoolFirstRun = true;
        internal static readonly int IntStartScreenCaptureCount = 0;
        internal static readonly bool BoolActiveWindowTitleCaptureCheck = false;
        internal static readonly string StringActiveWindowTitleCaptureText = string.Empty;
        internal static readonly bool BoolUseKeyboardShortcuts = false;
        internal static readonly string StringKeyboardShortcutStartScreenCaptureModifier1 = "Control";
        internal static readonly string StringKeyboardShortcutStartScreenCaptureModifier2 = "Alt";
        internal static readonly string StringKeyboardShortcutStartScreenCaptureKey = "Z";
        internal static readonly string StringKeyboardShortcutStopScreenCaptureModifier1 = "Control";
        internal static readonly string StringKeyboardShortcutStopScreenCaptureModifier2 = "Alt";
        internal static readonly string StringKeyboardShortcutStopScreenCaptureKey = "X";
        internal static readonly string StringKeyboardShortcutCaptureNowArchiveModifier1 = "Control";
        internal static readonly string StringKeyboardShortcutCaptureNowArchiveModifier2 = "Alt";
        internal static readonly string StringKeyboardShortcutCaptureNowArchiveKey = "A";
        internal static readonly string StringKeyboardShortcutCaptureNowEditModifier1 = "Control";
        internal static readonly string StringKeyboardShortcutCaptureNowEditModifier2 = "Alt";
        internal static readonly string StringKeyboardShortcutCaptureNowEditKey = "E";
        internal static readonly string StringKeyboardShortcutRegionSelectClipboardModifier1 = "Control";
        internal static readonly string StringKeyboardShortcutRegionSelectClipboardModifier2 = "Alt";
        internal static readonly string StringKeyboardShortcutRegionSelectClipboardKey = "S";

        // Old default user settings.
        internal static readonly bool BoolCaptureStartAt = false;
        internal static readonly bool BoolCaptureStopAt = false;
        internal static readonly DateTime DateTimeCaptureStartAt = DateTime.Now;
        internal static readonly DateTime DateTimeCaptureStopAt = DateTime.Now;
        internal static readonly bool BoolCaptureOnTheseDays = false;
        internal static readonly bool BoolCaptureOnSunday = false;
        internal static readonly bool BoolCaptureOnMonday = false;
        internal static readonly bool BoolCaptureOnTuesday = false;
        internal static readonly bool BoolCaptureOnWednesday = false;
        internal static readonly bool BoolCaptureOnThursday = false;
        internal static readonly bool BoolCaptureOnFriday = false;
        internal static readonly bool BoolCaptureOnSaturday = false;
    }
}
