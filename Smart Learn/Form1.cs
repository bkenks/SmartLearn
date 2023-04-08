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
        int tadIndex = -1;

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
            pnlCorI.Visible = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // Add example term and definition
            tad.Add(new TermsAndDefinitions()
            {
                term = "Lorem ipsum",
                definition = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In interdum porttitor egestas. Nulla ac vestibulum lorem. Vivamus tellus magna, tristique ac leo eget, dapibus porta augue. Morbi lacinia velit nec orci scelerisque, in suscipit justo maximus. Vivamus vestibulum, felis ut fringilla malesuada, augue tellus faucibus est, sit amet cursus mauris felis a erat. Nulla eget sapien sed metus semper sagittis non vel tortor. Nullam gravida, magna at ornare tempus, orci diam hendrerit libero, ac ullamcorper nisl odio at arcu. Sed commodo ac quam in dignissim. Donec sed justo vel orci tristique pulvinar non sed justo. Donec aliquet metus nec molestie efficitur.\r\n\r\nVestibulum a purus velit. Praesent eu viverra mauris, id varius massa. Morbi dapibus nunc id nulla accumsan euismod. Sed eleifend, metus non pharetra aliquet, tellus odio tempus leo, ut mattis ipsum lectus in nulla. Cras porta augue ligula, non molestie turpis congue id. Morbi sapien sem, rhoncus vitae tincidunt vel, vehicula condimentum ligula. Suspendisse sollicitudin odio lobortis arcu faucibus sagittis. Nulla ut magna gravida, vestibulum ligula et, sodales magna. Vivamus ac augue ut purus imperdiet volutpat. Cras sit amet consequat odio. Sed sodales sollicitudin mattis. Curabitur eget lacus ac odio sagittis varius in ut libero. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus risus velit, eleifend iaculis quam id, iaculis pellentesque sem.\r\n\r\nSed felis purus, eleifend a vehicula vitae, sollicitudin et odio. Integer iaculis efficitur augue quis ultricies. Mauris vitae quam molestie, imperdiet mauris vel, accumsan turpis. Aliquam ut sapien euismod, tempus dolor quis, scelerisque sem. Praesent nec pretium quam. In hac habitasse platea dictumst. Sed efficitur lobortis augue id mattis. Sed suscipit rhoncus magna, et tempus risus suscipit vel. Vivamus in orci ante. Duis diam sem, accumsan a tortor et, sollicitudin elementum erat. Ut fringilla nisi vel velit pharetra pharetra. Curabitur facilisis ac leo eget molestie. Nulla vitae est vitae nisi luctus fermentum in id purus.\r\n\r\nVivamus pretium, erat ut ornare consectetur, ante sapien ullamcorper lacus, sed mattis sapien orci ut arcu. Donec enim massa, finibus non pellentesque sollicitudin, placerat quis sapien. Nullam gravida euismod condimentum. Maecenas ut nulla euismod, condimentum quam vel, gravida ante. Aenean id massa malesuada ipsum pretium venenatis ut ac nisi. Nullam eget mauris tortor. Pellentesque imperdiet imperdiet purus non placerat. Nunc quis dui vel tortor sagittis egestas. Sed ac erat fringilla ipsum euismod lacinia.\r\n\r\nMaecenas luctus pellentesque ipsum, non molestie enim placerat quis. Curabitur finibus finibus lorem, vel placerat enim lacinia at. Nulla laoreet velit ut mattis euismod. Nullam vel mi orci. Donec in convallis libero, tincidunt commodo nisi. Phasellus consectetur, sem posuere lobortis molestie, felis metus consectetur nulla, id pretium nulla est ut urna. Mauris a sodales nunc, ac finibus velit. Curabitur vulputate nisi justo, at viverra erat molestie eu."
            });

            tad.Add(new TermsAndDefinitions()
            {
                term = "Test Term",
                definition = "Test Definition"
            });

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
            UpdateCurrentTAD();
        }

        private void UpdateCurrentTAD()
        {
            // Sets definition to definition of tadIndex in the tad list
            if (tadIndex + 1 <= tad.Count)
            {
                tadIndex += 1;
                rtxtDef.Text = tad[tadIndex].definition;
            }
            else
            {
                DisablePanels();
                pnlMain.Visible = true;
            }
            txtAnswer.Text = "";
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
            CorIPanel();
            if (txtAnswer.Text.ToLower() == tad[tadIndex].term.ToLower())
            {
                lblCorI.Text = "Correct!";
                lblCorI.ForeColor = Color.Green;
            }
            else
            {
                lblCorI.Text = "Incorrect!";
                lblCorI.ForeColor = Color.Red;
            }
            UpdateCurrentTAD();
        }

        private async void CorIPanel()
        {
            DisablePanels();
            pnlCorI.Visible = true;
            await Task.Delay(TimeSpan.FromSeconds(1.25));
            DisablePanels();
            pnlStudy.Visible = true;
        }
    }
}