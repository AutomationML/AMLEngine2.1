DocumentVersions.GetAllDocumentVersionInformation Method
========================================================
AutomationML 2.1 APIThis methods returns an Enumeration of all Information related to document versions defined in the "DocumentVersions" information of an AutomationML document.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<DocumentVersionInformation> GetAllDocumentVersionInformation(
	this CAEXFileType myCAEXFile
)
```

#### Parameters

##### *myCAEXFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 the CAEX file of the AutomationML document.

#### Return Value
Type: [IEnumerable][3]&lt;[DocumentVersionInformation][4]>  
 Enumerable containing all Documents in the DocumentVersion information, or null if no DocumentVersion information exists. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[DocumentVersions Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../DocumentVersionInformation/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png