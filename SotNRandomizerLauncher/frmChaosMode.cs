using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotNRandomizerLauncher
{
    public partial class frmChaosMode : Form
    {
        List<PresetInfo> presets;
        Dictionary<string, PresetInfo> presetDictionary;

        Dictionary<string, object> presetGroups = new Dictionary<string, object>
        {
            { "Full Chaos", new  List<string> { "All Presets!"} },
            { "Classics", new List<string> { "Safe", "Guarded O.G.", "Casual", "Nimble", "Lycanthrope", "Warlock", "O.G." } },
            { "Transform", new List<string> { "Nimble Lite", "Lycanthrope", "Warlock", "Bat-Master", "Chimera", "Cornivus" } },
            { "Broken Sequence", new List<string> { "Any Percent", "Glitch Remastered", "Glitchmaster", "Sequence Breaker" } },
            { "Enemy Hunter", new List<string> { "Bounty Hunter", "Target Confirmed", "Hitman", "Chaos Lite", "Rampage" } },
            { "Long Journey", new  List<string> { "Adventure", "Expedition", "Grand Tour", "Crash Course", "Lookingglass", "Skinwalker", "Sight-Seer", "Mobility"} },
            { "Chaotic Mix", new  List<string> { "Max Rando", "Chaos Lite", "Lucky Sevens", "Third Castle"} },
            { "Tough Challenges", new  List<string> { "Anguish 2025", "Agonize 2020", "Cursed Night", "Empty Hand", "Brawler", "Scavenger", "Spellbound", "Dog life"} },
            { "One Castle", new  List<string> { "First Castle", "Seeker"} },
            { "Unique Gimmicks", new  List<string> { "Bat-Master", "Magic Mirror", "Leg Day", "Boss Rush", "Aperture", "Big Toss", "Beyond", "Breach", "Summoner", "Cursed Night", "Dog life", "Battle Mage", "Timeline", "Chimera", "Oracle", "Mirror Breaker", "Recycler", "Gear Rush"} },
            { "New Goals", new  List<string> { "Gem farmer", "Beyond", "Breach", "All Bosses", "Seeker", "Recycler", "Gourmet Race", "Collector"} },
            { "Quick Run", new  List<string> { "Nimble", "Nimble Lite", "Hitman", "Breach", "First Castle", "Lucky Sevens", "Seeker", "Gear Rush"} },
        };

        Dictionary<string, object> optionGroups = new Dictionary<string, object>
        {
            { "Full Chaos", new  List<string> { "All Settings!"} },
            { "QoL", new  List<string> { "Magic Vessels", "Tournament Mode", "Anti Freeze", "Fast Warps", "Remove Prologue", "Guaranteed Drops", "Easy Mode", "Single-Hit Gears"} },
            { "Chaos Castle", new  List<string> { "Tournament Mode Disabled", "Complexity", "Relic Extension", "Area Randomizer", "Starting Zone", "Unlocked Mode", "Fast Warps", "Relic Surprise!", "That's My Purse!", "Reverse Library Card", "Library Shortcut", "Reverse Teleporter", "Spike Room", "Zero-dollar Relic", "Open Clock Statue"} },
        }; 

        public frmChaosMode()
        {
            InitializeComponent();
            GetPresets();
            LoadGroups();
        }

        private void cbSettingsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSettingsIncluded.Text = string.Join(", ", (List<string>)optionGroups[cbSettingsGroup.SelectedItem.ToString()]);
        }

        void LoadGroups()
        {
            cbPresetGroup.Items.Clear();
            cbSettingsGroup.Items.Clear();
            cbPresetGroup.Items.AddRange(presetGroups.Keys.ToArray());
            cbPresetGroup.SelectedIndex = 0;
            cbSettingsGroup.Items.AddRange(optionGroups.Keys.ToArray());
            cbSettingsGroup.SelectedIndex = 0;
        }

        void GetPresets()
        {
            string jsonFilePath = Path.Combine(LauncherClient.GetConfigValue("RandomizerPath"), "Randomizer", "preset-data.json");
            string jsonString = File.ReadAllText(jsonFilePath);
            presets = JsonConvert.DeserializeObject<List<PresetInfo>>(jsonString);
            presets.Sort((preset1, preset2) => string.Compare(preset1.Name, preset2.Name));

            // Store presets in a dictionary for quick lookup
            presetDictionary = presets.ToDictionary(p => p.Name, p => p);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void cbPresetGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPresetsIncluded.Text = string.Join(", ", (List<string>)presetGroups[cbPresetGroup.SelectedItem.ToString()]);
        }
    }
}
