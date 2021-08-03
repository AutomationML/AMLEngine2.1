# CAEXDocument.XName Method 
AutomationML 2.1 API 

Gets the correct XName for the provided CAEX element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema (as in CAEX 2.15), no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the CAEX element name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override XName XName(
	string tagname
)
```

**VB**<br />
``` VB
Public Overrides Function XName ( 
	tagname As String
) As XName
```

**C++**<br />
``` C++
public:
virtual XName^ XName(
	String^ tagname
) override
```


#### Parameters
&nbsp;<dl><dt>tagname</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A CAEX Tag name which should be transformed to a XName.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">XName</a><br />The generated XName.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>tag name</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />