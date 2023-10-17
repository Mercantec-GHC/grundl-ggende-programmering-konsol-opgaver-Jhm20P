Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

switch (daysUntilExpiration) {
    case 0: Console.WriteLine("Your subscribtion has expired");
    break;
    case 1: Console.WriteLine($"Your subscribtion expires within a day!\nRenew now and save {discountPercentage += 20}");
    break;
    case <= 5: Console.WriteLine($"Your subscribtion expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage += 10}");
    break;
    case <= 10: Console.WriteLine("Your subscribtion will expire soon. Renew now!");
    break;
    default: Console.WriteLine();
    break;
}