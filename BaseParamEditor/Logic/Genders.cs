using System.ComponentModel;

namespace BaseParamEditor.Logic
{
    public enum Genders
    {
        [Description("Male")]
        Male = 0,

        [Description("Female")]
        Female = 1,

        [Description("Ungender")]
        Ungender = 2,
    }
}
