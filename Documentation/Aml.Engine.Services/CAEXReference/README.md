CAEXReference Class
===================
AutomationML 2.1 APIThis class is used in queries to provide information about objects, which contain references to other objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.CAEXReference**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXReference : ICAEXReference
```

The **CAEXReference** type exposes the following members.


Constructors
------------

                 | Name               | Description                                                
---------------- | ------------------ | ---------------------------------------------------------- 
![Public method] | [CAEXReference][3] | Initializes a new instance of the **CAEXReference** class. 


Properties
----------

                   | Name                         | Description                                                                                                                                                                                                                                               
------------------ | ---------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CaexObject][4]              | Gets the CAEX object which contains the reference.                                                                                                                                                                                                        
![Public property] | [Element][5]                 | Gets the XML element, which contains the reference.                                                                                                                                                                                                       
![Public property] | [ReferenceAttributeName][6]  | Gets the name of the reference attribute which contains the value of the reference. To get or set the attribute value for the attribute with this name the [SetXAttributeValue(XName, Object)][7] and [GetXAttributeValue(XName)][8] methods can be used. 
![Public property] | [ReferenceAttributeValue][9] | Gets the reference attribute value.                                                                                                                                                                                                                       


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.ICAEXReference][10]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: CaexObject.md
[5]: Element.md
[6]: ReferenceAttributeName.md
[7]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[8]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[9]: ReferenceAttributeValue.md
[10]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"