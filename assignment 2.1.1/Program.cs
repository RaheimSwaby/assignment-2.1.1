namespace assignment_2._1._1

{
    public class Student
    {
        // Private data members
        private int studentId;
        private string studentFirstname;
        private string studentLastname;
        private char studentGrade;

        // Public properties
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentFirstname
        {
            get { return studentFirstname; }
            set { studentFirstname = value; }
        }

        public string StudentLastname
        {
            get { return studentLastname; }
            set { studentLastname = value; }
        }

        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Student class
            Student student = new Student();

            // Assign data to properties
            student.StudentId = 1;
            student.StudentFirstname = "Raheim";
            student.StudentLastname = "Swaby";
            student.StudentGrade = 'A';

            // Display the data back on the console
            Console.WriteLine("Student Information:");
            Console.WriteLine($"ID: {student.StudentId}");
            Console.WriteLine($"First Name: {student.StudentFirstname}");
            Console.WriteLine($"Last Name: {student.StudentLastname}");
            Console.WriteLine($"Grade: {student.StudentGrade}");



            // class hierarchy 

            /*                     cars
             *                      |
             *                   buggati
             *                /    |            \
             *      quad-turbo   specials         NA
             *           /          |               \
             *        chiron     la louvuitre noir    tourbillion
             *        /             |                   \
             *    veyron          EB110                 Mistral
             * 
             */

            Console.WriteLine("Select an option you want to use: ");
            Console.WriteLine("1.ADD num1 + num2");
            Console.WriteLine("2.Add decimal1 + decimal2");
            Console.WriteLine("3.Multiply float num1 * float num2");
            Console.WriteLine("4.Multiply - float num1 * float num2 *float num3");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter 2 integers");
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("the result is :" + Maths.Add(int1, int2));
                    break;

                case 2:
                    Console.WriteLine("enter 3 decimals:");
                    decimal dec1 = decimal.Parse(Console.ReadLine());
                    decimal dec2 = decimal.Parse(Console.ReadLine());
                    decimal dec3 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("result" + Maths.Add1(dec1, dec2, dec3));
                    break;

                case 3:
                    Console.WriteLine("enter two floats: ");
                    float float1 = float.Parse(Console.ReadLine());
                    float float2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("result: " + Maths.Multiply(float1, float2));
                    break;

                case 4:
                    Console.WriteLine("enter 3 floats");
                    float float3 = float.Parse(Console.ReadLine());
                    float float4 = float.Parse(Console.ReadLine());
                    float float5 = float.Parse(Console.ReadLine());
                    Console.WriteLine("result" + Maths.Multiply(float3, float4, float4));
                    break;


                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }





        public class Maths
        {
            public static int Add(int num1, int num2)
            {
                return num1 + num2;

            }

            public static decimal Add1(decimal num1, decimal num2, decimal num3)
            {
                return num1 + num2;
            }
            public static float Multiply(float num1, float num2)
            {
                return num1 * num2;
            }
            public static float Multiply(float num1, float num2, float num3)
            {
                return (num1 * num2 * num3);
            }

            

           
          
        }
    
        
    }      
    }

