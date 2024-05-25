using System.ComponentModel;

namespace BaseParamEditor.Logic
{
    public enum Races
    {
        [Description("Saiyan")]
        Saiyan = 0,

        [Description("Earthling")]
        Earthling = 1,

        [Description("Offworlder")]
        Offworlder = 2,

        [Description("Alien")]
        Alien = 3,

        [Description("Namekian")]
        Namekian = 4,
    }
}
