static class Service
{
    public static double CalculateSum(Func<int, double> getTerm, double epsilon)
    {
        double sum = 0;
        double currentTerm;
        int n = 0; 

        do
        {
            currentTerm = getTerm(n); 
            sum += currentTerm;
            n++;
        }
        while (Math.Abs(currentTerm) >= epsilon);

        return sum;
    }
    public static double Factorial(int n)
    {
        double res = 1;
        for (int i = 1; i <= n; i++) res *= i;
        return res;
    }
}

