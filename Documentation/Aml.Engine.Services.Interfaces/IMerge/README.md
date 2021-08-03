IMerge Interface
================
AutomationML 2.1 APIThis interface defines methods for a merge service. A merge service can merge ExternalReferences into an AML document.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IMerge : IAMLService
```


Methods
-------

                 | Name                                                                       | Description                                                                                                                             
---------------- | -------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [Merge(CAEXDocument, ExternalReferenceType, String[], Boolean)][2]         | Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the file path in the external reference. 
![Public method] | [Merge(CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)][3] | Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream.     


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][4]  

[1]: ../README.md
[2]: Merge_1.md
[3]: Merge.md
[4]: ../IAMLService/README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"