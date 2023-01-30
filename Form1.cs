namespace LAB4Encapsulation
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        double maxigrade = 0;
        double minigrade=int.MaxValue;
       
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("oop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = tbName.Text;
            string input_year = textBY.Text;
            string input_GPA = tbGPA.Text;


            int iYear =Int32.Parse (input_year); 
            int igrade=Int32.Parse (input_GPA);

            Person person = new Person(input_name,iYear, igrade);
           //Display person
            this.classroom.addPerson2Class(person);
            this.tbList.Text =
                this.classroom.showAllPersoninClass();
            // Display total age of class
            this.tbTotal.Text = "";
            

        }

       
    }
}