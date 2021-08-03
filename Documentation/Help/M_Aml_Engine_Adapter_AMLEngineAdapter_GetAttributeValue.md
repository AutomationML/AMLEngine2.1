# AMLEngineAdapter.GetAttributeValue Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Returns an attribute value of a given attribute name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use Indexer of Attribute Property with access to the Attribute Value Property: ...Attribute[attName]?.Value")]
public static string GetAttributeValue(
	this IObjectWithAttributes objWithAttr,
	string attName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use Indexer of Attribute Property with access to the Attribute Value Property: ...Attribute[attName]?.Value")>
Public Shared Function GetAttributeValue ( 
	objWithAttr As IObjectWithAttributes,
	attName As String
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use Indexer of Attribute Property with access to the Attribute Value Property: ...Attribute[attName]?.Value")]
static String^ GetAttributeValue(
	IObjectWithAttributes^ objWithAttr, 
	String^ attName
)
```


#### Parameters
&nbsp;<dl><dt>objWithAttr</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />Object with attributes</dd><dt>attName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />name of attribute</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />attribute value, "" if attribute does not exist

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />