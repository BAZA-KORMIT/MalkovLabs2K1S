using System.Numerics;

namespace SparceArray;
public class SparseArr
{
    private Dictionary<(int, int), double> elements;
    private int Rows;
    private int Cols;
    private double BackgroundElem;

    public SparseArr(double[,] matrix)
    {
        Rows = matrix.GetLength(0);
        Cols = matrix.GetLength(1);
        BackgroundElem = GetBackgroundElem(matrix);
        elements = new Dictionary<(int, int), double>();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                double element = matrix[i, j];
                if (element != BackgroundElem)
                    elements[(i, j)] = element;
            }
        }
    }

    public int GetRows() => Rows;
    
    public int GetCols() => Cols;

    public SparseArr()
    {
        Rows = 2;
        Cols = 2;
        BackgroundElem = 0;
        elements = new Dictionary<(int, int), double>();
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
                elements[(i, j)] = BackgroundElem;
    }
    //возвращение элемента по двум индексам из массива (фонового элемента если нет там ничего нет)
    public double GetElemFromSpArr(int row, int col)
    {
        foreach (var key in elements.Keys)
            if (key.Item1 == row && key.Item2 == col)
                return elements[key];
        Console.WriteLine("Элемент не найден");
        return BackgroundElem;
    }

    //запись элемента в упаковонное представление
    public void SetVal(int row, int col, double value)
    {
        bool flag = false;
        if (row <= Rows && col <= Cols)
            foreach (var key in elements.Keys)
                if (key.Item1 == row && key.Item2 == col)
                {
                    elements[key] += value;
                    flag = true;
                }
        if (!flag)
            elements.Add((row, col), value);
    }

    //получение индекса вектора
    public double[] ConvertToVectorIndices()
    {
        List<double> vectorIndices = new List<double>();
        foreach (var key in elements.Keys)
            vectorIndices.Add(key.Item1 * key.Item2 + key.Item2);
        return vectorIndices.ToArray();
    }

    //unpack
    public double[,] UnpackSparseArray()
    {
        double[,] result = new double[Rows, Cols];
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
                result[i, j] = BackgroundElem;
        foreach (var key in elements.Keys)
            result[key.Item1, key.Item2] = elements[key];
        return result;
    }

    //Получение фонового элемента
    public double GetBackgroundElem(double[,] array)
    {
        Dictionary<double, double> countDictionary = new Dictionary<double, double>();
        double phoneelement = 0;
        List<(int, double)> listcountelem = new List<(int, double)>();// кол-во элементов и элемент
        int count = 0;
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
            {
                double value = array[i, j];
                if (!countDictionary.ContainsValue(value))
                {
                    countDictionary.Add(count, value);
                    listcountelem.Add((1, value));
                    count++;
                }
                else
                {
                    int indx = listcountelem.FindIndex(t => t.Item2 == value);
                    int thisitem1 = listcountelem[indx].Item1;
                    listcountelem[indx] = (thisitem1 + 1, value);
                }
        }
        int index = listcountelem.FindIndex(t => t.Item1 == listcountelem.Max(tuple => tuple.Item1));
        phoneelement = listcountelem[index].Item2;
        return phoneelement;
    }
}

