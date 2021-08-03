# IAutoUpdate.ReferenceUpdated Event
AutomationML 2.1 API 

Occurs when any reference has been updated.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
event EventHandler<UpdateEventArgs> ReferenceUpdated
```

**VB**<br />
``` VB
Event ReferenceUpdated As EventHandler(Of UpdateEventArgs)
```

**C++**<br />
``` C++
 event EventHandler<UpdateEventArgs^>^ ReferenceUpdated {
	void add (EventHandler<UpdateEventArgs^>^ value);
	void remove (EventHandler<UpdateEventArgs^>^ value);
}
```


#### Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_parent" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Aml_Engine_Services_Interfaces_UpdateEventArgs">UpdateEventArgs</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IAutoUpdate">IAutoUpdate Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />