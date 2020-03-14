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
    /// Implements the CoursePoint profile message.
    /// </summary>
    public class CoursePointMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="CoursePointMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Timestamp = 1;
            public const byte PositionLat = 2;
            public const byte PositionLong = 3;
            public const byte Distance = 4;
            public const byte Type = 5;
            public const byte Name = 6;
            public const byte Favorite = 8;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public CoursePointMesg() : base(Profile.GetMesg(MesgNum.CoursePoint))
        {
        }

        public CoursePointMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Timestamp field</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return TimestampToDateTime(Convert.ToUInt32(val));
            
        }

        /// <summary>
        /// Set Timestamp field</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(1, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PositionLat field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the PositionLat field</returns>
        public int? GetPositionLat()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt32(val));
            
        }

        /// <summary>
        /// Set PositionLat field
        /// Units: semicircles</summary>
        /// <param name="positionLat_">Nullable field value to be set</param>
        public void SetPositionLat(int? positionLat_)
        {
            SetFieldValue(2, 0, positionLat_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the PositionLong field
        /// Units: semicircles</summary>
        /// <returns>Returns nullable int representing the PositionLong field</returns>
        public int? GetPositionLong()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt32(val));
            
        }

        /// <summary>
        /// Set PositionLong field
        /// Units: semicircles</summary>
        /// <param name="positionLong_">Nullable field value to be set</param>
        public void SetPositionLong(int? positionLong_)
        {
            SetFieldValue(3, 0, positionLong_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Distance field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Distance field</returns>
        public float? GetDistance()
        {
            Object val = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Distance field
        /// Units: m</summary>
        /// <param name="distance_">Nullable field value to be set</param>
        public void SetDistance(float? distance_)
        {
            SetFieldValue(4, 0, distance_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Type field</summary>
        /// <returns>Returns nullable CoursePoint enum representing the Type field</returns>
        new public CoursePoint? GetType()
        {
            object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            CoursePoint? value = obj == null ? (CoursePoint?)null : (CoursePoint)obj;
            return value;
        }

        /// <summary>
        /// Set Type field</summary>
        /// <param name="type_">Nullable field value to be set</param>
        public void SetType(CoursePoint? type_)
        {
            SetFieldValue(5, 0, type_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns byte[] representing the Name field</returns>
        public byte[] GetName()
        {
            byte[] data = (byte[])GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns String representing the Name field</returns>
        public String GetNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Name field</summary>
        /// <param name="name_"> field value to be set</param>
        public void SetName(String name_)
        {
            byte[] data = Encoding.UTF8.GetBytes(name_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(6, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Name field</summary>
        /// <param name="name_">field value to be set</param>
        public void SetName(byte[] name_)
        {
            SetFieldValue(6, 0, name_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Favorite field</summary>
        /// <returns>Returns nullable Bool enum representing the Favorite field</returns>
        public Bool? GetFavorite()
        {
            object obj = GetFieldValue(8, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Favorite field</summary>
        /// <param name="favorite_">Nullable field value to be set</param>
        public void SetFavorite(Bool? favorite_)
        {
            SetFieldValue(8, 0, favorite_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
