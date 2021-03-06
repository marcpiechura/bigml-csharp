﻿using Newtonsoft.Json.Linq;

namespace BigML
{
    public partial class DataSet
    {
        public partial class Field
        {
            public abstract partial class Summary
            {
                /// <summary>
                /// Text summaries give you a count per each category and missing count in case any of the instances contain missing values.
                /// </summary>
                public class Datetime : Summary
                {
                    internal Datetime(JObject json)
                        : base(json)
                    {
                    }
                }
            }
        }
    }
}
