# RoleFamilyType.RefBaseClassPath Property 
AutomationML 2.1 API 

Gets and sets the path which references a base class. According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string RefBaseClassPath { get; set; }
```

**VB**<br />
``` VB
Public Property RefBaseClassPath As String
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property String^ RefBaseClassPath {
	String^ get () sealed;
	void set (String^ value) sealed;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IClassWithBaseClassReference_RefBaseClassPath">IClassWithBaseClassReference.RefBaseClassPath</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />