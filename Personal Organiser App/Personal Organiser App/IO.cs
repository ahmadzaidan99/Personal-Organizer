﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Personal_Organiser_App
{
    class IO
    {
        private string path;
        public IO(string path)
        {
            this.path = path;
        }
        public void ReadUserList()
        {
            try
            {
                using (var reader = new StreamReader(path))
                {
                    if (User.userList.Count > 0)
                    {
                        User.userList.Clear();
                    }
                    while (!reader.EndOfStream)
                    {                        
                        var line = reader.ReadLine();
                        if (line == "")
                            break;
                        var values = line.Split(',');
                        User user = new User(Hash.Decrypt(values[1]), Hash.Decrypt(values[2]), values[3], Hash.Decrypt(values[4]));
                        user.ID = int.Parse(values[0]);
                        user.firstName = Hash.Decrypt(values[5]);
                        user.surname = Hash.Decrypt(values[6]);
                        user.phoneNumber = Hash.Decrypt(values[7]);
                        user.emailAddress = Hash.Decrypt(values[8]);
                        values[9] = Hash.Decrypt(values[9]);
                        if (values[9].Contains("##CO##"))
                        {
                            values[9] = values[9].Replace("##CO##", ",");
                        }
                        user.address = values[9];
                        user.minimumSalary = Double.Parse(Hash.Decrypt(values[10]));
                        user.picture = values[11];
                        User.AddUserToList(user);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex);
                return;
            }
        }

      
        static public void WriteUserList(string path)
        {
            using (var w = new StreamWriter(path,false))
            {
                for (var i = 0; i<User.userList.Count; i++)
                {
                    var userID = User.userList[i].ID;
                    var username = Hash.Encrypt(User.userList[i].username);
                    var password = Hash.Encrypt(User.userList[i].password);
                    var remember = User.userList[i].remember;
                    var userType = Hash.Encrypt(User.userList[i].userType);
                    var firstName = Hash.Encrypt(User.userList[i].firstName);
                    var surname = Hash.Encrypt(User.userList[i].surname);
                    var phoneNumber = Hash.Encrypt(User.userList[i].phoneNumber);
                    var emailAddress = Hash.Encrypt(User.userList[i].emailAddress);
                    var address = Hash.Encrypt(User.userList[i].address);
                    var minimumSalary = Hash.Encrypt(User.userList[i].minimumSalary.ToString());
                    var picture = User.userList[i].picture;
                    if (address.Contains(","))
                    {
                        address = address.Replace(",", "##CO##");
                    }
                    var line = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", userID, username, password, remember, userType,firstName,surname, 
                        phoneNumber, emailAddress, address, minimumSalary, picture);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }

        public static string ReadRemindersList(int id)
        {
            string reminders = "";
            try
            {
                using (var reader = new StreamReader("reminders.csv"))
                {
                    User.userList[id].remindersList.Clear();
                    while (!reader.EndOfStream)
                    {
                        var line = Hash.Decrypt(reader.ReadLine());
                        var values = line.Split(',');
                        if (int.Parse(values[0]) == id)
                        {
                            reminders += line + ',';
                        }

                        string reminderDescription = values[5].ToString();
                        if (reminderDescription.Contains("##CO##"))
                        {
                            reminderDescription.Replace("##CO##", ",");
                        }

                        Reminder reminder = new Reminder(Convert.ToDateTime(values[1]), Convert.ToDateTime(values[2]),values[3],values[4],reminderDescription);
                        User.userList[id].remindersList.Add(reminder);
                    }
                    return reminders; 
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex);
                return "FileNotFound";
            }
        }

        static public bool AddReminder(string Entry, string Path = "reminders.csv")
        {
            using (StreamWriter w = File.AppendText(Path))
            {
                w.WriteLine(Hash.Encrypt(Entry));
                w.Flush();
                return true;
            }
        }

        static public bool DeleteReminder(int info, string path = "reminders.csv")
        {
            var tempFile = Path.GetTempFileName();
            int iter = 0;
            var linesToKeep = File.ReadLines(path).Where(l => iter++ != info);
            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete(path);
            File.Move(tempFile, path);
            return true;
        }
        public static string ReadPhonebook(int id)
        {
            string phonebook = "";
            try
            {
                using (var reader = new StreamReader("phonebook.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = Hash.Decrypt(reader.ReadLine());
                        var values = line.Split(',');
                        if (int.Parse(values[0]) == id)
                        {
                            phonebook += line + ',';
                        }
                    }
                    return phonebook;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.Write(ex);
                return "FileNotFound";
            }
        }

        //Checks if new record's Name,Surname and phone number are matching then returns T/F accordingly
        static public bool IsDuplicateEntry(string entry)
        {
            var entryValues = entry.Split(',');
            string phonebook = ReadPhonebook(int.Parse(entryValues[0]));
            var phonebookValues = phonebook.Split(',');
            for(int i = 0; i < phonebookValues.Length - 1; i += 6)
            {
                if(entryValues[1] == phonebookValues[i + 1] && entryValues[2] == phonebookValues[i + 2])
                {
                    if (entryValues[3] == phonebookValues[i + 3] && entryValues[4] == phonebookValues[i + 4])
                    {
                        if (entryValues[5] == phonebookValues[i + 5] && entryValues[6] == phonebookValues[i + 6])
                            return true;
                    }
                }
            }
            return false;
        }

        static public bool AddEntry(string Entry, string Path = "phonebook.csv")
        {
            using (StreamWriter w = File.AppendText(Path))
            {                
                w.WriteLine(Hash.Encrypt(Entry));
                w.Flush();
                return true;
            }
        }
        
        static public bool DeleteEntry(int info, string path = "phonebook.csv") {
            var tempFile = Path.GetTempFileName();
            int iter = 0;
            var linesToKeep = File.ReadLines(path).Where(l => iter++ != info);
            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete(path);
            File.Move(tempFile, path);
            return true;
        }
        
        static public void Tabbed(string path)
        {
            using (
                var w = new StreamWriter(path))
            {
                for (var i = 0; i<User.userList.Count; i++)
                {
                    var username = User.userList[i].username;
                    var password = User.userList[i].password;
                    var userType = User.userList[i].userType;
                    var line = string.Format("{0}\t{1}\t{2}", username, password, userType);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }
        static public string ReadNotes(int id) {
            string notes = "";
            try
            {
                using (var reader = new StreamReader("notes.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = Hash.Decrypt(reader.ReadLine());
                        var values = line.Split(',');
                        if (int.Parse(values[0]) == id)
                        {
                            notes += line + ',';
                        }
                    }
                    return notes;
                }
            }
            catch (FileNotFoundException ex)
            {
                return "FileNotFound";
            }
        }
        static public string PhotoBase64(System.Drawing.Bitmap imageBytes) {
            System.IO.MemoryStream ms = new MemoryStream();
            imageBytes.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            return Convert.ToBase64String(byteImage);
        }        
    }
}