CAEXPathBuilder.RemoveAlias Method
==================================
Removes the alias from the provided path if the path is [IsReferenceWithAlias(String, CAEXDocument.CAEXSchema)][1].

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string RemoveAlias(
	string path
)
```

#### Parameters

##### *path*
Type: [System.String][3]  
The path.

#### Return Value
Type: [String][3]  
 The path without the alias part. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][4]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: IsReferenceWithAlias.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png