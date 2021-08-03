# AutomationMLContainer.GetRelatedPartByUri Method 
AutomationML 2.1 API 

Gets the related part by URI.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public PackagePart GetRelatedPartByUri(
	Uri refUri,
	AutomationMLContainer.RelationshipType relationShipType
)
```

**VB**<br />
``` VB
Public Function GetRelatedPartByUri ( 
	refUri As Uri,
	relationShipType As AutomationMLContainer.RelationshipType
) As PackagePart
```

**C++**<br />
``` C++
public:
PackagePart^ GetRelatedPartByUri(
	Uri^ refUri, 
	AutomationMLContainer.RelationshipType^ relationShipType
)
```


#### Parameters
&nbsp;<dl><dt>refUri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">System.Uri</a><br />The reference URI.</dd><dt>relationShipType</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType</a><br />The relationship type.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">PackagePart</a><br />PackagePart.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />