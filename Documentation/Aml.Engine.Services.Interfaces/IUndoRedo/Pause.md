IUndoRedo.Pause Method
======================
Request to not record changes of the specified document. If the recording of document changes is paused the [Undo(CAEXDocument)][1] and [Redo(CAEXDocument)][2] methods can not be applied.

  **Namespace:**  [Aml.Engine.Services.Interfaces][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
void Pause(
	CAEXDocument document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][4]  
The document.


See Also
--------

#### Reference
[IUndoRedo Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][3]  

[1]: Undo.md
[2]: Redo.md
[3]: ../README.md
[4]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png