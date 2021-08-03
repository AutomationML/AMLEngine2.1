UndoRedoService.LastModificationDate Method
===========================================
Gets the date of the most recently executed command for the specified document.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public DateTime LastModificationDate(
	CAEXDocument document,
	bool undo = true
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *undo* (Optional)
Type: [System.Boolean][3]  
if set to `true` the last undo operation is considered; otherwise the last redo operation.

#### Return Value
Type: [DateTime][4]  

[Missing &lt;returns> documentation for "M:Aml.Engine.Services.UndoRedoService.LastModificationDate(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"]

#### Implements
[IUndoRedo.LastModificationDate(CAEXDocument, Boolean)][5]  


See Also
--------

#### Reference
[UndoRedoService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.datetime
[5]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/LastModificationDate.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png