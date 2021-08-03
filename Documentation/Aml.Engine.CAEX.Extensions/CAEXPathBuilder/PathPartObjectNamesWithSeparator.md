CAEXPathBuilder.PathPartObjectNamesWithSeparator Method
=======================================================
AutomationML 2.1 APIReturns the Path Part object names of a CAEX Path with the Separator Char at the Names End

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<string> PathPartObjectNamesWithSeparator(
	string path,
	CAEXDocument.CAEXSchema schema,
	bool onlyAlias = false
)
```

#### Parameters

##### *path*
Type: [System.String][2]  
The full CAEX path.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
The CAEX schema version.

##### *onlyAlias* (Optional)
Type: [System.Boolean][4]  
optional parameter, specifying that only the alias char should be kept.

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