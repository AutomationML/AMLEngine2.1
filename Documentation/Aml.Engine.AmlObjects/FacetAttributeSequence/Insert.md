FacetAttributeSequence.Insert Method
====================================
Inserts the specified attribute into this sequence. Before the attribute is inserted, it is checked, if it is a valid Facet attribute.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override AttributeType Insert(
	AttributeType attribute,
	bool asFirst = true
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The Attribute.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.

#### Return Value
Type: [AttributeType][2]  

[Missing &lt;returns> documentation for "M:Aml.Engine.AmlObjects.FacetAttributeSequence.Insert(Aml.Engine.CAEX.AttributeType,System.Boolean)"]


See Also
--------

#### Reference
[FacetAttributeSequence Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png