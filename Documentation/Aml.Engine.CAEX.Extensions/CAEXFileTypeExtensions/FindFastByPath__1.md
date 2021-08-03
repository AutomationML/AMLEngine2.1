CAEXFileTypeExtensions.FindFastByPath&lt;T> Method (CAEXFileType, String, Boolean)
==================================================================================


**Note: This API is now obsolete.**
Performs a document wide fast search and returns an object of type 'T' given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface".

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the standard Query FindByPath. If fast dictionary based access is required, register a FastQueryService.")]
public static T FindFastByPath<T>(
	this CAEXFileType caexFile,
	string path,
	bool includeExternals = false
)
where T : CAEXObject

```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
the CAEX file

##### *path*
Type: [System.String][3]  
the path of the object which is subject of the search

##### *includeExternals* (Optional)
Type: [System.Boolean][4]  
 new optional parameter to enable this method (default=`false`), to search in referenced documents also.

#### Type Parameters

##### *T*
Type of the expected CAEX object.

#### Return Value
Type: **T**  
 the found CAEXObject or null if not found 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Remarks
-------
 External references are resolved in the search if a [IExternalReferenceResolver][7] service is registered. 

See Also
--------

#### Reference
[CAEXFileTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png