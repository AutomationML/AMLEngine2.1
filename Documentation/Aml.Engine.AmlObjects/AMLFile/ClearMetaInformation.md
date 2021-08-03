AMLFile.ClearMetaInformation Method
===================================
Removes all "Writer Header" specific meta information out of this CAEX file.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void ClearMetaInformation()
```


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][2]. 

See Also
--------

#### Reference
[AMLFile Class][3]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png