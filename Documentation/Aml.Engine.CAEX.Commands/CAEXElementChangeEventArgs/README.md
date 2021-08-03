CAEXElementChangeEventArgs Class
================================
Event arguments for a [CAEXElementChangingEvent][1] and a [CAEXElementChangedEvent][2]


Inheritance Hierarchy
---------------------
[System.Object][3]  
  [System.EventArgs][4]  
    **Aml.Engine.CAEX.Commands.CAEXElementChangeEventArgs**  

  **Namespace:**  [Aml.Engine.CAEX.Commands][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXElementChangeEventArgs : EventArgs
```

The **CAEXElementChangeEventArgs** type exposes the following members.


Constructors
------------

                 | Name                                                                                                                         | Description                                                    
---------------- | ---------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------- 
![Public method] | [CAEXElementChangeEventArgs(XElement, XElement, CAEXDocument, CAEXElementChangeMode)][6]                                     | Constructs arguments for an element changing event             
![Public method] | [CAEXElementChangeEventArgs(XElement, XElement, CAEXDocument, XAttribute, String, Object, Object, CAEXElementChangeMode)][7] | Constructs arguments for an element's attribute changing event 


Properties
----------

                   | Name                   | Description                                                                                                                                                                     
------------------ | ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXAttribute][8]     | The changed CAEXAttribute                                                                                                                                                       
![Public property] | [CAEXAttributeName][9] | Gets the name of the CAEX attribute.                                                                                                                                            
![Public property] | [CAEXDocument][10]     | Gets the CAEX document.                                                                                                                                                         
![Public property] | [CAEXElement][11]      | The changed CAEXElement                                                                                                                                                         
![Public property] | [CAEXParent][12]       | The changed CAEXElement's parent. This Property should be used, to detect a former parent of a CAEXElement, when the CAEXElement has been deleted and has no associated parent. 
![Public property] | [ChangeMode][13]       | The change mode                                                                                                                                                                 
![Public property] | [NewValue][14]         | The new value                                                                                                                                                                   
![Public property] | [OldValue][15]         | The old value                                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.CAEX.Commands Namespace][5]  

[1]: ../CaexCommand/CAEXElementChangingEvent.md
[2]: ../CaexCommand/CAEXElementChangedEvent.md
[3]: https://docs.microsoft.com/dotnet/api/system.object
[4]: https://docs.microsoft.com/dotnet/api/system.eventargs
[5]: ../README.md
[6]: _ctor.md
[7]: _ctor_1.md
[8]: CAEXAttribute.md
[9]: CAEXAttributeName.md
[10]: CAEXDocument.md
[11]: CAEXElement.md
[12]: CAEXParent.md
[13]: ChangeMode.md
[14]: NewValue.md
[15]: OldValue.md
[16]: https://www.automationml.org
[17]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"