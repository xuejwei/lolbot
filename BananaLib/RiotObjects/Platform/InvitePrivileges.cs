﻿// Decompiled with JetBrains decompiler
// Type: BananaLib.RiotObjects.Platform.InvitePrivileges
// Assembly: BananaLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75213AF3-E339-4AEB-B3FE-095F85BC5F53
// Assembly location: C:\Users\Hesa\Desktop\eZ\BananaLib.dll

using RtmpSharp.IO;
using System;

namespace BananaLib.RiotObjects.Platform
{
  [SerializedName("com.riotgames.platform.gameinvite.contract.InvitePrivileges")]
  [Serializable]
  public class InvitePrivileges
  {
    [SerializedName("canInvite")]
    public bool canInvite { get; set; }
  }
}
