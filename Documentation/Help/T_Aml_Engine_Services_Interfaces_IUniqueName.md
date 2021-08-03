# IUniqueName Interface
AutomationML 2.1 API 

This interface defines methods for a unique name service. The names of CAEX objects in a sequence of elements should all be unique. If a unique name service is registered, the AML Engine will automatically call this service for a unique name generation whenever a new element is added to the sequence which requires a unique name for its members.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IUniqueName : IAMLService
```

**VB**<br />
``` VB
Public Interface IUniqueName
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class IUniqueName : IAMLService
```

The IUniqueName type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUniqueName_IsUniqueCAEXName">IsUniqueCAEXName</a></td><td>
Determines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUniqueName_RegisterDefault">RegisterDefault</a></td><td>
Registers a new default name for the generation of unique names for the specified element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUniqueName_Resume">Resume</a></td><td>
Resumes activities of the unique name service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUniqueName_Suspend">Suspend</a></td><td>
Suspends activities of the unique name service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUniqueName_UniqueCAEXName">UniqueCAEXName(XElement, String)</a></td><td>
Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUniqueName_UniqueCAEXName_1">UniqueCAEXName(XElement, String, String)</a></td><td>
Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence using the specified defaultName</td></tr></table>&nbsp;
<a href="#iuniquename-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAMLService">Aml.Engine.Services.Interfaces.IAMLService</a><br />