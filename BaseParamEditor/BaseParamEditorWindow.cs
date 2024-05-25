using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseParamEditor.Logic;
using BaseParamEditor.Tools;
using BaseParamEditor.Common;

namespace BaseParamEditor
{
    public partial class BaseParamEditorWindow : Form
    {
        private List<Logic.Logic.BaseParam> BaseParams = new List<Logic.Logic.BaseParam>();

        private List<Logic.Logic.BaseParam> BaseParamsFiltred = null;

        private Logic.Logic.BaseParam SelectedBaseParam;

        public BaseParamEditorWindow()
        {
            InitializeComponent();

            // Init ComboBox
            raceFlatComboBox.Items.AddRange(EnumHelper.GetValues<Logic.Races>().Select(s => s.Name).ToArray());
            genderFlatComboBox.Items.AddRange(EnumHelper.GetValues<Logic.Genders>().Select(s => s.Name).ToArray());
            poseFlatComboBox.Items.AddRange(Poses.English.ToArray());
            rankFlatComboBox.Items.AddRange(EnumHelper.GetValues<Logic.Rank>().Select(s => s.Name).ToArray());
            styleFlatComboBox.Items.AddRange(EnumHelper.GetValues<Logic.FightingStyles>().Select(s => s.Name).ToArray());
            skillFlatComboBox1.Items.AddRange(Skills.English.Values.ToArray());
            skillFlatComboBox2.Items.AddRange(skillFlatComboBox1.Items.Cast<Object>().ToArray());
            skillFlatComboBox3.Items.AddRange(skillFlatComboBox1.Items.Cast<Object>().ToArray());
        }

        private void SetComboBox(uint itemID, Dictionary<uint, string> dict, ComboBox comboBox)
        {
            if (dict.ContainsKey(itemID))
            {
                comboBox.SelectedIndex = comboBox.Items.IndexOf(dict[itemID]);
            }
            else
            {
                comboBox.SelectedIndex = -1;
                comboBox.Text = "";
            }
        }

        private string[] GetNames(List<Logic.Logic.BaseParam> baseParams)
        {
            return baseParams
                .Select((x, i) => i + " - " + (Common.Characters.English.TryGetValue(x.CharacterID, out var name) ? name : $"Character {i}"))
                .ToArray();
        }

        private string GetName(Logic.Logic.BaseParam baseParam)
        {
            return Common.Characters.English.TryGetValue(baseParam.CharacterID, out var name) ? name : $"Character";
        }

        private int GetIndex(Logic.Logic.BaseParam baseParam)
        {
            return BaseParams.FindIndex(x => x.CharacterID == baseParam.CharacterID);
        }

        private int GetFirstUnusedCharacterID()
        {
            HashSet<int> usedIDs = new HashSet<int>(BaseParams.Select(bp => bp.CharacterID));

            int id = 0;
            while (usedIDs.Contains(id))
            {
                id++;
            }

            return id;
        }

        private int GetFirstUnusedNumber()
        {
            HashSet<int> usedNumbers = new HashSet<int>(BaseParams.Select(bp => bp.Number));

            int number = 0;
            while (usedNumbers.Contains(number))
            {
                number++;
            }

            return number;
        }

        private void LoadFile(string filePath)
        {
            BinaryDataReader reader = new BinaryDataReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

            int characterLength = Convert.ToInt32(reader.Length / 0x54);

            BaseParams = reader.ReadMultipleStruct<Logic.Logic.BaseParam>(characterLength).ToList();
            characterListBox.Items.AddRange(GetNames(BaseParams));

            characterListBox.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            searchTextBox.Enabled = true;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Supported Files (.bin)|*.bin";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);
            }
        }

        private void BaseParamEditorWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string dragPath = Path.GetFullPath(files[0]);
            string dragExt = Path.GetExtension(files[0]);

            if (files.Length > 1) return;
            if (dragExt != ".bin") return;

            openFileDialog1.FileName = dragPath;
            LoadFile(openFileDialog1.FileName);
        }

        private void BaseParamEditorWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Supported Files (.bin)|*.bin";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog1.FileName);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    BinaryDataWriter writer = new BinaryDataWriter(stream);
                    writer.WriteMultipleStruct(BaseParams);
                }

                MessageBox.Show("Saved!");
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!searchTextBox.Focused || searchTextBox.Text == "Search...") return;

            if (searchTextBox.Text == null || searchTextBox.Text == "")
            {
                characterListBox.Items.Clear();
                characterListBox.Items.AddRange(GetNames(BaseParams).ToArray());
                BaseParamsFiltred = null;
                insertToolStripMenuItem.Enabled = true;
                importToolStripMenuItem1.Enabled = true;
                searchTextBox.Text = "Search...";
            }
            else
            {
                BaseParamsFiltred = BaseParams
                    .Where(charabase =>
                    {
                        bool searchByID = ("0x" + charabase.CharacterID.ToString("X8").ToLower()).Contains(searchTextBox.Text.ToLower());
                        bool searchByNumber = charabase.Number.ToString().ToLower().Contains(searchTextBox.Text.ToLower());
                        bool searchByName = GetName(charabase).ToLower().Contains(searchTextBox.Text.ToLower());

                        return searchByID || searchByNumber || searchByName;
                    })
                    .ToList();

                string[] names = GetNames(BaseParamsFiltred);

                string focusedText = characterListBox.Text;

                characterListBox.Items.Clear();
                characterListBox.Items.AddRange(names);

                if (names.Contains(focusedText))
                {
                    characterListBox.SelectedIndex = Array.IndexOf(names, focusedText);
                }

                insertToolStripMenuItem.Enabled = false;
                importToolStripMenuItem1.Enabled = false;
            }
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentIndex = GetIndex(SelectedBaseParam) + 1;

            // Import
            Logic.Logic.BaseParam newBaseParam = new Logic.Logic.BaseParam();

            // Check if the id exist
            if (BaseParams.Any(x => x.CharacterID == newBaseParam.CharacterID))
            {
                newBaseParam.CharacterID = GetFirstUnusedCharacterID();
            }

            // Check if the number exist
            if (BaseParams.Any(x => x.Number == newBaseParam.Number))
            {
                newBaseParam.Number = GetFirstUnusedNumber();
            }

            BaseParams.Insert(currentIndex, newBaseParam);

            // Refresh form
            characterListBox.Items.Clear();
            characterListBox.Items.AddRange(GetNames(BaseParams));
            characterListBox.SelectedIndex = currentIndex;

            // Refresh form
            CharacterListBox_SelectedIndexChanged(sender, e);
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Supported Files (.bin)|*.bin";
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.FileName = null;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                BinaryDataReader reader = new BinaryDataReader(new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

                if (reader.Length == 0x54)
                {
                    int currentIndex = GetIndex(SelectedBaseParam) + 1;

                    // Import
                    Logic.Logic.BaseParam newBaseParam = reader.ReadStruct<Logic.Logic.BaseParam>();

                    // Check if the id exist
                    if (BaseParams.Any(x => x.CharacterID == newBaseParam.CharacterID)) 
                    {
                        newBaseParam.CharacterID = GetFirstUnusedCharacterID();
                    }

                    // Check if the number exist
                    if (BaseParams.Any(x => x.Number == newBaseParam.Number))
                    {
                        newBaseParam.Number = GetFirstUnusedNumber();
                    }

                    BaseParams.Insert(currentIndex, newBaseParam);

                    // Refresh form
                    characterListBox.Items.Clear();
                    characterListBox.Items.AddRange(GetNames(BaseParams));
                    characterListBox.SelectedIndex = currentIndex;

                    // Refresh form
                    CharacterListBox_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Can't import, file contains multiple characters");
                }
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Supported Files (.bin)|*.bin";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = GetName(SelectedBaseParam);
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog1.FileName);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    BinaryDataWriter writer = new BinaryDataWriter(stream);
                    writer.WriteStruct(SelectedBaseParam);
                }

                MessageBox.Show(characterListBox.SelectedItem.ToString() + " exported!");
            }
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Supported Files (.bin)|*.bin";
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.FileName = null;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                BinaryDataReader reader = new BinaryDataReader(new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));

                if (reader.Length == 0x54)
                {
                    // Replace
                    Logic.Logic.BaseParam newBaseParam = reader.ReadStruct<Logic.Logic.BaseParam>();
                    newBaseParam.CharacterID = SelectedBaseParam.CharacterID;
                    newBaseParam.Number = SelectedBaseParam.Number;
                    BaseParams[GetIndex(SelectedBaseParam)] = newBaseParam;

                    if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
                    {
                        BaseParamsFiltred[characterListBox.SelectedIndex] = newBaseParam;
                    }

                    // Refresh form
                    CharacterListBox_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Can't import, file contains multiple characters");
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex == -1) return;

            DialogResult dialogResult = MessageBox.Show("Do you want to delete " + characterListBox.SelectedItem.ToString() + "?", "Delete character", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                characterGroupBox.Enabled = false;

                BaseParams.RemoveAt(GetIndex(SelectedBaseParam));

                MessageBox.Show(characterListBox.SelectedItem.ToString() + " has been removed!");

                if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
                {
                    BaseParamsFiltred.RemoveAt(characterListBox.SelectedIndex);

                    characterListBox.Items.Clear();
                    characterListBox.Items.AddRange(GetNames(BaseParamsFiltred).ToArray());
                }
                else
                {
                    characterListBox.Items.Clear();
                    characterListBox.Items.AddRange(GetNames(BaseParams).ToArray());
                }
            }
        }

        private void CharacterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterListBox.SelectedIndex == -1) return;

            Logic.Logic.BaseParam selectedBaseParam = BaseParams[characterListBox.SelectedIndex];

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                selectedBaseParam = BaseParamsFiltred[characterListBox.SelectedIndex];
            }

            characterIDFlatNumericUpDown.Value = selectedBaseParam.CharacterID;
            characterNumberFlatNumericUpDown.Value = selectedBaseParam.Number;

            nameIDFlatNumericUpDown.Value = selectedBaseParam.CharacterNameID;
            descriptionIDFlatNumericUpDown.Value = selectedBaseParam.CharacterDescriptionID;
            voiceIDFlatNumericUpDown.Value = selectedBaseParam.CharacterVoiceID;
            clothParamIDFlatNumericUpDown.Value = selectedBaseParam.MakeClothParamID;
            modelIDFlatNumericUpDown.Value = selectedBaseParam.ModelID;
            transformationIDFlatNumericUpDown.Value = selectedBaseParam.TransformationModelID;

            raceFlatComboBox.SelectedIndex = selectedBaseParam.Race;
            genderFlatComboBox.SelectedIndex = selectedBaseParam.Gender;
            poseFlatComboBox.SelectedIndex = selectedBaseParam.Pos;
            rankFlatComboBox.SelectedIndex = selectedBaseParam.Rank;
            styleFlatComboBox.SelectedIndex = selectedBaseParam.FightingStyle;

            SetComboBox(selectedBaseParam.Skill1ID, Skills.English, skillFlatComboBox1);
            SetComboBox(selectedBaseParam.Skill2ID, Skills.English, skillFlatComboBox2);
            SetComboBox(selectedBaseParam.Skill3ID, Skills.English, skillFlatComboBox3);

            minHpFlatNumericUpDown.Value = selectedBaseParam.MinHp;
            minMeleeFlatNumericUpDown.Value = selectedBaseParam.MinMelee;
            minKiBlastFlatNumericUpDown.Value = selectedBaseParam.MinKiBlast;
            minDefenseFlatNumericUpDown.Value = selectedBaseParam.MinDefense;
            minLuckFlatNumericUpDown.Value = selectedBaseParam.MinLuck;
            maxHpFlatNumericUpDown.Value = selectedBaseParam.MaxHp;
            maxMeleeFlatNumericUpDown.Value = selectedBaseParam.MaxMelee;
            maxKiBlastFlatNumericUpDown.Value = selectedBaseParam.MaxKiBlast;
            maxDefenseFlatNumericUpDown.Value = selectedBaseParam.MaxDefense;
            maxLuckFlatNumericUpDown.Value = selectedBaseParam.MaxLuck;

            characterGroupBox.Enabled = true;
            SelectedBaseParam = selectedBaseParam;
        }

        private void CharacterIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!characterIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.CharacterID = Convert.ToInt32(characterIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;
        }

        private void CharacterNumberFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!characterNumberFlatNumericUpDown.Focused) return;

            SelectedBaseParam.Number = Convert.ToInt32(characterNumberFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void NameIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!nameIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.CharacterNameID = Convert.ToUInt32(nameIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void DescriptionIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!descriptionIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.CharacterDescriptionID = Convert.ToUInt32(descriptionIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void VoiceIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!voiceIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.CharacterVoiceID = Convert.ToUInt32(voiceIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void ClothParamIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!clothParamIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MakeClothParamID = Convert.ToUInt32(clothParamIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void ModelIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!modelIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.ModelID = Convert.ToUInt32(modelIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void TransformationIDFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!transformationIDFlatNumericUpDown.Focused) return;

            SelectedBaseParam.TransformationModelID = Convert.ToUInt32(transformationIDFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void RaceFlatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!raceFlatComboBox.Focused) return;

            SelectedBaseParam.Race = (byte)raceFlatComboBox.SelectedIndex;
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void GenderFlatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!genderFlatComboBox.Focused) return;

            SelectedBaseParam.Gender = (byte)genderFlatComboBox.SelectedIndex;
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void PoseFlatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!poseFlatComboBox.Focused) return;

            SelectedBaseParam.Pos = (byte)poseFlatComboBox.SelectedIndex;
            SelectedBaseParam.Pos2 = (byte)poseFlatComboBox.SelectedIndex;
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void RankFlatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rankFlatComboBox.Focused) return;

            SelectedBaseParam.Rank = (byte)rankFlatComboBox.SelectedIndex;
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void StyleFlatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!styleFlatComboBox.Focused) return;

            SelectedBaseParam.FightingStyle = (byte)styleFlatComboBox.SelectedIndex;
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void SkillFlatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!skillFlatComboBox1.Focused) return;

            if (skillFlatComboBox1.SelectedIndex == -1)
            {
                SelectedBaseParam.Skill1ID = 0;
            }
            else
            {
                SelectedBaseParam.Skill1ID = Skills.English.ElementAt(skillFlatComboBox1.SelectedIndex).Key;
            }

            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void SkillFlatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!skillFlatComboBox2.Focused) return;

            if (skillFlatComboBox2.SelectedIndex == -1)
            {
                SelectedBaseParam.Skill2ID = 0;
            }
            else
            {
                SelectedBaseParam.Skill2ID = Skills.English.ElementAt(skillFlatComboBox2.SelectedIndex).Key;
            }

            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void SkillFlatComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!skillFlatComboBox3.Focused) return;

            if (skillFlatComboBox3.SelectedIndex == -1)
            {
                SelectedBaseParam.Skill3ID = 0;
            }
            else
            {
                SelectedBaseParam.Skill3ID = Skills.English.ElementAt(skillFlatComboBox3.SelectedIndex).Key;
            }

            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MinHpFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!minHpFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MinHp = Convert.ToInt32(minHpFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MinMeleeFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!minMeleeFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MinMelee = Convert.ToInt16(minMeleeFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MinKiBlastFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!minKiBlastFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MinKiBlast = Convert.ToInt16(minKiBlastFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MinDefenseFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!minDefenseFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MinDefense = Convert.ToInt16(minDefenseFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MinLuckFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!minLuckFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MinKiBlast = Convert.ToInt16(minLuckFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MaxHpFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!maxHpFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MaxHp = Convert.ToInt32(maxHpFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MaxMeleeFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!maxMeleeFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MaxMelee = Convert.ToInt16(maxMeleeFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MaxKiBlastFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!maxKiBlastFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MaxKiBlast = Convert.ToInt16(maxKiBlastFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MaxDefenseFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!maxDefenseFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MaxDefense = Convert.ToInt16(maxDefenseFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }

        private void MaxLuckFlatNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!maxLuckFlatNumericUpDown.Focused) return;

            SelectedBaseParam.MaxLuck = Convert.ToInt16(maxLuckFlatNumericUpDown.Value);
            BaseParams[GetIndex(SelectedBaseParam)] = SelectedBaseParam;

            if (BaseParamsFiltred != null && BaseParamsFiltred.Count > 0)
            {
                BaseParamsFiltred[characterListBox.SelectedIndex] = SelectedBaseParam;
            }
        }
    }
}
