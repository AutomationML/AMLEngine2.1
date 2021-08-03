AmlObjectsExtensions.SetMetaInformation Method (CAEXFileType, String, String, String, String, String, String, String, String, String)
=====================================================================================================================================
This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void SetMetaInformation(
	this CAEXFileType caexFile,
	string writerName,
	string writerID,
	string writerVendor,
	string writerVendorURL,
	string writerVersion,
	string writerRelease,
	string lastWritingDateTime,
	string writerProjectTitle,
	string writerProjectID
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
the CAEXFile

##### *writerName*
Type: [System.String][3]  
the name of the writing tool

##### *writerID*
Type: [System.String][3]  
an ID of the writing tool

##### *writerVendor*
Type: [System.String][3]  
the tool vendors name

##### *writerVendorURL*
Type: [System.String][3]  
the tools vendors URL

##### *writerVersion*
Type: [System.String][3]  
the version of the writing tool

##### *writerRelease*
Type: [System.String][3]  
the release number of the writing tool

##### *lastWritingDateTime*
Type: [System.String][3]  
the date of the last writing time

##### *writerProjectTitle*
Type: [System.String][3]  
the title of the written project

##### *writerProjectID*
Type: [System.String][3]  
an ID of the written project

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][6] | caexFile  


Remarks
-------
 Extension Method for AutomationML Versions based on CAEX 2.15. If this method is called for a CAEX 3.0 or later Version, the call is redirected to the [SetSourceDocumentInformation(CAEXFileType, String, String, String, String, String, String, DateTime, String, String)][7]. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][8]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: SetSourceDocumentInformation.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png