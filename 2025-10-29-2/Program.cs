// string navn1 = "Øyvind";
// string navn2 = navn1;
// navn2 = "Stine";
// Person person1 = new Person("Øyvind");
// Person person2 = person1;
// person2.Navn = "Stine";


int number1 = 1;
int number2 = number1;

number2 = 2;

Console.WriteLine(number1);
    






class Person
{
    public string Navn { get; set; }

    public Person(string navn)
    {
        Navn = navn;
    }
    
    public override string ToString()
    {
        return Navn;
    }
    
}