XDocumentWrapper.SaveToStream Method
====================================
Saves the document to the specified file path.

  **Namespace:**  [Aml.Engine.XML][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual Stream SaveToStream(
	bool prettyPrint
)
```

#### Parameters

##### *prettyPrint*
Type: [System.Boolean][2]  
Set to true, if pretty printing is desired

#### Return Value
Type: [Stream][3]  
The stream, containing the document content.
#### Implements
[IDocument.SaveToStream(Boolean)][4]  


See Also
--------

#### Reference
[XDocumentWrapper Class][5]  
[Aml.Engine.XML Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: https://docs.microsoft.com/dotnet/api/system.io.stream
[4]: ../IDocument/SaveToStream.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png