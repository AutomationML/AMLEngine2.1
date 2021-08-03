InterfaceFamilyType.CreateClassInstance Method
==============================================
Creates an ExternalInterface object as an instance of this InterfaceClass object. All Base-Class references are resolved to create the instance - copying the Attribute and ExternalInterface objects to the created ExternalInterface object. The IDs of the ExternalInterface objects are made unique.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType CreateClassInstance()
```

#### Return Value
Type: [ExternalInterfaceType][2]  
The ExternalInterface object
#### Implements
[IInstantiable&lt;TINSTANCE>.CreateClassInstance()][3]  


See Also
--------

#### Reference
[InterfaceFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ExternalInterfaceType/README.md
[3]: ../IInstantiable_1/CreateClassInstance.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png