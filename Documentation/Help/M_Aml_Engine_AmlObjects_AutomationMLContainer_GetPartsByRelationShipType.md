# AutomationMLContainer.GetPartsByRelationShipType Method 
AutomationML 2.1 API 

Returns an enumeration of all parts with the given relationship type from the package.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<PackagePart> GetPartsByRelationShipType(
	AutomationMLContainer.RelationshipType relationShipType
)
```

**VB**<br />
``` VB
Public Function GetPartsByRelationShipType ( 
	relationShipType As AutomationMLContainer.RelationshipType
) As IEnumerable(Of PackagePart)
```

**C++**<br />
``` C++
public:
IEnumerable<PackagePart^>^ GetPartsByRelationShipType(
	AutomationMLContainer.RelationshipType^ relationShipType
)
```


#### Parameters
&nbsp;<dl><dt>relationShipType</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType</a><br />The relationship type.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">PackagePart</a>)<br />IEnumerable<PackagePart>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />