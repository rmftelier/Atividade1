namespace AstroAPI.Util
{
    public class FileUtil
    {        
        /// <summary>
             /// Obtem o caminho do projeto
             /// </summary>
             /// <returns></returns>
        private static string GetPathProjeto()
        {
            return Environment.CurrentDirectory;
        }

        public static List<string> ReadLines(string filename)
        {
            filename = GetPathProjeto() + @"\" + filename;
            return File.ReadLines(filename).ToList();
        }
    }
}
