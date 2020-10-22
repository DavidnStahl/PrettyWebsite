using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Business.Initializers
{

        [InitializableModule]
        [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
        public class CategoryInitialization : IInitializableModule
        {

            public void Initialize(InitializationEngine context)
            {
                CreateCategories();
            }

            private void CreateCategories()
            {
                var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
                var root = categoryRepository.GetRoot();

                if (categoryRepository.Get("[DataType]") == null)
                {
                    var systemCategory = new Category(root, "[DataType]")
                    {
                        Description = "[DataType]",
                        Selectable = false
                    };

                    categoryRepository.Save(systemCategory);

                    var system = categoryRepository.Get("[DataType]");

                    var type = new Category(system, "RssFeed")
                    {
                        Description = "RssFeed",
                        Selectable = true
                    };

                    categoryRepository.Save(type);
                }
               
            }

            public void Uninitialize(InitializationEngine context)
            {
                throw new NotImplementedException();
            }
        }
    
}