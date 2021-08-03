# ExternalDataReference.AddAutomationMLBPRInterfaceClassLib Method 
AutomationML 2.1 API 

Adds the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void AddAutomationMLBPRInterfaceClassLib(
	this CAEXFileType caexFile
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub AddAutomationMLBPRInterfaceClassLib ( 
	caexFile As CAEXFileType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static void AddAutomationMLBPRInterfaceClassLib(
	CAEXFileType^ caexFile
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file of the AMLDocument.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>Different CAEX Versions used; register the SchemaTransform service to import the AutomationMLBPRInterfaceClassLib in your current document.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />