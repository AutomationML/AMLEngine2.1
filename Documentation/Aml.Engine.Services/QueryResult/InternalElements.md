QueryResult.InternalElements Method
===================================
AutomationML 2.1 APIGets the InternalElement objects from the query result.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<InternalElementType> InternalElements(
	this ILookup<string, ICAEXReference> queryResult
)
```

#### Parameters

##### *queryResult*
Type: [System.Linq.ILookup][2]&lt;[String][3], [ICAEXReference][4]>  
The queryResult.

#### Return Value
Type: [IEnumerable][5]&lt;[InternalElementType][6]>  
An enumeration of all InternalElement objects in the query result.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ILookup][2]&lt;[String][3], [ICAEXReference][4]>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

#### Reference
[QueryResult Class][9]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png