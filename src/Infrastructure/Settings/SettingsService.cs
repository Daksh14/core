﻿using Codidact.Core.Application.Common.Interfaces;

namespace Codidact.Core.Infrastructure.Settings
{
    /// <summary>
    /// Gets the settings for the platform
    /// </summary>
    public class SettingsService : ISettingsService
    {
        /// <summary>
        /// Gets the currently used platform from platform settings file
        /// </summary>
        /// <returns>Platform name</returns>
        public string GetPlatformName()
        {
            return PlatformSettings.PlatformName;
        }
        /// <summary>
        /// Gets the platform accent color from platform settings file
        /// </summary>
        /// <returns>Platform accent color</returns>
        public string GetPlatformAccentColor()
        {
            return PlatformSettings.PlatformAccentColor;
        }
    }
}
