# AttributeFamilyType.InheritedAttributes Property 
AutomationML 2.1 API 

Gets all attributes, including the inherited attributes of the base classes in the inheritance tree.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<AttributeType> InheritedAttributes { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property InheritedAttributes As IEnumerable(Of AttributeType)
	Get
```

**C++**<br />
``` C++
public:
property IEnumerable<AttributeType^>^ InheritedAttributes {
	IEnumerable<AttributeType^>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="M_Aml_Engine_CAEX_AttributeFamilyType_GetReferenceHierarchy">AttributeFamilyType.GetReferenceHierarchy()</a><br />