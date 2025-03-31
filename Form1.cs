using System;
using System.Reflection;


namespace Hogwarts
{
    public partial class Form1 : Form
    {
        public int delay;
        private List<string> students = new List<string>();
        public Random? random;

        private OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = "Archivos separados por coma (*.csv)|*.csv",
            Title = "Selecciona el archivo de alumnos"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                students = File.ReadAllLines(openFileDialog.FileName).ToList();
                if (students.Count == 0)
                {
                    MessageBox.Show("El fichero está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                lbl_filename.Text = openFileDialog.SafeFileName.ToString();
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            generate_roller();
        }

        public void generate_roller()
        {
            delay = 5;
            random = new Random();
            for (int i = 0; i < students.Count; i++)
            {
                int randomIndex = random.Next(students.Count);
                lbl_name.Text = students[randomIndex].ToString();
                lbl_name.Refresh();
                Thread.Sleep(delay);
                delay += 8;
            }

        }
        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}