int[] array = {1,21,13,41,15,2,3,2,6,117,8,119,10};

int n = array.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index+1;
    index++;
}