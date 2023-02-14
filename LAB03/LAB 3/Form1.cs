using System.Diagnostics;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }
        List<double> Grades = new List<double>();
        List<Student> students = new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            Student student1 = new Student()
            {
                _Name = Name.Text,
                _StudentID = StudentID.Text,
                _DateOfBirth = int.Parse(DateOfBirth.Text),
                _Height = double.Parse(Height.Text),
                _Grade = double.Parse(Grade.Text),
                _Major = Major.Text,
            };
            students.Add(student1);
            Grades.Add(student1._Grade);
            dataGridView1.Rows.Add(student1._Name, student1._StudentID, student1._DateOfBirth, student1._Height, student1._Grade, student1._Height);

            //
            Grades.Sort();

            // 
            max.Text = "MaxGrades " + Grades.Last().ToString();
            min.Text = "MinGrades " + Grades.First().ToString();
            all.Text = "AllStudents " + students.Count.ToString();
        }

    }
}