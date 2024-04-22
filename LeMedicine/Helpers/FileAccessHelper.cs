namespace LeMedicine.Helpers
{
    public class FileAccessHelper
    {
        public static string? GetPathFile(string file)
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, file);
        }
        public static string? GetAppDirectory(string v)
        {
            return FileSystem.AppDataDirectory;
        }
    }
}
