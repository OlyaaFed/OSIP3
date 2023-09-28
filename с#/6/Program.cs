
Console.WriteLine("Ввести число до5");
double abc = Convert.ToDouble(Console.ReadLine());
switch (abc)
{
    case 1:
        Console.WriteLine("плохо");
            break;

    case 2:
        Console.WriteLine("неудовлетворительно");
             break;

    case 3:
        Console.WriteLine("удовлетворительно");
        break;

    case 4:
        Console.WriteLine("хорошо");
        break;

    case 5:
        Console.WriteLine("отлично");
             break;

    default: Console.WriteLine("Ввести число от 1 до 5") ;
        break;

}
