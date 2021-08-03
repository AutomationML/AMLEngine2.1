InterfaceFamilyTypeExtensions Class
===================================
AutomationML 2.1 APIExtension methods for an InterfaceClass element and its defining class [InterfaceFamilyType][1].


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.CAEX.Extensions.InterfaceFamilyTypeExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class InterfaceFamilyTypeExtensions
```

The **InterfaceFamilyTypeExtensions** type exposes the following members.


Methods
-------

                                 | Name                            | Description                                                                                                                                                                     
-------------------------------- | ------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [CreateInterfaceFamilyClass][4] | Create an InterfaceClass from this interface (e.g. ExternalInterface). An InterfaceClass is of type InterfaceFamilyType and may contain InterfaceFamilyTypes as child elements. 
![Public method]![Static member] | [Insert_InterfaceClass][5]      | **Obsolete.**Inserting the new InterfaceClass element to the provided InterfaceClass object.                                                                                    
![Public method]![Static member] | [InterfaceClassDescendants][6]  | **Obsolete.**Gets all descendant [InterfaceFamilyType][1] Objects of the InterfaceClass. InterfaceClasses on all levels are returned.                                           
![Public method]![Static member] | [New_InterfaceClass][7]         | A new InterfaceClass is added to the specified InterfaceClass object.                                                                                                           


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/InterfaceFamilyType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: CreateInterfaceFamilyClass.md
[5]: Insert_InterfaceClass.md
[6]: InterfaceClassDescendants.md
[7]: New_InterfaceClass.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"