﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geneal
{
    public class Member
    {

        #region properties

        public String Name { get; set; }

        public DateTime BirthDate { get; set; }

        public String BirthLocation { get; set; }

        public DateTime DeathDate { get; set; }

        public String DeathLoction { get; set; }

        public String Parent1 { get; set; }

        public String Parent2 { get; set; }

        public Dictionary<String, String> MiscInfo { get; set; }

        public int Generation { get; set; }

        public int GenerationIndex { get; set; }

        #endregion

        public Member() { }
        
        public String getMisc(string key)
        {
            if(MiscInfo.ContainsKey(key))
            {
                return MiscInfo[key];
            }
            return null;
        }
    }
}
