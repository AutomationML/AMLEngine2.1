# SystemUnitClassTypeExtensions.New_InternalLink Method 
AutomationML 2.1 API 

Inserts a new InternalLink as the first InternalLink if nothing else if explicit defined.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InternalLinkType New_InternalLink(
	this SystemUnitClassType systemUnitClass,
	string name,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_InternalLink ( 
	systemUnitClass As SystemUnitClassType,
	name As String,
	Optional asFirst As Boolean = true
) As InternalLinkType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InternalLinkType^ New_InternalLink(
	SystemUnitClassType^ systemUnitClass, 
	String^ name, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The SystemUnitClass object</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the InternalLink</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if `true` insert at first InternalLink, otherwise at last InternalLink</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType</a><br />The new InternalLink element

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />