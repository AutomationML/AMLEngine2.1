# RoleRequirementsType.QualifiedRoleClassAttributes Property 
AutomationML 2.1 API 

Retrieves the <a href="P_Aml_Engine_CAEX_RoleRequirementsType_QualifiedAttributes">QualifiedAttributes</a> and gets the according original RoleClass Attribute of each qualified Attribute. This method is valid for documents based on CAEX 2.15 only. The qualification of attributes is a feature to assign multiple roles to an InternalElement.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<(RoleClassType RoleClass, AttributeType Attribute)> QualifiedRoleClassAttributes { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property QualifiedRoleClassAttributes As IEnumerable(Of (RoleClass As RoleClassType, Attribute As AttributeType))
	Get
```

**C++**<br />
``` C++
public:
property IEnumerable<ValueTuple<RoleClassType^, AttributeType^>>^ QualifiedRoleClassAttributes {
	IEnumerable<ValueTuple<RoleClassType^, AttributeType^>>^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_RoleClassType">RoleClassType</a>, <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>))

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />