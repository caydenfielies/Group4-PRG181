// Array to track store department codes.
string[] departments = {"ELE", "CAM", "OFF", "HOM", "AUD", "GAM", "ACC"};
// Array to track sales transactions.
double[,] salesTransactions = new double[7, 1000];
// Array to track the number of transactions made for each department.
int[] transactionCount = new int[7];

string depCode;
double sale;

Console.WriteLine("----------------------------------");
Console.WriteLine("Best Buy Supermarket Sales Tracker");
Console.WriteLine("----------------------------------");
Console.WriteLine("Type quit to stop the program.\n");
bool running = true;

while (running)
{
    // Ask user for department code input.
    Console.WriteLine("Enter a department code. (ELE, CAM, OFF, HOM, AUD, GAM, ACC)");
    depCode = (Console.ReadLine() ?? "").ToUpper();
    if (depCode == "QUIT")
    {
        running = false;
        continue;
    }
    // foundIndex var will be used to keep track of the row index in salesTransactions array.
    int foundIndex = -1;

    int i = 0;

    // Loop through departments array to find the department code position in the departments array to be used later on.
    while(i < 7)
    {
        if (departments[i] == depCode)
        { 
            foundIndex = i;
            break;
        } else
        {
            i++;
        }
    }

    // If user input is invalid then warning message appears.
    if (foundIndex == -1)
    {
        Console.WriteLine("\n->\tInvalid department code!\n");
    } else
    {
        // Else run code as normal.

        // Ask user for sales transaction amount.
        Console.WriteLine("\nEnter a sales transaction amount.");
        string input = Console.ReadLine() ?? "";
        if (input.ToUpper() == "QUIT")
        {
            running = false;
            continue;
        }
        input = input.Replace(".", ",");

        // Convert string to a double and export double to var 'sale' if input is valid.
        bool success = double.TryParse(input, out sale);

        // To avoid invalid sales transactions such as sale = 0 or sale = -n. Test to see if both parse and conditions are true, then run code as normal.
        if (success && sale > 0)
        {
            // If input is valid, run code as normal.

            // To check if department is full capacity or not.
            if (transactionCount[foundIndex] >= 1000)
            {
                Console.WriteLine("\n->\tDepartment is at full capacity.\n");
            } else
            {
                // When sales input is valid, code stores the inputted sales transaction amount in the salesTransactions array.
                salesTransactions[foundIndex, transactionCount[foundIndex]] = sale;

                // Increment the transaction count for the specific department. Value is used as a column index for salesTransaction array.
                transactionCount[foundIndex] += 1;
                
                Console.WriteLine("\nSuccess!\n");

                // Display the results.
                Console.WriteLine("DEPT\tQTY\tAMOUNT");
                Console.WriteLine("-----------------------------");
                for (int j = 0; j < transactionCount.Length; j++)
                {
                    double totalPrices = 0;
                    for (int n = 0; n < transactionCount[j]; n++)
                    {
                        totalPrices += salesTransactions[j, n];
                    }
                    Console.WriteLine(departments[j] + "\t" + transactionCount[j] + "\t" + "R " + totalPrices.ToString("F2"));
                }
                Console.WriteLine("-----------------------------\n");
            }
        } else
        {
            // If input is invalid, display warning message.
            Console.WriteLine("\n->\tInvalid input!\n");
        }
    }
}