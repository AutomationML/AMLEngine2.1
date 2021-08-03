AMLSchemaManager.CreateElement Method
=====================================
Method overrides the [CreateElement(XName, XName, Boolean)][1]. The created node is made to an AML node.

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override XElement CreateElement(
	XName parentName,
	XName childName,
	bool allAttributes = false
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][3]  
Name of the child's parent

##### *childName*
Type: [System.Xml.Linq.XName][3]  
Name of the child

##### *allAttributes* (Optional)
Type: [System.Boolean][4]  
 optional parameter to define, that not only required attributes, but all possible attributes should be created.

#### Return Value
Type: [XElement][5]  
 The created XML node. 

See Also
--------

#### Reference
[AMLSchemaManager Class][6]  
[Aml.Engine.Schema Namespace][2]  

[1]: ../XmlSchemaManager/CreateElement.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png