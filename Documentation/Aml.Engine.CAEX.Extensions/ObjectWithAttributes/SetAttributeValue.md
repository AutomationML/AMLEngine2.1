ObjectWithAttributes.SetAttributeValue Method (IObjectWithAttributes, String, Double)
=====================================================================================
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static AttributeType SetAttributeValue(
	this IObjectWithAttributes objWithAttr,
	string attName,
	double attValue
)
```

#### Parameters

##### *objWithAttr*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
parent object

##### *attName*
Type: [System.String][3]  
attribute name

##### *attValue*
Type: [System.Double][4]  
attribute value of type double

#### Return Value
Type: [AttributeType][5]  
The modified attribute
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ObjectWithAttributes Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.double
[5]: ../../Aml.Engine.CAEX/AttributeType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png