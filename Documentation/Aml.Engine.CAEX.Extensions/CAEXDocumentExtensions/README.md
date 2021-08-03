CAEXDocumentExtensions Class
============================
AutomationML 2.1 APIThis class defines extension methods for the [CAEXDocument][1] class.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.CAEX.Extensions.CAEXDocumentExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class CAEXDocumentExtensions
```

The **CAEXDocumentExtensions** type exposes the following members.


Methods
-------

                                 | Name            | Description                                                                                                                                                                                                                                           
-------------------------------- | --------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [FindByID][4]   | Tries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an [IExternalReferenceResolver][5] can be located, it is tried to resolve the external reference and to get the object from the external source.           
![Public method]![Static member] | [FindByPath][6] | Tries to locates a CAEX object from the specified CAEX path. If the path uses an alias reference and an [IExternalReferenceResolver][5] can be located, it is tried to resolve the external reference and to get the object from the external source. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: FindByID.md
[5]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[6]: FindByPath.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"