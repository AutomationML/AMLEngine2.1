AMLFacet.HasAttributeOfParent Method
====================================
AutomationML 2.1 APIDetermines whether the AMLFacet contains this attribute of the parent AML object.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasAttributeOfParent(
	AttributeType attribute
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
An attribute of the parent.

#### Return Value
Type: [Boolean][3]  
`true` if this attribute of the parent is assigned to the AMLFacet; otherwise, `false`. 

Remarks
-------
 In CAEX 3.0 the Attribute of the AMLFacet has to be a Mirror Attribute. CAEX 2.15 identifies Attributes with identical names. 

See Also
--------

#### Reference
[AMLFacet Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png