ObjectWithBaseClass.GetInheritedAttributes Method
=================================================
AutomationML 2.1 APIGets a collection of Attribute objects that are inherited from base classes. The own attributes are included in the enumeration.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<AttributeType> GetInheritedAttributes(
	this IClassWithBaseClassReference classWithBaseClass,
	bool includeSelf = true
)
```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]  
The class with a possible base class reference for inheritance.

##### *includeSelf* (Optional)
Type: [System.Boolean][3]  
if set to `true` includes the own attributes.

#### Return Value
Type: [IEnumerable][4]&lt;[AttributeType][5]>  
 A collection of Attribute objects 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/AttributeType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png