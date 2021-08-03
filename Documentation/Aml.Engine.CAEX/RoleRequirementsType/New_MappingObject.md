RoleRequirementsType.New_MappingObject Method
=============================================
AutomationML 2.1 APIAdding a new MappingObject element to this RoleRequirements object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public MappingType New_MappingObject()
```

#### Return Value
Type: [MappingType][2]  
 The new MappingObject element if not existing, otherwise the existing. 

Exceptions
----------

Exception                       | Condition                                               
------------------------------- | ------------------------------------------------------- 
[NullReferenceException][3]     | A RoleRequirements object doesn't exist!                
[SchemaConformanceException][4] | If the Document Schema Version is prior to Version 3.0. 


Remarks
-------
 Applicable since CAEX Version 3.0 

See Also
--------

#### Reference
[RoleRequirementsType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../MappingType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.nullreferenceexception
[4]: ../SchemaConformanceException/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png