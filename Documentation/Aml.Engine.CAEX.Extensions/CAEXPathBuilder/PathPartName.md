CAEXPathBuilder.PathPartName Method
===================================
AutomationML 2.1 APITransforms a name to a path Part (special characters are escaped).

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string PathPartName(
	string name,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *name*
Type: [System.String][2]  
 The name.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
This method has different implementations according to the used CAEX Version

#### Return Value
Type: [String][2]  
 The transformed name that can be used as a path part. 

Remarks
-------
 Since CAEX Version 3.0 the Path separator characters '.' and ':' are eliminated. 

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