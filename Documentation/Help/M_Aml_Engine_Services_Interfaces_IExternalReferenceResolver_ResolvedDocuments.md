# IExternalReferenceResolver.ResolvedDocuments Method 
AutomationML 2.1 API 

Gets all already resolved externals for the provided CAEXDocument containing ExternalReference objects

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<CAEXDocument> ResolvedDocuments(
	CAEXDocument documentWithExternals
)
```

**VB**<br />
``` VB
Function ResolvedDocuments ( 
	documentWithExternals As CAEXDocument
) As IEnumerable(Of CAEXDocument)
```

**C++**<br />
``` C++
IEnumerable<CAEXDocument^>^ ResolvedDocuments(
	CAEXDocument^ documentWithExternals
)
```


#### Parameters
&nbsp;<dl><dt>documentWithExternals</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document containing ExternalRefrence objects.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>)<br />An enumeration of all resolved documents.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />