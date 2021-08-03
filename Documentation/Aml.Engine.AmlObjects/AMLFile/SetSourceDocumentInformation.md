AMLFile.SetSourceDocumentInformation Method
===========================================
AutomationML 2.1 APIThis function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void SetSourceDocumentInformation(
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

##### *originName*
Type: [System.String][2]  
the name of the writing tool

##### *originID*
Type: [System.String][2]  
an ID of the writing tool

##### *originVendor*
Type: [System.String][2]  
the tool vendors name

##### *originVendorURL*
Type: [System.String][2]  
the tools vendors URL

##### *originVersion*
Type: [System.String][2]  
the version of the writing tool

##### *originRelease*
Type: [System.String][2]  
the release number of the writing tool

##### *lastWritingDateTime*
Type: [System.DateTime][3]  
the date of the last writing time

##### *originProjectTitle*
Type: [System.String][2]  
the title of the written project

##### *originProjectID*
Type: [System.String][2]  
an ID of the written project


Exceptions
----------

Exception              | Condition 
---------------------- | --------- 
[ArgumentException][4] | originID  


Remarks
-------
 Extension Method for AutomationML Versions based on CAEX 3.0. If this method is called for an CAEX 2.15 Version, the call is redirected to the [SetMetaInformation(String, String, String, String, String, String, String, String, String)][5]. 

See Also
--------

#### Reference
[AMLFile Class][6]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.datetime
[4]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[5]: SetMetaInformation_1.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png