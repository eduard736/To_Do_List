using System.ComponentModel;
using System.Text.Json;

namespace lab5
{
    public partial class Form2 : Form
    {
        List<Task> tasks = new List<Task>();
        int ind;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                tasks[ind].Title = title.Text;
                tasks[ind].Priority = Priority.Text;
                tasks[ind].TermLimit = DateTime.Parse(Limit.Text);
                tasks[ind].Description = Description.Text;
                listBox1.Items.Clear();
                foreach (Task t in tasks)
                {
                    listBox1.Items.Add(t.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tasks.Add(new Task(DateTime.MinValue, "", "", ""));
                listBox1.Items.Clear();
                foreach (Task task in tasks)
                {
                    listBox1.Items.Add(task.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void editTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                title.Text = tasks[ind].Title;
                Priority.Text = tasks[ind].Priority;
                Limit.Text = tasks[ind].TermLimit.ToString();
                Description.Text = tasks[ind].Description;
                ind = listBox1.SelectedIndex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            title.Text = string.Empty;
            Priority.Text = string.Empty;
            Limit.Text = DateTime.MinValue.ToString();
            Description.Text = string.Empty;


        }

        private void deletTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tasks.RemoveAt(ind);
                listBox1.Items.Clear();
                foreach (Task task in tasks)
                {
                    listBox1.Items.Add(task.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog1.FileName);
                    List<Task> tasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
                    listBox1.Items.Clear();
                    foreach (Task task in tasks)
                    {
                        listBox1.Items.Add(task.ToString());
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(tasks);
            File.WriteAllText("C:\\Users\\eduar\\Documents\\Tasks.json", jsonString);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(tasks);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When the user selects \"New\" from the \"File\" menu, a new empty activity record should be created and displayed in the corresponding controls.\r\nWhen the user selects \"Open\" from the \"File\" menu, a file open dialog should be displayed to allow the user to select a file containing task information. The selected file should be loaded and the list box should be populated with the task names.\r\nWhen the user selects a task from the list box, the corresponding task information should be displayed in the appropriate controls.\r\nWhen the user clicks the \"Add Task\" button, a new empty task record should be created and added to the list box.\r\nWhen the user clicks the \"Edit Task\" button, the current task information should be editable in the appropriate controls.\r\nWhen the user clicks the \"Delete Task\" button, the current task should be removed from the list box and the appropriate controls should be cleared.\r\nWhen the user clicks the \"Save\" button, the current task information should be saved to the current file. If there is no current file, a file save dialog should be displayed to allow the user to select a file name and location. The current file name should be updated to the selected file name.\r\nWhen the user clicks the \"Save As\" button, a file save dialog should be displayed to allow the user to select a file name and location. The current file name should be updated to the selected file name.\r\nWhen the user clicks the \"Exit\" button, the application should close.\r\nWhen the user clicks the \"About\" button, a dialog box should be displayed with information about the application.");
        }
    }
}