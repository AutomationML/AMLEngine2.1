# ExternalReferenceResolver.LoadOrGetReferencedDocument Method (ExternalReferenceType)
AutomationML 2.1 API 

This method is used to load an outsourced CAEX document. The external representation for that document is defined in the provided ExternalReference object. The CAEXDocument is loaded as a new 'stand alone' document, which means that no libraries of the loaded document are merged to the original referencing document. The ExternalReference is not changed and all external references in the original document which use the alias name in a path- or id-reference will not change too. A merge of documents can only be requested by a <a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge</a> service.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXDocument LoadOrGetReferencedDocument(
	ExternalReferenceType externalReference
)
```

**VB**<br />
``` VB
Public Function LoadOrGetReferencedDocument ( 
	externalReference As ExternalReferenceType
) As CAEXDocument
```

**C++**<br />
``` C++
public:
virtual CAEXDocument^ LoadOrGetReferencedDocument(
	ExternalReferenceType^ externalReference
) sealed
```


#### Parameters
&nbsp;<dl><dt>externalReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalReferenceType">Aml.Engine.CAEX.ExternalReferenceType</a><br />the ExternalReference object</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />If the ExternalReference doesn't have an alias, the document is not loaded. If a referenced document for the alias already exists, the existing document is returned.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument_1">IExternalReferenceResolver.LoadOrGetReferencedDocument(ExternalReferenceType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ExternalReferenceResolver">ExternalReferenceResolver Class</a><br /><a href="Overload_Aml_Engine_Services_ExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />