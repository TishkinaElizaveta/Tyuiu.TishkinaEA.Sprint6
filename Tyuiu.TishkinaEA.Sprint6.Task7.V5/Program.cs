﻿using Tyuiu.TishkinaEA.Sprint6.Task7.V5.Lib;
namespace Tyuiu.TishkinaEA.Sprint6.Task7.V5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}