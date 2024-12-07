﻿using System;
using AnuscaDavidLab7.Data;
using System.IO;
namespace AnuscaDavidLab7
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database { get { if (database == null) { database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3")); } return database; } }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}