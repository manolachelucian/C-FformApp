namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student(1,"Karel","Novak","c1a")) ;
            students.Add(new Student(2, "Ondra", "Novak", "c1b"));
            students.Add(new Student(3, "Adam", "Novak", "c4a"));
            students.Add(new Student(4, "Milan", "Novak", "c3a"));

            foreach (var student in students)
            {
                listBox1.Items.Add(student);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            students.Add(new Student(5,textBox1.Text,textBox2.Text,textBox3.Text));
            listBox1.BeginUpdate();
            listBox1.DataSource = students;
            listBox1.EndUpdate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}