﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRL.ExistsTableCache
{
    [Serializable]
    internal class Table
    {
        public override string ToString()
        {
            return Name;
        }
        public string Name
        {
            get;
            set;
        }
        List<string> fields = new List<string>();
        public List<string> Fields
        {
            get { return fields; }
            set { fields = value; }
        }
        /// <summary>
        /// 是否需要检查字段
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        [NonSerializedAttribute]
        public bool ColumnChecked;
        /// <summary>
        /// 是否需要二次检查字段
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        [NonSerializedAttribute]
        public bool ColumnChecked2;
    }
}