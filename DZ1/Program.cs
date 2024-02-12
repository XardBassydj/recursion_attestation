int m = 1;
int n = 10;
     void ShowNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            ShowNumbers(m + 1, n);
        }
    }
    
 Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
 ShowNumbers(m, n);
    
