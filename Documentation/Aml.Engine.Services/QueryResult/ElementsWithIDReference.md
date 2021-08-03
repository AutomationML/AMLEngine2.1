QueryResult.ElementsWithIDReference Method
==========================================
AutomationML 2.1 APIGets alls the elements from the document which have a reference to the provided ID.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<ICAEXReference> ElementsWithIDReference(
	this CAEXDocument doc,
	string ID
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *ID*
Type: [System.String][3]  
The identifier.

#### Return Value
Type: [IEnumerable][4]&lt;[ICAEXReference][5]>  
 a collection of elements which have a reference to the provided ID 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXDocument][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[QueryResult Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png