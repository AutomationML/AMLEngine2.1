DocumentVersions.AppendDocumentVersionInformation Method (CAEXFileType, DocumentVersionInformation, String)
===========================================================================================================
AutomationML 2.1 APIAppends the provided document version information to the AutomationML document

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool AppendDocumentVersionInformation(
	this CAEXFileType myCAEXFile,
	DocumentVersionInformation versionInformation,
	out string error
)
```

#### Parameters

##### *myCAEXFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 The CAEX file of the AutomationML document.

##### *versionInformation*
Type: [Aml.Engine.AmlObjects.DocumentVersionInformation][3]  
 The version information.

##### *error*
Type: [System.String][4]  
 Out parameter containing error information if the method returns false. Possibles errors are: No Document Identifier definedDocumentVersion to be parsed is nullNegative value in version stringBad number of components in version stringNon-integer value in version stringNumber out of range in version string

#### Return Value
Type: [Boolean][5]  
 true if the version information could be added, false otherwise. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[DocumentVersions Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: ../DocumentVersionInformation/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png