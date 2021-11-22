using System;
using System.IO;
using Xamarin.Forms;
using XamEFCore_lab13.iOS.Implementations;
using XamEFCoreLab13.Interfaces;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace XamEFCore_lab13.iOS.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseFileName);
        }

    }
}