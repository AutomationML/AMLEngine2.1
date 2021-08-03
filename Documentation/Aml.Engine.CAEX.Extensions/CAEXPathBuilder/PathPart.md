CAEXPathBuilder.PathPart Method (CAEXObject, Boolean)
=====================================================
Builds the Path Part for any CAEXObject, which may be part of a CAEX Path. The Path Part is build from the object Names and the Part - Syntax, according to chapter 2.8 of the CAEX guide: If defined separators are potentially a valid part of object names, the following syntax shall be used: all path elements shall be separated by square brackets “[“ name “]”. This allows for using the original names and the defined separators at the same time. If the conflict case arises that the described brackets are part of object names, the brackets in the object name shall be escaped by means of common XML escape-sequences. If a name contains any Path part - Separator like '[' or ]' this character will be escaped with '\'.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string PathPart(
	CAEXObject element,
	bool useId = false
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.CAEXObject][2]  
 The CAEX element which should be part of the Path.

##### *useId* (Optional)
Type: [System.Boolean][3]  
 if true, the path part is build with the ID-Attribute

#### Return Value
Type: [String][4]  
 The Element Representation in the CAEX Path 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png