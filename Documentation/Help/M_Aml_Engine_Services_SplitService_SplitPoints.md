# SplitService.SplitPoints Method 
AutomationML 2.1 API 

Gets a collection of all split points for the provided document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ISplitPoint> SplitPoints(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Function SplitPoints ( 
	document As CAEXDocument
) As IEnumerable(Of ISplitPoint)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ISplitPoint^>^ SplitPoints(
	CAEXDocument^ document
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_Interfaces_ISplitPoint">ISplitPoint</a>)<br />all split points for this document.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_ISplit_SplitPoints">ISplit.SplitPoints(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_SplitService">SplitService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />