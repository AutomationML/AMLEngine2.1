OrdinalScaledTypeType.GetCaexValue Method
=========================================
AutomationML 2.1 APIGets the [CaexValue][1] for the value attribute with the defined attribute name. are [ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING][2] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING][3] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING][4].

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CaexValue GetCaexValue(
	string attributeName
)
```

#### Parameters

##### *attributeName*
Type: [System.String][6]  


#### Return Value
Type: [CaexValue][1]  
The CAEXValue for the named attribute.
#### Implements
[IAttributeValueType.GetCaexValue(String)][7]  


See Also
--------

#### Reference
[OrdinalScaledTypeType Class][8]  
[Aml.Engine.CAEX Namespace][5]  

[1]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[2]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING.md
[3]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING.md
[4]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING.md
[5]: ../README.md
[6]: https://docs.microsoft.com/dotnet/api/system.string
[7]: ../IAttributeValueType/GetCaexValue.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png