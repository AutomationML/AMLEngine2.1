CAEXPathBuilder.InternalLinkReferencePath Method (XElement, XElement)
=====================================================================
gets the reference path for an Interface-Reference in an InternalLink

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string InternalLinkReferencePath(
	XElement interfaceParent,
	XElement externalInterface
)
```

#### Parameters

##### *interfaceParent*
Type: [System.Xml.Linq.XElement][2]  
 The interface Parent (SystemUnitClass or InternalElement)

##### *externalInterface*
Type: [System.Xml.Linq.XElement][2]  
 The external Interface.

#### Return Value
Type: [String][3]  
 System.String. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][4]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png