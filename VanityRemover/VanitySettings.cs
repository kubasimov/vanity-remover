﻿using System;
using System.Configuration;
using System.Drawing;

namespace FolderVanityRemover
{
    class VanitySettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string LastFolder
        {
            get
            {
                return ((string)this["LastFolder"]);
            }
            set
            {
                this["LastFolder"] = (string)value;
            }
        }
    }
}