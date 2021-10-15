LookupService.RemoveDocument Method
===================================
Removes the document from the internal registry of the service.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public void RemoveDocument(
	XDocumentWrapper document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.XML.XDocumentWrapper][2]  
The XML document.

#### Implements
[IXMLDocumentRegistry.RemoveDocument(XDocumentWrapper)][3]  


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | doc       


See Also
--------

#### Reference
[LookupService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.XML/XDocumentWrapper/README.md
[3]: ../../Aml.Engine.Services.Interfaces/IXMLDocumentRegistry/RemoveDocument.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png