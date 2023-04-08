using SmartLearn.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SmartLearn
{
    public partial class Form1 : Form
    {
        private readonly string tadFilePath = @".\TermsAndDefinitions\";
        List<TermsAndDefinitions> tad = new List<TermsAndDefinitions>();
        string[] setNames;

        public Form1()
        {
            InitializeComponent();
            setNames = Directory.GetFiles(tadFilePath, "*", SearchOption.AllDirectories).Select(x => Path.GetFileNameWithoutExtension(x)).ToArray();
            lstSets.DataSource = setNames;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tad.Add(new TermsAndDefinitions()
            {
                term = "Test Term",
                definition = "Test Definition"
            });

            string json = System.Text.Json.JsonSerializer.Serialize(tad);
            File.WriteAllText(tadFilePath + "TestName.json", json);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using StreamReader reader = new(tadFilePath + "TestName.json");
            var json = reader.ReadToEnd();
            List<TermsAndDefinitions>? tadRead = JsonConvert.DeserializeObject<List<TermsAndDefinitions>>(json);

            txtTest.Text = tadRead[0].term + "|" + tadRead[0].definition;
        }

    }
}