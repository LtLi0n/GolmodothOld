using System;
using Microsoft.Extensions.DependencyInjection;

namespace Golmodoth
{
    public class EntityDataService
    {
        private readonly IServiceProvider _services;

        public EntityDataService()
        {
            ServiceCollection sc = new ServiceCollection();
            sc.AddSingleton<MapContainer>();
            sc.AddSingleton<TileContainer>();
            _services = sc.BuildServiceProvider();
        }

        public T GetContainer<T>() where T : EntityContainerBase => _services.GetService<T>();

        public void InitializeStaticEntites()
        {
            GetContainer<MapContainer>().Load();
            GetContainer<TileContainer>().Load();
        }
    }
}
