﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unnamed_Weather_App
{
    internal class Rain
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }
}