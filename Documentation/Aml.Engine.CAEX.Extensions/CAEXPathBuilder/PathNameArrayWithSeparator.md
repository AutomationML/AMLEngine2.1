CAEXPathBuilder.PathNameArrayWithSeparator Method
=================================================
AutomationML 2.1 APIReturns the Path Part object names of a CAEX Path with the Separator Char at the Names End as an array of strings.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string[] PathNameArrayWithSeparator(
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
Type: [String][2][]  
 Array of path part names. 

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