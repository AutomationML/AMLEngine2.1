# AMLEngineAdapter.getReferencedInterfaceName Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Getting the name of the referenced Interface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use CAEXPathBuilder.ExternalInterfaceNameInInternalLinkReference")]
public static string getReferencedInterfaceName(
	this CAEXBasicObject caexObject,
	string reference
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use CAEXPathBuilder.ExternalInterfaceNameInInternalLinkReference")>
Public Shared Function getReferencedInterfaceName ( 
	caexObject As CAEXBasicObject,
	reference As String
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use CAEXPathBuilder.ExternalInterfaceNameInInternalLinkReference")]
static String^ getReferencedInterfaceName(
	CAEXBasicObject^ caexObject, 
	String^ reference
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>reference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A reference to a interface class in form GUID:InterfaceClass</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The name of the referenced interface class or string.empty if separator char not found in string

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />