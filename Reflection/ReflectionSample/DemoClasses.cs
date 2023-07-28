namespace ReflectionSample
{
    public interface ITalk
    {
        void Talk(string message);
    }

    public class EmployeeMakerAttribute : Attribute
    {

    }

    [EmployeeMaker]
    public class Employee : Person
    {
        public string Company { get; set; }
    }

    public class Alien : ITalk
    {
        public void Talk(string message)
        {
            Console.WriteLine($"Alien is talking...: {message}");
        }
    }

    public class Person : ITalk
    {
        public string Name { get; set; }
        public int age;
        private string _aPrivateField = "init private field value";

        public Person()
        {
            Console.WriteLine("A person is being created.");
        }

        public Person(string name)
        {
            Console.WriteLine($"A person with name {name} is being created using a private ctor");
            Name = name;
        }

        public Person(string name, int age)
        {
            Console.WriteLine($"A person with name {name} and age {age} is being created using a private ctor");
            Name = name;
            this.age = age;
        }

        public void Talk(string message)
        {
            Console.WriteLine($"Talking...: {message}");
        }

        protected void Yell(string message)
        {
            Console.WriteLine($"Yelling... {message}");
        }

        public override string ToString()
        {
            return $"{Name} {age} {_aPrivateField}";
        }
    }
}
