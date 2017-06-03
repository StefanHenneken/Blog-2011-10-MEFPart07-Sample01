using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Logger;

namespace Host
{
    class Program
    {
        [Import]
        public ConsoleLogger Logger { get; set; }

        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);

            Logger.Log("Message A");
            Logger.Log("Message B");
            Logger.Log("Message C");
        }
    }
}
