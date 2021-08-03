# AttributeType.MasterID Property 
AutomationML 2.1 API 

Gets the identifier of the master Attribute if this is a Mirror. The identifier contains the ID of the attribute owner followed by the Attribute path.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string MasterID { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property MasterID As String
	Get
```

**C++**<br />
``` C++
public:
virtual property String^ MasterID {
	String^ get () sealed;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IMirror_MasterID">IMirror.MasterID</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />