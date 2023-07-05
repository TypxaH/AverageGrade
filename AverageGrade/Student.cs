

namespace AverageGrade
{
    class Student
    {
        private string name;
        private int belGrade;
        private int matGrade;
        private int infoGrade;

        public Student(string name, int belGrade, int matGrade, int infoGrade)
        {
            this.name = name;
            this.belGrade = belGrade;
            this.matGrade = matGrade;
            this.infoGrade = infoGrade;
        }

        public string Name { get => name; set => name = value; }
        public int BelGrade { get => belGrade; set => belGrade = value; }
        public int MatGrade { get => matGrade; set => matGrade = value; }
        public int InfoGrade { get => infoGrade; set => infoGrade = value; }
    }
}
