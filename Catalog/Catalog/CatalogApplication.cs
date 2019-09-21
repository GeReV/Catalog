﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using Catalog.Model;
using Eto;
using Eto.Forms;
using LiteDB;

namespace Catalog
{
    public class CatalogApplication : Application
    {
        public CatalogDatabase Database { get; private set; }

        public string HomeDirectory { get; private set; }

        public static new CatalogApplication Instance
        {
            get { return Application.Instance as CatalogApplication; }
        }

        public CatalogApplication()
        {
        }

        public CatalogApplication(string platformType) : base(platformType)
        {
        }

        public CatalogApplication(Eto.Platform platform) : base(platform)
        {
            Name = Assembly.GetExecutingAssembly().GetName().Name;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            string settingsDirectory = EtoEnvironment.GetFolderPath(EtoSpecialFolder.ApplicationSettings);

            HomeDirectory = Path.Combine(settingsDirectory, Name);

            if (!Directory.Exists(HomeDirectory))
            {
                Directory.CreateDirectory(HomeDirectory);
            }

            Database = new CatalogDatabase(Path.Combine(HomeDirectory, "database.litedb"));
        }

        protected override void OnTerminating(CancelEventArgs e)
        {
            Database.Dispose();

            base.OnTerminating(e);
        }
    }
}
