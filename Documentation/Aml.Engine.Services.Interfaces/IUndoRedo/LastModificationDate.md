IUndoRedo.LastModificationDate Method
=====================================
AutomationML 2.1 APIGets the date of the most recently executed command for the specified document.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
DateTime LastModificationDate(
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
 if set to `true` the date of the last undo operation is returned; otherwise the date of the last redo operation.

#### Return Value
Type: [DateTime][4]  

[Missing &lt;returns> documentation for "M:Aml.Engine.Services.Interfaces.IUndoRedo.LastModificationDate(Aml.Engine.CAEX.CAEXDocument,System.Boolean)"]


See Also
--------

#### Reference
[IUndoRedo Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.datetime
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png