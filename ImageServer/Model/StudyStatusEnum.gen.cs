#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Collections.Generic;
    using ClearCanvas.ImageServer.Model.EntityBrokers;
    using ClearCanvas.ImageServer.Enterprise;
    using System.Reflection;

[Serializable]
public partial class StudyStatusEnum : ServerEnum
{
      #region Private Static Members
      private static readonly StudyStatusEnum _Online = GetEnum("Online");
      private static readonly StudyStatusEnum _OnlineLossless = GetEnum("OnlineLossless");
      private static readonly StudyStatusEnum _OnlineLossy = GetEnum("OnlineLossy");
      private static readonly StudyStatusEnum _Nearline = GetEnum("Nearline");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// Study is online
      /// </summary>
      public static StudyStatusEnum Online
      {
          get { return _Online; }
      }
      /// <summary>
      /// Study is online and lossless compressed
      /// </summary>
      public static StudyStatusEnum OnlineLossless
      {
          get { return _OnlineLossless; }
      }
      /// <summary>
      /// Study is online and lossy compressed
      /// </summary>
      public static StudyStatusEnum OnlineLossy
      {
          get { return _OnlineLossy; }
      }
      /// <summary>
      /// The study is nearline (in an automated library)
      /// </summary>
      public static StudyStatusEnum Nearline
      {
          get { return _Nearline; }
      }

      #endregion

      #region Constructors
      public StudyStatusEnum():base("StudyStatusEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<StudyStatusEnum, IStudyStatusEnumBroker>.SetEnum(this, val);
      }
      static public List<StudyStatusEnum> GetAll()
      {
          return ServerEnumHelper<StudyStatusEnum, IStudyStatusEnumBroker>.GetAll();
      }
      static public StudyStatusEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<StudyStatusEnum, IStudyStatusEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}