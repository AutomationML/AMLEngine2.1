# FacetAttributeSequence Constructor 
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public FacetAttributeSequence(
	XElement owner,
	Func<XElement, AttributeType> create
)
```

**VB**<br />
``` VB
Public Sub New ( 
	owner As XElement,
	create As Func(Of XElement, AttributeType)
)
```

**C++**<br />
``` C++
public:
FacetAttributeSequence(
	XElement^ owner, 
	Func<XElement^, AttributeType^>^ create
)
```


#### Parameters
&nbsp;<dl><dt>owner</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The owner.</dd><dt>create</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)<br />The constructor function to create an Attribute wrapper.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />