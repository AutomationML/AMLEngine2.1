DocumentVersions.AppendDocumentVersionInformation Method (CAEXFileType, String, String, String)
===============================================================================================
AutomationML 2.1 APIThis function sets the DocumentVersion information for a referenced document. If DocumentVersion information about the same document Identifier already exists, this DocumentVersion information is replaced.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool AppendDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	string documentIdentifier,
	string documentVersion,
	out string error
)
```

#### Parameters

##### *myCAEXFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 the CAEXFile of the AutomationML document

##### *documentIdentifier*
Type: [System.String][3]  
 The "DocumentIdentifier" shall define the name of the referenced document.

##### *documentVersion*
Type: [System.String][3]  
 The "Version" shall define the version range of the referenced document. The version number shall have three numbers separated by ".".

##### *error*
Type: [System.String][3]  
 Out parameter with error information if provided values are not valid or null. Possibles errors are: No Document Identifier definedDocumentVersion to be parsed is nullNegative value in version stringBad number of components in version stringNon-integer value in version stringNumber out of range in version string

#### Return Value
Type: [Boolean][4]  
 true, if information is added, false otherwise. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[DocumentVersions Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png