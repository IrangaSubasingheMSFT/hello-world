The provided code is incomplete, and it doesn't seem to include any HTTP requests, database queries, or application secrets, so there's not much to correct according to the checklist. However, I can show you how to add unit tests to the GetValue() function and how to close the strings in the assertion messages. Here's the corrected code:

```csharp
public TValue GetValue()
{
    return _value;
}

[Fact]
public void GetValue_ReturnsCorrectValue()
{
    // Arrange
    var expectedValue = _value; // assuming _value is a field in the class

    // Act
    var actualValue = GetValue();

    // Assert
    Assert.True(expectedValue == actualValue, $"actual value {actualValue}");
}

public void Test1()
{
    double a = 13;
    double b = 31;
    double expectedValue = a + b;
    double actualValue = Library.MyMath.Add(a, b);
    Assert.True(expectedValue == actualValue, $"actual value {actualValue}");
}

[Theory]
[InlineData(0)]
[InlineData(1)]
public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
{
    var result = Library.MyMath.IsPrime(value);

    Assert.False(result, $"{value} is not prime");
}

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double a = 13;
        double b = 31;
        double expectedValue = a + b;
        double actualValue = Library.MyMath.Add(a, b);
        Assert.True(expectedValue == actualValue, $"actual value {actualValue}");
    }
}
```

The GetValue_ReturnsCorrectValue() function is a new unit test for the GetValue() function. The IsPrime_ValuesLessThan2_ReturnFalse() and Test1() functions now have closed strings in the assertion messages. The IsPrime_ValuesLessThan2_ReturnFalse() function also uses the [Theory] and [InlineData] attributes to test multiple values.