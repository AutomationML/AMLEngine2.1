# ExternalDataReference.ExternalDataReferenceInterfaceClass Method (InterfaceClassLibType)
AutomationML 2.1 API 

Gets the ExternalDataReference InterfaceClass from the AutomationMLBPRInterfaceClassLib.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InterfaceFamilyType ExternalDataReferenceInterfaceClass(
	this InterfaceClassLibType automationMLBPRInterfaceClassLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ExternalDataReferenceInterfaceClass ( 
	automationMLBPRInterfaceClassLib As InterfaceClassLibType
) As InterfaceFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InterfaceFamilyType^ ExternalDataReferenceInterfaceClass(
	InterfaceClassLibType^ automationMLBPRInterfaceClassLib
)
```


#### Parameters
&nbsp;<dl><dt>automationMLBPRInterfaceClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceClassLibType">Aml.Engine.CAEX.InterfaceClassLibType</a><br />The AutomationMLBPRInterfaceClassLib.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType</a><br />The 'ExternalDataReference' InterfaceClass.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceClassLibType">InterfaceClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>automationMLBPRInterfaceClassLib</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.nullreferenceexception" target="_parent" rel="noopener noreferrer">NullReferenceException</a></td><td>Couldn't locate the ExternalDataReference InterfaceClass or Couldn't locate the CAEX file of the InterfaceClass.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataReferenceInterfaceClass">ExternalDataReferenceInterfaceClass Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />