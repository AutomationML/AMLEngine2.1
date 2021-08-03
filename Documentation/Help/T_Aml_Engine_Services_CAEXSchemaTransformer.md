# CAEXSchemaTransformer Class
AutomationML 2.1 API 

This class defines a service for a schema transformation. The service supports transformation of CAEX documents from CAEX Version 2.15 to version 3.0 and back. Backwards transformation can result in a loss of information.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.CAEXSchemaTransformer<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXSchemaTransformer : ISchemaTransform, 
	IAMLService
```

**VB**<br />
``` VB
Public Class CAEXSchemaTransformer
	Implements ISchemaTransform, IAMLService
```

**C++**<br />
``` C++
public ref class CAEXSchemaTransformer : ISchemaTransform, 
	IAMLService
```

The CAEXSchemaTransformer type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_CAEXSchemaTransformer_Register">Register</a></td><td>
Registration of a new <a href="T_Aml_Engine_Services_Interfaces_ISchemaTransform">ISchemaTransform</a></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXSchemaTransformer_TransformTo">TransformTo</a></td><td>
Method to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_CAEXSchemaTransformer_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#caexschematransformer-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_CAEXSchemaTransformer_TransformationEnded">TransformationEnded</a></td><td>
Raised from the ShemaTransform service when a transformation has ended.</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_CAEXSchemaTransformer_TransformationStarted">TransformationStarted</a></td><td>
Raised from the ShemaTransform service when a transformation has started.</td></tr></table>&nbsp;
<a href="#caexschematransformer-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_ISchemaTransform">Aml.Engine.Services.Interfaces.ISchemaTransform</a><br />