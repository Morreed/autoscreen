﻿//-----------------------------------------------------------------------
// <copyright file="Tag.cs" company="Gavin Kendall">
//     Copyright (c) Gavin Kendall. All rights reserved.
// </copyright>
// <author>Gavin Kendall</author>
// <summary>A class representing a tag.</summary>
//-----------------------------------------------------------------------
using System;

namespace AutoScreenCapture
{
    /// <summary>
    /// 
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TagType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DateTimeFormatValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeOfDayMorningStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeOfDayMorningEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeOfDayAfternoonStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeOfDayAfternoonEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeOfDayEveningStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TimeOfDayEveningEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TimeOfDayMorningValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TimeOfDayAfternoonValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TimeOfDayEveningValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool EveningExtendsToNextMorning { get; set; }

        private void SetDefaultValues()
        {
            DateTimeFormatValue = MacroParser.DateFormat + "_" + MacroParser.TimeFormatForWindows;

            // Morning
            TimeOfDayMorningStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0); // 12am
            TimeOfDayMorningEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 59, 59); // 11:59:59am
            TimeOfDayMorningValue = "morning at %hour%-%minute%-%second%";

            // Afternoon
            TimeOfDayAfternoonStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0); // 12pm
            TimeOfDayAfternoonEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 59, 59); // 5:59:59pm
            TimeOfDayAfternoonValue = "afternoon at %hour%-%minute%-%second%";

            // Evening
            TimeOfDayEveningStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0); // 6pm
            TimeOfDayEveningEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59); // 11:59:59pm
            TimeOfDayEveningValue = "evening at %hour%-%minute%-%second%";

            EveningExtendsToNextMorning = false;

            Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tag()
        {
            SetDefaultValues();
        }

        public Tag(string name, TagType tagType, bool enabled)
        {
            SetDefaultValues();

            Name = name;
            Type = tagType;
            Enabled = enabled;
        }

        public Tag(string name, TagType tagType, string dateTimeFormatValue, bool enabled)
        {
            SetDefaultValues();

            Name = name;
            Type = tagType;
            DateTimeFormatValue = dateTimeFormatValue;
            Enabled = enabled;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tagType"></param>
        /// <param name="timeOfDayMorningStart"></param>
        /// <param name="timeOfDayMorningEnd"></param>
        /// <param name="timeOfDayMorningValue"></param>
        /// <param name="timeOfDayAfternoonStart"></param>
        /// <param name="timeOfDayAfternoonEnd"></param>
        /// <param name="timeOfDayAfternoonValue"></param>
        /// <param name="timeOfDayEveningStart"></param>
        /// <param name="timeOfDayEveningEnd"></param>
        /// <param name="timeOfDayEveningValue"></param>
        /// <param name="eveningExtendsToNextMorning</param>
        public Tag(string name, TagType tagType,
            string dateTimeFormatValue,
            DateTime timeOfDayMorningStart,
            DateTime timeOfDayMorningEnd,
            string timeOfDayMorningValue,
            DateTime timeOfDayAfternoonStart,
            DateTime timeOfDayAfternoonEnd,
            string timeOfDayAfternoonValue,
            DateTime timeOfDayEveningStart,
            DateTime timeOfDayEveningEnd,
            string timeOfDayEveningValue,
            bool eveningExtendsToNextMorning,
            bool enabled)
        {
            Name = name;
            Type = tagType;

            DateTimeFormatValue = dateTimeFormatValue;

            TimeOfDayMorningStart = timeOfDayMorningStart;
            TimeOfDayMorningEnd = timeOfDayMorningEnd;

            TimeOfDayAfternoonStart = timeOfDayAfternoonStart;
            TimeOfDayAfternoonEnd = timeOfDayAfternoonEnd;

            TimeOfDayEveningStart = timeOfDayEveningStart;
            TimeOfDayEveningEnd = timeOfDayEveningEnd;

            TimeOfDayMorningValue = timeOfDayMorningValue;
            TimeOfDayAfternoonValue = timeOfDayAfternoonValue;
            TimeOfDayEveningValue = timeOfDayEveningValue;

            EveningExtendsToNextMorning = eveningExtendsToNextMorning;

            Enabled = enabled;
        }
    }
}
