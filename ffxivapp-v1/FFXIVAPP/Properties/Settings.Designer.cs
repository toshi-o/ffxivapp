﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFXIVAPP.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DebugMode {
            get {
                return ((bool)(this["DebugMode"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Application_UpgradeRequired {
            get {
                return ((bool)(this["Application_UpgradeRequired"]));
            }
            set {
                this["Application_UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Top {
            get {
                return ((int)(this["Top"]));
            }
            set {
                this["Top"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Left {
            get {
                return ((int)(this["Left"]));
            }
            set {
                this["Left"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("720")]
        public int Width {
            get {
                return ((int)(this["Width"]));
            }
            set {
                this["Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("480")]
        public int Height {
            get {
                return ((int)(this["Height"]));
            }
            set {
                this["Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TopMost {
            get {
                return ((bool)(this["TopMost"]));
            }
            set {
                this["TopMost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableChat {
            get {
                return ((bool)(this["EnableChat"]));
            }
            set {
                this["EnableChat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableLog {
            get {
                return ((bool)(this["EnableLog"]));
            }
            set {
                this["EnableLog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableParse {
            get {
                return ((bool)(this["EnableParse"]));
            }
            set {
                this["EnableParse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableEvent {
            get {
                return ((bool)(this["EnableEvent"]));
            }
            set {
                this["EnableEvent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SiteName {
            get {
                return ((string)(this["SiteName"]));
            }
            set {
                this["SiteName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string APIKey {
            get {
                return ((string)(this["APIKey"]));
            }
            set {
                this["APIKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CharacterName {
            get {
                return ((string)(this["CharacterName"]));
            }
            set {
                this["CharacterName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Server {
            get {
                return ((string)(this["Server"]));
            }
            set {
                this["Server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ServerName {
            get {
                return ((string)(this["ServerName"]));
            }
            set {
                this["ServerName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Durandal</string>
  <string>Hyperion</string>
  <string>Masamune</string>
  <string>Gungnir</string>
  <string>Aegis</string>
  <string>Sargatanas</string>
  <string>Balmung</string>
  <string>Ridill</string>
  <string>Excalibur</string>
  <string>Ragnarok</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ServerList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ServerList"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FirstName {
            get {
                return ((string)(this["FirstName"]));
            }
            set {
                this["FirstName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastName {
            get {
                return ((string)(this["LastName"]));
            }
            set {
                this["LastName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CICUID {
            get {
                return ((string)(this["CICUID"]));
            }
            set {
                this["CICUID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF000000")]
        public global::System.Windows.Media.Color Color_ChatlogBackground {
            get {
                return ((global::System.Windows.Media.Color)(this["Color_ChatlogBackground"]));
            }
            set {
                this["Color_ChatlogBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF800080")]
        public global::System.Windows.Media.Color Color_TimeStamp {
            get {
                return ((global::System.Windows.Media.Color)(this["Color_TimeStamp"]));
            }
            set {
                this["Color_TimeStamp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 12pt")]
        public global::System.Drawing.Font LogFont {
            get {
                return ((global::System.Drawing.Font)(this["LogFont"]));
            }
            set {
                this["LogFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Parse_ExportXML {
            get {
                return ((bool)(this["Parse_ExportXML"]));
            }
            set {
                this["Parse_ExportXML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Parse_SaveLog {
            get {
                return ((bool)(this["Parse_SaveLog"]));
            }
            set {
                this["Parse_SaveLog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UploadParse {
            get {
                return ((bool)(this["UploadParse"]));
            }
            set {
                this["UploadParse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MobAbility {
            get {
                return ((bool)(this["MobAbility"]));
            }
            set {
                this["MobAbility"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PartyStats {
            get {
                return ((bool)(this["PartyStats"]));
            }
            set {
                this["PartyStats"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HealingStats {
            get {
                return ((bool)(this["HealingStats"]));
            }
            set {
                this["HealingStats"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DamageStats {
            get {
                return ((bool)(this["DamageStats"]));
            }
            set {
                this["DamageStats"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MonsterStats {
            get {
                return ((bool)(this["MonsterStats"]));
            }
            set {
                this["MonsterStats"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Debug {
            get {
                return ((bool)(this["Debug"]));
            }
            set {
                this["Debug"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AbilityPlayerDetail {
            get {
                return ((bool)(this["AbilityPlayerDetail"]));
            }
            set {
                this["AbilityPlayerDetail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AbilityPlayerMonster {
            get {
                return ((bool)(this["AbilityPlayerMonster"]));
            }
            set {
                this["AbilityPlayerMonster"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AbilityPlayerMonsterDetails {
            get {
                return ((bool)(this["AbilityPlayerMonsterDetails"]));
            }
            set {
                this["AbilityPlayerMonsterDetails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HealingAbilties {
            get {
                return ((bool)(this["HealingAbilties"]));
            }
            set {
                this["HealingAbilties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HealingPlayers {
            get {
                return ((bool)(this["HealingPlayers"]));
            }
            set {
                this["HealingPlayers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HealingDetails {
            get {
                return ((bool)(this["HealingDetails"]));
            }
            set {
                this["HealingDetails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DamageDetailMonster {
            get {
                return ((bool)(this["DamageDetailMonster"]));
            }
            set {
                this["DamageDetailMonster"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DamageDetailAbilties {
            get {
                return ((bool)(this["DamageDetailAbilties"]));
            }
            set {
                this["DamageDetailAbilties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MonsterDetailsDrops {
            get {
                return ((bool)(this["MonsterDetailsDrops"]));
            }
            set {
                this["MonsterDetailsDrops"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MonsterDetailAbilities {
            get {
                return ((bool)(this["MonsterDetailAbilities"]));
            }
            set {
                this["MonsterDetailAbilities"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WebsiteControl {
            get {
                return ((bool)(this["WebsiteControl"]));
            }
            set {
                this["WebsiteControl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Log_SaveLog {
            get {
                return ((bool)(this["Log_SaveLog"]));
            }
            set {
                this["Log_SaveLog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowAll {
            get {
                return ((bool)(this["ShowAll"]));
            }
            set {
                this["ShowAll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowDebug {
            get {
                return ((bool)(this["ShowDebug"]));
            }
            set {
                this["ShowDebug"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Translate {
            get {
                return ((bool)(this["Translate"]));
            }
            set {
                this["Translate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SendToGame {
            get {
                return ((bool)(this["SendToGame"]));
            }
            set {
                this["SendToGame"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Romanization {
            get {
                return ((bool)(this["Romanization"]));
            }
            set {
                this["Romanization"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TranslateJPOnly {
            get {
                return ((bool)(this["TranslateJPOnly"]));
            }
            set {
                this["TranslateJPOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string TranslateTo {
            get {
                return ((string)(this["TranslateTo"]));
            }
            set {
                this["TranslateTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Say {
            get {
                return ((bool)(this["Say"]));
            }
            set {
                this["Say"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Tell {
            get {
                return ((bool)(this["Tell"]));
            }
            set {
                this["Tell"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Party {
            get {
                return ((bool)(this["Party"]));
            }
            set {
                this["Party"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LS {
            get {
                return ((bool)(this["LS"]));
            }
            set {
                this["LS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Shout {
            get {
                return ((bool)(this["Shout"]));
            }
            set {
                this["Shout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ASCII {
            get {
                return ((bool)(this["ASCII"]));
            }
            set {
                this["ASCII"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TranslateToEcho {
            get {
                return ((bool)(this["TranslateToEcho"]));
            }
            set {
                this["TranslateToEcho"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Japanese")]
        public string ManualTranslate {
            get {
                return ((string)(this["ManualTranslate"]));
            }
            set {
                this["ManualTranslate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>English</string>
  <string>Japanese</string>
  <string>French</string>
  <string>German</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection LanguageList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LanguageList"]));
            }
            set {
                this["LanguageList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Red|Light</string>
  <string>Green|Light</string>
  <string>Blue|Light</string>
  <string>Purple|Light</string>
  <string>Orange|Light</string>
  <string>Red|Dark</string>
  <string>Green|Dark</string>
  <string>Blue|Dark</string>
  <string>Purple|Dark</string>
  <string>Orange|Dark</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ThemeList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ThemeList"]));
            }
            set {
                this["ThemeList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orange|Light")]
        public string Theme {
            get {
                return ((string)(this["Theme"]));
            }
            set {
                this["Theme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public string LogZoomLevel {
            get {
                return ((string)(this["LogZoomLevel"]));
            }
            set {
                this["LogZoomLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red|Light")]
        public string ChatTheme {
            get {
                return ((string)(this["ChatTheme"]));
            }
            set {
                this["ChatTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Blue|Light")]
        public string LogTheme {
            get {
                return ((string)(this["LogTheme"]));
            }
            set {
                this["LogTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Green|Light")]
        public string ParseTheme {
            get {
                return ((string)(this["ParseTheme"]));
            }
            set {
                this["ParseTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Albanian</string>
  <string>Arabic</string>
  <string>Bulgarian</string>
  <string>Catalan</string>
  <string>Chinese (Simplified)</string>
  <string>Chinese (Traditional)</string>
  <string>Croatian</string>
  <string>Czech</string>
  <string>Danish</string>
  <string>Dutch</string>
  <string>English</string>
  <string>Estonian</string>
  <string>Filipino</string>
  <string>Finnish</string>
  <string>French</string>
  <string>Galician</string>
  <string>German</string>
  <string>Greek</string>
  <string>Hebrew</string>
  <string>Hindi</string>
  <string>Hungarian</string>
  <string>Indonesian</string>
  <string>Italian</string>
  <string>Japanese</string>
  <string>Korean</string>
  <string>Latvian</string>
  <string>Lithuanian</string>
  <string>Maltese</string>
  <string>Norwegian</string>
  <string>Polish</string>
  <string>Portuguese</string>
  <string>Romanian</string>
  <string>Russian</string>
  <string>Serbian</string>
  <string>Slovak</string>
  <string>Slovenian</string>
  <string>Spanish</string>
  <string>Swedish</string>
  <string>Thai</string>
  <string>Turkish</string>
  <string>Ukrainian</string>
  <string>Vietnamese</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection TranslateLanguages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TranslateLanguages"]));
            }
            set {
                this["TranslateLanguages"] = value;
            }
        }
    }
}
