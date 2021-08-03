AMLFile.SetMetaInformation Method (MetaInformation)
===================================================
This method is a short version of the setMetaInformation. Meta data with identical WriterID is replaced.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void SetMetaInformation(
	MetaInformation metaInformation
)
```

#### Parameters

##### *metaInformation*
Type: [Aml.Engine.AmlObjects.MetaInformation][2]  
the structure MetaInformation


Exceptions
----------

Exception                  | Condition       
-------------------------- | --------------- 
[ArgumentNullException][3] | metaInformation 


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][4]. 

See Also
--------

#### Reference
[AMLFile Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../MetaInformation/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[4]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png