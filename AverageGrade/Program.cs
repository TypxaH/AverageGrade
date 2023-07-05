using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StreamReader reader = new StreamReader("students.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                List<string> studentInfo = line
                    .Split(',')
                    .ToList();
                Student current = new Student(studentInfo[0], int.Parse(studentInfo[1]), int.Parse(studentInfo[2]), int.Parse(studentInfo[3]));
               
                students.Add(current);

                line = reader.ReadLine();
            }
            StreamWriter writer = new StreamWriter("output.txt");
            using (writer)
            {
                foreach (Student st in students)
                {
                    double avarege = (st.BelGrade + st.MatGrade + st.InfoGrade) / 3.0;                    
                    writer.WriteLine($"{st.Name} - {avarege:f2}");
                }
            }
        }
    }
}
