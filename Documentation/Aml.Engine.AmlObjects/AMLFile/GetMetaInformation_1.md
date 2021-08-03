AMLFile.GetMetaInformation Method (String)
==========================================
AutomationML 2.1 APIThis function returns the MetaInformation corresponding to the writerID, otherwise null.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public MetaInformation GetMetaInformation(
	string writerID
)
```

#### Parameters

##### *writerID*
Type: [System.String][2]  
the writerID

#### Return Value
Type: [MetaInformation][3]  
 This function returns the MetaInformation corresponding to the writerID, otherwise null. 

Exceptions
----------

Exception                        | Condition 
-------------------------------- | --------- 
[ArgumentException][4]           | writerID  
[ArgumentOutOfRangeException][5] |           


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed from a [SourceDocumentInformationType][6]. 

See Also
--------

#### Reference
[AMLFile Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../MetaInformation/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[5]: https://docs.microsoft.com/dotnet/api/system.argumentoutofrangeexception
[6]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png