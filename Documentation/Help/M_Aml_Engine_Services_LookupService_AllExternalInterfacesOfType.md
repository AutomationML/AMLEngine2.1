# LookupService.AllExternalInterfacesOfType Method 
AutomationML 2.1 API 

Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the Interface class defined by the provided *interfaceClassPath*.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> AllExternalInterfacesOfType(
	CAEXDocument document,
	string interfaceClassPath,
	CAEXBasicObject caexObject = null
)
```

**VB**<br />
``` VB
Public Function AllExternalInterfacesOfType ( 
	document As CAEXDocument,
	interfaceClassPath As String,
	Optional caexObject As CAEXBasicObject = Nothing
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ExternalInterfaceType^>^ AllExternalInterfacesOfType(
	CAEXDocument^ document, 
	String^ interfaceClassPath, 
	CAEXBasicObject^ caexObject = nullptr
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>interfaceClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX ClassPath of the InterfaceClassType</dd><dt>caexObject (Optional)</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />Optional parameter, defining a possible start object for the query.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />A collection of all ExternalInterface which are instances of the Interface class defined by the provided *interfaceClassPath*.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllExternalInterfacesOfType">IQuery.AllExternalInterfacesOfType(CAEXDocument, String, CAEXBasicObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />