# AutomationMLContainer.RelationShipExists Method 
AutomationML 2.1 API 

Determines, if the specified relationship type exists.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool RelationShipExists(
	AutomationMLContainer.RelationshipType relationShipType
)
```

**VB**<br />
``` VB
Public Function RelationShipExists ( 
	relationShipType As AutomationMLContainer.RelationshipType
) As Boolean
```

**C++**<br />
``` C++
public:
bool RelationShipExists(
	AutomationMLContainer.RelationshipType^ relationShipType
)
```


#### Parameters
&nbsp;<dl><dt>relationShipType</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType</a><br />Type of the relation.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if relationship type exists, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />