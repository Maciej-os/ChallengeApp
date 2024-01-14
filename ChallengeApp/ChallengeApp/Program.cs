int number = 4566;
string numberAsString = number.ToString();

char[] letters = numberAsString.ToArray();
int[] countChars = new int[10];

for (int i = 0; i < letters.Length; i++)
{
    char a = letters[i];
    int digit = Convert.ToInt32(a) - Convert.ToInt32('0');
    countChars[digit]++;
}

Console.WriteLine("Wyniki dla liczby: " + number);

for (int i = 0; i < countChars.Length; i++)
{
    Console.WriteLine(i + " => " + countChars[i]);
}


