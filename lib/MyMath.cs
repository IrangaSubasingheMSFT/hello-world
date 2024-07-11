Without the context of the entire codebase, it's difficult to provide a comprehensive solution to your request. However, I can provide some general guidance on how to implement the checklist items. 

Here's a general example of how you might refactor the `Add` method in `MyMath` and add a corresponding unit test:

```csharp
public class MyMath
{
    public static double Add(double a, double b)
    {
        return a + b;
    }
}

public class MyMathTests
{
    [Fact]
    public void Add_AddsCorrectly()
    {
        double result = MyMath.Add(2, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Add_HandlesNegativeNumbers()
    {
        double result = MyMath.Add(-2, 2);
        Assert.Equal(0, result);
    }
}
```

For Open Telemetry Instrumentation, you would typically use a library like `OpenTelemetry.Instrumentation.Http` to instrument HTTP requests and `OpenTelemetry.Instrumentation.SqlClient` for SQL queries. 

For Managed Service Identities (MSIs), you would use Azure's `Azure.Identity` library to access secrets from Azure Key Vault, rather than hardcoding them in your application. Here's an example of how you might do that:

```csharp
var client = new SecretClient(new Uri("<key-vault-url>"), new DefaultAzureCredential());

KeyVaultSecret secret = client.GetSecret("<secret-name>");

string secretValue = secret.Value;
```

Please note that in a real-world scenario, you would handle errors and edge cases for all these operations. These examples are simplified for the sake of brevity.