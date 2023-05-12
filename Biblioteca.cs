class Biblioteca
{
    static public double Soma(double a, double b)
    {
        return a + b;
    }
    static public decimal Soma(double[] listNum)
    {
        decimal sumary = 0;

        foreach (decimal num in listNum)
        {
            sumary += num;
        }

        return sumary;
    }
}