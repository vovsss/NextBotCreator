using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace NextBotCreator
{
    public class Project
    {
        public readonly string Name;
        private string rootPath, addonPath;


        public string PathToIcon;
        public readonly string PathToPicture;

        public string SteamID;

        public Project(string name, string pathToIcon, string pathToPicture)
        {
            Name = name.ToLower().Replace(' ', '_');
            PathToIcon = pathToIcon;
            PathToPicture = pathToPicture;
            rootPath = Directory.GetCurrentDirectory() + "\\projects\\" + Name;
            Template.CopyTo(rootPath);

            var log = $"Created project {Name}\nPath to Icon: {pathToIcon}\nPath to Picture: {pathToPicture}";

            Logger.Log(log, "Project init");

            Build();
        }


        public void SaveSound(string file, string sound)
        {
            Logger.Log("Saved sound: " + sound, "SoundSaver");
            SoundUtils.ChangeBitrate(file, addonPath + "\\sound\\" + Name + "\\" + sound, 128);


        }

        public string[] GetPathsToSound()
        {
            return Directory.GetFiles(addonPath + "\\sound\\" + Name);
        }

        public void DeleteSoundFiles()
        {
            foreach (string path in GetPathsToSound())
            {
                Logger.Log("Deleted file " + path, "SoundFilesDeleter");
                new FileInfo(path).Delete();
            }
        }

        public void Build()
        {

            Logger.Log("Start building of " + Name, "Builder");

            var size = new System.Drawing.Size(512, 512);

            ImageTools.ResizePicture(PathToPicture, size);
            ImageTools.ResizePicture(PathToIcon, size);


            var png = ImageTools.GenerateWithFormat(PathToPicture, ImageFormat.Png);
            var vtf = ImageTools.GenerateVTF(png);
            var jpg = ImageTools.GenerateWithFormat(PathToIcon, ImageFormat.Jpeg);
            RenameAllDirectories(Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories));
            addonPath = rootPath + "\\" + Name;
            RenameAllDirectories(Directory.GetFiles(addonPath, "*", SearchOption.AllDirectories));


            File.Move(vtf, addonPath + "\\materials\\" + Name + $"\\{Name}.vtf");


            File.Move(png, addonPath + "\\materials\\entities\\" + Name + ".png");

            PathToIcon = rootPath + "\\icon.jpg";

            File.Move(jpg, PathToIcon);


            ReplaceContentOfAllFiles();

            Logger.Log("Finished building of " + Name, "Builder");
        }



        private void ReplaceContentOfAllFiles()
        {

            string[] RIGHT_SUFFIXES = new string[] { "vmt", "lua", "txt", "json" };

            var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories).Where(s => RIGHT_SUFFIXES.Contains(s.Split('.').Last<string>()));



            foreach (string dir in files)
            {
                string text = File.ReadAllText(dir);
                text = text.Replace("{project_name}", Name);
                File.WriteAllText(dir, text);

                Logger.Log("Content of file " + dir + " was updated");
            }

        }

        public void Publish()
        {


            var gModPath = File.ReadAllText("modules/gmod_path.txt");

            var gma = GMODUtils.GenerateGMA(addonPath, rootPath, gModPath + "\\bin\\gmad.exe");
            SteamID = GMODUtils.PublishGMA(gma, PathToIcon, gModPath + "\\bin\\gmpublish.exe");

            Logger.Log($"Project {Name} was succesfully published to Steam Workshop; steam_id = {SteamID}");

        }
        private void RenameAllDirectories(string[] dirs)
        {
            for (int i = dirs.Length - 1; i >= 0; i--)
            {

                var dir = dirs[i];


                string[] parts = dir.Split('\\');

                string lastPart = parts[parts.Length - 1];

                if (!lastPart.Contains("{project_name}")) continue;
                parts[parts.Length - 1] = lastPart.Replace("{project_name}", Name);

                var newDir = String.Join("\\", parts);

                Console.WriteLine(dir + newDir);


                Directory.Move(dir, newDir);
            }




        }
    }
}