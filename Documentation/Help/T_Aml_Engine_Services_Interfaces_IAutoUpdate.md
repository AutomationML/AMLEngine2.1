# IAutoUpdate Interface
AutomationML 2.1 API 

Interface defined for services, which support automatic updates of cross references between AutomationML objects. Updates are executed, when a referenced object changes its identification (its Name or its ID).

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IAutoUpdate : IAMLService
```

**VB**<br />
``` VB
Public Interface IAutoUpdate
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class IAutoUpdate : IAMLService
```

The IAutoUpdate type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_IAutoUpdate_IsAutoUpdateEnabled">IsAutoUpdateEnabled</a></td><td>
Gets or sets a value indicating whether this instance will automatically update cross references between AutomationML objects.</td></tr></table>&nbsp;
<a href="#iautoupdate-interface">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_Interfaces_IAutoUpdate_ReferenceUpdated">ReferenceUpdated</a></td><td>
Occurs when any reference has been updated.</td></tr></table>&nbsp;
<a href="#iautoupdate-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />