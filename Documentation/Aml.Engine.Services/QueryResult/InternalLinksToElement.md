QueryResult.InternalLinksToElement Method
=========================================
AutomationML 2.1 APIGets all InternalLink referencing the provided SystemUnitClass object.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<InternalLinkType> InternalLinksToElement(
	this SystemUnitClassType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The SystemUnitClass object.

#### Return Value
Type: [IEnumerable][3]&lt;[InternalLinkType][4]>  
 An enumeration of all InternalLink objects referencing the provided SystemUnitClass. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[QueryResult Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/InternalLinkType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png