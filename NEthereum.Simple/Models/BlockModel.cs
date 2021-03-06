﻿using NEthereum.Simple.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEthereum.Simple.Models
{
    public class BlockModel : BlockModelBase
    {
        public string idBioRefMaterial { get; set; }
        public string name { get; set; }
        public int unit { get; set; }
        public bool isBio { get; set; }
        public int dateCreated { get; set; }
    }
}
