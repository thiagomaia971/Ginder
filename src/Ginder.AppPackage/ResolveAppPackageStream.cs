using System.IO;

namespace Ginder.AppPackage
{
    public static class AppPackageHelper
    {
        public const string BlazorAppPackageName = "Ginder.Blazor.zip";

        public static Stream ResolveAppPackageStream()
        {
            //This app assembly
            var assembly = typeof(AppPackageHelper).Assembly;

            //Name of our current Blazor package in this project, stored as an "Embedded Resource"
            //The file is resolved through AssemblyName.FolderAsNamespace.YourPackageNameFile
            //In this example, the result would be Ginder.Package.Ginder.Blazor.zip
            return assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Package.{BlazorAppPackageName}");
        }
    }
}
