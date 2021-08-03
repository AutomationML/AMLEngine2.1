AMLFile.SetMetaInformationStandardAutomationMLLibrary Method
============================================================
This method labels this CAEX file as a standard AutomationML library coming from the AutomationML e.V. It removes all other meta information and should only be used from authorized persons in agreement with the AutomationML e.V.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void SetMetaInformationStandardAutomationMLLibrary()
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