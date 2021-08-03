# LookupService.AllExternalDataReferences Method 
AutomationML 2.1 API 

Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class <a href="F_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib_ExternalDataConnector">ExternalDataConnector</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> AllExternalDataReferences(
	CAEXDocument document,
	CAEXBasicObject caexObject = null
)
```

**VB**<br />
``` VB
Public Function AllExternalDataReferences ( 
	document As CAEXDocument,
	Optional caexObject As CAEXBasicObject = Nothing
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ExternalInterfaceType^>^ AllExternalDataReferences(
	CAEXDocument^ document, 
	CAEXBasicObject^ caexObject = nullptr
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>caexObject (Optional)</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />Optional parameter, defining a possible start object for the query.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />A collection of all ExternalInterface which are instances of the standard Interface class <a href="F_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib_ExternalDataConnector">ExternalDataConnector</a>.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllExternalDataReferences">IQuery.AllExternalDataReferences(CAEXDocument, CAEXBasicObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />