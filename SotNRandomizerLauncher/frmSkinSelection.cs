using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotNRandomizerLauncher
{
    public partial class frmSkinSelection : Form
    {
        int TotalPalettes = Enum.GetValues(typeof(AlucardPalettes)).Length;
        int TotalLiners = Enum.GetValues(typeof(AlucardLiner)).Length;

        int alPaletteIdx = 0;
        int alLinerIdx = 0;
        int wlfPaletteIdx = 0;
        int wlfLinerIdx = 0;

        int pastAlPaletteIdx = 0;
        int pastAlLinerIdx = 0;
        int pastWlfPaletteIdx = 0;
        int pastWlfLinerIdx = 0;

        public frmSkinSelection()
        {
            InitializeComponent();
        }
        private void frmSkinSelection_Load(object sender, EventArgs e)
        {
            LoadLastVisuals();
        }

        void LoadLastVisuals()
        {
            string alucardPalette = LauncherClient.GetConfigValue("LastAlucardPalette");
            string alucardLiner = LauncherClient.GetConfigValue("LastAlucardLiner");
            string wolfPalette = LauncherClient.GetConfigValue("LastWolfPalette");
            string wolfLiner = LauncherClient.GetConfigValue("LastWolfLiner");

            if (alucardPalette != null && alucardLiner != null)
            {
                alPaletteIdx = int.Parse(alucardPalette);
                alLinerIdx = int.Parse(alucardLiner);
            }

            if (wolfLiner != null && wolfPalette != null)
            {
                wlfPaletteIdx = int.Parse(wolfPalette);
                wlfLinerIdx = int.Parse(wolfLiner);
            }

            if (alPaletteIdx == -1) cbAlRandomPalette.Checked = true; else UpdateAlucardPalette();
            if (alLinerIdx == -1) cbAlRandomLiner.Checked = true; else UpdateAlucardLiner();
            if (wlfPaletteIdx == -1) cbWlfRandomPalette.Checked = true; else UpdateWolfPalette();
            if (wlfLinerIdx == -1) cbWlfRandomLiner.Checked = true; else UpdateWolfLiner();
        }

        void UpdateAlucardPalette()
        {
            int localIdx = alPaletteIdx;
            AlucardPalettes alucardPalette = (AlucardPalettes)alPaletteIdx;
            if (alucardPalette == AlucardPalettes.Disabled) localIdx = 0;
            Bitmap originalImage = new Bitmap(Properties.Resources.alucar12);
            Rectangle cropArea = new Rectangle(localIdx * 96, 0, 32, 64);
            Bitmap cropped = originalImage.Clone(cropArea, originalImage.PixelFormat);
            pbSkinPreview.BackgroundImage = cropped;            
            lblAlPalette.Text = $"Palette: {GetNameFromEnum(alucardPalette)}";
        }

        void UpdateAlucardLiner()
        {
            int localIdx = alLinerIdx;
            AlucardLiner alucardLiner = (AlucardLiner)alLinerIdx;
            if (alucardLiner == AlucardLiner.Disabled) localIdx = 0;
            Bitmap originalImage = new Bitmap(Properties.Resources.alucar12);
            Rectangle cropArea = new Rectangle(localIdx * 96, 64, 32, 64);
            Bitmap cropped = originalImage.Clone(cropArea, originalImage.PixelFormat);
            pbSkinPreview.Image = cropped;
            lblAlLiner.Text = $"Liner: {GetNameFromEnum(alucardLiner)}";
        }

        void UpdateWolfPalette()
        {
            int localIdx = wlfPaletteIdx;
            AlucardPalettes alucardPalette = (AlucardPalettes)wlfPaletteIdx;
            if (alucardPalette == AlucardPalettes.Disabled) localIdx = 0;
            Bitmap originalImage = new Bitmap(Properties.Resources.alucar12);
            Rectangle cropArea = new Rectangle(localIdx * 96 + 32, 0, 64, 64);
            Bitmap cropped = originalImage.Clone(cropArea, originalImage.PixelFormat);
            pbWolfPreview.BackgroundImage = cropped;
            lblWlfPalette.Text = $"Palette: {GetNameFromEnum(alucardPalette)}";
        }

        void UpdateWolfLiner()
        {
            int localIdx = wlfLinerIdx;
            AlucardLiner alucardLiner = (AlucardLiner)wlfLinerIdx;
            if (alucardLiner == AlucardLiner.Disabled) localIdx = 0;
            Bitmap originalImage = new Bitmap(Properties.Resources.alucar12);
            Rectangle cropArea = new Rectangle(localIdx * 96 + 32, 64, 64, 64);
            Bitmap cropped = originalImage.Clone(cropArea, originalImage.PixelFormat);
            pbWolfPreview.Image = cropped;
            lblWlfLiner.Text = $"Liner: {GetNameFromEnum(alucardLiner)}";
        }

        public static string GetNameFromEnum(Enum inputEnum)
        {
            string input = inputEnum.ToString();
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return Regex.Replace(input, "(\\B[A-Z])", " $1");
        }

        private int SpinInt(int value, int max, bool add)
        {
            value = (add) ? value + 1 : value - 1;
            if (value < 0) value = max - 1;
            if (value >= max) value = 0;
            return value;
        }
        

        private void lblPalette_Click(object sender, EventArgs e)
        {

        }

        private void btnAlPaletteLeft_Click(object sender, EventArgs e)
        {
            alPaletteIdx = SpinInt(alPaletteIdx, TotalPalettes, false);
            UpdateAlucardPalette();
        }

        private void btnAlPaletteRight_Click(object sender, EventArgs e)
        {
            alPaletteIdx = SpinInt(alPaletteIdx, TotalPalettes, true);
            UpdateAlucardPalette();
        }

        private void btnAlLinerLeft_Click(object sender, EventArgs e)
        {
            alLinerIdx = SpinInt(alLinerIdx, TotalLiners, false);
            UpdateAlucardLiner();
        }

        private void btnAlLinerRight_Click(object sender, EventArgs e)
        {
            alLinerIdx = SpinInt(alLinerIdx, TotalLiners, true);
            UpdateAlucardLiner();
        }

        private void btnWlfPaletteLeft_Click(object sender, EventArgs e)
        {
            wlfPaletteIdx = SpinInt(wlfPaletteIdx, TotalPalettes, false);
            UpdateWolfPalette();
        }

        private void btnWlfPaletteRight_Click(object sender, EventArgs e)
        {
            wlfPaletteIdx = SpinInt(wlfPaletteIdx, TotalPalettes, true);
            UpdateWolfPalette();
        }

        private void btnWlfLinerLeft_Click(object sender, EventArgs e)
        {
            wlfLinerIdx = SpinInt(wlfLinerIdx, TotalLiners, false);
            UpdateWolfLiner();
        }

        private void btnWlfLinerRight_Click(object sender, EventArgs e)
        {
            wlfLinerIdx = SpinInt(wlfLinerIdx, TotalLiners, true);
            UpdateWolfLiner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LauncherClient.SetAppConfig("LastAlucardPalette", alPaletteIdx.ToString());
            LauncherClient.SetAppConfig("LastAlucardLiner", alLinerIdx.ToString());
            LauncherClient.SetAppConfig("LastWolfPalette", wlfPaletteIdx.ToString());
            LauncherClient.SetAppConfig("LastWolfLiner", wlfLinerIdx.ToString());

            this.Close();
        }

        private void cbAlRandomPalette_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlRandomPalette.Checked)
            {
                lblAlPalette.Text = "Palette: Random";
                pastAlPaletteIdx = alPaletteIdx;
                alPaletteIdx = -1;
                pbSkinPreview.Hide();
                btnAlPaletteLeft.Enabled = false;
                btnAlPaletteRight.Enabled = false;
            }else
            {
                alPaletteIdx = (pastAlPaletteIdx != -1) ? pastAlPaletteIdx : 0;
                UpdateAlucardPalette();
                if(!cbAlRandomLiner.Checked) pbSkinPreview.Show();
                btnAlPaletteLeft.Enabled = true;
                btnAlPaletteRight.Enabled = true;
            }
        }

        private void cbAlRandomLiner_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlRandomLiner.Checked)
            {
                lblAlLiner.Text = "Liner: Random";
                pastAlLinerIdx = alLinerIdx;
                alLinerIdx = -1;
                pbSkinPreview.Hide();
                btnAlLinerLeft.Enabled = false;
                btnAlLinerRight.Enabled = false;
            }
            else
            {
                alLinerIdx = (pastAlLinerIdx != -1) ? pastAlLinerIdx : 0;
                UpdateAlucardLiner();
                if(!cbAlRandomPalette.Checked) pbSkinPreview.Show();
                btnAlLinerLeft.Enabled = true;
                btnAlLinerRight.Enabled = true;
            }
        }

        private void cbWlfRandomPalette_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWlfRandomPalette.Checked)
            {
                lblWlfPalette.Text = "Palette: Random";
                pastWlfPaletteIdx = wlfPaletteIdx;
                wlfPaletteIdx = -1;
                pbWolfPreview.Hide();
                btnWlfPaletteLeft.Enabled = false;
                btnWlfPaletteRight.Enabled = false;
            }
            else
            {
                wlfPaletteIdx = (pastWlfPaletteIdx != -1) ? pastWlfPaletteIdx : 0;
                UpdateWolfPalette();
                if(!cbWlfRandomLiner.Checked) pbWolfPreview.Show();
                btnWlfPaletteLeft.Enabled = true;
                btnWlfPaletteRight.Enabled = true;
            }
        }

        private void cbWlfRandomLiner_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWlfRandomLiner.Checked)
            {
                lblWlfLiner.Text = "Liner: Random";
                pastWlfLinerIdx = wlfLinerIdx;
                wlfLinerIdx = -1;
                pbWolfPreview.Hide();
                btnWlfLinerLeft.Enabled = false;
                btnWlfLinerRight.Enabled = false;
            }
            else
            {
                wlfLinerIdx = (pastWlfLinerIdx != -1) ? pastWlfLinerIdx : 0;
                UpdateWolfLiner();
                if(!cbWlfRandomPalette.Checked) pbWolfPreview.Show();
                btnWlfLinerLeft.Enabled = true;
                btnWlfLinerRight.Enabled = true;
            }
        }
    }
}
