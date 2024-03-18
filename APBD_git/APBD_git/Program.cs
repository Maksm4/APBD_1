Console.WriteLine("Hello, World!");
Person mark = new Person("mark",16,"31311313312");
mark.SaySomething();
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
