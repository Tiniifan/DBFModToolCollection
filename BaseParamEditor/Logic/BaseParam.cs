using System.Runtime.InteropServices;

namespace BaseParamEditor.Logic
{
    public class Logic
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BaseParam
        {
            public int CharacterID { get; set; }
            public byte Unk1 { get; set; }
            public byte Rank { get; set; }
            public byte Race { get; set; }
            public byte Unk2 { get; set; }
            public byte Gender { get; set; }
            public byte Unk3 { get; set; }
            public byte Pos { get; set; }
            public byte Pos2 { get; set; }
            public byte FightingStyle { get; set; }
            public byte Unk4 { get; set; }
            public byte Unk5 { get; set; }
            public byte Unk6 { get; set; }
            public uint ModelID { get; set; }
            public uint TransformationModelID { get; set; }
            public uint CharacterNameID { get; set; }
            public uint CharacterDescriptionID { get; set; }
            public uint CharacterVoiceID { get; set; }
            public int MinHp { get; set; }
            public short MinMelee { get; set; }
            public short MinKiBlast { get; set; }
            public short MinDefense { get; set; }
            public short MinLuck { get; set; }
            public int MaxHp { get; set; }
            public short MaxMelee { get; set; }
            public short MaxKiBlast { get; set; }
            public short MaxDefense { get; set; }
            public short MaxLuck { get; set; }
            public short Unk7 { get; set; }
            public short Unk8 { get; set; }
            public uint Skill1ID { get; set; }
            public uint Skill2ID { get; set; }
            public uint Skill3ID { get; set; }
            public int Number { get; set; }
            public uint MakeClothParamID { get; set; }
        }

        public class BaseParamWrapper
        {
            public BaseParam BaseParam { get; }

            public BaseParamWrapper(BaseParam baseParam)
            {
                BaseParam = baseParam;
            }

            public override bool Equals(object obj)
            {
                if (obj is BaseParamWrapper other)
                {
                    return ReferenceEquals(BaseParam, other.BaseParam);
                }
                return false;
            }

            public override int GetHashCode()
            {
                return BaseParam.GetHashCode();
            }
        }
    }
}
