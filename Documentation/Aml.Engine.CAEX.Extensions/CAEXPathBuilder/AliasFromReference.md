CAEXPathBuilder.AliasFromReference Method
=========================================
AutomationML 2.1 APIGets the alias name from a reference. If the reference is not a reference with an alias, the return value is string.Empty.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string AliasFromReference(
	string classReference,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *classReference*
Type: [System.String][2]  
The class reference.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
The CAEX schema version.

#### Return Value
Type: [String][2]  
 The Alias Name without the Ending AliasSeparator or string.empty 

See Also
--------

#### Reference
[CAEXPathBuilder Class][4]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png