using System.Diagnostics;

namespace Voltsoft.FileVersion
{
    public static class FileVersion
    {
        public static string Get(string pathToFile)
        {
            string fileVersion;

            try
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(pathToFile);
                fileVersion = versionInfo.FileVersion;
            }
            catch (System.IO.FileNotFoundException)
            {
                fileVersion = null;
            }
            return fileVersion;
        }
    }
}
