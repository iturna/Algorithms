public class Factorization
{
    public static List<int> GetPrimeFactors(int n)
    {
        List<int> factors = new List<int>();
        
        // Handle the smallest prime factor 2
        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }

        // Handle odd factors from 3 onwards
        for (int i = 3; i * i <= n; i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }

        // If n is still greater than 2, then n is a prime number
        if (n > 2)
        {
            factors.Add(n);
        }

        return factors;
    }
}
