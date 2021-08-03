AMLFile.ReplaceMetaInformation Method
=====================================
This function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the new Meta information

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool ReplaceMetaInformation(
	string oldWriterID,
	MetaInformation newMetainformation
)
```

#### Parameters

##### *oldWriterID*
Type: [System.String][2]  
writerID of the old meta information

##### *newMetainformation*
Type: [Aml.Engine.AmlObjects.MetaInformation][3]  
substitute for the old version of meta information

#### Return Value
Type: [Boolean][4]  
 true if succeeded, false if meta information about the oldWriterID is not found 

Exceptions
----------

Exception              | Condition   
---------------------- | ----------- 
[ArgumentException][5] | oldWriterID 


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][6]. 

See Also
--------

#### Reference
[AMLFile Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../MetaInformation/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[6]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png