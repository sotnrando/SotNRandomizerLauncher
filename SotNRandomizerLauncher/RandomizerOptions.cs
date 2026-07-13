using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotNRandomizerLauncher
{
    enum MapColor
    {
        Blue,
        Crimson,
        Brown,
        Green,
        Gray,
        Purple,
        Pink,
        Black,
        Invisible,
        Default
    }

    enum Goal
    {
        Disabled,
        Default,
        AllBosses,
        AllRelics,
        AllBossesRelics,
        AllBossesVladRelics,
        BountyHunter,
        TargetConfirmed,
        Hitman,
        AllBossesBounties,
        AllBossesRelicsBounties
    }
    internal class RandomizerOptions
    {
        public bool TournamentMode { get; set; }
        public bool VanillaMusic { get; set; }
        public bool ShowEquipment { get; set; }
        public bool MagicMaxMode { get; set; }
        public bool AntiFreezeMode { get; set; }
        public bool MyPurseMode { get; set; }
        public bool ColorRando { get; set; }
        public string RelicExtension { get; set; }
        public string Preset { get; set; }
        public string PpfFilePath { get; set; }
        public string Seed { get; set; }
        public MapColor MapColor { get; set; }
        public int Complexity { get; set; }
        public bool BHSeed { get; set; }
        public bool AreaRando { get; set; }
        public AreaRandoOptions AreaRandoOptions { get; set; }
        public bool IWBMode { get; set; }
        public bool FastWarpMode { get; set; }
        public bool UnlockedMode { get; set; }
        public bool ExcludeSongs { get; set; }
        public bool IsCustom { get; set; }
        public bool EnemyStatRando { get; set; }
        public bool MisteryMode { get; set; }
        public bool ShopPrices { get; set; }
        public bool StartingZone { get; set; }
        public bool StartingZone2 { get; set; }
        public bool NoPrologue { get; set; }
        public bool ItemNameRando { get; set; }
        public bool GuaranteedDrops { get; set; }
        public bool AlucardPalette { get; set; }
        public bool ReverseLibraryCard { get; set; }
        public bool ImmunityPotions { get; set; }
        public bool GodspeedShoes { get; set; }
        public bool LibraryShortcut { get; set; }
        public bool BossMusic { get; set; }
        public bool SeasonalPhrases {  get; set; }
        public bool SimplifiedInputs { get; set; }
        public bool ElementalChaos { get; set; }
        public bool SingleHitGears { get; set; }
        public bool RandomStartingStats { get; set; }
        public bool SpikeRoomRando { get; set; }
        public bool OpenClockStatue { get; set; }
        public bool ReverseTeleporter { get; set; }
        public bool ZeroDollarRelic { get; set; }
        public bool LycanthropeMode { get; set; }
        public bool WarlockMode { get; set; }
        public bool ChaosDrops { get; set; }
        public bool LevelOneMode { get; set; }
        public bool InstantDeath { get; set; }
        public bool FourBeasts { get; set; }
        public bool EntranceTrap { get; set; }
        public bool ForbiddenShortcut { get; set; }
        public bool EnhancedCross { get; set; }
        public bool MaximumMuramasa { get; set; }
        public bool EnhancedDarkShield { get; set; }
        public bool SwordOfBrawn { get; set; }
        public bool AListOfNames { get; set; }
        public int StartingStatsAmount { get; set; }
        public Goal CustomGoal { get; set; }
        public CheckState ItemStats { get; set; }
        public CheckState ItemLocations { get; set; }
        public CheckState EnemyDrops { get; set; }
        public CheckState StartingEquipment { get; set; }
        public CheckState PrologueRewards { get; set; }
        public CheckState TurkeyMode { get; set; }
        public CheckState RelicLocations { get; set; }
        public bool OverrideSettings { get; set; }

        private string GetArgument(CheckState state, string checkedValue)
        {
            if(state == CheckState.Indeterminate) return "";
            return state == CheckState.Checked ? checkedValue : $"~{checkedValue}";
        }

        private void AppendFlag(StringBuilder arguments, bool enabled, string flag, bool canOverride = false)
        {
            if (enabled)
            {
                arguments.Append(flag).Append(' ');
            }
            else if (canOverride && this.OverrideSettings)
            {
                arguments.Append(ToNegatedFlag(flag)).Append(' ');
            }
        }

        private static string ToNegatedFlag(string flag)
        {
            if (flag.StartsWith("--"))
                return "--no-" + flag.Substring(2);
            if (flag.StartsWith("-"))
                return "--no-" + flag.Substring(1);
            return "--no-" + flag;
        }

        public string GenerateArguments()
        {
            var arguments = new StringBuilder();

            AppendFlag(arguments, this.TournamentMode, "-t");
            AppendFlag(arguments, this.MagicMaxMode, "--magicmax", true);
            AppendFlag(arguments, this.AntiFreezeMode, "--antifreeze", true);
            AppendFlag(arguments, this.ColorRando, "-l");
            AppendFlag(arguments, this.MyPurseMode, "--mypurse", true);
            AppendFlag(arguments, this.IWBMode, "--iws", true);
            AppendFlag(arguments, this.FastWarpMode, "--fastwarp", true);
            AppendFlag(arguments, this.UnlockedMode, "--unlocked", true);
            AppendFlag(arguments, this.MisteryMode, "--surprise", true);
            AppendFlag(arguments, this.EnemyStatRando, "--enemyStatRando", true);
            AppendFlag(arguments, this.ShopPrices, "--shopPriceRando", true);
            AppendFlag(arguments, this.StartingZone, "--startRoomRando", true);
            AppendFlag(arguments, this.StartingZone2, "--startRoomRando2nd", true);
            AppendFlag(arguments, this.NoPrologue, "--noprologue");
            AppendFlag(arguments, this.AlucardPalette, "--ap");
            AppendFlag(arguments, this.ReverseLibraryCard, "--rlbc", true);
            AppendFlag(arguments, this.GuaranteedDrops, "--domino", true);
            AppendFlag(arguments, this.ItemNameRando, "--in");
            AppendFlag(arguments, this.ImmunityPotions, "--immunityPotion", true);
            AppendFlag(arguments, this.GodspeedShoes, "--godspeed", true);
            AppendFlag(arguments, this.LibraryShortcut, "--libShort", true);
            AppendFlag(arguments, this.BossMusic, "--bm");
            AppendFlag(arguments, this.SimplifiedInputs, "--easy");
            AppendFlag(arguments, this.ElementalChaos, "--elemChaos", true);
            AppendFlag(arguments, this.SingleHitGears, "--singleHitGear", true);
            AppendFlag(arguments, this.ReverseTeleporter, "--revCastleTeleport", true);
            AppendFlag(arguments, this.ZeroDollarRelic, "--zeroDollarRelic", true);
            AppendFlag(arguments, this.OpenClockStatue, "--openClockStatue", true);
            AppendFlag(arguments, this.SpikeRoomRando, "--spikeRoom", true);
            AppendFlag(arguments, this.LycanthropeMode, "--lycan", true);
            AppendFlag(arguments, this.WarlockMode, "--warlock", true);
            AppendFlag(arguments, this.LevelOneMode, "--levelOne", true);
            AppendFlag(arguments, this.InstantDeath, "--instantDeath", true);
            AppendFlag(arguments, this.ChaosDrops, "--cornucopia", true);
            AppendFlag(arguments, this.FourBeasts, "--fourBeast", true);
            AppendFlag(arguments, this.MaximumMuramasa, "--maxMasa", true);
            AppendFlag(arguments, this.SwordOfBrawn, "--brawnySword", true);
            AppendFlag(arguments, this.EntranceTrap, "--trapDoor", true);
            AppendFlag(arguments, this.EnhancedCross, "--betterCross", true);
            AppendFlag(arguments, this.EnhancedDarkShield, "--darkEIF", true);
            AppendFlag(arguments, this.AListOfNames, "--nameList", true);

            if (this.RandomStartingStats)
                arguments.Append($"--ss {this.StartingStatsAmount} ");
            else if (this.OverrideSettings)
                arguments.Append("--no-ss ");

            // --sp desactiva frases estacionales (lógica invertida; sin --no-).
            AppendFlag(arguments, !this.SeasonalPhrases, "--sp");

            if (this.ExcludeSongs)
            {
                string excludeSongList = LauncherClient.GetConfigValue("ExcludedSongs");
                arguments.Append($"--eds {excludeSongList} ");
            }
            if (this.Complexity > 0) arguments.Append($"-c {this.Complexity} ");
            char mapColor = MapColorToSetting(this.MapColor);
            if (mapColor != ' ') arguments.Append($"-m {mapColor} ");
            char customGoal = GoalToSetting(this.CustomGoal);
            if (customGoal != ' ') arguments.Append($"-g {customGoal} ");

            if (this.IsCustom)
            {
                string currentAppDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string customPresetsPath = Path.Combine(currentAppDirectory, "files", "customPresets");
                string presetPath = Path.Combine(customPresetsPath, $"{this.Preset}.json");
                arguments.Append($"-f \"{presetPath}\" ");
            }
            else
            {
                arguments.Append($"-p {this.Preset.ToLower()} ");
            }
            arguments.Append($"-s {this.Seed} ");
            var states = new[] { this.EnemyDrops, this.ItemLocations, this.ItemStats, this.StartingEquipment, this.PrologueRewards, this.TurkeyMode, this.RelicLocations };
            if (this.VanillaMusic || this.RelicExtension != "" || states.Any(state => state != CheckState.Indeterminate))
            {
                arguments.Append("--opt ");
                if (this.Preset == "bingo")
                {
                    arguments.Append("~r");
                }
                else
                {
                    if (this.VanillaMusic)
                    {
                        arguments.Append("~m");
                    }
                    else
                    {
                        arguments.Append("m");
                    }
                }
                arguments.Append(GetArgument(this.EnemyDrops, "d"));
                arguments.Append(GetArgument(this.ItemLocations, "i"));
                arguments.Append(GetArgument(this.ItemStats, "s"));
                arguments.Append(GetArgument(this.StartingEquipment, "e"));
                arguments.Append(GetArgument(this.PrologueRewards, "b"));
                arguments.Append(GetArgument(this.TurkeyMode, "k"));
                if (this.RelicExtension != "")
                {
                    arguments.Append($"r:x:{RelicExtension.ToLower()}");
                }
                else if (this.RelicLocations == CheckState.Unchecked)
                {
                    arguments.Append("~r");
                }
            }
            arguments.Append($" -o \"{this.PpfFilePath}\"");

            if (this.ShowEquipment) arguments.Append(" -vv ");

            return arguments.ToString();
        }

        public char MapColorToSetting(MapColor color)
        {
            switch (color)
            {
                case MapColor.Purple: return 'p';
                case MapColor.Pink: return 'k';
                case MapColor.Gray: return 'y';
                case MapColor.Green: return 'g';
                case MapColor.Crimson: return 'r';
                case MapColor.Brown: return 'n';
                case MapColor.Blue: return 'u';
                case MapColor.Black: return 'b';
                case MapColor.Invisible: return 'i';
            }
            return ' ';
        }

        public char GoalToSetting(Goal goal)
        {
            switch (goal)
            {
                case Goal.Default: return 'd';
                case Goal.AllRelics: return 'r';
                case Goal.AllBosses: return 'b';
                case Goal.AllBossesRelics: return 'a';
                case Goal.AllBossesVladRelics: return 'v';
                case Goal.BountyHunter: return 'h';
                case Goal.TargetConfirmed: return 't';
                case Goal.Hitman: return 'w';
                case Goal.AllBossesBounties: return 'x';
                case Goal.AllBossesRelicsBounties: return 'y';
            }
            return ' ';
        }

    }
}
