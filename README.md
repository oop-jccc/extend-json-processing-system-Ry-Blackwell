# Dynamic JSON Processing - Educational Repository

This repository demonstrates the Strategy Design Pattern and SOLID principles through a JSON processing system built with ASP.NET Core.

## Branch Structure

This repository follows a numbered branch structure that reflects the educational progression:

### 01-todo-starter-code (Default Branch)
- **Purpose**: Starting point for students
- **Content**: Base infrastructure with User and Product processors
- **Missing**: TodoItem model and processor implementation
- **Student Task**: Implement the missing TodoItem functionality

### 02-todo-solution
- **Purpose**: Complete solution for the Todo assignment
- **Content**: Full TodoItem implementation demonstrating proper use of records and the `with` operator
- **Learning Focus**: Strategy pattern, Open/Closed principle, immutable data structures

### 03-template-method-pattern
- **Purpose**: Advanced implementation showing Template Method pattern
- **Content**: Refactored processors using BaseJsonProcessor abstract class
- **Learning Focus**: Template Method pattern, inheritance, advanced OOP design

### 04-exam-thumbnail-exercise
- **Purpose**: Additional exercise for assessment
- **Content**: Thumbnail model and processor implementation
- **Learning Focus**: Pattern application with different data types

## Advanced Pattern Implementation - Template Method Pattern

**🎯 This branch demonstrates the Template Method pattern combined with the Strategy pattern.**

This branch shows an advanced refactoring of the JSON processing system that introduces the Template Method design pattern alongside the existing Strategy pattern. This implementation provides a more sophisticated object-oriented design that reduces code duplication and provides a cleaner inheritance hierarchy.

### What's Implemented

This branch includes all previous functionality plus:
- ✅ **BaseJsonProcessor Abstract Class**: Generic base class implementing the Template Method pattern
- ✅ **Refactored Processors**: All processors now inherit from `BaseJsonProcessor<T>`
- ✅ **Template Method Implementation**: Common processing logic extracted to base class
- ✅ **Type Safety**: Generic implementation provides compile-time type safety
- ✅ **Code Reuse**: Eliminates duplication across processor implementations

### Template Method Pattern Structure

The `BaseJsonProcessor<T>` abstract class implements the Template Method pattern:

```csharp
public abstract class BaseJsonProcessor<T> : IJsonProcessor
{
    public object? Process(JObject json)
    {
        return !CanProcess(json) ? null : ProcessInternal(json);
    }

    public abstract bool CanProcess(JObject json);
    protected abstract T? ProcessInternal(JObject json);
}
```

### Key Design Benefits

- **Template Method Pattern**: The `Process` method defines the algorithm structure while allowing subclasses to implement specific steps
- **Generic Type Safety**: Each processor specifies its return type through the generic parameter
- **Code Reduction**: Common null-checking and flow control logic is centralized
- **Inheritance Hierarchy**: Clear relationship between base class and concrete implementations
- **Maintainability**: Changes to common processing logic only need to be made in one place

### Processor Implementations

All processors now follow this pattern:
- **UserJsonProcessor**: Inherits from `BaseJsonProcessor<User>`
- **ProductJsonProcessor**: Inherits from `BaseJsonProcessor<Product>`
- **TodoItemProcessor**: Inherits from `BaseJsonProcessor<TodoItem>`

### Testing the Implementation

1. Run the application to launch Swagger UI
2. Test with any of the supported JSON formats:
   - User: `{"Name":"John Doe","Email":"john.doe@example.com"}`
   - Product: `{"ProductName":"Laptop","Price":999.99}`
   - TodoItem: `{"Title":"Buy Milk","IsCompleted":false}`

### Advanced Learning Outcomes

- **Template Method Pattern**: Understanding how to define algorithm skeletons in base classes
- **Generic Programming**: Using generics for type safety and code reuse
- **Inheritance vs Composition**: When and how to use inheritance effectively
- **Design Pattern Combination**: How multiple patterns can work together
- **Code Refactoring**: Improving existing code while maintaining functionality

## Technologies Used

- ASP.NET Core 6.0
- Newtonsoft.Json
- Swagger/OpenAPI
- C# Records and Pattern Matching

## Learning Objectives

- Template Method Design Pattern implementation
- Strategy Design Pattern implementation
- SOLID principles (especially Open/Closed)
- Dependency Injection in .NET
- Immutable data structures with C# records
- Web API development with ASP.NET Core
- Generic programming and type safety