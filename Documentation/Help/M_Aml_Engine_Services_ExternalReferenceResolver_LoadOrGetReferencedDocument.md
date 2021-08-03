# ExternalReferenceResolver.LoadOrGetReferencedDocument Method (CAEXDocument, String)
AutomationML 2.1 API 

Determines, if the provided path contains an alias and gets the resolved document for that alias.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXDocument LoadOrGetReferencedDocument(
	CAEXDocument document,
	string path
)
```

**VB**<br />
``` VB
Public Function LoadOrGetReferencedDocument ( 
	document As CAEXDocument,
	path As String
) As CAEXDocument
```

**C++**<br />
``` C++
public:
virtual CAEXDocument^ LoadOrGetReferencedDocument(
	CAEXDocument^ document, 
	String^ path
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document, which provides the ExternalReference to resolve the 'Alias'.</dd><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX path which contains an 'Alias'.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />The resolved document for the alias, extracted from the path.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument">IExternalReferenceResolver.LoadOrGetReferencedDocument(CAEXDocument, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ExternalReferenceResolver">ExternalReferenceResolver Class</a><br /><a href="Overload_Aml_Engine_Services_ExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />