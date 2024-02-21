Console.WriteLine("Podaj dlugosc tablicy");
int dlugosc = Convert.ToInt32(Console.ReadLine());

//sortowanie babelkowe

int[] array = new int[dlugosc];
Random random = new Random();


for (int i = 0; i < dlugosc; i++)
{
    array[i] = random.Next(1, 100);
    Console.Write(array[i]+" ");
}


int temp;

for (int i = 0; i < dlugosc; i++)
{
    for (int j = 1; j < dlugosc - i; j++)
    {
        if (array[j - 1] > array[j])
        {
            temp = array[j - 1];
            array[j - 1] = array[j];
            array[j] = temp;
        }
    }
}

Console.WriteLine("\nPosortowana tablica");
for (int i = 0; i < dlugosc; i++)
{
    Console.Write(array[i] + " ");
}

//sortowanie kubelkowe