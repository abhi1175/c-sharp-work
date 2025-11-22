using System;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Employee Name", 150);
            listView1.Columns.Add("Employee ID", 100);
            listView1.Columns.Add("Employee Detail", 150);
            listView1.Columns.Add("Organization Detail", 150);
        }

        // ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string empId = textBox2.Text;
            string empDetail = textBox3.Text;
            string organization = textBox4.Text;

            // Validate
            if (name == "" || empId == "" || empDetail == "" || organization == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            // Create ListView Row
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(empId);
            item.SubItems.Add(empDetail);
            item.SubItems.Add(organization);

            listView1.Items.Add(item);

            // Clear Textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        // CLEAR TEXTBOXES BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        // CLEAR LISTVIEW BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
