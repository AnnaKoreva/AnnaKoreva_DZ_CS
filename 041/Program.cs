// 41 В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int n=Convert.ToInt32(Console.ReadLine());
double []ar=new double[n];
Random random=new Random();
for(int i=0; i<ar.Length;i++)
{
    ar[i]=random.NextDouble(); 
    System.Console.WriteLine($"{ar[i]}");
} 


double max=ar[0];
double min=ar[0];

for(int i=0; i<ar.Length;i++)
{
  
    if(max<ar[i])
    {
        max=ar[i];
    }
    
    if(min>ar[i])
    {
        min=ar[i];
    }
    
}
double r=max-min;
System.Console.WriteLine(r);

