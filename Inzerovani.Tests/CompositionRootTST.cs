﻿using DataAccessLayer;
using DryIoc;
using System.Configuration;

namespace Inzerovani.Tests
{
    public class CompositionRootTST
    {
        public void Compose()
        {
            var compositionRoot = new CompositionRoot.CompositionRoot();
            compositionRoot.Compose();
            var IocContainer = compositionRoot.IocContainer;

            //IocContainer.Register<IAllDaos, AllDaos>();

            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["ConnectionStringLocal"];
            IocContainer.UseInstance(connString);

            DalInitializer.Init();
        }
    }
}
