Console.Write("Enter number: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSumFromMToN(M, N));

int GetSumFromMToN(int numOne, int numTwo) {
    if (numOne == numTwo) {
        return numOne;
    }
    return numOne + GetSumFromMToN(numOne+1, numTwo);
}