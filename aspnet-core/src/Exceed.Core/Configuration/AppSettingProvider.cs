﻿using System.Collections.Generic;
using Abp.Configuration;

namespace Exceed.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                new SettingDefinition(AppSettingNames.UiTheme, "red", scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                new SettingDefinition(AppSettingNames.AppInfo,"{\"Name\": \"易兒善 家装\",\"Desc\": \"\"}")
            };
        }
    }
}
