CAEXBasicObjectExtensions.CreateCaexWrapper&lt;T> Method
========================================================
Creates a CAEX object of the given type from the specified XML element.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static T CreateCaexWrapper<T>(
	XElement xmlNode
)
where T : CAEXWrapper

```

#### Parameters

##### *xmlNode*
Type: [System.Xml.Linq.XElement][2]  
The XML node.

#### Type Parameters

##### *T*
CAEX element type.

#### Return Value
Type: **T**  
CAEX object in the given type.

See Also
--------

#### Reference
[CAEXBasicObjectExtensions Class][3]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png