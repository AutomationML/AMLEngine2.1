# AutomationMLContainer.RelationshipType.CompareTo Method 
AutomationML 2.1 API 

Compares the current instance's name to another object's name of the same type and returns an integer indicating whether the current instance's name occurs in the sort order before or after the other object or at the same position.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public int CompareTo(
	AutomationMLContainer.RelationshipType other
)
```

**VB**<br />
``` VB
Public Function CompareTo ( 
	other As AutomationMLContainer.RelationshipType
) As Integer
```

**C++**<br />
``` C++
public:
virtual int CompareTo(
	AutomationMLContainer.RelationshipType^ other
) sealed
```


#### Parameters
&nbsp;<dl><dt>other</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType</a><br />An object to compare with this instance.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">Int32</a><br />A value indicating the relative order of the objects being compared. The return value has the following meaning: Less than zero: This instance is in the sort order before *other*. Zero: This instance occurs in the sort order at the same position as *other*. Greater than zero: This instance follows in the sort order*other*.

#### Implements
<a href="https://docs.microsoft.com/dotnet/api/system.icomparable-1.compareto#System_IComparable_1_CompareTo__0_" target="_parent" rel="noopener noreferrer">IComparable(T).CompareTo(T)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType">AutomationMLContainer.RelationshipType Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />