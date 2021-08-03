# AMLEngineAdapter.getReferencedGUID Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Parsing a string of form GUID:Interface and returning the GUID

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use CAEXPathBuilder.InternalElementIDInInternalLinkReference")]
public static string getReferencedGUID(
	this CAEXBasicObject caexObject,
	string reference
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use CAEXPathBuilder.InternalElementIDInInternalLinkReference")>
Public Shared Function getReferencedGUID ( 
	caexObject As CAEXBasicObject,
	reference As String
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use CAEXPathBuilder.InternalElementIDInInternalLinkReference")]
static String^ getReferencedGUID(
	CAEXBasicObject^ caexObject, 
	String^ reference
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>reference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A reference in form GUID:InterfaceClass</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The GUID

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />