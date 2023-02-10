using System;
using System.Collections.Generic;
using System.Text;
using EasySaveApp.controller;
using EasySaveApp.model;

namespace EasySaveApp.view
{
    class View
    {
        //Display on the console a welcome message
        public void ViewStart()
        {
            Console.WriteLine(" _____                _____                   _   _  __   _____ ");
            Console.WriteLine("|  ___|              /  ___|                 | | | |/  | |  _  |");
            Console.WriteLine("| |__  __ _ ___ _   _\\ `--.  __ ___   _____  | | | |`| | | |/' |");
            Console.WriteLine("|  __|/ _` / __| | | |`--. \\/ _` \\ \\ / / _ \\ | | | | | | |  /| |");
            Console.WriteLine("| |__| (_| \\__ \\ |_| /\\__/ / (_| |\\ V /  __/ \\ \\_/ /_| |_\\ |_/ /");
            Console.WriteLine("\\____/\\__,_|___/\\__, \\____/ \\__,_| \\_/ \\___|  \\___/ \\___(_)___/");
            Console.WriteLine("                 __/ |                                          ");
            Console.WriteLine("                |___/                                           ");

        }
        //Display on the console the menu
        public void ViewMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Open a backup job");
            Console.WriteLine("2. Create a backup job");
            Console.Write("Enter the function you want : ");
        }
        //Display on the console the menu of backup jobs
        public void ViewBackupMenu()
        {
            Console.WriteLine("Backup jobs");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Complete Save");
            Console.WriteLine("2. Differential Save");
            Console.Write("Please enter the type of save you want : ");
        }
        //Display on the console when you enter the name of the save
        public void EnterName()
        {
            Console.WriteLine("Please enter the name of the backup job : ");
        }
        //Display on the console when you have to enter the path of the folder that you want to back up
        public void EnterSourceFold()
        {
            Console.WriteLine("Drag and drop here the folder you want to backup :");
        }
        //Display on the console when you have to enter the path of the folder that you want to back up
        public void EnterTargetFold()
        {
            Console.WriteLine("Drag and drop here the destination folder where you want to backup  :");
        }

        public void EnterMirrorFold()
        {
            Console.WriteLine("Drag and drop here the folder for the mirror backup  :");
        }
        //Display on the console an error message
        public void MenuError(string result)
        {
            Console.WriteLine(result);
        }
        //Display on the console when you have to enter the name of backup
        public void ViewFile()
        {
            Console.Write("Enter the name of the backup : ");
        }
        //Display on the console when you have to enter the name of backups
        public void ViewFileName()
        {
            Console.Clear();
            Console.WriteLine("Backups available : ");
        }
    }
}
