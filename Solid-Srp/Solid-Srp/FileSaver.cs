using System.IO;

namespace Solid_Srp
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, ISavable report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}

