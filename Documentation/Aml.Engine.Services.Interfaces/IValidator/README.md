IValidator Interface
====================
AutomationML 2.1 APIThis service interface is defined for the validation of an AML document. Additionally the service can also be used to repair specific invalid properties in a document and to automatically updated references to objects if the source changes.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IValidator : IAMLService
```

The **IValidator** type exposes the following members.


Methods
-------

                 | Name                | Description                                                                                                                                                                                                                                                                                                                                                                                                                          
---------------- | ------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [IDValidation][2]   | Validates the ID of a CAEX object. IDs of CAEX objects shall be unique.                                                                                                                                                                                                                                                                                                                                                              
![Public method] | [NameValidation][3] | Validates a name of a CAEX object. Names of CAEX classes or types (RoleClasses, InterfaceClasses, SystemUnitClasses and AttributeTypes), Attributes, Libraries and CAEX InstanceHierarchies shall be unique across its siblings or across all child elements of the same CAEX parent element over its life time. This shall assure that referencing a library, a class, a type or an attribute by its path delivers a unique result. 


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][4]  

[1]: ../README.md
[2]: IDValidation.md
[3]: NameValidation.md
[4]: ../IAMLService/README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"