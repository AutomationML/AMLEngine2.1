# CAEXWrapper.GetXAttributeValue Method 
AutomationML 2.1 API 

Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string GetXAttributeValue(
	XName attributeName
)
```

**VB**<br />
``` VB
Public Function GetXAttributeValue ( 
	attributeName As XName
) As String
```

**C++**<br />
``` C++
public:
String^ GetXAttributeValue(
	XName^ attributeName
)
```


#### Parameters
&nbsp;<dl><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />The name of the attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The attribute value if the attribute is defined, otherwise `null`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />