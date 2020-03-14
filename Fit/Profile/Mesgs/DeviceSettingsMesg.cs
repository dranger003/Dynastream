#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2020 Garmin Canada Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.22Release
// Tag = production/akw/21.22.00-0-g5065eaa
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the DeviceSettings profile message.
    /// </summary>
    public class DeviceSettingsMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="DeviceSettingsMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte ActiveTimeZone = 0;
            public const byte UtcOffset = 1;
            public const byte TimeOffset = 2;
            public const byte TimeMode = 4;
            public const byte TimeZoneOffset = 5;
            public const byte BacklightMode = 12;
            public const byte ActivityTrackerEnabled = 36;
            public const byte ClockTime = 39;
            public const byte PagesEnabled = 40;
            public const byte MoveAlertEnabled = 46;
            public const byte DateMode = 47;
            public const byte DisplayOrientation = 55;
            public const byte MountingSide = 56;
            public const byte DefaultPage = 57;
            public const byte AutosyncMinSteps = 58;
            public const byte AutosyncMinTime = 59;
            public const byte LactateThresholdAutodetectEnabled = 80;
            public const byte BleAutoUploadEnabled = 86;
            public const byte AutoSyncFrequency = 89;
            public const byte AutoActivityDetect = 90;
            public const byte NumberOfScreens = 94;
            public const byte SmartNotificationDisplayOrientation = 95;
            public const byte TapInterface = 134;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public DeviceSettingsMesg() : base(Profile.GetMesg(MesgNum.DeviceSettings))
        {
        }

        public DeviceSettingsMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the ActiveTimeZone field
        /// Comment: Index into time zone arrays.</summary>
        /// <returns>Returns nullable byte representing the ActiveTimeZone field</returns>
        public byte? GetActiveTimeZone()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set ActiveTimeZone field
        /// Comment: Index into time zone arrays.</summary>
        /// <param name="activeTimeZone_">Nullable field value to be set</param>
        public void SetActiveTimeZone(byte? activeTimeZone_)
        {
            SetFieldValue(0, 0, activeTimeZone_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the UtcOffset field
        /// Comment: Offset from system time. Required to convert timestamp from system time to UTC.</summary>
        /// <returns>Returns nullable uint representing the UtcOffset field</returns>
        public uint? GetUtcOffset()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set UtcOffset field
        /// Comment: Offset from system time. Required to convert timestamp from system time to UTC.</summary>
        /// <param name="utcOffset_">Nullable field value to be set</param>
        public void SetUtcOffset(uint? utcOffset_)
        {
            SetFieldValue(1, 0, utcOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeOffset</returns>
        public int GetNumTimeOffset()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeOffset field
        /// Units: s
        /// Comment: Offset from system time.</summary>
        /// <param name="index">0 based index of TimeOffset element to retrieve</param>
        /// <returns>Returns nullable uint representing the TimeOffset field</returns>
        public uint? GetTimeOffset(int index)
        {
            Object val = GetFieldValue(2, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set TimeOffset field
        /// Units: s
        /// Comment: Offset from system time.</summary>
        /// <param name="index">0 based index of time_offset</param>
        /// <param name="timeOffset_">Nullable field value to be set</param>
        public void SetTimeOffset(int index, uint? timeOffset_)
        {
            SetFieldValue(2, index, timeOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeMode</returns>
        public int GetNumTimeMode()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeMode field
        /// Comment: Display mode for the time</summary>
        /// <param name="index">0 based index of TimeMode element to retrieve</param>
        /// <returns>Returns nullable TimeMode enum representing the TimeMode field</returns>
        public TimeMode? GetTimeMode(int index)
        {
            object obj = GetFieldValue(4, index, Fit.SubfieldIndexMainField);
            TimeMode? value = obj == null ? (TimeMode?)null : (TimeMode)obj;
            return value;
        }

        /// <summary>
        /// Set TimeMode field
        /// Comment: Display mode for the time</summary>
        /// <param name="index">0 based index of time_mode</param>
        /// <param name="timeMode_">Nullable field value to be set</param>
        public void SetTimeMode(int index, TimeMode? timeMode_)
        {
            SetFieldValue(4, index, timeMode_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TimeZoneOffset</returns>
        public int GetNumTimeZoneOffset()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TimeZoneOffset field
        /// Units: hr
        /// Comment: timezone offset in 1/4 hour increments</summary>
        /// <param name="index">0 based index of TimeZoneOffset element to retrieve</param>
        /// <returns>Returns nullable float representing the TimeZoneOffset field</returns>
        public float? GetTimeZoneOffset(int index)
        {
            Object val = GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set TimeZoneOffset field
        /// Units: hr
        /// Comment: timezone offset in 1/4 hour increments</summary>
        /// <param name="index">0 based index of time_zone_offset</param>
        /// <param name="timeZoneOffset_">Nullable field value to be set</param>
        public void SetTimeZoneOffset(int index, float? timeZoneOffset_)
        {
            SetFieldValue(5, index, timeZoneOffset_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BacklightMode field
        /// Comment: Mode for backlight</summary>
        /// <returns>Returns nullable BacklightMode enum representing the BacklightMode field</returns>
        public BacklightMode? GetBacklightMode()
        {
            object obj = GetFieldValue(12, 0, Fit.SubfieldIndexMainField);
            BacklightMode? value = obj == null ? (BacklightMode?)null : (BacklightMode)obj;
            return value;
        }

        /// <summary>
        /// Set BacklightMode field
        /// Comment: Mode for backlight</summary>
        /// <param name="backlightMode_">Nullable field value to be set</param>
        public void SetBacklightMode(BacklightMode? backlightMode_)
        {
            SetFieldValue(12, 0, backlightMode_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ActivityTrackerEnabled field
        /// Comment: Enabled state of the activity tracker functionality</summary>
        /// <returns>Returns nullable Bool enum representing the ActivityTrackerEnabled field</returns>
        public Bool? GetActivityTrackerEnabled()
        {
            object obj = GetFieldValue(36, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set ActivityTrackerEnabled field
        /// Comment: Enabled state of the activity tracker functionality</summary>
        /// <param name="activityTrackerEnabled_">Nullable field value to be set</param>
        public void SetActivityTrackerEnabled(Bool? activityTrackerEnabled_)
        {
            SetFieldValue(36, 0, activityTrackerEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the ClockTime field
        /// Comment: UTC timestamp used to set the devices clock and date</summary>
        /// <returns>Returns DateTime representing the ClockTime field</returns>
        public DateTime GetClockTime()
        {
            Object val = GetFieldValue(39, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set ClockTime field
        /// Comment: UTC timestamp used to set the devices clock and date</summary>
        /// <param name="clockTime_">Nullable field value to be set</param>
        public void SetClockTime(DateTime clockTime_)
        {
            SetFieldValue(39, 0, clockTime_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field PagesEnabled</returns>
        public int GetNumPagesEnabled()
        {
            return GetNumFieldValues(40, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the PagesEnabled field
        /// Comment: Bitfield  to configure enabled screens for each supported loop</summary>
        /// <param name="index">0 based index of PagesEnabled element to retrieve</param>
        /// <returns>Returns nullable ushort representing the PagesEnabled field</returns>
        public ushort? GetPagesEnabled(int index)
        {
            Object val = GetFieldValue(40, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set PagesEnabled field
        /// Comment: Bitfield  to configure enabled screens for each supported loop</summary>
        /// <param name="index">0 based index of pages_enabled</param>
        /// <param name="pagesEnabled_">Nullable field value to be set</param>
        public void SetPagesEnabled(int index, ushort? pagesEnabled_)
        {
            SetFieldValue(40, index, pagesEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MoveAlertEnabled field
        /// Comment: Enabled state of the move alert</summary>
        /// <returns>Returns nullable Bool enum representing the MoveAlertEnabled field</returns>
        public Bool? GetMoveAlertEnabled()
        {
            object obj = GetFieldValue(46, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set MoveAlertEnabled field
        /// Comment: Enabled state of the move alert</summary>
        /// <param name="moveAlertEnabled_">Nullable field value to be set</param>
        public void SetMoveAlertEnabled(Bool? moveAlertEnabled_)
        {
            SetFieldValue(46, 0, moveAlertEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DateMode field
        /// Comment: Display mode for the date</summary>
        /// <returns>Returns nullable DateMode enum representing the DateMode field</returns>
        public DateMode? GetDateMode()
        {
            object obj = GetFieldValue(47, 0, Fit.SubfieldIndexMainField);
            DateMode? value = obj == null ? (DateMode?)null : (DateMode)obj;
            return value;
        }

        /// <summary>
        /// Set DateMode field
        /// Comment: Display mode for the date</summary>
        /// <param name="dateMode_">Nullable field value to be set</param>
        public void SetDateMode(DateMode? dateMode_)
        {
            SetFieldValue(47, 0, dateMode_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the DisplayOrientation field</summary>
        /// <returns>Returns nullable DisplayOrientation enum representing the DisplayOrientation field</returns>
        public DisplayOrientation? GetDisplayOrientation()
        {
            object obj = GetFieldValue(55, 0, Fit.SubfieldIndexMainField);
            DisplayOrientation? value = obj == null ? (DisplayOrientation?)null : (DisplayOrientation)obj;
            return value;
        }

        /// <summary>
        /// Set DisplayOrientation field</summary>
        /// <param name="displayOrientation_">Nullable field value to be set</param>
        public void SetDisplayOrientation(DisplayOrientation? displayOrientation_)
        {
            SetFieldValue(55, 0, displayOrientation_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MountingSide field</summary>
        /// <returns>Returns nullable Side enum representing the MountingSide field</returns>
        public Side? GetMountingSide()
        {
            object obj = GetFieldValue(56, 0, Fit.SubfieldIndexMainField);
            Side? value = obj == null ? (Side?)null : (Side)obj;
            return value;
        }

        /// <summary>
        /// Set MountingSide field</summary>
        /// <param name="mountingSide_">Nullable field value to be set</param>
        public void SetMountingSide(Side? mountingSide_)
        {
            SetFieldValue(56, 0, mountingSide_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field DefaultPage</returns>
        public int GetNumDefaultPage()
        {
            return GetNumFieldValues(57, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the DefaultPage field
        /// Comment: Bitfield to indicate one page as default for each supported loop</summary>
        /// <param name="index">0 based index of DefaultPage element to retrieve</param>
        /// <returns>Returns nullable ushort representing the DefaultPage field</returns>
        public ushort? GetDefaultPage(int index)
        {
            Object val = GetFieldValue(57, index, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set DefaultPage field
        /// Comment: Bitfield to indicate one page as default for each supported loop</summary>
        /// <param name="index">0 based index of default_page</param>
        /// <param name="defaultPage_">Nullable field value to be set</param>
        public void SetDefaultPage(int index, ushort? defaultPage_)
        {
            SetFieldValue(57, index, defaultPage_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutosyncMinSteps field
        /// Units: steps
        /// Comment: Minimum steps before an autosync can occur</summary>
        /// <returns>Returns nullable ushort representing the AutosyncMinSteps field</returns>
        public ushort? GetAutosyncMinSteps()
        {
            Object val = GetFieldValue(58, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set AutosyncMinSteps field
        /// Units: steps
        /// Comment: Minimum steps before an autosync can occur</summary>
        /// <param name="autosyncMinSteps_">Nullable field value to be set</param>
        public void SetAutosyncMinSteps(ushort? autosyncMinSteps_)
        {
            SetFieldValue(58, 0, autosyncMinSteps_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutosyncMinTime field
        /// Units: minutes
        /// Comment: Minimum minutes before an autosync can occur</summary>
        /// <returns>Returns nullable ushort representing the AutosyncMinTime field</returns>
        public ushort? GetAutosyncMinTime()
        {
            Object val = GetFieldValue(59, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set AutosyncMinTime field
        /// Units: minutes
        /// Comment: Minimum minutes before an autosync can occur</summary>
        /// <param name="autosyncMinTime_">Nullable field value to be set</param>
        public void SetAutosyncMinTime(ushort? autosyncMinTime_)
        {
            SetFieldValue(59, 0, autosyncMinTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LactateThresholdAutodetectEnabled field
        /// Comment: Enable auto-detect setting for the lactate threshold feature.</summary>
        /// <returns>Returns nullable Bool enum representing the LactateThresholdAutodetectEnabled field</returns>
        public Bool? GetLactateThresholdAutodetectEnabled()
        {
            object obj = GetFieldValue(80, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set LactateThresholdAutodetectEnabled field
        /// Comment: Enable auto-detect setting for the lactate threshold feature.</summary>
        /// <param name="lactateThresholdAutodetectEnabled_">Nullable field value to be set</param>
        public void SetLactateThresholdAutodetectEnabled(Bool? lactateThresholdAutodetectEnabled_)
        {
            SetFieldValue(80, 0, lactateThresholdAutodetectEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the BleAutoUploadEnabled field
        /// Comment: Automatically upload using BLE</summary>
        /// <returns>Returns nullable Bool enum representing the BleAutoUploadEnabled field</returns>
        public Bool? GetBleAutoUploadEnabled()
        {
            object obj = GetFieldValue(86, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set BleAutoUploadEnabled field
        /// Comment: Automatically upload using BLE</summary>
        /// <param name="bleAutoUploadEnabled_">Nullable field value to be set</param>
        public void SetBleAutoUploadEnabled(Bool? bleAutoUploadEnabled_)
        {
            SetFieldValue(86, 0, bleAutoUploadEnabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutoSyncFrequency field
        /// Comment: Helps to conserve battery by changing modes</summary>
        /// <returns>Returns nullable AutoSyncFrequency enum representing the AutoSyncFrequency field</returns>
        public AutoSyncFrequency? GetAutoSyncFrequency()
        {
            object obj = GetFieldValue(89, 0, Fit.SubfieldIndexMainField);
            AutoSyncFrequency? value = obj == null ? (AutoSyncFrequency?)null : (AutoSyncFrequency)obj;
            return value;
        }

        /// <summary>
        /// Set AutoSyncFrequency field
        /// Comment: Helps to conserve battery by changing modes</summary>
        /// <param name="autoSyncFrequency_">Nullable field value to be set</param>
        public void SetAutoSyncFrequency(AutoSyncFrequency? autoSyncFrequency_)
        {
            SetFieldValue(89, 0, autoSyncFrequency_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AutoActivityDetect field
        /// Comment: Allows setting specific activities auto-activity detect enabled/disabled settings</summary>
        /// <returns>Returns nullable uint representing the AutoActivityDetect field</returns>
        public uint? GetAutoActivityDetect()
        {
            Object val = GetFieldValue(90, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set AutoActivityDetect field
        /// Comment: Allows setting specific activities auto-activity detect enabled/disabled settings</summary>
        /// <param name="autoActivityDetect_">Nullable field value to be set</param>
        public void SetAutoActivityDetect(uint? autoActivityDetect_)
        {
            SetFieldValue(90, 0, autoActivityDetect_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the NumberOfScreens field
        /// Comment: Number of screens configured to display</summary>
        /// <returns>Returns nullable byte representing the NumberOfScreens field</returns>
        public byte? GetNumberOfScreens()
        {
            Object val = GetFieldValue(94, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set NumberOfScreens field
        /// Comment: Number of screens configured to display</summary>
        /// <param name="numberOfScreens_">Nullable field value to be set</param>
        public void SetNumberOfScreens(byte? numberOfScreens_)
        {
            SetFieldValue(94, 0, numberOfScreens_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SmartNotificationDisplayOrientation field
        /// Comment: Smart Notification display orientation</summary>
        /// <returns>Returns nullable DisplayOrientation enum representing the SmartNotificationDisplayOrientation field</returns>
        public DisplayOrientation? GetSmartNotificationDisplayOrientation()
        {
            object obj = GetFieldValue(95, 0, Fit.SubfieldIndexMainField);
            DisplayOrientation? value = obj == null ? (DisplayOrientation?)null : (DisplayOrientation)obj;
            return value;
        }

        /// <summary>
        /// Set SmartNotificationDisplayOrientation field
        /// Comment: Smart Notification display orientation</summary>
        /// <param name="smartNotificationDisplayOrientation_">Nullable field value to be set</param>
        public void SetSmartNotificationDisplayOrientation(DisplayOrientation? smartNotificationDisplayOrientation_)
        {
            SetFieldValue(95, 0, smartNotificationDisplayOrientation_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TapInterface field</summary>
        /// <returns>Returns nullable Switch enum representing the TapInterface field</returns>
        public Switch? GetTapInterface()
        {
            object obj = GetFieldValue(134, 0, Fit.SubfieldIndexMainField);
            Switch? value = obj == null ? (Switch?)null : (Switch)obj;
            return value;
        }

        /// <summary>
        /// Set TapInterface field</summary>
        /// <param name="tapInterface_">Nullable field value to be set</param>
        public void SetTapInterface(Switch? tapInterface_)
        {
            SetFieldValue(134, 0, tapInterface_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
