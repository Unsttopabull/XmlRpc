﻿using System.Collections.Generic;

namespace CookComputing.XmlRpc
{
    public class MappingStack : Stack<string>
    {
      public MappingStack(string parseType)
      {
        m_parseType = parseType;
      }

      void Push(string str)
      {
        base.Push(str);
      }

      public string MappingType
      {
        get { return m_parseType; }
      }

      public string m_parseType = "";
    }
  }
