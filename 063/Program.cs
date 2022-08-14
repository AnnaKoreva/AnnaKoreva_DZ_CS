// Сформировать трехмерный массив неповторяющимися двузначными числами показать его построчно на экран
// выводя индексы соответствующего элемента
int[,,]arr;
Fill3D(out arr,4,4,4);
Print3D (arr);
void Fill3D (out int[,,] arr, int one,int two,int three)
{
    arr=new int[one,two,three];
    int NewRandomValue;
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            for(int k=0;k<arr.GetLength(2);)
            {
                bool match = false;
                NewRandomValue = new Random().Next(20,100);
                match = CheckUnique(arr,NewRandomValue,i,j,k);
                if (match!=true)
                {
                arr[i,j,k] = NewRandomValue;
                k++;                      
                }         
            }
        }
    }
}
bool CheckUnique (int[,,] arr,int NewRandom,int i,int j,int k)
{
    for(int z=0;z<i+1;z++)
    {
        for(int x=0;x<arr.GetLength(1);x++)
        {
            for(int g=0;g<arr.GetLength(2);g++)
            {
                if(arr[z,x,g] == NewRandom)
                {
                    return true;
                } 
            }
        }
    } 
    return false;        
}
void Print3D (int[,,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            for(int k=0;k<arr.GetLength(2);k++)
            {
                System.Console.WriteLine($"|{i}|{j}|{k}| = {arr[i,j,k]}");
      
            }
        }
    }
}
