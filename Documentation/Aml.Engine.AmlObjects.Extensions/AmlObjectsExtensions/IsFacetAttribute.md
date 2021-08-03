AmlObjectsExtensions.IsFacetAttribute Method
============================================
Determines, if the attribute is an attribute of an AMLFacet.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsFacetAttribute(
	this AttributeType facetAttribute
)
```

#### Parameters

##### *facetAttribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The facet attribute.

#### Return Value
Type: [Boolean][3]  
`true`, if the Attribute belongs to an AMLFacet. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [AttributeType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][6] | facetAttribute 


See Also
--------

#### Reference
[AmlObjectsExtensions Class][7]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png