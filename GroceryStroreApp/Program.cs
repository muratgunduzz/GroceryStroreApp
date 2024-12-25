using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Center Grocery Store!\nApple = 2 TL\nPear = 3 TL \nStrawberry = 2 TL\nBanana = 3 TL\nOther Stuff = 4 TL");

        Console.Write("\n\nWhat fruit do you want to buy? (Apple, Pear, Strawberry, Banana, Other): ");
        string fruit = Console.ReadLine(); // Kullanıcının meyve seçimini alıyoruz.

        Console.Write("How many kilograms? ");
        int weight;
        if (!int.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        {
            Console.WriteLine("Invalid input for weight. Please enter a positive number.");
            return;
        }

        int price = 0;
        switch (fruit.ToLower()) // Meyve seçimine göre fiyat belirleme
        {
            case "apple":
                price = 2 * weight;
                break;
            case "pear":
                price = 3 * weight;
                break;
            case "strawberry":
                price = 2 * weight;
                break;
            case "banana":
                price = 3 * weight;
                break;
            case "other":
                price = 4 * weight;
                break;
            default:
                Console.WriteLine("Invalid fruit selection.");
                return;
        }

        Console.WriteLine($"The total price for {weight} kg of {fruit} is: {price} TL");
    }
}
