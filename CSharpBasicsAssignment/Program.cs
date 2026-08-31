//namespace CSharpBasicsAssignment;
using CSharpBasicsAssignment;
using System.Drawing;

static void PartA()
{
    Console.WriteLine("=== PART A: Project & Structure ===");
    // csproj : Contains the .Net version , enabled or diabled features and packages used
    // Program.cs : Contains the code that runs the app
    // obj/ : Stores temporary files used while building the project
    // bin/: Contains the final build output including the IL code
    // File-scoped namespace removes one indentation level because it does not use braces
    // It is not used here because Program.cs uses top-level statements
    // I use .slnx , one advantage of .sln is better support with older tools
}
void RunTypesDemo()
{
    Console.WriteLine("=== PART B: Variables, Types & Casting ===");
    int inte = 10;
    double doub = 10.5;
    decimal deci = 10.554m;
    long lon = 12346789;
    bool bol = true;
    char cha = 'a';
    string stri = "Fares";
    var va = "Ali";
    Console.WriteLine($"{inte}  {inte.GetType()}");
    Console.WriteLine($"{doub}  {doub.GetType()}");
    Console.WriteLine($"{deci}  {deci.GetType()}");
    Console.WriteLine($"{lon}  {lon.GetType()}");
    Console.WriteLine($"{bol}  {bol.GetType()}");
    Console.WriteLine($"{cha}  {cha.GetType()}");
    Console.WriteLine($"{stri}  {stri.GetType()}");
    Console.WriteLine($"{va}  {va.GetType()}");

    int x = 100;
    long lo = x;
    Console.WriteLine(lo);
    // Because int is smaller than long and long can represent all int
    char ch = 'a';
    int y = ch;
    Console.WriteLine(y);
    // Converts char to ASCI value

    double t = 150.75;
    int u = (int)t;
    Console.WriteLine(u);
    // truncation : int truncates the decimal part
    u = Convert.ToInt32(t);
    Console.WriteLine(u);
    // rounding : Convert.ToInt32 rounds to the nearest

    Console.WriteLine(5 / 2);
    Console.WriteLine(5.0 / 2);
    // 5 / 2 uses integer division so the decimal part is removed ** 5.0 / 2 uses double division so the result is 2.5

    int p = 1000;
    object obj = p;
    Console.WriteLine(obj);
    int pp = (int)obj;
    Console.WriteLine(pp);

    int num = int.Parse("123");
    Console.WriteLine(num);
    bool isSucceeded = int.TryParse("abc", out int q);
    if (isSucceeded)
    {
        Console.WriteLine("succeeded " + q);
    }
    else
        Console.WriteLine("failure");

    float f = 10.5f;
    // decimal d1 = f;   // implicit conversion is not allowed
    decimal d = (decimal)f;
    Console.WriteLine(d);
    // Explicit cast is required because float and decimal have different precision and representation
}
void RunValueVsReferenceDemo()
{
    Console.WriteLine("=== PART C: Value vs. Reference Types ===");
    System.Drawing.Point p1 = new System.Drawing.Point { X = 1, Y = 2 };
    System.Drawing.Point p2;
    p2 = p1;
    p2.X = 99;
    Console.WriteLine(p1.X);
    Console.WriteLine(p2.X);
    // Because struct is a value type p2 gets a copy of p1

    Order o1 = new Order { OrderId = 123, CustomerName = "Fares", Quantity = 500, UnitPrice = 15.75m, TotalPrice = 20.90m, IsPaid = false, DiscountPercent = 10, ShippingCity = "C1", Priority = 'M', ItemCode = 1223456 };
    Order o2 = o1;
    o2.IsPaid = true;
    Console.WriteLine(o1.IsPaid);
    Console.WriteLine(o2.IsPaid);
    // o1 and o2 reference the same object so only the reference is copied not the value

    object boxedOrder = o1;
    Order o3 = (Order)boxedOrder;
    Console.WriteLine(ReferenceEquals(o1, o3));

    o2.PrintSummary();

    /*
     Value types store the value and reference types store the object in the heap
     The reference is stored in the stack
     When we assign a value type we copy the value
     When we assign a reference type we copy the reference that points to the same object
     When we put a reference type in an object variable we copy the same reference not the object
     */
}

void Part_D()
{
    Console.WriteLine("=== PART D: Scope & Operators ===");
    Scope scope = new Scope();
    scope.Meth1();
    scope.Meth2();
    scope.MethLoc();

    for (int i = 0; i < 3; i++)
    {
        int insideLoop = i * 2;
        Console.WriteLine(insideLoop);
    }
    // Console.WriteLine(i); error because i is only available inside the for loop
    // Console.WriteLine(insideLoop); error because insideLoop is only available inside the loop block

    int total = 100;
    total += 5;
    Console.WriteLine(total);
    total -= 10;
    Console.WriteLine(total);
    total *= 2;
    Console.WriteLine(total);
    total /= 5;
    Console.WriteLine(total);
    total %= 3;
    Console.WriteLine(total);
    total += 5; //is the same as total = total + 5
    Console.WriteLine(total);


    int a = 12;//1100
    int b = 10;//1010
    Console.WriteLine(a & b);//1000
    Console.WriteLine(a | b);//1110
    Console.WriteLine(a ^ b);//0110
    // & short circuit checks both sides bit by bit while && is a logical operator and uses short circuit when the left side is false
}