﻿// Decompiled with JetBrains decompiler
// Type: RtmpSharp.Net.ChunkMessageHeaderType
// Assembly: rtmp-sharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8588136F-A4B9-4004-9712-4EA13AA4AF9D
// Assembly location: C:\Users\Hesa\Desktop\eZ_Source\bin\Debug\rtmp-sharp.dll

namespace RtmpSharp.Net
{
  internal enum ChunkMessageHeaderType : byte
  {
    New,
    SameSource,
    TimestampAdjustment,
    Continuation,
  }
}
