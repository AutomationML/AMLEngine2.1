# ISchemaTransform Interface
AutomationML 2.1 API 

This interface class defines a service interface for a schema transformation service

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface ISchemaTransform : IAMLService
```

**VB**<br />
``` VB
Public Interface ISchemaTransform
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class ISchemaTransform : IAMLService
```

The ISchemaTransform type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_ISchemaTransform_TransformTo">TransformTo</a></td><td>
Method to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations.</td></tr></table>&nbsp;
<a href="#ischematransform-interface">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_Interfaces_ISchemaTransform_TransformationEnded">TransformationEnded</a></td><td>
Raised from the ShemaTransform service when a transformation has ended.</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_Interfaces_ISchemaTransform_TransformationStarted">TransformationStarted</a></td><td>
Raised from the ShemaTransform service when a transformation has started.</td></tr></table>&nbsp;
<a href="#ischematransform-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAMLService">Aml.Engine.Services.Interfaces.IAMLService</a><br />