# QueryService.AllElementsIdentifiedByCAEXPath Method 
AutomationML 2.1 API 

Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ILookup<string, ICAEXReference> AllElementsIdentifiedByCAEXPath(
	CAEXBasicObject caexObject
)
```

**VB**<br />
``` VB
Public Function AllElementsIdentifiedByCAEXPath ( 
	caexObject As CAEXBasicObject
) As ILookup(Of String, ICAEXReference)
```

**C++**<br />
``` C++
public:
virtual ILookup<String^, ICAEXReference^>^ AllElementsIdentifiedByCAEXPath(
	CAEXBasicObject^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />Groups of elements which are identifiable by a CAEX path.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllElementsIdentifiedByCAEXPath">IQuery.AllElementsIdentifiedByCAEXPath(CAEXBasicObject)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />