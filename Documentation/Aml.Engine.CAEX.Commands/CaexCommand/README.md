CaexCommand Class
=================
AutomationML 2.1 APIThis is the abstract base class for all CAEX commands, applicable to CAEX elements


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Commands.CaexCommand**  

  **Namespace:**  [Aml.Engine.CAEX.Commands][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class CaexCommand : ICAEXCommand
```

The **CaexCommand** type exposes the following members.


Properties
----------

                   | Name              | Description                                   
------------------ | ----------------- | --------------------------------------------- 
![Public property] | [CAEXDocument][3] | Gets the CAEX document processing the command 
![Public property] | [DisplayName][4]  | Gets the display name of the command          
![Public property] | [XDocument][5]    | Gets the XML document processing the command  


Methods
-------

                                 | Name                            | Description                                                          
-------------------------------- | ------------------------------- | -------------------------------------------------------------------- 
![Public method]                 | [Execute][6]                    | Command Execution method                                             
![Public method]![Static member] | [OnCAEXElementChangedEvent][7]  | Raises the [CAEXElementChangedEvent][8] for the provided document.   
![Public method]![Static member] | [OnCAEXElementChangingEvent][9] | Raises the [CAEXElementChangingEvent][10] for the provided document. 
![Public method]                 | [UnExecute][11]                 | Command reverse execution method                                     


Events
------

                                | Name                           | Description                                                                            
------------------------------- | ------------------------------ | -------------------------------------------------------------------------------------- 
![Public event]![Static member] | [CAEXElementChangedEvent][8]   | This event is raised after a CAEXElement has been changed. [CAEXElementChangeMode][12] 
![Public event]![Static member] | [CAEXElementChangingEvent][10] | This event is raised before a CAEXElement will be changed. [CAEXElementChangeMode][12] 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Commands Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: CAEXDocument.md
[4]: DisplayName.md
[5]: XDocument.md
[6]: Execute.md
[7]: OnCAEXElementChangedEvent.md
[8]: CAEXElementChangedEvent.md
[9]: OnCAEXElementChangingEvent.md
[10]: CAEXElementChangingEvent.md
[11]: UnExecute.md
[12]: ../CAEXElementChangeMode/README.md
[13]: https://www.automationml.org
[14]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"