CAEXSequenceExtension Class
===========================
AutomationML 2.1 APIExtensions defined for ExternalInterface Sequence and RoleRequirements sequence


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Linq.CAEXSequenceExtension**  

  **Namespace:**  [Aml.Engine.CAEX.Linq][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class CAEXSequenceExtension
```

The **CAEXSequenceExtension** type exposes the following members.


Methods
-------

                                 | Name                                                                      | Description                                                                                               
-------------------------------- | ------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [OfInterfaceClass][3]                                                     | Gets all ExternalInterfaces from the specified sequence, which are instances of a specific InterfaceClass 
![Public method]![Static member] | [OfRoleClass(CAEXSequence&lt;RoleRequirementsType>, RoleFamilyType)][4]   | Gets all RoleRequirements from the specified sequence, which are instances of a specific RoleClass        
![Public method]![Static member] | [OfRoleClass(CAEXSequence&lt;SupportedRoleClassType>, RoleFamilyType)][5] | Gets all SupportedRoleClasses from the specified sequence, which are instances of a specific RoleClass    


See Also
--------

#### Reference
[Aml.Engine.CAEX.Linq Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: OfInterfaceClass.md
[4]: OfRoleClass.md
[5]: OfRoleClass_1.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"