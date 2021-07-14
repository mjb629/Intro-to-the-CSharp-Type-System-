using System;
using System.Globalization;
using System.Text;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("Enter the wage:");
        string wage = Console.ReadLine();

        //int wageValue = int.Parse(wage);

        int wageValue;
        if (int.TryParse(wage, out wageValue))
            Console.WriteLine("Parsing success: " + wageValue);
        else
            Console.WriteLine("Parsing failed");

        string hireDateString = "12/12/2020";
        DateTime hireDate = DateTime.Parse(hireDateString);
        Console.WriteLine("Parsed date: " + hireDate);

        var cultureInfo = new CultureInfo("nl-BE");
        string birthDateString = "28 Maart 1984";//Dutch, spoken in Belgium 
        var birthDate = DateTime.Parse(birthDateString, cultureInfo);
        Console.WriteLine("Birth date: " + birthDate);

        string name = "Bethany";
        string anotherName = name;

        name += " Smith";

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Another name: " + anotherName);

        string lowerCaseName = name.ToLower();

        string indexes = string.Empty;
        for (int i = 0; i < 2500; i++)
        {
            indexes += i.ToString();
        }

        string firstName = "Bethany";
        string lastName = "Smith";

        StringBuilder builder = new StringBuilder();

        builder.Append("Last name: ");
        builder.AppendLine(lastName);
        builder.Append("First name: ");
        builder.Append(firstName);
        string result = builder.ToString();

        Console.WriteLine(result);

        string name1 = "Bethany";
        string name2 = "BETHANY";

        //Console.WriteLine("Are both names equal?" + (name1 == name2));
        //Console.WriteLine("Is name equal to Bethany?" + (name1 == "Bethany"));
        //Console.WriteLine("Are both names equal?" + name2.Equals("BETHANY"));
        Console.WriteLine("Is lower name equal to bethany" + (name1.ToLower() == "bethany"));

        //string firstName = "Bethany";
        //string lastName = "Smith";

        string fullName = firstName + " " + lastName;
        string employeeIdentification = string.Concat(firstName, lastName);


        string displayName = $"Welcome!\n{firstName}\t{lastName}";

        Console.WriteLine(displayName);

        string invlaidFilePath = "C:\\data\\employeelist.xlsx";

        string marketingTagLine = "Baking the \"best pies\" ever";

        string verbatimFilePath = @"C:\data\employeelist.xslx";

        string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

        int length = empId.Length;

        if (fullName.Contains("beth") || fullName.Contains("Beth"))
        {
            Console.WriteLine("It's Bethany");
        }

        string subString = fullName.Substring(1, 3);
        Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

        string nameUsingInterpolation = $"{firstName}-{lastName}";

        string greeting = $"Hello, {firstName.ToLower()}";

        //string fullName = "Bethany Smith";

        string noValueString = null;
        string s;

        s = firstName;

        var userName = "Bethnay";

        int monthlyWage = 1234;
        int months = 12, bonus = 1000;

        bool isActive = true;
        double rating = 99.25;

        double ratePerHour = 12.34;
        int numberOfHoursWorked = 165;

        long veryLongMonth = numberOfHoursWorked;
        double d = 123456789.0;
        int x = (int)d;

        int intVeryLongMonth = (int)veryLongMonth;

        double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

        Console.WriteLine(currentMonthWage);

        ratePerHour += 3; //ratePerHour = ratePerHour + 3;

        if (currentMonthWage > 2000)
        {
            Console.WriteLine("Top paid employee");
        }

        int numberOfEmployees = 15;
        numberOfEmployees--;

        int intMaxValue = int.MaxValue;
        int intMinValue = int.MinValue;

        char userSelection = 'a';
        char upperVersion = char.ToUpper(userSelection);
        bool isDigit = char.IsDigit(userSelection);
        bool isLetter = char.IsLetter(userSelection);

        //DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);

        Console.WriteLine(hireDate);

        DateTime exitDate = new DateTime(2021, 12, 11);

        //DateTime invalidDate = new DateTime(2021, 15, 11);

        DateTime startDate = hireDate.AddDays(15);

        Console.WriteLine(startDate);

        DateTime currentDate = DateTime.Now;
        bool areWeInDst = currentDate.IsDaylightSavingTime();

        DateTime startHour = DateTime.Now;
        TimeSpan workTime = new TimeSpan(8, 35, 0);
        DateTime endHour = startHour.Add(workTime);

        Console.WriteLine(startHour.ToLongDateString());
        Console.WriteLine(endHour.ToShortTimeString());

        Console.ReadLine();
    }
}
}
