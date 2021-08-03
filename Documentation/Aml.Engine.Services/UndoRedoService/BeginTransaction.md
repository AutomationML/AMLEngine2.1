UndoRedoService.BeginTransaction Method
=======================================
Begins a new transaction. All changes, made to a CAEXDocument inside a transaction are treated as a single operation.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool BeginTransaction(
	CAEXDocument document,
	string name = ""
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document to which the transaction should be associated.

##### *name* (Optional)
Type: [System.String][3]  
A friendly name for this transaction.

#### Return Value
Type: [Boolean][4]  
If the transaction started.
#### Implements
[IUndoRedo.BeginTransaction(CAEXDocument, String)][5]  


See Also
--------

#### Reference
[UndoRedoService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/BeginTransaction.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png