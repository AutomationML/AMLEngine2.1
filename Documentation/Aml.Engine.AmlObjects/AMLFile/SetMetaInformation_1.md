AMLFile.SetMetaInformation Method (String, String, String, String, String, String, String, String, String)
==========================================================================================================
This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void SetMetaInformation(
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

##### *writerName*
Type: [System.String][2]  
the name of the writing tool

##### *writerID*
Type: [System.String][2]  
an ID of the writing tool

##### *writerVendor*
Type: [System.String][2]  
the tool vendors name

##### *writerVendorURL*
Type: [System.String][2]  
the tools vendors URL

##### *writerVersion*
Type: [System.String][2]  
the version of the writing tool

##### *writerRelease*
Type: [System.String][2]  
the release number of the writing tool

##### *lastWritingDateTime*
Type: [System.String][2]  
the date of the last writing time

##### *writerProjectTitle*
Type: [System.String][2]  
the title of the written project

##### *writerProjectID*
Type: [System.String][2]  
an ID of the written project


Exceptions
----------

Exception              | Condition 
---------------------- | --------- 
[ArgumentException][3] | writerID  


Remarks
-------
 Extension Method for AutomationML Versions based on CAEX 2.15. If this method is called for a CAEX 3.0 or later Version, the call is redirected to the [SetSourceDocumentInformation(String, String, String, String, String, String, DateTime, String, String)][4]. 

See Also
--------

#### Reference
[AMLFile Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[4]: SetSourceDocumentInformation.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png