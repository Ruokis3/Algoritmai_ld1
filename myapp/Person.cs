namespace myapp
{
    public class Person
    {
        public int Heigth{get; set; }
        public int Weight {get; set; }
        public float BMI {get; set; }
        public Person(int heigth, int weight)
        {
            int Heigth = heigth;
            int Weight = weight;
            float BMI = (float)weight / (float)(heigth * heigth) * 10000;
        }
    }
}