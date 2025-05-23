using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivalPatcher
{
    public enum PluginFilter
    {
        [SettingName("All Plugins")]
        [Tooltip("Process all plugins in the load order")]
        AllPlugins,

        [SettingName("Exclude Plugins")]
        [Tooltip("Process all plugins except those in the exclude list")]
        ExcludePlugins
    }

    internal class Settings
    {
        [SettingName("Plugin Exclude List")]
        [Tooltip("List of plugins to exclude (semicolon separated)")]
        [JsonProperty]
        public string PluginExcludeList { get; set; } = "";

        [SettingName("Plugin Processing")]
        [Tooltip("Choose which plugins to process")]
        [JsonProperty(ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PluginFilter PluginFilter { get; set; } = PluginFilter.AllPlugins;

    }
}
