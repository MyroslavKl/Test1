using TestProject1;

namespace Task1;

public class UnitTest1
{
    [Fact]
    public void Add_CollectionNumbers_ReturnCorrectSum()
    {
        //Arrange
        var task = new Tasks();
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        //Act
        var result = task.AddListNumbers(numbers);
        
        //Assert
        Assert.Equal(21,result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        var task = new Tasks();

        // Act
        var result = task.Subtract(10, 5);

        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        var task = new Tasks();

        // Act
        var result = task.Multiply(4, 5);

        // Assert
        Assert.Equal(20, result);
    }
    
    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        var task = new Tasks();

        // Act
        var result = task.Divide(10, 2);

        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var task = new Tasks();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => task.Divide(10, 0));
    }
    
    [Fact]
    public void IntegerDivide_TwoNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.IntegerDivide(10, 3);

        // Assert
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void Modulus_TwoNumbers_ReturnsCorrectRemainder()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.Modulus(10, 3);

        // Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Factorial_PositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.Factorial(5);

        // Assert
        Assert.Equal(120, result);
    }
    
    [Fact]
    public void Factorial_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        var tasks = new Tasks();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => tasks.Factorial(-1));
    }
    
    [Fact]
    public void AbsoluteValue_NegativeNumber_ReturnsPositiveValue()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.AbsoluteValue(-10);

        // Assert
        Assert.Equal(10, result);
    }
    
    [Fact]
    public void FindMax_ListOfNumbers_ReturnsLargestNumber()
    {
        // Arrange
        var tasks = new Tasks();
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Act
        var result = tasks.FindMax(numbers);

        // Assert
        Assert.Equal(6, result);
    }
    
    [Fact]
    public void FindMax_EmptyList_ThrowsArgumentException()
    {
        // Arrange
        var tasks = new Tasks();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => tasks.FindMax(new List<int>()));
    }
    
    [Fact]
    public void ConcatenateStrings_TwoStrings_ReturnsConcatenatedString()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.ConcatenateStrings("Hello", "World");

        // Assert
        Assert.Equal("HelloWorld", result);
    }
    
    [Fact]
    public void ContainsSubstring_StringContainsSubstring_ReturnsTrue()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.ContainsSubstring("Hello World", "World");

        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void ContainsSubstring_StringDoesNotContainSubstring_ReturnsFalse()
    {
        // Arrange
        var tasks = new Tasks();

        // Act
        var result = tasks.ContainsSubstring("Hello World", "world");

        // Assert
        Assert.False(result);
    }
}