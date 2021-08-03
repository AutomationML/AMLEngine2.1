# AutomationMLContainer.GetRelationShipsByType Method 
AutomationML 2.1 API 

Returns an enumeration of all relationships with the given relationship type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<PackageRelationship> GetRelationShipsByType(
	AutomationMLContainer.RelationshipType relationType
)
```

**VB**<br />
``` VB
Public Function GetRelationShipsByType ( 
	relationType As AutomationMLContainer.RelationshipType
) As IEnumerable(Of PackageRelationship)
```

**C++**<br />
``` C++
public:
IEnumerable<PackageRelationship^>^ GetRelationShipsByType(
	AutomationMLContainer.RelationshipType^ relationType
)
```


#### Parameters
&nbsp;<dl><dt>relationType</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType</a><br />Type of the relation.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagerelationship" target="_parent" rel="noopener noreferrer">PackageRelationship</a>)<br />IEnumerable<PackageRelationship>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />