using System.Text.Json;
using System.Text.Json.Serialization;
using SmartLearn.Model;

namespace SmartLearn
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
            Application.Run(new Form1());

            List<TermsAndDefinitions> tad = new List<TermsAndDefinitions>();
            tad.Add(new TermsAndDefinitions()
            {
                term = "Test Term"
            });

            string json = JsonSerializer.Serialize(tad);
            File.WriteAllText("./TermsAndDefinitions");
        }
    }
}