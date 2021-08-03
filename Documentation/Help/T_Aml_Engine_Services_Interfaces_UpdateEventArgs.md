# UpdateEventArgs Class
AutomationML 2.1 API 

Event arguments used to inform about update events in the <a href="T_Aml_Engine_Services_Interfaces_IAutoUpdate">IAutoUpdate</a> service.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.eventargs" target="_parent" rel="noopener noreferrer">System.EventArgs</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.Services.Interfaces.UpdateEventArgs<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class UpdateEventArgs : EventArgs
```

**VB**<br />
``` VB
Public Class UpdateEventArgs
	Inherits EventArgs
```

**C++**<br />
``` C++
public ref class UpdateEventArgs : public EventArgs
```

The UpdateEventArgs type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_UpdateEventArgs__ctor">UpdateEventArgs(XElement, XAttribute)</a></td><td>
Initializes a new instance of the UpdateEventArgs class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_UpdateEventArgs__ctor_1">UpdateEventArgs(XElement, XAttribute, String)</a></td><td>
Initializes a new instance of the UpdateEventArgs class.</td></tr></table>&nbsp;
<a href="#updateeventargs-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_UpdateEventArgs_Reference">Reference</a></td><td>
Gets the updated reference.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_UpdateEventArgs_ReferencedElement">ReferencedElement</a></td><td>
Gets the referenced element which is triggered by the update</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_UpdateEventArgs_UpdateValue">UpdateValue</a></td><td>
Gets the updated new value (used in changing event notifications, if the reference has not updated).</td></tr></table>&nbsp;
<a href="#updateeventargs-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.eventargs" target="_parent" rel="noopener noreferrer">System.EventArgs</a><br />