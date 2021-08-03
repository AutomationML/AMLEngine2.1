CAEXPathBuilder.IsObjectReferenceWithAlias Method
=================================================
Determines whether the specified classReference is an alias reference to the provided AutomationML class path.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsObjectReferenceWithAlias(
	string classReference,
	string automationMlClassPath,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *classReference*
Type: [System.String][2]  
The class reference.

##### *automationMlClassPath*
Type: [System.String][2]  
The automation ml class path.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
The CAEX schema version.

#### Return Value
Type: [Boolean][4]  
`true` if [is object reference with alias] [the specified class reference]; otherwise, `false`. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png