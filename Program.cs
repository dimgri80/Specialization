
Console.Clear();

while (true)

{

int i = 0;

int j = 0;

Console.Write("Введите количество элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());

string [] array = new string [n];

void InputArray(string [] array)

{

for (i = 0; i < n; i++)

{

Console.Write("Введите " + (i+1) + " элемент массива: ");

array [i] = Convert.ToString(Console.ReadLine());

}

}

void ReleaseArray(string [] array)

{

for (i = 0; i < n; i++)

{

if (array [i].Length < 4)

{

array[j] = array [i];

j++;

}

}


if (j > 0)
{

Console.WriteLine("Масcив из элементов длиной не более 3х символов: ");

}

else

{

Console.WriteLine("Масcив не содежит элементы длиной не более 3х символов.");

}

for (i = 0; i < j; i++)

{

if (i==0)

{Console.Write("["+array [i] + ", ");}

if (i!=0 && i!=j-1)

{Console.Write(array [i] + ", ");}

if (i==j-1)

{Console.WriteLine(array [i] + "]");}

}
}

InputArray(array);

ReleaseArray(array);

}
