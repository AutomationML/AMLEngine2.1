AMLFacet.SourceAttribute Method
===============================
AutomationML 2.1 APIGets the original Attribute from the [AssignedParentAttributes()][1] which is related to this Facet Attribute.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AttributeType SourceAttribute(
	AttributeType facetAttribute
)
```

#### Parameters

##### *facetAttribute*
Type: [Aml.Engine.CAEX.AttributeType][3]  
The facet attribute.

#### Return Value
Type: [AttributeType][3]  
An Attribute from the parent with the same name.

Remarks
-------
 In CAEX 3.0 the Source Attribute is the Master Attribute of the *facetAttribute*. CAEX 2.15 the Source Attribute is the first identified Attribute of the parent with an identical name. 

See Also
--------

#### Reference
[AMLFacet Class][4]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: AssignedParentAttributes.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/AttributeType/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png