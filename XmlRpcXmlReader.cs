﻿using System.Xml;
using System.IO;

namespace CookComputing.XmlRpc
{
  public static class XmlRpcXmlReader
  {
    public static XmlReader Create(Stream stm)
    {
      XmlTextReader xmlRdr = new XmlTextReader(stm);
      ConfigureXmlTextReader(xmlRdr);
      return xmlRdr;
    }

    public static XmlReader Create(TextReader textReader)
    {
      XmlTextReader xmlRdr = new XmlTextReader(textReader);
      ConfigureXmlTextReader(xmlRdr);
      return xmlRdr;
    }

    private static void ConfigureXmlTextReader(XmlTextReader xmlRdr)
    {
      xmlRdr.Normalization = false;
      xmlRdr.ProhibitDtd = true;
      xmlRdr.WhitespaceHandling = WhitespaceHandling.All;
    }
  }
}
