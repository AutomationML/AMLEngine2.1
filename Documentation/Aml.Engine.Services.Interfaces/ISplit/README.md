ISplit Interface
================
AutomationML 2.1 APIThis interface defines the service interface for a split service. A split service is able to split one [CAEXDocument][1] into multiple files using split points.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ISplit : IAMLService
```

The **ISplit** type exposes the following members.


Methods
-------

                 | Name                                                  | Description                                                                                                                                                                                                                                                                                                                                                    
---------------- | ----------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [RemoveSplitPoint][3]                                 | Removes the split point for the provided CAEX object.                                                                                                                                                                                                                                                                                                          
![Public method] | [SetSplitPoint][4]                                    | Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.                                                                                                                   
![Public method] | [Split(CAEXDocument, String, String)][5]              | Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more. 
![Public method] | [Split(CAEXDocument, ISplitPoint, String, String)][6] | Splits the specified document on only the specified split point. The created library is saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain this SplitPoints any more.       
![Public method] | [SplitPoints][7]                                      | Gets a collection of all split points for the provided document.                                                                                                                                                                                                                                                                                               


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][2]  
[Aml.Engine.Services.Interfaces.IAMLService][8]  

[1]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[2]: ../README.md
[3]: RemoveSplitPoint.md
[4]: SetSplitPoint.md
[5]: Split_1.md
[6]: Split.md
[7]: SplitPoints.md
[8]: ../IAMLService/README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"