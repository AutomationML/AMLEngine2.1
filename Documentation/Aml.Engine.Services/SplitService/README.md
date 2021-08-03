SplitService Class
==================
AutomationML 2.1 APIThis class is an implementation of a split service. This service is able to split one [CAEXDocument][1] into multiple files using split points.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.Services.SplitService**  

  **Namespace:**  [Aml.Engine.Services][3]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class SplitService : ISplit, 
	IAMLService, IXMLDocumentRegistry
```

The **SplitService** type exposes the following members.


Methods
-------

                                 | Name                                                   | Description                                                                                                                                                                                                                                                                                                                                                    
-------------------------------- | ------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [Register][4]                                          | Registers a new instance of a SplitService with the [ServiceLocator][5] of the AMLEngine.                                                                                                                                                                                                                                                                      
![Public method]                 | [RemoveDocument][6]                                    | Removes the document from the internal registry of the split service. All registered split points for this document will be removed.                                                                                                                                                                                                                           
![Public method]                 | [RemoveSplitPoint][7]                                  | Removes the split point for the provided CAEX object.                                                                                                                                                                                                                                                                                                          
![Public method]                 | [SetSplitPoint][8]                                     | Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.                                                                                                                   
![Public method]                 | [Split(CAEXDocument, String, String)][9]               | Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more. 
![Public method]                 | [Split(CAEXDocument, ISplitPoint, String, String)][10] | Splits the specified source document.                                                                                                                                                                                                                                                                                                                          
![Public method]                 | [SplitPoints][11]                                      | Gets a collection of all split points for the provided document.                                                                                                                                                                                                                                                                                               
![Public method]![Static member] | [UnRegister][12]                                       | Unregisters this service                                                                                                                                                                                                                                                                                                                                       


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][3]  
[Aml.Engine.Services.Interfaces.ISplit][13]  

[1]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: Register.md
[5]: ../ServiceLocator/README.md
[6]: RemoveDocument.md
[7]: RemoveSplitPoint.md
[8]: SetSplitPoint.md
[9]: Split_1.md
[10]: Split.md
[11]: SplitPoints.md
[12]: UnRegister.md
[13]: ../../Aml.Engine.Services.Interfaces/ISplit/README.md
[14]: https://www.automationml.org
[15]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"