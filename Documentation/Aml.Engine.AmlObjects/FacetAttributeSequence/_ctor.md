FacetAttributeSequence Constructor
==================================
Initializes a new instance of the [FacetAttributeSequence][1] class.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public FacetAttributeSequence(
	XElement owner,
	Func<XElement, AttributeType> create
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][3]  
The owner.

##### *create*
Type: [System.Func][4]&lt;[XElement][3], [AttributeType][5]>  
The constructor function to create an Attribute wrapper.


See Also
--------

#### Reference
[FacetAttributeSequence Class][1]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.func-2
[5]: ../../Aml.Engine.CAEX/AttributeType/README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png