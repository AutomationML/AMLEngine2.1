OrdinalScaledTypeType.Item Property
===================================
AutomationML 2.1 APIGets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names are [ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING][1] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING][2] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING][3].

  **Namespace:**  [Aml.Engine.CAEX][4]  
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
Type: [System.String][5]  


#### Return Value
Type: [Object][6]  
A type based object
#### Implements
[IAttributeValueType.Item[String]][7]  


See Also
--------

#### Reference
[OrdinalScaledTypeType Class][8]  
[Aml.Engine.CAEX Namespace][4]  

[1]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING.md
[2]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING.md
[3]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING.md
[4]: ../README.md
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://docs.microsoft.com/dotnet/api/system.object
[7]: ../IAttributeValueType/Item.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png