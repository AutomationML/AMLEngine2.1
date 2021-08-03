# IValidator Interface
AutomationML 2.1 API 

This service interface is defined for the validation of an AML document. Additionally the service can also be used to repair specific invalid properties in a document and to automatically updated references to objects if the source changes.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IValidator : IAMLService
```

**VB**<br />
``` VB
Public Interface IValidator
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class IValidator : IAMLService
```

The IValidator type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_IDValidation">IDValidation</a></td><td>
Validates the ID of a CAEX object. IDs of CAEX objects shall be unique.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IValidator_NameValidation">NameValidation</a></td><td>
Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result.</td></tr></table>&nbsp;
<a href="#ivalidator-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAMLService">Aml.Engine.Services.Interfaces.IAMLService</a><br />