using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace NextBotCreator
{
    public static class Template
    {

        private static string templateDir = "modules/templates";

        public static void CopyTo(string newFolder)
        {
            CopyDirectories(newFolder);
            CopyFiles(newFolder);
        }

        private static void CopyDirectories(string newFolder)
        {
            foreach (string dirPath in Directory.GetDirectories(templateDir, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(templateDir, newFolder));
        }

        private static void CopyFiles(string newFolder)
        {
            foreach (string newPath in Directory.GetFiles(templateDir, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(templateDir, newFolder), true);
        }

    }

    public static class ImageTools
    {

        private static string VTFGeneratorDir = "modules\\vtfcmd\\VTFCmd.exe";
        private static string args = "-file \"{file}\" -format \"dxt5\"";


        public static string GenerateWithFormat(string from, ImageFormat format)
        {
            Bitmap bitmap;
            using (Image image = Image.FromFile(from))
            {
                bitmap = new Bitmap(image);

            }




            var newFile = FileUtils.ReplaceSuffix(from, format.ToString().ToLower());

            if (newFile == from) new FileInfo(from).Delete();

            bitmap.Save(newFile, format);
            return newFile;
        }

        public static string GenerateVTF(string from)
        {
            ResizePicture(from, new Size(512, 512));

            FileUtils.ExecuteProcess(VTFGeneratorDir, (args.Replace("{file}", from)).Replace("\\", "/").Replace("\\", "/"));
            return FileUtils.ReplaceSuffix(from, "vtf");

        }


        public static string ResizePicture(string dir, Size size)
        {

            Bitmap bitmap;

            using (Image image = Image.FromFile(dir))
            {
                bitmap = new Bitmap(image, size);
            }

            new FileInfo(dir).Delete();
            bitmap.Save(dir);



            return dir;
        }


    }

    public static class FileUtils
    {

        public static string ExecuteProcess(string filename, string args)
        {

            Logger.Log($"Start of executing process {filename} with args:\n{args}");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = $"\"{filename}\"",
                Arguments = args,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false

            };

            var lineCount = 0;
            string output = "";

            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!String.IsNullOrEmpty(e.Data))
                {
                    lineCount++;
                    output += ("\n[" + lineCount + "]: " + e.Data);
                }
            });

            process.StartInfo = startInfo;
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
            process.Dispose();

            Logger.Log(output, filename);
            return output;

        }

        public static string ReplaceSuffix(string from, string to)
        {
            var parts = from.Split('.');
            parts[parts.Length - 1] = to;

            return String.Join(".", parts);
        }



    }


    public static class GMODUtils
    {
        public static string GenerateGMA(string from, string to, string generator_path)
        {



            Logger.Log("Start of generating GMA");


            var parts = from.Split('\\');
            FileUtils.ExecuteProcess(generator_path, $"create -folder \"{from}\" -out \"{to}\\{parts[parts.Length - 1]}.gma\"");



            Logger.Log("GMA was succesfully generated");

            return to + "\\" + parts[parts.Length - 1] + ".gma";

        }

        public static string PublishGMA(string gma, string icon, string publisher_path)
        {

            var o = FileUtils.ExecuteProcess(publisher_path, $"create -addon \"{gma}\" -icon \"{icon}\"");
            var steamLink = "http://steamcommunity.com/sharedfiles/filedetails/?id=";

            var p = o.Split(new string[] { steamLink }, StringSplitOptions.None);
            try
            {
                return steamLink + p[1];
            }
            catch (IndexOutOfRangeException)
            {
                return "ERROR";
            }

        }

    }


    public static class SoundUtils
    {



        public static void ChangeBitrate(string file, string copyTo, int newBitrate)
        {



            FileUtils.ExecuteProcess("modules\\ffmpeg\\ffmpeg.exe", $"-i \"{file}\" -ab {newBitrate}k \"{copyTo}\"");



        }
    }

}
