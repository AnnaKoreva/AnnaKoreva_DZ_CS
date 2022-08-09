//GENERIC (Обобщения, шаблоны)
class Program
{
    // перегрузка, пишем в разных подпрограммах  Swap указываем разные виды (типы) переменных
    //и когда мы запустим программу, введя число или символ, программа самма опредит какой тип использовать int или double и т.д.
    public static void Swap(ref int a,ref int b) // переменные тип int
    {
        int t=a;
        a=b;
        b=t;
    }
    public static void Swap(ref double a,ref double b) // переменные  тип double
    {
        double t=a;
        a=b;
        b=t;
    }
     public static     void Swap(ref string a,ref string b) // переменные  тип string 
    {
        string t=a;
        a=b;
        b=t;
    }
    
    //Generic (обобощенные методы)

//T - параметризированный тип
    public static void Swap<T>(ref T a,ref T b) // для того чтобы не писать каждый раз тип переменной int или double и т.д. можно указать просто Swap<T> (ref T a,ref T b) и программа сама определит тип переменной
    {
        T t=a;
        a=b;
        b=t;
    }



    public static void Init(out int[] a)
    {
        a=new int[10];
        for(int i=0;i<10;i++)
            a[i]=10;
    }


}

class MyClass
{
        static void Main()
    {
        List<int> list=new List<int>(); //  List (список) это замена массива, мы можем из List  динамически добавлять и удалять элементы
        LinkedList<string> linkedList=new LinkedList<string>();
        
        int[] a;
        int x=1,y=2;
        double e=2,t=4;
        
        Program.Swap<int>(ref x,ref y);
        Program.Swap<double>(ref e,ref t);
        Program.Init(out a);        
    }
}



/*// неинициализированный массив, метод который позволяет внутри себя создавать переменные, присв. значения и т.д. 
 void Init (out int[] array) // метод создания массива out означает что внутри в переменную array мы обязательно поместим какое-то значение
 {
        array= new int[10];
        for(int i=0; i<10; i++)
            array[i] = 10;
 }
 int [] array;
 Init(out array); */
