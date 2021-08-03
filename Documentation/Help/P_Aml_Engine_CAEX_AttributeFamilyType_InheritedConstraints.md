# AttributeFamilyType.InheritedConstraints Property 
AutomationML 2.1 API 

Gets all constraints, including the inherited constraints of the base classes in the inheritance tree.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<AttributeValueRequirementType> InheritedConstraints { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property InheritedConstraints As IEnumerable(Of AttributeValueRequirementType)
	Get
```

**C++**<br />
``` C++
public:
property IEnumerable<AttributeValueRequirementType^>^ InheritedConstraints {
	IEnumerable<AttributeValueRequirementType^>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_AttributeValueRequirementType">AttributeValueRequirementType</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="M_Aml_Engine_CAEX_AttributeFamilyType_GetReferenceHierarchy">AttributeFamilyType.GetReferenceHierarchy()</a><br />