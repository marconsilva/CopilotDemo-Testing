# CopilotDemo-Testing

Welcome to the CopilotDemo-Testing repository! This project is designed to demonstrate the capabilities of GitHub Copilot in generating tests for various types of code. It includes sample projects in C# .NET 9.0 and JavaScript, showcasing how Copilot can assist in writing unit tests, integration tests, and utilizing mocking techniques.

## Project Structure

The project is organized into the following main directories:

- **src**: Contains the source code for the C# Web API and Library, as well as JavaScript utility functions.
  - **CSharp**: 
    - **WebApi**: The main Web API project with controllers, models, and services.
    - **Library**: A library project with utility classes for arithmetic and string operations.
  - **JavaScript**: Contains utility functions for array manipulation and data formatting.

- **tests**: Contains test projects for both the C# and JavaScript code.
  - **CSharp**: 
    - **WebApi.Tests**: Unit tests for the Web API controllers and services.
    - **Library.Tests**: Unit tests for the library classes.
  - **JavaScript**: Unit tests for the JavaScript utility functions.

- **docs**: Documentation files, including examples of unit tests, integration tests, and mocking techniques.

- **.github**: Contains GitHub Actions workflows for continuous integration.

## Demo Use Cases

This repository showcases several use cases for GitHub Copilot in generating tests:

1. **Unit Testing**: 
   - Demonstrates how to write unit tests for individual methods in classes, ensuring that each method behaves as expected.
   - Example: Unit tests for `WeatherForecastController` and `WeatherService`.

2. **Integration Testing**: 
   - Shows how to test the interaction between different components of the application.
   - Example: Integration tests that verify the behavior of the Web API when interacting with the service layer.

3. **Mocking**: 
   - Illustrates the use of mocking frameworks to isolate components during testing.
   - Example: Mocking dependencies in tests for `WeatherService` to simulate different scenarios.

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/CopilotDemo-Testing.git
   ```

2. Navigate to the project directory:
   ```
   cd CopilotDemo-Testing
   ```

3. Restore the dependencies for the C# projects:
   ```
   cd src/CSharp/WebApi
   dotnet restore
   ```

4. Run the Web API project:
   ```
   dotnet run
   ```

5. Navigate to the tests directory and run the tests:
   ```
   cd ../../tests/CSharp/WebApi.Tests
   dotnet test
   ```

6. For JavaScript tests, navigate to the JavaScript directory and install dependencies:
   ```
   cd ../../src/JavaScript
   npm install
   ```

7. Run the JavaScript tests:
   ```
   npm test
   ```

## Conclusion

This repository serves as a practical demonstration of how GitHub Copilot can enhance the development process by assisting in writing tests. We encourage you to explore the code, run the tests, and see how Copilot can help you in your own projects!