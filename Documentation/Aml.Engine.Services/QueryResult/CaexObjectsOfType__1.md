QueryResult.CaexObjectsOfType&lt;T> Method
==========================================
Gets the CAEX objects of the specified type from the query result.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<T> CaexObjectsOfType<T>(
	this ILookup<string, ICAEXReference> queryResult
)
where T : CAEXBasicObject

```

#### Parameters

##### *queryResult*
Type: [System.Linq.ILookup][2]&lt;[String][3], [ICAEXReference][4]>  
The queryResult.

#### Type Parameters

##### *T*
Type of the required CAEX object.

#### Return Value
Type: [IEnumerable][5]&lt;**T**>  
 An enumeration of all CAEX objects of the specified type in the query result. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ILookup][2]&lt;[String][3], [ICAEXReference][4]>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[QueryResult Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png