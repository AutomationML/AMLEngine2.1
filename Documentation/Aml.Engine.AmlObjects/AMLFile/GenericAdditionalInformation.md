AMLFile.GenericAdditionalInformation Property
=============================================
Gets the AdditionalInformation values contained in this instance which are neither DocumentVersion or WriterHeader. DocumentVersion and WriterHeader objects are realized using AdditionalInformation objects, too. But these elements define a specific syntax to be recognized as specific AdditionalInformation objects.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ValueSequence<Object> GenericAdditionalInformation { get; }
```

#### Property Value
Type: [ValueSequence][2]&lt;[Object][3]>

See Also
--------

#### Reference
[AMLFile Class][4]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ValueSequence_1/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.object
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png