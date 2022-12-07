int [] array = { 1, 28, 34, 41, 15, 67, 17, 8} ;

int n = array.Length;
int find = 67;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1;
    index++;
}