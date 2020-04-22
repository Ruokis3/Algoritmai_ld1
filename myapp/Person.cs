namespace myapp
{
    public class Person : System.IComparable
    {
        public int Heigth{get; set; }
        public int Weight {get; set; }
        public float BMI {get; set; }
        public Person(int heigth, int weight)
        {
            Heigth = heigth;
            Weight = weight;
            BMI = (float)weight / (float)(heigth * heigth) * 10000;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Person otherPerson = obj as Person;
            if (BMI <= otherPerson.BMI)
                return 0;
            return -1;
        }
        public override string ToString()
        {
            return Heigth.ToString() + " " + Weight.ToString() + " " + BMI.ToString();
        }
    }
}