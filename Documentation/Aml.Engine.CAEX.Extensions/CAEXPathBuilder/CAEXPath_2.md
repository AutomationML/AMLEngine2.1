CAEXPathBuilder.CAEXPath Method (String[], CAEXDocument.CAEXSchema)
===================================================================
AutomationML 2.1 APIBuilds the Reference-Path which includes all names of CAEX objects in the given name array.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string CAEXPath(
	string[] names,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *names*
Type: [System.String][2][]  
The names, which build the path parts.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
The CAEX schema version.

#### Return Value
Type: [String][2]  
 The CAEX path created from the names array. 

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