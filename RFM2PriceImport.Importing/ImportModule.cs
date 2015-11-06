using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using RFM2PriceImport.Importing.Views;
using System.ComponentModel.Composition;

namespace RFM2PriceImport.Importing
{
    [ModuleExport(typeof(ImportModule))]
    public class ImportModule : IModule
    {
        [Import]
        public IRegionManager regionManager;

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion("MainNavigationRegion", typeof(ImportNavigationView));
        }
    }
}
