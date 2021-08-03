SystemUnitFamilyType.CreateClassInstance Method
===============================================
Creates an InternalElement as an instance of this class. All References to Base classes are resolved.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public InternalElementType CreateClassInstance()
```

#### Return Value
Type: [InternalElementType][2]  
The InternalElement
#### Implements
[IInstantiable&lt;TINSTANCE>.CreateClassInstance()][3]  


Remarks
-------
 If the document is based on CAEX 2.15 and the SystemUnitClass provides only one Supported role class, the created Internal Element will contain a role requirement object, representing the role. 

See Also
--------

#### Reference
[SystemUnitFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../InternalElementType/README.md
[3]: ../IInstantiable_1/CreateClassInstance.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png