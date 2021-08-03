CAEXDocument.Validate Method
============================
AutomationML 2.1 APIChecks if the document is schema compliant.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool Validate(
	out string[] violationLog
)
```

#### Parameters

##### *violationLog*
Type: [System.String][2][]  
Log of schema violations.

#### Return Value
Type: [Boolean][3]  
`true`, if the CAEX document is schema compliant; otherwise `false`.

See Also
--------

#### Reference
[CAEXDocument Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png