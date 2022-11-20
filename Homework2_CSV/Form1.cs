namespace CSVandUnivariat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                GridView.Rows.Clear();
                GridView.Columns.Clear();
                FilePathTextBox.Text = OpenFileDialog.FileName;
                var strings = File.ReadAllLines(FilePathTextBox.Text);
                bool headerSet = false;

                if (!HasHeaderCheckBox.Checked)
                {
                    for (int i = 0; i < strings.Length; i++)
                        GridView.Columns.Add($"Field{i + 1}", $"Field {i + 1}");
                    headerSet = true;
                }
                
                foreach (var s in strings)
                {
                    var fields = s.Split(string.IsNullOrEmpty(SeparatorTextBox.Text) ? "," : SeparatorTextBox.Text);

                    if (!headerSet)
                    {   
                        foreach (var field in fields)
                            GridView.Columns.Add(field, field);
                        headerSet = true;
                    }
                    else
                        GridView.Rows.Add(fields);                    
                }
            }

        }

        private void GridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Dictionary<string, int> valuePairs = new Dictionary<string, int>();

            UnivariatGridView.Rows.Clear();
            UnivariatLabel.Text = GridView.Columns[e.ColumnIndex].HeaderText;
            
            for (int i = 0; i < GridView.Rows.Count; i++)
            {
                var value = (string)GridView[e.ColumnIndex, i].Value;
                if (!valuePairs.ContainsKey(value))
                    valuePairs.Add(value, 1);
                else
                    valuePairs[value]++;
            }

            foreach (var pair in valuePairs)
                UnivariatGridView.Rows.Add(pair.Key, $"{pair.Value} / {GridView.Rows.Count} ({(double)pair.Value / GridView.Rows.Count * 100:N2}%)");
        }
    }
}