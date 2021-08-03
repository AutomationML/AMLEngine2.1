AmlObjectsExtensions.SetSourceDocumentInformation Method
========================================================
This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void SetSourceDocumentInformation(
	this CAEXFileType caexFile,
	string originName,
	string originID,
	string originVendor,
	string originVendorURL,
	string originVersion,
	string originRelease,
	DateTime lastWritingDateTime,
	string originProjectTitle,
	string originProjectID
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
the CAEXFile

##### *originName*
Type: [System.String][3]  
the name of the writing tool

##### *originID*
Type: [System.String][3]  
an ID of the writing tool

##### *originVendor*
Type: [System.String][3]  
the tool vendors name

##### *originVendorURL*
Type: [System.String][3]  
the tools vendors URL

##### *originVersion*
Type: [System.String][3]  
the version of the writing tool

##### *originRelease*
Type: [System.String][3]  
the release number of the writing tool

##### *lastWritingDateTime*
Type: [System.DateTime][4]  
the date of the last writing time

##### *originProjectTitle*
Type: [System.String][3]  
the title of the written project

##### *originProjectID*
Type: [System.String][3]  
an ID of the written project

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][7] | caexFile  


Remarks
-------
 Extension Method for AutomationML Versions based on CAEX 3.0. If this method is called for an CAEX 2.15 Version, the call is redirected to the [SetMetaInformation(CAEXFileType, String, String, String, String, String, String, String, String, String)][8] . 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][9]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.datetime
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: SetMetaInformation_1.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png