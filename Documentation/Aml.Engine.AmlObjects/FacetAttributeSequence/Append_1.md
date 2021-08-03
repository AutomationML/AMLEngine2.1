FacetAttributeSequence.Append Method (String)
=============================================
AutomationML 2.1 APIAppends a new Attribute with the provided name to the sequence of Attributes, if the conditions for Facet Attributes are fulfilled. Facet Attributes are a subset of Attributes which are defined for the Parent object of an [AMLFacet][1]. An Attribute with the specified name can only be added as a Facet Attribute, if the Facets parent has an identical Attribute with that name and the Attribute has not been associated to the Facet before.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override AttributeType Append(
	string name
)
```

#### Parameters

##### *name*
Type: [System.String][3]  
The name of the Attribute.

#### Return Value
Type: [AttributeType][4]  
The created and appended Attribute, if the conditions were fulfilled; otherwise `null`.

See Also
--------

#### Reference
[FacetAttributeSequence Class][5]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: ../AMLFacet/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/AttributeType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png