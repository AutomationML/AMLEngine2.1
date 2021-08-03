QueryResult.AllElementsWithIDs Method
=====================================
Gets all the elements with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static ILookup<string, ICAEXReference> AllElementsWithIDs(
	this CAEXDocument doc
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

#### Return Value
Type: [ILookup][3]&lt;[String][4], [ICAEXReference][5]>  
group of elements with IDs. The ID is used as a group key.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXDocument][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[QueryResult Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png