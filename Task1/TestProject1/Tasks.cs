namespace TestProject1;

public class Tasks
{
    public int AddListNumbers(List<int> numbers)
    {
        int sum = 0;
        if (numbers == null || numbers.Count == 0)
        {
            throw new Exception("Nothing in the collection");
        }
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }
    
    public int Subtract(int a, int b)
    {
        var result = a - b;
        return result;
    }
    
    public int Multiply(int a, int b)
    {
        var result = a * b;
        return result;
    }
    
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        var result = (double)a / b;
        
        return result;
    }
    
    public int IntegerDivide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        var result = a / b;
        return result;
    }
    
    public int Modulus(int a, int b)
    {
        var module = a % b;
        return module;
    }
    
    public int Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Negative number not allowed.");
        }
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    
    public int AbsoluteValue(int n)
    {
        var result = Math.Abs(n);
        return result;
    }
    
    public int FindMax(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("List cannot be empty.");    
        }
        
        var result = numbers.Max();
        return result;
    }
    
    public string ConcatenateStrings(string str1, string str2)
    {
        var result = str1 + str2;
        return result;
    }
    
    public bool ContainsSubstring(string mainString, string substring)
    {
        bool result = mainString.Contains(substring);
        return result;
    }

}