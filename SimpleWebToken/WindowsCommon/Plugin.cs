﻿using Cheesebaron.MvxPlugins.SimpleWebToken.Interfaces;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace Cheesebaron.MvxPlugins.SimpleWebToken.WindowsCommon
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<ISimpleWebToken, SimpleWebToken>();
        }
    }
}
