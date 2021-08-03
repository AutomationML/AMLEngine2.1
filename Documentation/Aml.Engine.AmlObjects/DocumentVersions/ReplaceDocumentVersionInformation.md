DocumentVersions.ReplaceDocumentVersionInformation Method
=========================================================
This function replaces any existing DocumentVersion information corresponding to the identical oldDocumentID with the provided new DocumentVersion information.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool ReplaceDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	string oldDocumentID,
	DocumentVersionInformation newDocumentVersionInformation,
	out string error
)
```

#### Parameters

##### *myCAEXFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 The CAEX file of the AutomationML document.

##### *oldDocumentID*
Type: [System.String][3]  
 Document identifier of the old DocumentVersion information

##### *newDocumentVersionInformation*
Type: [Aml.Engine.AmlObjects.DocumentVersionInformation][4]  
 substitute for the old version of DocumentVersion information

##### *error*
Type: [System.String][3]  
 error information if provided values are invalid

#### Return Value
Type: [Boolean][5]  
 true if succeeded, false if DocumentVersion information corresponding to the oldDocumentID is not found 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[DocumentVersions Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../DocumentVersionInformation/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png