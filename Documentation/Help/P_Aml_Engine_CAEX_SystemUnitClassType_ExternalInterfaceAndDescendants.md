# SystemUnitClassType.ExternalInterfaceAndDescendants Property 
AutomationML 2.1 API 

Gets the collection of ExternalInterface objects including all nested descendant interfaces

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<ExternalInterfaceType> ExternalInterfaceAndDescendants { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ExternalInterfaceAndDescendants As IEnumerable(Of ExternalInterfaceType)
	Get
```

**C++**<br />
``` C++
public:
virtual property IEnumerable<ExternalInterfaceType^>^ ExternalInterfaceAndDescendants {
	IEnumerable<ExternalInterfaceType^>^ get () sealed;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)

#### Implements
<a href="P_Aml_Engine_CAEX_IObjectWithExternalInterface_ExternalInterfaceAndDescendants">IObjectWithExternalInterface.ExternalInterfaceAndDescendants</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />