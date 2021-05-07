using System.Linq;
using System.Reflection;

namespace Vorabi._2018
{
    public static class EmbeddedHelper
    {
        public static string GetResourcePath(string name)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
            //if (!name.StartsWith(nameof(Termin)))
            //{
            resourcePath = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith(name));
            //}

            return resourcePath;
        }
    }
}