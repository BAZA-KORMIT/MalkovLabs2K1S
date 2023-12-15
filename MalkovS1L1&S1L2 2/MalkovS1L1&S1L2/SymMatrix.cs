using System;

namespace SymmetricMatrix;
public class SymMastrix
{
    protected int[,] val;
    protected int n;

    public int N => n;

    public SymMastrix(int n)
    {
        Random rnd = new();
        this.n = rnd.Next(3, 4);
        this.val = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                val[i, j] = rnd.Next(1, 10);
            }
        }
    }

    public SymMastrix(int[,] val)
    {
        this.n = val.GetLength(0);
        this.val = val;
    }

    public int GetElem(int i, int j)=>this.val[i, j];
    
    
    public int GetVectorIndex(int i, int j)
    {
        if (i < j)
        {
            (i,j)=(j,i);
        }
        return i * (i + 1) / 2 + j;
    }

    public int[] PackingOperation(SymMastrix m)
    {
        int q = n * (n + 1) / 2;
        int[] vector = new int[q]; 
        for (int i = 0; i < N ;i++)
        {
            for (int j = i; j < N ; j++)
            {
                int vectorIndex = GetVectorIndex(i, j);
                vector[vectorIndex] = m.GetElem(i, j);
            }
        }
        return vector;
    }

    public  int[,] UnpackingOperation(int[] vector)
    {
        int[,] result = new int[N, N];

        for (int i = 0; i < N;i++ )
        {
            for (int j = i; j < N; j++)
            {
                int vectorIndex = GetVectorIndex(i, j);
                result[i, j] = vector[vectorIndex];
                result[j, i] = vector[vectorIndex];
            }
        }

        return result;
    }
    public bool IsSym()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (GetElem(i, j) != GetElem(j, i))
                {
                    return false;
                }
            }
        }
        return true;
    }
}

