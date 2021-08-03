MergeService Class
==================
This class implements a merge service which is able to merge CAEX documents from different sources into one common document. The merge service adds the libraries from the external referenced file into the target document and updates all references, which use an alias and can be resolved after the merge. If a library, which is used in the external source, also exists in the target document, this library is replaced, if the library version in the external source is newer. If not the existing library is kept. If an InstanceHierarchy in the external source can be identified as an outsourced Master InternalElement, it is tried to add the Master InternalElement back to its original position.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.MergeService**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class MergeService : IMerge, 
	IAMLService
```

The **MergeService** type exposes the following members.


Constructors
------------

                 | Name              | Description                                              
---------------- | ----------------- | -------------------------------------------------------- 
![Public method] | [MergeService][3] | Initializes a new instance of the **MergeService** class 


Methods
-------

                                 | Name                                                                       | Description                                                                                                                         
-------------------------------- | -------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [Merge(CAEXDocument, ExternalReferenceType, String[], Boolean)][4]         | Merges the defined ExternalReference into the provided CAEXDocument.                                                                
![Public method]                 | [Merge(CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)][5] | Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream. 
![Public method]![Static member] | [Register][6]                                                              | Registers a new instance of a MergeService with the [ServiceLocator][7] of the AMLEngine.                                           
![Public method]![Static member] | [UnRegister][8]                                                            | Unregisters this service                                                                                                            


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IMerge][9]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: Merge_1.md
[5]: Merge.md
[6]: Register.md
[7]: ../ServiceLocator/README.md
[8]: UnRegister.md
[9]: ../../Aml.Engine.Services.Interfaces/IMerge/README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"