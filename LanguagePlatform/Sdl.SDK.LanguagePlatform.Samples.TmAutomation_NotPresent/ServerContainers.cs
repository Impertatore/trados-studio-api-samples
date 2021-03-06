﻿namespace Sdl.SDK.LanguagePlatform.Samples.TmAutomation
{
    using System.Windows.Forms;
    using Sdl.LanguagePlatform.TranslationMemoryApi;

    public class ServerContainers
    {
        #region "get"
        public void GetDBContainers(TranslationProviderServer tmServer)
        {
            string dbInfo = string.Empty;

            foreach (TranslationMemoryContainer container in tmServer.GetContainers(ContainerProperties.None))
            {
                dbInfo += "DB Name: " + container.DatabaseName + "\n";
                dbInfo += "Friendly name: " + container.Name + "\n";
                dbInfo += "DB Server: " + container.DatabaseServer + "\n";
                dbInfo += "Description: " + container.Description + "\n\n";
                dbInfo += "ParentOrganization: " + container.ParentResourceGroupPath + "\n\n";
            }

            MessageBox.Show(dbInfo);
        }
        #endregion
    }
}
