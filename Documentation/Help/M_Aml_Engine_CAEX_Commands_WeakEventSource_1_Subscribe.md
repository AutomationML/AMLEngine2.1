# WeakEventSource(*TEventArgs*).Subscribe Method 
AutomationML 2.1 API 

Subscribes the specified handler with this event source.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void Subscribe(
	EventHandler<TEventArgs> handler
)
```

**VB**<br />
``` VB
Public Sub Subscribe ( 
	handler As EventHandler(Of TEventArgs)
)
```

**C++**<br />
``` C++
public:
void Subscribe(
	EventHandler<TEventArgs>^ handler
)
```


#### Parameters
&nbsp;<dl><dt>handler</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_parent" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Aml_Engine_CAEX_Commands_WeakEventSource_1">*TEventArgs*</a>)<br />The handler.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Commands_WeakEventSource_1">WeakEventSource(TEventArgs) Class</a><br /><a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />