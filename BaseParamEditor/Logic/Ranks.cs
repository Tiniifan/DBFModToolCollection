using System.ComponentModel;

namespace BaseParamEditor.Logic
{
    public enum Rank
    {
        [Description("C")]
        RankC = 0,

        [Description("B")]
        RankB = 1,

        [Description("A")]
        RankA = 2,

        [Description("S")]
        RankS = 3,

        [Description("G")]
        RankG = 4,

        [Description("Unrank")]
        Unrank = 5,
    }
}
