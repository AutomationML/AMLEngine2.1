AttributeTypeType.Item Property
===============================
Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as [ATTRIBUTE_VALUE_STRING][1] and [ATTRIBUTE_DEFAULTVALUE_STRING][2].

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public Object this[
	string attributeName
] { get; set; }
```

#### Parameters

##### *attributeName*
Type: [System.String][4]  


#### Return Value
Type: [Object][5]  

#### Implements
[IAttributeValueType.Item[String]][6]  


See Also
--------

#### Reference
[AttributeTypeType Class][7]  
[Aml.Engine.CAEX Namespace][3]  

[1]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_VALUE_STRING.md
[2]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_DEFAULTVALUE_STRING.md
[3]: ../README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.object
[6]: ../IAttributeValueType/Item.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png