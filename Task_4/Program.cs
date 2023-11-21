int num = 654564645;

int length = Math.Abs(num).ToString().Length;

var array = new int [length];

int count = 0;

int ostatok;

while (num > 0) {
    ostatok = num % 10;
    num = num / 10;
    array[count] = ostatok;
    //Console.WriteLine(array[count]);
    count++;
}

Array.Reverse(array);




Console.WriteLine($"{string.Join(", ", array)}");