



//public static class ExtensionMethod
//{
//    public static void AllWant(this IEnumerable<int> collection, bool isEven = true)
//    {
//        collection
//            .Where(x => (x % 2).ToBoolean() != isEven)
//            .ToList()
//            .ForEach(x=>Console.WriteLine(x));
//    }

//    public static bool ToBoolean(this int x) => Convert.ToBoolean(x);

//}


//class Program
//{


//    static void Main(string[] args)
//    {

//        IEnumerable<int> numbers = Enumerable.Range(10, 20);



//        //numbers.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
//        numbers.AllWant(false);




//    }
//}







//using System.Threading.Channels;

//class Program
//{
//Action - return type void (0-16) parametr 
//Predicate - return bool   (1) parametr
//Func - return istenilen void den basqa (0,16) parametr

//-----Action-----
//public static void foo()
//{
//    Console.WriteLine("foo Action method");
//}
//public static void boo()
//{
//    Console.WriteLine("boo Action method");
//}
//public static void doo(int a, int b)
//{
//    Console.WriteLine(a + b);
//}
//public static void too(int a, int b)
//{
//    Console.WriteLine(a - b);
//}
//static void Main(string[] args)
//{
//    //Action action = foo;
//    //action += boo;
//    //action.Invoke();
//    //Action<int, int> action2 = doo;
//    //action2 += too;
//    //action2.Invoke(5,4);
//}


//-------Predicate-------


//public static bool IsEven(int num)
//{
//    return num % 2 == 0;
//}

//static void Main(string[] args)
//{
//    Predicate<int> predicate = IsEven;

//    Console.WriteLine(predicate.Invoke(7));


//}




//public static double foo(float a, float b)
//{
//    return a / b;
//}
//public static double doo(float a, float b)
//{
//    return a * b;
//}

//public static bool IsEven(int a)
//{
//    return a % 2 == 0;
//}

//public static bool IsOdd(int a)
//{
//    return a % 2 != 0;
//}

//public static void Print(int a)
//{
//    Console.WriteLine(a);
//}


//static void Main(string[] args)
//{

//    //Func<float, float, double> func = foo;
//    //func += doo;
//    //func -= doo;

//    //Console.WriteLine(func.Invoke(7, 4));
//   //Func<int, bool> func = IsEven;
//   // func += IsOdd;
//   // Action<int> action = Print;
//   // IEnumerable<int> numbers = Enumerable.Range(10, 25);

//    //List<string> lists = new List<string>() { "alma", "banan", "ciyelek" };

//    //lists.Where(x=>x=="alma").ToList().ForEach(x=>Console.WriteLine(x));

//    //numbers.Where(x=>x%2==0).ToList().ForEach(x=>Console.WriteLine(x));
//    //Console.WriteLine(numbers.Count(func));

//    //Console.WriteLine(numbers.FirstOrDefault());



//}







//}



//------Event------


delegate void Notify();

class Button
{

    public event Notify MouseEnter = delegate { };
    public event Notify MouseLeave = delegate { };
    //public event Notify MouseDoubleClick = null;
    //public event Notify TextChanged = null;
    //public event Notify SizeChanged = null;



    public string Text { get; set; }
    public string Loaction { get; set; }
    public string BacgroundColor { get; set; }
    public string ForegrounddColor { get; set; }


    public void Start()
    {
        MouseEnter.Invoke();
        MouseLeave.Invoke();
        //MouseDoubleClick.Invoke();
        //TextChanged.Invoke();
        //SizeChanged.Invoke();
    }




}
class Program
{
    static void Main(string[] args)
    {
        Button button = new Button();
        button.MouseEnter += Button_MouseEnter;
        button.MouseEnter += Button_MouseLeave;

        button.Start();


    }


    private static void Button_MouseEnter()
    {
        Console.WriteLine("Button Mouse Enter");
    }

    private static void Button_MouseLeave()
    {
        Console.WriteLine("Button Mouse Enter");
    }


}