OrdinalScaledTypeType.ValueAttributes Property
==============================================
AutomationML 2.1 APIGets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are [ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING][1] and [ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING][2] and [ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING][3].

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public List<CaexValue> ValueAttributes { get; }
```

#### Property Value
Type: [List][5]&lt;[CaexValue][6]>
#### Implements
[IAttributeValueType.ValueAttributes][7]  


See Also
--------

#### Reference
[OrdinalScaledTypeType Class][8]  
[Aml.Engine.CAEX Namespace][4]  

[1]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING.md
[2]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING.md
[3]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING.md
[4]: ../README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1
[6]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[7]: ../IAttributeValueType/ValueAttributes.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png