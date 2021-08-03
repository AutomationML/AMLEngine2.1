# IExternalReferenceResolver.LoadOrGetReferencedDocument Method (ExternalReferenceType)
AutomationML 2.1 API 

Loads the external reference in a new CAEXDocument. The new CAEXDocument is a separate document and no libraries are merged to the current document. This Method doesn't change any references, which use the alias of this external reference. Use the <a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge</a> service to achieve this.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXDocument LoadOrGetReferencedDocument(
	ExternalReferenceType externalReference
)
```

**VB**<br />
``` VB
Function LoadOrGetReferencedDocument ( 
	externalReference As ExternalReferenceType
) As CAEXDocument
```

**C++**<br />
``` C++
CAEXDocument^ LoadOrGetReferencedDocument(
	ExternalReferenceType^ externalReference
)
```


#### Parameters
&nbsp;<dl><dt>externalReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalReferenceType">Aml.Engine.CAEX.ExternalReferenceType</a><br />the external reference</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />If the ExternalReference doesn't have an alias, the document is not loaded. If a referenced document for the alias already exists, the existing document is returned.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />