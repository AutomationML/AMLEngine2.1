CAEXPathBuilder.PathPartObjectNames Method
==========================================
AutomationML 2.1 APIReturns the Path Part object names of a CAEX Path. If any object name contains a path separator character the path part is enclosed in square brackets '[', ']'. The square brackets are removed from the object name in the returned result (default behaviour). If keepPathPartBrackets is set to true, square brackets are not removed.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<string> PathPartObjectNames(
	string path,
	CAEXDocument.CAEXSchema schema,
	bool keepPathPartBrackets = false
)
```

#### Parameters

##### *path*
Type: [System.String][2]  
The full CAEX path.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
The CAEX schema version.

##### *keepPathPartBrackets* (Optional)
Type: [System.Boolean][4]  
`false` (default); if `true`, object names may be enclosed in square brackets

#### Return Value
Type: [IEnumerable][5]&lt;[String][2]>  
 IEnumerable&lt;System.String>. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png