Console.WriteLine("Hello, World!");
Person mark = new Person("mark",16,"31311313312");
mark.SaySomething();
int[] numbers = {1,6,1,5,16};
Console.WriteLine(Person.CalcAverage(numbers));
Console.WriteLine(Person.MaximumValue(numbers));

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

public static double CalcAverage(int[] numbers)
{
    double sum = 0;
    foreach (int  num in numbers)
    {
        sum += num;
    }

    return sum / numbers.Length;
}

public static int MaximumValue(int[] numbers)
{
    int max = int.MinValue;
    foreach (int number in numbers)
    {
        if (number > max)
            max = number;
    }

    return max;
}
}
