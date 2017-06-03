using System;
using System.ComponentModel;

namespace UsgsClient.Quakes
{
    public enum Magnitude
    {
        Significant,
        [Description("4.5")]
        M4_5,
        [Description("2.5")]
        M2_5,
        [Description("1.0")]
        M1_0,
        All
    }
}
