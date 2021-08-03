# AutomationMLContainer.CheckRelatedParts Method 
AutomationML 2.1 API 

Returns an enumeration of the related parts for the specified part and relationship type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<(Uri PartUri, Uri RelatedPartUri, bool Exists)> CheckRelatedParts(
	PackagePart part,
	AutomationMLContainer.RelationshipType relationShipType
)
```

**VB**<br />
``` VB
Public Function CheckRelatedParts ( 
	part As PackagePart,
	relationShipType As AutomationMLContainer.RelationshipType
) As IEnumerable(Of (PartUri As Uri, RelatedPartUri As Uri, Exists As Boolean))
```

**C++**<br />
``` C++
public:
IEnumerable<ValueTuple<Uri^, Uri^, bool>>^ CheckRelatedParts(
	PackagePart^ part, 
	AutomationMLContainer.RelationshipType^ relationShipType
)
```


#### Parameters
&nbsp;<dl><dt>part</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">System.IO.Packaging.PackagePart</a><br />The part.</dd><dt>relationShipType</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType</a><br />The relationship type.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-3" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">Uri</a>, <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">Uri</a>, <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a>))<br />IEnumerable<PackagePart>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />