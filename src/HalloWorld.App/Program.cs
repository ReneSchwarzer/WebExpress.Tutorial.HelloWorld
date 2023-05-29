using System.Reflection;

namespace HalloWorld.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new WebExpress.WebEx()
            {
                Name = Assembly.GetExecutingAssembly().GetName().Name
            };

            app.Execution(args);
        }
    }
}