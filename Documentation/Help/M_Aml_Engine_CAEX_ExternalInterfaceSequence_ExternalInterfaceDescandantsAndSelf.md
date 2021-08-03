# ExternalInterfaceSequence.ExternalInterfaceDescandantsAndSelf Method 
AutomationML 2.1 API 

Gets all external interfaces and the external interface descendants (The external interface tree).

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> ExternalInterfaceDescandantsAndSelf()
```

**VB**<br />
``` VB
Public Function ExternalInterfaceDescandantsAndSelf As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
IEnumerable<ExternalInterfaceType^>^ ExternalInterfaceDescandantsAndSelf()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />an enumeration of all ExternalInterface object of this instance and their nested ExternalInterface objects.

## Remarks
available since CAEX Version 3.0.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ExternalInterfaceSequence">ExternalInterfaceSequence Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />