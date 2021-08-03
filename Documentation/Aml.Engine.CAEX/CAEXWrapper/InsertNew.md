CAEXWrapper.InsertNew Method
============================
AutomationML 2.1 APIThis method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][1] is defined. The new created CAEX object is inserted as a new child of the owner.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool InsertNew()
```

#### Return Value
Type: [Boolean][3]  
`true, if the XML node could be created and inserted as a new child of the owner.`

See Also
--------

#### Reference
[CAEXWrapper Class][4]  
[Aml.Engine.CAEX Namespace][2]  

[1]: Owner.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png