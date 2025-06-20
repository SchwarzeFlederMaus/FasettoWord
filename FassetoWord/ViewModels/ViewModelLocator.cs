﻿using FasettoWordCore;

namespace FasettoWord
{
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; } = new();

        public static ApplicationViewModel ApplicationViewModel => IoC.Application;
        public static SettingsViewModel SettingsViewModel => IoC.Settings;
    }
}
