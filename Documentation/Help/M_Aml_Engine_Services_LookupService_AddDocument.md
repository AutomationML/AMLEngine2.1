# LookupService.AddDocument Method 
AutomationML 2.1 API 

Adds the document to the query service. All tables for the document will be created.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void AddDocument(
	CAEXDocument doc
)
```

**VB**<br />
``` VB
Public Sub AddDocument ( 
	doc As CAEXDocument
)
```

**C++**<br />
``` C++
public:
void AddDocument(
	CAEXDocument^ doc
)
```


#### Parameters
&nbsp;<dl><dt>doc</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>doc</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />