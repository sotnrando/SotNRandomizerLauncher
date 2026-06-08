namespace SotNRandomizerLauncher
{
    partial class frmChaosMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChaosMode));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPresetGroup = new System.Windows.Forms.ComboBox();
            this.cbSettingsGroup = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPresetsIncluded = new System.Windows.Forms.Label();
            this.lblSettingsIncluded = new System.Windows.Forms.Label();
            this.grpForceSettings = new System.Windows.Forms.GroupBox();
            this.cbForcePrologue = new System.Windows.Forms.CheckBox();
            this.cbForceStartingEquipment = new System.Windows.Forms.CheckBox();
            this.cbForceItemLocations = new System.Windows.Forms.CheckBox();
            this.cbForceEnemyDrops = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbForceEasy = new System.Windows.Forms.CheckBox();
            this.cbForceTournament = new System.Windows.Forms.CheckBox();
            this.grpForceSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(212, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Presets included in the group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(206, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Settings included in the group:";
            // 
            // cbPresetGroup
            // 
            this.cbPresetGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresetGroup.FormattingEnabled = true;
            this.cbPresetGroup.Items.AddRange(new object[] {
            "Full Chaos",
            "Classics",
            "Transform",
            "Broken Sequence",
            "Enemy Hunter",
            "Long Journey",
            "Chaotic Mix",
            "New Mechanics",
            "Limited Power",
            "One Castle",
            "Unique Gimmicks"});
            this.cbPresetGroup.Location = new System.Drawing.Point(71, 268);
            this.cbPresetGroup.Name = "cbPresetGroup";
            this.cbPresetGroup.Size = new System.Drawing.Size(132, 21);
            this.cbPresetGroup.TabIndex = 17;
            this.cbPresetGroup.SelectedIndexChanged += new System.EventHandler(this.cbPresetGroup_SelectedIndexChanged);
            // 
            // cbSettingsGroup
            // 
            this.cbSettingsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsGroup.FormattingEnabled = true;
            this.cbSettingsGroup.Items.AddRange(new object[] {
            "Full Chaos",
            "Basics",
            "Additions",
            "Visuals",
            "Chaos Castle"});
            this.cbSettingsGroup.Location = new System.Drawing.Point(71, 156);
            this.cbSettingsGroup.Name = "cbSettingsGroup";
            this.cbSettingsGroup.Size = new System.Drawing.Size(132, 21);
            this.cbSettingsGroup.TabIndex = 16;
            this.cbSettingsGroup.SelectedIndexChanged += new System.EventHandler(this.cbSettingsGroup_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(180, 486);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 30);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Shuffle the Chaos!";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(68, 22);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(368, 39);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(68, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Presets Group";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(68, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Settings Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresetsIncluded
            // 
            this.lblPresetsIncluded.BackColor = System.Drawing.Color.Transparent;
            this.lblPresetsIncluded.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresetsIncluded.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPresetsIncluded.Location = new System.Drawing.Point(212, 226);
            this.lblPresetsIncluded.Name = "lblPresetsIncluded";
            this.lblPresetsIncluded.Size = new System.Drawing.Size(286, 115);
            this.lblPresetsIncluded.TabIndex = 20;
            this.lblPresetsIncluded.Text = " ";
            // 
            // lblSettingsIncluded
            // 
            this.lblSettingsIncluded.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsIncluded.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsIncluded.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSettingsIncluded.Location = new System.Drawing.Point(206, 110);
            this.lblSettingsIncluded.Name = "lblSettingsIncluded";
            this.lblSettingsIncluded.Size = new System.Drawing.Size(292, 99);
            this.lblSettingsIncluded.TabIndex = 21;
            this.lblSettingsIncluded.Text = " ";
            // 
            // grpForceSettings
            // 
            this.grpForceSettings.BackColor = System.Drawing.Color.Transparent;
            this.grpForceSettings.Controls.Add(this.cbForcePrologue);
            this.grpForceSettings.Controls.Add(this.cbForceStartingEquipment);
            this.grpForceSettings.Controls.Add(this.cbForceItemLocations);
            this.grpForceSettings.Controls.Add(this.cbForceEnemyDrops);
            this.grpForceSettings.Controls.Add(this.label3);
            this.grpForceSettings.Controls.Add(this.cbForceEasy);
            this.grpForceSettings.Controls.Add(this.cbForceTournament);
            this.grpForceSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpForceSettings.Location = new System.Drawing.Point(71, 351);
            this.grpForceSettings.Name = "grpForceSettings";
            this.grpForceSettings.Size = new System.Drawing.Size(364, 112);
            this.grpForceSettings.TabIndex = 22;
            this.grpForceSettings.TabStop = false;
            this.grpForceSettings.Text = "Forced Settings";
            // 
            // cbForcePrologue
            // 
            this.cbForcePrologue.AutoSize = true;
            this.cbForcePrologue.Location = new System.Drawing.Point(191, 84);
            this.cbForcePrologue.Name = "cbForcePrologue";
            this.cbForcePrologue.Size = new System.Drawing.Size(120, 17);
            this.cbForcePrologue.TabIndex = 27;
            this.cbForcePrologue.Text = "Prologue Rewards";
            this.cbForcePrologue.UseVisualStyleBackColor = true;
            // 
            // cbForceStartingEquipment
            // 
            this.cbForceStartingEquipment.AutoSize = true;
            this.cbForceStartingEquipment.Location = new System.Drawing.Point(24, 84);
            this.cbForceStartingEquipment.Name = "cbForceStartingEquipment";
            this.cbForceStartingEquipment.Size = new System.Drawing.Size(126, 17);
            this.cbForceStartingEquipment.TabIndex = 26;
            this.cbForceStartingEquipment.Text = "Starting Equipment";
            this.cbForceStartingEquipment.UseVisualStyleBackColor = true;
            // 
            // cbForceItemLocations
            // 
            this.cbForceItemLocations.AutoSize = true;
            this.cbForceItemLocations.Location = new System.Drawing.Point(191, 61);
            this.cbForceItemLocations.Name = "cbForceItemLocations";
            this.cbForceItemLocations.Size = new System.Drawing.Size(100, 17);
            this.cbForceItemLocations.TabIndex = 25;
            this.cbForceItemLocations.Text = "Item Locations";
            this.cbForceItemLocations.UseVisualStyleBackColor = true;
            // 
            // cbForceEnemyDrops
            // 
            this.cbForceEnemyDrops.AutoSize = true;
            this.cbForceEnemyDrops.Location = new System.Drawing.Point(24, 61);
            this.cbForceEnemyDrops.Name = "cbForceEnemyDrops";
            this.cbForceEnemyDrops.Size = new System.Drawing.Size(93, 17);
            this.cbForceEnemyDrops.TabIndex = 24;
            this.cbForceEnemyDrops.Text = "Enemy Drops";
            this.cbForceEnemyDrops.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Any settings enabled here will be enabled regardless of Chaos";
            // 
            // cbForceEasy
            // 
            this.cbForceEasy.AutoSize = true;
            this.cbForceEasy.Location = new System.Drawing.Point(191, 38);
            this.cbForceEasy.Name = "cbForceEasy";
            this.cbForceEasy.Size = new System.Drawing.Size(81, 17);
            this.cbForceEasy.TabIndex = 1;
            this.cbForceEasy.Text = "Easy Mode";
            this.cbForceEasy.UseVisualStyleBackColor = true;
            // 
            // cbForceTournament
            // 
            this.cbForceTournament.AutoSize = true;
            this.cbForceTournament.Location = new System.Drawing.Point(24, 38);
            this.cbForceTournament.Name = "cbForceTournament";
            this.cbForceTournament.Size = new System.Drawing.Size(120, 17);
            this.cbForceTournament.TabIndex = 0;
            this.cbForceTournament.Text = "Tournament Mode";
            this.cbForceTournament.UseVisualStyleBackColor = true;
            // 
            // frmChaosMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SotNRandomizerLauncher.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 528);
            this.Controls.Add(this.grpForceSettings);
            this.Controls.Add(this.lblSettingsIncluded);
            this.Controls.Add(this.lblPresetsIncluded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPresetGroup);
            this.Controls.Add(this.cbSettingsGroup);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChaosMode";
            this.Text = "Chaos Mode";
            this.grpForceSettings.ResumeLayout(false);
            this.grpForceSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPresetGroup;
        private System.Windows.Forms.ComboBox cbSettingsGroup;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPresetsIncluded;
        private System.Windows.Forms.Label lblSettingsIncluded;
        private System.Windows.Forms.GroupBox grpForceSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbForceEasy;
        private System.Windows.Forms.CheckBox cbForceTournament;
        private System.Windows.Forms.CheckBox cbForcePrologue;
        private System.Windows.Forms.CheckBox cbForceStartingEquipment;
        private System.Windows.Forms.CheckBox cbForceItemLocations;
        private System.Windows.Forms.CheckBox cbForceEnemyDrops;
    }
}