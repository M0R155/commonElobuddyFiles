﻿// Decompiled with JetBrains decompiler
// Type: RtmpSharp.IO.AMF0.AMFWriters.Amf0XDocumentWriter
// Assembly: rtmp-sharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8588136F-A4B9-4004-9712-4EA13AA4AF9D
// Assembly location: C:\Users\Hesa\Desktop\eZ_Source\bin\Debug\rtmp-sharp.dll

using System.Xml.Linq;

namespace RtmpSharp.IO.AMF0.AMFWriters
{
  internal class Amf0XDocumentWriter : IAmfItemWriter
  {
    public void WriteData(AmfWriter writer, object obj)
    {
      writer.WriteMarker(Amf0TypeMarkers.Xml);
      writer.WriteAmf0XDocument(obj as XDocument);
    }
  }
}
