using System;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using EasySaveApp.model;
using System.Collections.Generic;
using System.Windows;

namespace EasySaveApp.viewmodel
{
    public class ViewModel
    {
        public bool blackilist_stop { get; set; }
        private Model model;

        public ViewModel()
        {
            model = new Model();
        }


        public void AddSaveModel(int type, string saveName, string sourceDir, string targetDir, string mirrorDir)//Function that allows you to add a backup
        {
            model.SaveName = saveName;
            Backup backup = new Backup(model.SaveName, sourceDir, targetDir, type, mirrorDir);
            model.AddSave(backup); // Calling the function to add a backup job
        }


        public List<string> ListBackup()//Function that lets you know the lists of the names of the backups.
        {

            List<string> nameslist = new List<string>();
            foreach (var obj in model.NameList())
            {
               nameslist.Add(obj.SaveName);
            }
            return nameslist;
        }

        public void LoadBackup(string backupname)//Function that allows you to load the backups that were selected by the user.
        {
            blackilist_stop = true;

            
                model.LoadSave(backupname);//Function that launches backups
            
        }

        
    }
}
