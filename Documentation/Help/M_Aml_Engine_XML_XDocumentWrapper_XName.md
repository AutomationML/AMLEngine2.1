# XDocumentWrapper.XName Method 
AutomationML 2.1 API 

Gets the correct XName for the provided element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema, no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the element name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual XName XName(
	string tagname
)
```

**VB**<br />
``` VB
Public Overridable Function XName ( 
	tagname As String
) As XName
```

**C++**<br />
``` C++
public:
virtual XName^ XName(
	String^ tagname
)
```


#### Parameters
&nbsp;<dl><dt>tagname</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A Tag name which should be transformed to an XName.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">XName</a><br />The generated XName.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>tag name</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper Class</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />