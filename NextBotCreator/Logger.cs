using System;

using System.IO;

namespace NextBotCreator
{
    public static class Logger
    {

        private static string logPath = "log.txt";

        public static void Log(string info, string by = "")
        {

            info = $"[{DateTime.Now}] {by}\n\n" + info + "\n\n";

            logPath = Path.GetFullPath(logPath);


            File.AppendAllText(logPath, info + "\n\n\n");

        }

        public static void StartLog()
        {
            File.WriteAllText(logPath, "");
            Log("Logging starts", "Logger");
        }





    }
}
