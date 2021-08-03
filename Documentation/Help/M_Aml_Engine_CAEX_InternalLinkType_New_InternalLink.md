# InternalLinkType.New_InternalLink Method 
AutomationML 2.1 API 

Creates a new InternalLink object and append it to the lowest common parent of the SystemUnitClass objects, associated with the provided ExternalInterface objects. If no common parent exists, the InternalLink will be associated with the owner of the *aInterface*.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InternalLinkType New_InternalLink(
	ExternalInterfaceType aInterface,
	ExternalInterfaceType bInterface,
	string name
)
```

**VB**<br />
``` VB
Public Shared Function New_InternalLink ( 
	aInterface As ExternalInterfaceType,
	bInterface As ExternalInterfaceType,
	name As String
) As InternalLinkType
```

**C++**<br />
``` C++
public:
static InternalLinkType^ New_InternalLink(
	ExternalInterfaceType^ aInterface, 
	ExternalInterfaceType^ bInterface, 
	String^ name
)
```


#### Parameters
&nbsp;<dl><dt>aInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface object, representing the A-Side of the relation.</dd><dt>bInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface object, representing the B-Side of the relation.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name for the InternalLink</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType</a><br />The newly created InternalLink object.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>If AInterface or BInterface is null</td></tr><tr><td><a href="T_Aml_Engine_CAEX_CAEXException">CAEXException</a></td><td>One of the provided ExternalInterface objects is not associated to a SystemUnitClass.</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.invalidoperationexception" target="_parent" rel="noopener noreferrer">InvalidOperationException</a></td><td>It is not allowed to link an ExternalInterface to itself.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />