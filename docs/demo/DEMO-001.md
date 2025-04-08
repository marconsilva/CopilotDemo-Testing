# Demo Script: Generating Unit Tests with GitHub Copilot

This demo script walks through how to use GitHub Copilot's `/test` command to generate unit tests for a .NET Web API project. The examples demonstrate multiple testing scenarios including controller tests, service tests, and mocking dependencies.

## Prerequisites

- Visual Studio Code with GitHub Copilot extension installed
- .NET 9.0 SDK installed
- CopilotDemo-Testing repository cloned to your local machine

## Demo Steps

### 1. Generate Basic Controller Tests

**Target File:** `WeatherForecastController.cs`

1. Open the controller file: `WeatherForecastController.cs`.
2. Place your cursor above the class definition.
3. Use the following prompt to generate basic tests for the controller:
   ```
   /test Generate unit tests for the WeatherForecastController class.
   ```

### 2. Add Test for Get Method

1. Identify the `Get` method in the `WeatherForecastController`.
2. Place your cursor inside the test class generated in the previous step.
3. Use the following prompt to create a test for the `Get` method:
   ```
   /test Create a unit test for the Get method in WeatherForecastController.
   ```

### 3. Mock Dependencies

1. If your controller has dependencies (e.g., a service), identify them.
2. Place your cursor in the test class.
3. Use the following prompt to generate mocks for the dependencies:
   ```
   /test Generate mocks for the dependencies of WeatherForecastController.
   ```

### 4. Test for Post Method

1. Identify the `Post` method in the `WeatherForecastController`.
2. Place your cursor inside the test class.
3. Use the following prompt to create a test for the `Post` method:
   ```
   /test Create a unit test for the Post method in WeatherForecastController.
   ```

### 5. Run the Tests

1. Open the terminal in your IDE.
2. Use the following command to run the tests:
   ```
   dotnet test
   ```

### 6. Review and Refine Tests

1. Review the generated tests for accuracy and completeness.
2. Make any necessary adjustments to ensure they meet your testing requirements.

### Conclusion

This demo showcased how to leverage GitHub Copilot's `/test` command to efficiently generate unit tests for a .NET Web API project. By following these steps, you can streamline your testing process and improve code quality.