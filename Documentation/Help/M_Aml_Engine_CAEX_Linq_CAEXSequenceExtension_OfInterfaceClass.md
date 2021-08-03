# CAEXSequenceExtension.OfInterfaceClass Method 
AutomationML 2.1 API 

Gets all ExternalInterfaces from the specified sequence, which are instances of a specific InterfaceClass

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Linq">Aml.Engine.CAEX.Linq</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<ExternalInterfaceType> OfInterfaceClass(
	this ExternalInterfaceSequence sequence,
	InterfaceFamilyType interfaceClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function OfInterfaceClass ( 
	sequence As ExternalInterfaceSequence,
	interfaceClass As InterfaceFamilyType
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<ExternalInterfaceType^>^ OfInterfaceClass(
	ExternalInterfaceSequence^ sequence, 
	InterfaceFamilyType^ interfaceClass
)
```


#### Parameters
&nbsp;<dl><dt>sequence</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceSequence">Aml.Engine.CAEX.ExternalInterfaceSequence</a><br />The Sequence of External Interfaces</dd><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">Aml.Engine.CAEX.InterfaceFamilyType</a><br />The required Interface Class</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />External Interfaces which are instances of the defined class.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ExternalInterfaceSequence">ExternalInterfaceSequence</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Linq_CAEXSequenceExtension">CAEXSequenceExtension Class</a><br /><a href="N_Aml_Engine_CAEX_Linq">Aml.Engine.CAEX.Linq Namespace</a><br />