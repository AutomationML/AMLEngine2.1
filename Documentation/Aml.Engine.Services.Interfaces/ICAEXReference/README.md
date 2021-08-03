ICAEXReference Interface
========================
AutomationML 2.1 APIThis interface is used to query references to CAEXObjects like references using the ID of objects or references using the CAEXPath of objects like RoleClass or InterfaceClass objects.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ICAEXReference
```

The **ICAEXReference** type exposes the following members.


Properties
----------

                   | Name                         | Description                                                                                                                                                                                                             
------------------ | ---------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CaexObject][2]              | Gets the CAEX object which owns the reference.                                                                                                                                                                          
![Public property] | [ReferenceAttributeName][3]  | Gets the name of the reference attribute which contains the value of the reference. To get or set the attribute value the [SetXAttributeValue(XName, Object)][4] an [GetXAttributeValue(XName)][5] methods can be used. 
![Public property] | [ReferenceAttributeValue][6] | Gets the reference attribute value.                                                                                                                                                                                     


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: CaexObject.md
[3]: ReferenceAttributeName.md
[4]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[5]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[6]: ReferenceAttributeValue.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"