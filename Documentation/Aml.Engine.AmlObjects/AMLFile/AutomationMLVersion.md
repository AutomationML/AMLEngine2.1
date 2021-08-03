AMLFile.AutomationMLVersion Property
====================================
Gets or sets the AutomationML version. It is not allowed to set an AMLVersion which is higher than the [MaximalAMLVersion][1]. If this is tried, the maximal known version is used for this document.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public string AutomationMLVersion { get; set; }
```

#### Property Value
Type: [String][3]

See Also
--------

#### Reference
[AMLFile Class][4]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: MaximalAMLVersion.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png