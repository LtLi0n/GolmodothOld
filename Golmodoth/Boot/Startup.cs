using Golmodoth.Engine;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Golmodoth
{
    public class Startup
    {
        private readonly IServiceProvider _services;

        public ReadOnlyCollection<string> Args { get; }
        public ConsoleWindow Window { get; }

        public Startup(string[] args)
        {
            Args = new ReadOnlyCollection<string>(args);
            _services = CreateServices();

            Window = new ConsoleWindow(_services);
        }

        public IServiceProvider CreateServices()
        {
            ServiceCollection sc = new ServiceCollection();
            sc.AddSingleton<EntityDataService>();

            return sc.BuildServiceProvider();
        }

        public async Task StartAsync()
        {
            _services.GetService<EntityDataService>().InitializeStaticEntites();

            Window.Construct(50, 25, 20, 30, ConsoleGameEngine.FramerateMode.MaxFps);
            //await Task.Delay(-1);
        }
    }
}
