﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Unnamed_Weather_App
{
    public static class Admin
    {
        // Global variables and data
        public static string apiKey = "8d01ea4154ae0c796aa21af303777837";
        public static string localDataPath = "data/local.txt";
        public static string accountDataPath = "data/acc.txt";
        public static string forecastDataPath = "data/forecast.json";
        public static string user = "";

        // Account management
        public static bool LogIn(string username, string password) {
            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();
            List<string> data = File.ReadAllLines(accountDataPath).ToList();

            for (int i = 0; i < data.Count(); i++) {
                string[] point = data[i].Split('|');
                usernames.Add(point[0]);
                passwords.Add(point[1]);
            }

            for (int i = 0; i < usernames.Count; i++) { 
                if (username == usernames[i] && password == passwords[i]) {
                    return true; // Log in succedeed
                }
            }

            return false; // Log in failed
        }

        public static void SignUp(string username, string password) {
            StreamWriter writer = new StreamWriter(accountDataPath, true);
            writer.WriteLine(username + "|" + password);
            writer.Close();
            return;
        }

        public static int ChangePassword(string oldPassword, string password, string repeatedPassword) {
            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();
            List<string> data = File.ReadAllLines(accountDataPath).ToList();

            for (int i = 0; i < data.Count(); i++) {
                string[] point = data[i].Split('|');
                usernames.Add(point[0]);
                passwords.Add(point[1]);
            }

            for (int i = 0; i < usernames.Count; i++) { 
                if (user == usernames[i] && oldPassword == passwords[i]) {
                    if (password == repeatedPassword) { 
                        passwords[i] = password;
                        
                        StreamWriter writer = new StreamWriter(accountDataPath, false);
                        for (i = 0; i < usernames.Count; i++) writer.WriteLine(usernames[i] + "|" + passwords[i]);
                        writer.Close();
                        
                        return 1; // Password change successful
                    } else {
                        return 0; // Password change unsuccessful because the new passwords don't match up
                    }
                }
            }

            return -1; // Password change unsuccessful because the old password was not entered correctly
        }

        // App management
        public static List<string> FetchCities() { 
            return File.ReadAllLines(localDataPath).ToList();
        }

        public static bool AddCity(string name, string id) {
            if (name == "" || id == "") return false;
            
            StreamWriter writer = new StreamWriter(localDataPath, true);
            writer.WriteLine(name + "|" + id);
            writer.Close();
            return true;
        }

        // Weather data management
        public static Root FetchWeatherData(int _cityID, string _apiKey) {
            WebClient client = new WebClient();
            client.DownloadFile("https://api.openweathermap.org/data/2.5/forecast?id=" + _cityID + "&appid=" + _apiKey, forecastDataPath);

            StreamReader reader = new StreamReader(forecastDataPath);
            string json = reader.ReadToEnd();
            reader.Close();

            Root weatherData = JsonConvert.DeserializeObject<Root>(json);

            return weatherData;
        }
    }
}
