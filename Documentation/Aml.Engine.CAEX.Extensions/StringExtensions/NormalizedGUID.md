StringExtensions.NormalizedGUID Method
======================================
String extension method to normalize a GUID. If the string cannot be identified as a GUID the original string is returned

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string NormalizedGUID(
	this string stringGuid
)
```

#### Parameters

##### *stringGuid*
Type: [System.String][2]  
The stringGuid.

#### Return Value
Type: [String][2]  
The normalized GUID if the provided string is a GUID; otherwise the original string is returned.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [String][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

See Also
--------

#### Reference
[StringExtensions Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png