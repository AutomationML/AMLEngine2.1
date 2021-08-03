# CAEXFileStatisticService Class
AutomationML 2.1 API 

This service calculates statistics for a CAEX document.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.CAEXFileStatisticService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXFileStatisticService : IStatistic, 
	IAMLService
```

**VB**<br />
``` VB
Public Class CAEXFileStatisticService
	Implements IStatistic, IAMLService
```

**C++**<br />
``` C++
public ref class CAEXFileStatisticService : IStatistic, 
	IAMLService
```

The CAEXFileStatisticService type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService__ctor">CAEXFileStatisticService</a></td><td>
Initializes a new instance of the CAEXFileStatisticService class</td></tr></table>&nbsp;
<a href="#caexfilestatisticservice-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfAllObjects">NumberOfAllObjects</a></td><td>
Counts all objects (sum of all others with specific counts) and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfAttributes">NumberOfAttributes</a></td><td>
Counts all Attribute objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfAttributeTypeReferences">NumberOfAttributeTypeReferences</a></td><td>
Counts all Attribute type reference objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfAttributeTypes">NumberOfAttributeTypes</a></td><td>
Counts all AttributeType objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfInterfaceClasses">NumberOfInterfaceClasses</a></td><td>
Counts all InterfaceClass objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfInterfaceInstances">NumberOfInterfaceInstances</a></td><td>
Counts all ExternalInterface objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfInternalElements">NumberOfInternalElements</a></td><td>
Counts all InternalElement objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfLinks">NumberOfLinks</a></td><td>
Counts all InternalLink objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfRoleClasses">NumberOfRoleClasses</a></td><td>
Counts all RoleClass objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfRoleClassReferences">NumberOfRoleClassReferences</a></td><td>
Counts all RoleClass reference (RoleRequirements and SupportedRoleClass) objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfSystemUnitClasses">NumberOfSystemUnitClasses</a></td><td>
Counts all SystemUnitClass objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_NumberOfSystemUnitClassReferences">NumberOfSystemUnitClassReferences</a></td><td>
Counts all SystemUnitClass reference objects and returns the result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_Register">Register</a></td><td>
Registers a new instance of a CAEXFileStatisticService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_CAEXFileStatisticService_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#caexfilestatisticservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IStatistic">Aml.Engine.Services.Interfaces.IStatistic</a><br />