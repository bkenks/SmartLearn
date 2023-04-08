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
        string selectedItem = "";

        public Form1()
        {
            InitializeComponent();
            DisablePanels();
            pnlMain.Visible = true;

            // Get set names
            setNames = Directory.GetFiles(tadFilePath, "*", SearchOption.AllDirectories).Select(x => Path.GetFileNameWithoutExtension(x)).ToArray();
            lstSets.DataSource = setNames;
        }

        // Disable all panels
        private void DisablePanels()
        {
            pnlMain.Visible = false;
            pnlStudy.Visible = false;
            pnlTest.Visible = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Add example term and definition
            tad.Add(new TermsAndDefinitions()
            {
                term = "Test Term",
                definition = "Test Definition"
            });

            WriteJSON();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Open stream reader and deserialize/read json file
            ReadJSON();

            txtTest.Text = tad[0].term + "|" + tad[0].definition;
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            if (lstSets.Items.Count > 0)
            {
                selectedItem = lstSets.SelectedItem.ToString();
            }

            DisablePanels();
            pnlStudy.Visible = true;

            ReadJSON();
            rtxtDef.Text = tad[0].definition;
        }

        private void ReadJSON()
        {
            // Open stream reader and deserialize/read json file
            using StreamReader reader = new(tadFilePath + "TestName.json");
            var json = reader.ReadToEnd();
            tad = JsonConvert.DeserializeObject<List<TermsAndDefinitions>>(json);
        }

        private void WriteJSON()
        {
            // Serialize json and write to file
            string json = System.Text.Json.JsonSerializer.Serialize(tad);
            File.WriteAllText(tadFilePath + "TestName.json", json);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.ToLower() == tad[0].term.ToLower())
            {

            }
        }
    }
}