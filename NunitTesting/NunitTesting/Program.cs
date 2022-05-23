// See https://aka.ms/new-console-template for more information
Console.WriteLine("1.VendingMachine\n2.DayOfweek\n3.Temprature\n4.MonthlyPayments\n5.Sqrt\n6.Binary\n7.BinaryToNible");
Console.WriteLine("Enter your Choice");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        NunitTesting.VendingMachine vendingMachine = new NunitTesting.VendingMachine();
        vendingMachine.userInput();
        break;
    case 2:
        NunitTesting.DayOfweek dayOfweek = new NunitTesting.DayOfweek();
        dayOfweek.dayWeek();
        break;
    case 3:
        NunitTesting.Temprature temprature = new NunitTesting.Temprature();
        temprature.tempratureConvert();
        break;
    case 4:
        NunitTesting.monthlyPayment monthlyPayment = new NunitTesting.monthlyPayment();
        monthlyPayment.monthlyPay();
        break;
    case 5:
        NunitTesting.SqrtNgeativeNum sqrtNgeativeNum = new NunitTesting.SqrtNgeativeNum();
        sqrtNgeativeNum.sqrt();
        break;
    case 6:
        NunitTesting.Binary binary = new NunitTesting.Binary();
        binary.toBinary();
        break;
    case 7:
        NunitTesting.BinaryToNible binaryToNible = new NunitTesting.BinaryToNible();
        binaryToNible.Nible();
        break;
    default:
        Console.WriteLine("Enter valid option");
        break;


}
