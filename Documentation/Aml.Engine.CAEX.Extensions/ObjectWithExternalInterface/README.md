ObjectWithExternalInterface Class
=================================
AutomationML 2.1 APIExtension methods for all objects with ExternalInterface collections.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.ObjectWithExternalInterface**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ObjectWithExternalInterface
```

The **ObjectWithExternalInterface** type exposes the following members.


Methods
-------

                                                | Name                                                                                                         | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                             
----------------------------------------------- | ------------------------------------------------------------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member]![Code example] | [AddInterfaceClassReference(IObjectWithExternalInterface, InterfaceFamilyType, Boolean, Boolean, String)][3] | Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][4] object.                                                                                                                                                                                                                                                                            
![Public method]![Static member]![Code example] | [AddInterfaceClassReference(IObjectWithExternalInterface, String, Boolean, Boolean, String)][5]              | Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][4] object.                                                                                                                                                                                                                                                  
![Public method]![Static member]![Code example] | [HasInterfaceClassReference(IObjectWithExternalInterface, InterfaceFamilyType, Boolean)][6]                  | Determines whether an object with ExternalInterfaces has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.                                             
![Public method]![Static member]![Code example] | [HasInterfaceClassReference(IObjectWithExternalInterface, String, Boolean)][7]                               | Determines whether this Object with ExternalInterfaces has an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.          
![Public method]![Static member]                | [InterfaceClassReferences][8]                                                                                | All external Interfaces of this Object with ExternalInterfaces with an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AddInterfaceClassReference.md
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: AddInterfaceClassReference_1.md
[6]: HasInterfaceClassReference.md
[7]: HasInterfaceClassReference_1.md
[8]: InterfaceClassReferences.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Code example]: ../../icons/CodeExample.png "Code example"