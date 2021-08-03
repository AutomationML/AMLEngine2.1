# XmlOperation.CreateCAEXWrapper Method 
AutomationML 2.1 API 

Wraps the provided Xml-Element into an element specific CAEXWrapper object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Xml_Extensions">Aml.Engine.Xml.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXWrapper CreateCAEXWrapper(
	this XElement element
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function CreateCAEXWrapper ( 
	element As XElement
) As CAEXWrapper
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static CAEXWrapper^ CreateCAEXWrapper(
	XElement^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />the Xml-Element</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a><br />The specific CAEXWrapper object if the element is a CAEX element; otherwise null

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Xml_Extensions_XmlOperation">XmlOperation Class</a><br /><a href="N_Aml_Engine_Xml_Extensions">Aml.Engine.Xml.Extensions Namespace</a><br />