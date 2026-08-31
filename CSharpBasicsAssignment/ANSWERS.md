# Part G — Short Answer

## 1. Paste your .csproj contents and confirm each of the four properties mentioned in Part A is present.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

Yes, all four properties are present:

- OutputType
- TargetFramework
- ImplicitUsings
- Nullable

## 2. Do #region / #endregion change the compiled output? Why might you still use them?

No, they do not change the compiled output.  
They help organize and collapse code.

## 3. When would you reach for /// XML doc comments instead of a plain //?

Use `///` to document classes, methods, or properties.  
Use `//` for normal comments.

## 4. Why does C# have no true global variables, and what's the closest equivalent?

C# has no true global variables because variables belong to a method or type.  
The closest equivalent is a static field in a static class.