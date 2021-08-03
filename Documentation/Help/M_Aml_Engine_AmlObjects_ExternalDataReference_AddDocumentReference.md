# ExternalDataReference.AddDocumentReference Method 
AutomationML 2.1 API 

Adds a document with the specified external reference interface to the document element. If the given internal element is not a document element or the defined class path to the external reference interface is not derived from the standard base class no interface is added.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InterfaceClassType AddDocumentReference(
	this InternalElementType documentElement,
	string referenceName,
	string externalDataReferenceInterfaceClassPath = "AutomationMLBPRInterfaceClassLib/ExternalDataReference"
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AddDocumentReference ( 
	documentElement As InternalElementType,
	referenceName As String,
	Optional externalDataReferenceInterfaceClassPath As String = "AutomationMLBPRInterfaceClassLib/ExternalDataReference"
) As InterfaceClassType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InterfaceClassType^ AddDocumentReference(
	InternalElementType^ documentElement, 
	String^ referenceName, 
	String^ externalDataReferenceInterfaceClassPath = L"AutomationMLBPRInterfaceClassLib/ExternalDataReference"
)
```


#### Parameters
&nbsp;<dl><dt>documentElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The document element.</dd><dt>referenceName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name for the referencing interface.</dd><dt>externalDataReferenceInterfaceClassPath (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The external data reference interface class path.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a><br />The InterfaceClass which is created as a reference to the external data.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.nullreferenceexception" target="_parent" rel="noopener noreferrer">NullReferenceException</a></td><td>Element is not contained in a CAEXDocument</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />