# CAEXDocument.Commanding.CAEXElementChangingEvent Event
AutomationML 2.1 API 

This event is raised before a CAEXElement will be changed. <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">CAEXElementChangeMode</a>

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public event EventHandler<CAEXElementChangeEventArgs> CAEXElementChangingEvent
```

**VB**<br />
``` VB
Public Event CAEXElementChangingEvent As EventHandler(Of CAEXElementChangeEventArgs)
```

**C++**<br />
``` C++
public:
 event EventHandler<CAEXElementChangeEventArgs^>^ CAEXElementChangingEvent {
	void add (EventHandler<CAEXElementChangeEventArgs^>^ value);
	void remove (EventHandler<CAEXElementChangeEventArgs^>^ value);
}
```


#### Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_parent" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs">CAEXElementChangeEventArgs</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument_Commanding">CAEXDocument.Commanding Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />