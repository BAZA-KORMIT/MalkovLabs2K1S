using System.Numerics;

namespace SparceArray;
public class SparseArr
{
    protected int n;
    protected int m;
    protected int vSize;
    protected int bg;
    protected int[] v;

    public int N => n;
    public int M => m;

    public SparseArr(int n, int m)
    {
        this.n = n;
        this.m = m;
        vSize = n * m / 2;
        v = new int[vSize];
        Console.WriteLine("Введите элементы: ");
        for (int i = 0; i < vSize; i++)
        {
            v[i] = Convert.ToInt32(Console.Read());
        }
    }

    private int IndexVec(int i, int j) => (i * n + j) / 2; //Не та формула :(

    public int GetElem(int i, int j) => v[IndexVec(i, j)];

    public void PrintSArr()
    {
        Console.WriteLine("Распакованное представление разряженной матрицы:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("|");
            for (int j = 0; j < m; j++)
            {
                Console.Write(" " + GetElem(i, j) + " ");
            }
            Console.Write("|\n");
        }
    }

}

