using System.Collections.Generic;

Phone phoneFirst = new Phone();
Phone phoneSecond = new Phone();
Phone phoneThird = new Phone();

phoneFirst.receiveCall("Александр");
phoneFirst.getNumber("+79087652837\n");

phoneSecond.receiveCall("Евгений");
phoneSecond.getNumber("+79804732476\n");

phoneThird.receiveCall("Антон");
phoneThird.getNumber("+79507523481\n");

phoneFirst.receiveCall(" Александр " + "+ 79087652837 ");

Console.WriteLine(phoneFirst.number);
Console.WriteLine(phoneFirst.model);
Console.WriteLine(phoneFirst.weight);

Console.WriteLine(phoneSecond.number);
Console.WriteLine(phoneSecond.model);
Console.WriteLine(phoneSecond.weight);

Console.WriteLine(phoneThird.number);
Console.WriteLine(phoneThird.model);
Console.WriteLine(phoneThird.weight);
public class Phone
{
    public string number = "None";
    public string model = "None";
    public string weight = "None";

    public void receiveCall(string name)
    {
        Console.WriteLine("Звонит" + name);
    }

    public void getNumber(string number)
    {
        Console.Write(number);
    }

    public Phone (string number, string model, string weight) : this(number, model)
    {
        this.number = number;
        this.model = number;
        this.weight = number;
    }

    public Phone(string number, string model)
    {
        this.number = number;
        this.model = model;
    }

    public Phone()
    {

    }
    public void receiveCall(string name, string number)
    {
        Console.WriteLine(name + number);
    }
    public void sendMessege(params string[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}