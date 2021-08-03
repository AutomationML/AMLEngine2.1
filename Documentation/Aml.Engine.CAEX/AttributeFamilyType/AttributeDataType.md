AttributeFamilyType.AttributeDataType Property
==============================================
Gets and set the AttributeDataType. If the AttributeDataType is not defined for this AttributeType but a [BaseClass][1] exists, the AttributeDataType of the BaseClass is returned. If this optional attribute is not defined, the data type is assumed to be "xs:string", according to CAEX (DIN EN 62424:2008-08)

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override string AttributeDataType { get; set; }
```

#### Property Value
Type: [String][3]
#### Implements
[IAttributeValueType.AttributeDataType][4]  


See Also
--------

#### Reference
[AttributeFamilyType Class][5]  
[Aml.Engine.CAEX Namespace][2]  
[AttributeFamilyType.BaseClass][1]  

[1]: BaseClass.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../IAttributeValueType/AttributeDataType.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png