# ISplit.SplitPoints Method 
AutomationML 2.1 API 

Gets a collection of all split points for the provided document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<ISplitPoint> SplitPoints(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Function SplitPoints ( 
	document As CAEXDocument
) As IEnumerable(Of ISplitPoint)
```

**C++**<br />
``` C++
IEnumerable<ISplitPoint^>^ SplitPoints(
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_Interfaces_ISplitPoint">ISplitPoint</a>)<br />all split points for this document.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_ISplit">ISplit Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />