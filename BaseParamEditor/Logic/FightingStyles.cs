using System.ComponentModel;

namespace BaseParamEditor.Logic
{
    public enum FightingStyles
    {
        [Description("Power")]
        Power = 0,

        [Description("Technique")]
        Technique = 1,

        [Description("Speed")]
        Speed = 2,

        [Description("Untype")]
        Untype = 3,
    }
}
