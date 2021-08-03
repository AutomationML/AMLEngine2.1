CAEXPathBuilder.NormalizePath Method
====================================
AutomationML 2.1 APINormalization of a CAEXPath. A normalized path is freed of all path part delimiters '[' and ']' in case that there is no path part name containing a path separator character like '/'.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string NormalizePath(
	string path,
	out bool isNormalized,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *path*
Type: [System.String][2]  
The path.

##### *isNormalized*
Type: [System.Boolean][3]  
if set to `true` [is normalized].

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][4]  
A CAEX schema version.

#### Return Value
Type: [String][2]  
 the normalized path 

Remarks
-------
 Since CAEX Version 3.0 a '.' and ':' is no longer used as a path separator. Names, containing such a character will be normalized in Version 3.0 also. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png