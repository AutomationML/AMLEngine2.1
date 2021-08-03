CAEXFileTypeExtensions.FindFastByID Method (CAEXFileType, String, Boolean)
==========================================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Performs a document wide fast search and returns a CAEXObject given by its ID.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the standard Query FindByID. If fast dictionary based access is required, register a FastQueryService.")]
public static CAEXObject FindFastByID(
	this CAEXFileType caexFile,
	string ID,
	bool includeExternals = false
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
the CAEXFile

##### *ID*
Type: [System.String][3]  
the ID ob the object which is subject of the search

##### *includeExternals* (Optional)
Type: [System.Boolean][4]  
 Optional parameter to enable this methods (default=`false`), to search in referenced documents also. Referenced Documents can only be considered, if they are loaded via the ExternalReference.

#### Return Value
Type: [CAEXObject][5]  
the found CAEXObject or null if not found
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

Remarks
-------
 External references are resolved in the search if a [IExternalReferenceResolver][8] service is registered. 

See Also
--------

#### Reference
[CAEXFileTypeExtensions Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png