# UniqueNameService Class
AutomationML 2.1 API 

This class defines methods for a unique name service. The names of CAEX-Objects in a Sequence of Elements should all be unique. If a unique name service is registered, the AMLEngine will automatically call this service for a unique name generation whenever a new element is added to a sequence which requires a unique name for its members. This services uses a generation pattern which consists of the specified default name followed by a generated ordinal number of the elements in a sequence.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.UniqueNameService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class UniqueNameService : IUniqueName, 
	IAMLService
```

**VB**<br />
``` VB
Public Class UniqueNameService
	Implements IUniqueName, IAMLService
```

**C++**<br />
``` C++
public ref class UniqueNameService : IUniqueName, 
	IAMLService
```

The UniqueNameService type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_IsUniqueCAEXName">IsUniqueCAEXName</a></td><td>
Determines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_Register">Register</a></td><td>
Registers a new instance of a UniqueNameService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_RegisterDefault">RegisterDefault</a></td><td>
Registers the default name for all CAEX objects with the provided element name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_Resume">Resume</a></td><td>
Resumes activities of the unique name service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_Suspend">Suspend</a></td><td>
Suspends activities of the unique name service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_UniqueCAEXName">UniqueCAEXName(XElement, String)</a></td><td>
Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_UniqueCAEXName_1">UniqueCAEXName(XElement, String, String)</a></td><td>
Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence using the specified defaultName</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_UniqueNameService_UnRegister">UnRegister</a></td><td>
Unregisters the current instance of the UniqueNameService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr></table>&nbsp;
<a href="#uniquenameservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IUniqueName">Aml.Engine.Services.Interfaces.IUniqueName</a><br />