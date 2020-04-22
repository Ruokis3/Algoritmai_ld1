namespace myapp
{
    public class Container
    {
        private Person[] people;
        public int personNumber { get; private set; }
        public Container(int size)
        {
            people = new Person[size];
            personNumber = 0;
        }
        public void AddPerson(Person person)
        {
            people[personNumber++] = person;
        }
        public Person GetPerson(int index)
        {
            return people[index];
        }
    }
}

