using CarApp.Data;
using Microsoft.EntityFrameworkCore;

namespace CarApp
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
            Records.carContext = new CarContext();
            //Records.carContext.Database.EnsureDeleted();
            Records.carContext.Database.EnsureCreated();
            Records.carContext.Carset.Load();
            Application.Run(new Form1());
        }
    }
}