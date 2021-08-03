# LookupService.ReferenceUpdated Event
AutomationML 2.1 API 

Occurs when any reference has been updated.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public event EventHandler<UpdateEventArgs> ReferenceUpdated
```

**VB**<br />
``` VB
Public Event ReferenceUpdated As EventHandler(Of UpdateEventArgs)
```

**C++**<br />
``` C++
public:
virtual  event EventHandler<UpdateEventArgs^>^ ReferenceUpdated {
	void add (EventHandler<UpdateEventArgs^>^ value);
	void remove (EventHandler<UpdateEventArgs^>^ value);
}
```


#### Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_parent" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Aml_Engine_Services_Interfaces_UpdateEventArgs">UpdateEventArgs</a>)

#### Implements
<a href="E_Aml_Engine_Services_Interfaces_IAutoUpdate_ReferenceUpdated">IAutoUpdate.ReferenceUpdated</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />