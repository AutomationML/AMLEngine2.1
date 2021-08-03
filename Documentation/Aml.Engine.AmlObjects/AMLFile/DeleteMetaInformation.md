AMLFile.DeleteMetaInformation Method
====================================
This function deletes any existing meta information corresponding to the writerID.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool DeleteMetaInformation(
	string writerID
)
```

#### Parameters

##### *writerID*
Type: [System.String][2]  
Writer ID

#### Return Value
Type: [Boolean][3]  
 true if delete succeeded, false if writerID has not been found 

Exceptions
----------

Exception              | Condition 
---------------------- | --------- 
[ArgumentException][4] | writerID  


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][5]. 

See Also
--------

#### Reference
[AMLFile Class][6]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[5]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png