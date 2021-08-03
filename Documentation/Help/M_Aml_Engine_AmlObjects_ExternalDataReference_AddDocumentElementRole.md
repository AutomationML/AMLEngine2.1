# ExternalDataReference.AddDocumentElementRole Method 
AutomationML 2.1 API 

Add a role reference to a external data role class or derived role class defined with the given role class path as a supported role class to the internal element. If the specified role class path can not be identified as a derived role from the <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> no role reference is added (returns false).

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool AddDocumentElementRole(
	this InternalElementType internalElement,
	string externalDataRoleClassPath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AddDocumentElementRole ( 
	internalElement As InternalElementType,
	externalDataRoleClassPath As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool AddDocumentElementRole(
	InternalElementType^ internalElement, 
	String^ externalDataRoleClassPath
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The internalElement.</dd><dt>externalDataRoleClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />path to the role class</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true, if a supported role class with the defined path is added `false` if the role class is invalid

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.nullreferenceexception" target="_parent" rel="noopener noreferrer">NullReferenceException</a></td><td>InternalElement not contained in CAEXDocument</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />