namespace Person_Alice
{

    class Student
    {
        private string name;
        private int grade;

        public void SetGrade(int g)
        {
            if (g >= 0 && g <= 100)
                grade = g;
            else
                Console.WriteLine("Invalid grade");
        }

        public string Name
        {
            get { return name; } // Get method
            set { name = value; } // Set method
        }

        public int Grade
        {
            get => grade;
            set => grade = value;
        }
    }

        internal class Person_Alice
        {
            static void Main(string[] arg)
            {
                Student s = new Student();
                s.Name = "Alice";  // ❌ Fejl!
                s.Grade = 90;      // ❌ Fejl!
                s.SetGrade(85);    // ✅ Fungerer

            Console.WriteLine(s.Name + s.Grade);

                Console.ReadLine();
            }
        }
    }

