# ExternalDataReference.AddDocumentElement Method 
AutomationML 2.1 API 

Adds a document element to the defined internalElement. A Document Element is semantically described with an attached role defined with the base role class <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> or a derived role class. If no role class path is given as a parameter the default is used. If the specified role class path can not be identified as a derived role from the <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> no document element is added (returns null).

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InternalElementType AddDocumentElement(
	this SystemUnitClassType internalElement,
	string name,
	string externalDataRoleClassPath = "AutomationMLBPRRoleClassLib/ExternalData"
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AddDocumentElement ( 
	internalElement As SystemUnitClassType,
	name As String,
	Optional externalDataRoleClassPath As String = "AutomationMLBPRRoleClassLib/ExternalData"
) As InternalElementType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InternalElementType^ AddDocumentElement(
	SystemUnitClassType^ internalElement, 
	String^ name, 
	String^ externalDataRoleClassPath = L"AutomationMLBPRRoleClassLib/ExternalData"
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The internalElement.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the document element.</dd><dt>externalDataRoleClassPath (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The Role class path to a role class, derived from the ExternalData Role Class <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a></dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />created InternalElementType document element or `null` if the role class is invalid

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />