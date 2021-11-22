using XamEFCoreLab13.Interfaces;
using System.IO;
using Xamarin.Forms;
using XamEFCore_lab13.Droid.Implementations;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace XamEFCore_lab13.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }

    }
}