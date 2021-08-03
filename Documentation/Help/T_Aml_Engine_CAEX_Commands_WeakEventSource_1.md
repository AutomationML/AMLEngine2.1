# WeakEventSource(*TEventArgs*) Class
AutomationML 2.1 API 

This Class defines a WeakEventSource, used to define Events, raised in the AML Engine.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Commands.WeakEventSource(TEventArgs)<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class WeakEventSource<TEventArgs>
where TEventArgs : EventArgs

```

**VB**<br />
``` VB
Public Class WeakEventSource(Of TEventArgs As EventArgs)
```

**C++**<br />
``` C++
generic<typename TEventArgs>
where TEventArgs : EventArgs
public ref class WeakEventSource
```


#### Type Parameters
&nbsp;<dl><dt>TEventArgs</dt><dd>The type of the event arguments.</dd></dl>&nbsp;
The WeakEventSource(TEventArgs) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_WeakEventSource_1__ctor">WeakEventSource(TEventArgs)</a></td><td>
Initializes a new instance of the WeakEventSource(TEventArgs) class.</td></tr></table>&nbsp;
<a href="#weakeventsource(*teventargs*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_WeakEventSource_1_Raise">Raise</a></td><td>
Raises an event, defined with this instance</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_WeakEventSource_1_Subscribe">Subscribe</a></td><td>
Subscribes the specified handler with this event source.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_WeakEventSource_1_Unsubscribe">Unsubscribe</a></td><td>
Unsubscribes the specified handler with this event source.</td></tr></table>&nbsp;
<a href="#weakeventsource(*teventargs*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />