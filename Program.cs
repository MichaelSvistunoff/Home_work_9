Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetRowFromMaxToMinN(N));

string GetRowFromMaxToMinN(int number) {
    if (number == 1) {
        return number.ToString();
    }
    return (number + " " + GetRowFromMaxToMinN(number-1));
}