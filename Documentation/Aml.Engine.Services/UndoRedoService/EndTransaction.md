UndoRedoService.EndTransaction Method
=====================================
Ends the current transaction from the specified document.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool EndTransaction(
	CAEXDocument document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

#### Return Value
Type: [Boolean][3]  
If the transaction ended
#### Implements
[IUndoRedo.EndTransaction(CAEXDocument)][4]  


Exceptions
----------

Exception                      | Condition                     
------------------------------ | ----------------------------- 
[InvalidOperationException][5] | No matching Transaction Begin 


See Also
--------

#### Reference
[UndoRedoService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IUndoRedo/EndTransaction.md
[5]: https://docs.microsoft.com/dotnet/api/system.invalidoperationexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png