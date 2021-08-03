CAEXDocument.Commanding Class
=============================
AutomationML 2.1 APIThe Commanding class, which provides events for changes of CAEX objects


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.CAEXDocument.Commanding**  

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class Commanding
```

The **CAEXDocument.Commanding** type exposes the following members.


Constructors
------------

                 | Name                         | Description                                                         
---------------- | ---------------------------- | ------------------------------------------------------------------- 
![Public method] | [CAEXDocument.Commanding][3] | Initializes a new instance of the **CAEXDocument.Commanding** class 


Events
------

                | Name                          | Description                                                                           
--------------- | ----------------------------- | ------------------------------------------------------------------------------------- 
![Public event] | [CAEXElementChangedEvent][4]  | This event is raised after a CAEXElement has been changed. [CAEXElementChangeMode][5] 
![Public event] | [CAEXElementChangingEvent][6] | This event is raised before a CAEXElement will be changed. [CAEXElementChangeMode][5] 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: CAEXElementChangedEvent.md
[5]: ../../Aml.Engine.CAEX.Commands/CAEXElementChangeMode/README.md
[6]: CAEXElementChangingEvent.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public event]: ../../icons/pubevent.gif "Public event"