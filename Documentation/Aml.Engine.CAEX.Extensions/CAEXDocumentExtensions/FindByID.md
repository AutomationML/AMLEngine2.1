CAEXDocumentExtensions.FindByID Method
======================================
AutomationML 2.1 APITries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an [IExternalReferenceResolver][1] can be located, it is tried to resolve the external reference and to get the object from the external source.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXObject FindByID(
	this CAEXDocument document,
	string id,
	bool resolveAlias = false
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *id*
Type: [System.String][4]  
The identifier.

##### *resolveAlias* (Optional)
Type: [System.Boolean][5]  
 if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.

#### Return Value
Type: [CAEXObject][6]  
 The CAEXObject if it is found; otherwise `null`. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXDocument][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

#### Reference
[CAEXDocumentExtensions Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png