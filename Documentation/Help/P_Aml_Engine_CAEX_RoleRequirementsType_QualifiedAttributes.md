# RoleRequirementsType.QualifiedAttributes Property 
AutomationML 2.1 API 

Gets the collection of CAEX attributes from the <a href="P_Aml_Engine_CAEX_RoleRequirementsType_Attribute">Attribute</a> which are qualified with the name of a SupportedRoleClass. This method is valid for documents based on CAEX 2.15 only. The qualification of attributes is a feature to assign multiple roles to an InternalElement.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<AttributeType> QualifiedAttributes { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property QualifiedAttributes As IEnumerable(Of AttributeType)
	Get
```

**C++**<br />
``` C++
public:
property IEnumerable<AttributeType^>^ QualifiedAttributes {
	IEnumerable<AttributeType^>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />