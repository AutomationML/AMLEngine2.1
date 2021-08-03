CAEXPathBuilder.CAEXPath Method (IEnumerable&lt;XElement>)
==========================================================
AutomationML 2.1 APIBuilds the Reference-Path which includes all Names of CAEXObjects in the given list of elements.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string CAEXPath(
	IEnumerable<XElement> elementNodes
)
```

#### Parameters

##### *elementNodes*
Type: [System.Collections.Generic.IEnumerable][2]&lt;[XElement][3]>  
The XML nodes of the CAEX objects.

#### Return Value
Type: [String][4]  
 The CAEX Path, build from the element XML nodes. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png