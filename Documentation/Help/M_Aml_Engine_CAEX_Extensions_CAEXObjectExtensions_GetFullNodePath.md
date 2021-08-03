# CAEXObjectExtensions.GetFullNodePath Method 
AutomationML 2.1 API 

Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string GetFullNodePath(
	this ICAEXObject caexObject
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetFullNodePath ( 
	caexObject As ICAEXObject
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static String^ GetFullNodePath(
	ICAEXObject^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXObject">Aml.Engine.CAEX.ICAEXObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The path to the XML node.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ICAEXObject">ICAEXObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
Please note that this method returns a different result than the <a href="M_Aml_Engine_CAEX_CAEXObject_CAEXPath">CAEXPath()</a> method, which returns the CAEX path used for referencing objects.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions">CAEXObjectExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />