using System;
using System.IO;
using System.Windows.Forms;

namespace OperationGhost_ServiceMenu
{
    public partial class WndMain : Form
    {
        private const string CONFIG_FILE_PATH = @"\gs2.ini";

        public WndMain()
        {
            InitializeComponent();
            this.Text = "Operation G.HO.S.T - System Menu v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();       
        }

        private void WndMain_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader Sr = new StreamReader(Application.StartupPath + CONFIG_FILE_PATH))
                {
                    string line = Sr.ReadLine();
                    int i;
                    while (line != null)
                    {
                        if (line.ToLower().Contains("language="))
                        {
                            string l = line.Split('=')[1].Trim().ToLower();
                            if (l.Equals("jp"))
                                Cbox_Region.SelectedIndex = 0;
                            else if (l.Equals("en"))
                                Cbox_Region.SelectedIndex = 1;
                            else if (l.Equals("ru"))
                                Cbox_Region.SelectedIndex = 2;
                        } 
                        else if (line.ToLower().Contains("difficulty="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_Difficulty.SelectedIndex = i;
                        }
                        else if (line.ToLower().Contains("life="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_Life.SelectedIndex = i - 2;
                        }
                        else if (line.ToLower().Contains("enablerecoil="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_Reaction.SelectedIndex = i;
                        }
                        else if (line.ToLower().Contains("enableblood="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_DammageEffect.SelectedIndex = i;
                        }
                        else if (line.ToLower().Contains("armor="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_Armour.SelectedIndex = i;
                        }
                        else if (line.ToLower().Contains("dresscode="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_DressCode.SelectedIndex = i;
                        }
                        else if (line.ToLower().Contains("swipecard="))
                        {
                            if (Int32.TryParse(line.Split('=')[1].Trim(), out i))
                                Cbox_Swipe.SelectedIndex = i;
                        }
                        



                        line = Sr.ReadLine();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error reading the following file : " + Application.StartupPath + CONFIG_FILE_PATH + "\n\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            String StrConfig = String.Empty;

            try
            {
                using (StreamReader Sr = new StreamReader(Application.StartupPath + CONFIG_FILE_PATH))
                {
                    string Line = Sr.ReadLine();
                    while (Line != null)
                    {
                        if (Line.ToLower().Contains("language="))
                        {
                            if (Cbox_Region.SelectedIndex == 0)
                                Line = "Language=jp";
                            else if (Cbox_Region.SelectedIndex == 1)
                                Line = "Language=en";
                            if (Cbox_Region.SelectedIndex == 2)
                                Line = "Language=ru";
                        }
                        else if (Line.ToLower().Contains("difficulty="))
                            Line = "Difficulty=" + Cbox_Difficulty.SelectedIndex.ToString();
                        else if (Line.ToLower().Contains("life="))
                            Line = "Life=" + (Cbox_Life.SelectedIndex + 2).ToString();
                        else if (Line.ToLower().Contains("enablerecoil="))
                            Line = "EnableRecoil=" + Cbox_Reaction.SelectedIndex.ToString();
                        else if (Line.ToLower().Contains("enableblood="))
                            Line = "EnableBlood=" + Cbox_DammageEffect.SelectedIndex.ToString();
                        else if (Line.ToLower().Contains("armor="))
                            Line = "Armor=" + Cbox_Armour.SelectedIndex.ToString();
                        else if (Line.ToLower().Contains("dresscode="))
                            Line = "DressCode=" + Cbox_DressCode.SelectedIndex.ToString();

                        StrConfig += Line + Environment.NewLine;
                        Line = Sr.ReadLine();
                    }
                }
                File.WriteAllText(Application.StartupPath + CONFIG_FILE_PATH, StrConfig);                

                MessageBox.Show("save complete !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error writing file :\n\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
