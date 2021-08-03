# ExternalReferenceResolver.ResolvedDocuments Method 
AutomationML 2.1 API 

Gets all already resolved externals for the provided CAEXDocument containing ExternalReference objects

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<CAEXDocument> ResolvedDocuments(
	CAEXDocument documentWithExternals
)
```

**VB**<br />
``` VB
Public Function ResolvedDocuments ( 
	documentWithExternals As CAEXDocument
) As IEnumerable(Of CAEXDocument)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<CAEXDocument^>^ ResolvedDocuments(
	CAEXDocument^ documentWithExternals
) sealed
```


#### Parameters
&nbsp;<dl><dt>documentWithExternals</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document, containing ExternalReference objects.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>)<br />An enumeration of all CAEX documents, which have been loaded from the ExternalReferences.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_ResolvedDocuments">IExternalReferenceResolver.ResolvedDocuments(CAEXDocument)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ExternalReferenceResolver">ExternalReferenceResolver Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />