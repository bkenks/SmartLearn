using SmartLearn.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SmartLearn
{
    public partial class Form1 : Form
    {
        private readonly string tadFilePath = @".\TermsAndDefinitions\tad.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<TermsAndDefinitions> tadCreate = new List<TermsAndDefinitions>();
            tadCreate.Add(new TermsAndDefinitions()
            {
                term = "Test Term",
                definition = "Test Definition"
            });

            string json = System.Text.Json.JsonSerializer.Serialize(tadCreate);
            File.WriteAllText(tadFilePath, json);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using StreamReader reader = new(tadFilePath);
            var json = reader.ReadToEnd();
            List<TermsAndDefinitions>? tadRead = JsonConvert.DeserializeObject<List<TermsAndDefinitions>>(json);

            txtTest.Text = tadRead[0].term + "|" + tadRead[0].definition;
        }
    }
}