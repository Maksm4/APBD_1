Console.WriteLine("Hello, World!");

public class Person
{
    private string name;
    private int age;
    private string pesel;

public Person(string name, int age, string pesel)
{
    this.name = name;
    this.age = age;
    this.pesel = pesel;
}

public void SaySomething()
{
    Console.WriteLine("my name is " + name);
}
}
