using System;
using Newtonsoft.Json;


namespace BackupApplication
{
    class BackupJob
    {
        public string Name { get; set; }
        public string SourceDirectory { get; set; }
        public string TargetDirectory { get; set; }
        public string Type { get; set; }

        public BackupJob(string name, string sourceDirectory, string targetDirectory, string type)
        {
            Name = name;
            SourceDirectory = sourceDirectory;
            TargetDirectory = targetDirectory;
            Type = type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var backupJobs = new List<BackupJob>();

            Console.WriteLine("Bienvenue dans l'application de sauvegarde");
            Console.WriteLine("Veuillez créer jusqu'à 5 tâches de sauvegarde");

            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("Entrez le nom de la tâche de sauvegarde " + (counter + 1));
                var name = Console.ReadLine();

                Console.WriteLine("Entrez le répertoire source du travail de sauvegarde " + (counter + 1));
                var sourceDirectory = Console.ReadLine();

                Console.WriteLine("Entrez le répertoire cible du travail de sauvegarde " + (counter + 1));
                var targetDirectory = Console.ReadLine();

                Console.WriteLine("Entrez le type de tâche de sauvegarde " + (counter + 1) + " (full ou differential)");
                var type = Console.ReadLine();

                backupJobs.Add(new BackupJob(name, sourceDirectory, targetDirectory, type));

                counter++;
            }

            Console.WriteLine("Entrez 1 pour exécuter une tâche de sauvegarde spécifique ou 2 pour exécuter toutes les tâches de sauvegarde");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Entrez le numéro de la tâche de sauvegarde que vous souhaitez exécuter");
                var jobNumber = Convert.ToInt32(Console.ReadLine());
                ExecuteBackupJob(backupJobs[jobNumber - 1]);
            }
            else if (userInput == "2")
            {
                foreach (var backupJob in backupJobs)
                {
                    ExecuteBackupJob(backupJob);
                }
            }

            Console.WriteLine("Processus de sauvegarde terminé");
        }

        static void ExecuteBackupJob(BackupJob backupJob)
        {
            var logFile = "BackupLog.txt";

            var sourceDirectoryInfo = new DirectoryInfo(backupJob.SourceDirectory);
            var targetDirectoryInfo = new DirectoryInfo(backupJob.TargetDirectory);

            Console.WriteLine("Démarrage de la tâche de sauvegarde: " + backupJob.Name);

            try
            {
                foreach (var file in sourceDirectoryInfo.GetFiles())
                {
                    var sourceFile = Path.Combine(sourceDirectoryInfo.FullName, file.Name);
                    var targetFile = Path.Combine(targetDirectoryInfo.FullName, file.Name);
                    var timestamp = DateTime.Now;
                    var transferTime = 0;

                    using (var sourceStream = file.OpenRead())
                    using (var targetStream = File.Create(targetFile))
                    {
                        var startTime = DateTime.Now;
                        sourceStream.CopyTo(targetStream);
                        transferTime = (int)(DateTime.Now - startTime).TotalMilliseconds;
                    }
                    using (var logStream = File.AppendText(logFile))
                    {

                        logStream.WriteLine("{0} {1} {2} {3} {4} {5}", timestamp, backupJob.Name, sourceFile, targetFile, file.Length, transferTime);
                        back_to_json(backupJob, file, transferTime);

                    }
                }
            }
            catch (Exception ex)
            {
                using (var logStream = File.AppendText(logFile))
                {
                    logStream.WriteLine("{0} {1} {2} {3} {4} {5}", DateTime.Now, backupJob.Name, backupJob.SourceDirectory, backupJob.TargetDirectory, 0, -1);
                }
                Console.WriteLine("Une erreur s'est produite lors du processus de sauvegarde: " + ex.Message);
            }
        }

        static void back_to_json(BackupJob backupJob, FileInfo? file, int transferTime)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["Name :"] = backupJob.Name;
            dictionary["FileSource :"] = backupJob.SourceDirectory;
            dictionary["FileTarget :"] = backupJob.TargetDirectory;
            dictionary["destPath :"] = "";
            if (file != null)
            {
                dictionary["FileSize :"] = file.Length.ToString();
            }
            else
            {
                dictionary["FileSize :"] = "";
            }

            dictionary["FileTransferTime :"] = DateTime.Now.ToString();
            dictionary["time :"] = transferTime.ToString();
            WriteDictionaryToJsonFile(dictionary, "dictionary.json");

        }

        static void WriteDictionaryToJsonFile(Dictionary<string, string> dictionary, string filePath)
        {
            string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);

            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
