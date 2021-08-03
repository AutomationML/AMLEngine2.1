XmlSchemaManager.HasChoiceOfElements Method
===========================================
Determines, whether the schema element representing the parent - child relation has a content, which is restricted to a choice of elements. If onlyOne is set to true, there can not be more than one element added to the element

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasChoiceOfElements(
	XName parentName,
	XName childName,
	out bool onlyOne
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the parent.

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child.

##### *onlyOne*
Type: [System.Boolean][3]  
if set to `true` [only one].

#### Return Value
Type: [Boolean][3]  
`true` if the specified parent to child relation is restricted to a choice of elements; otherwise, `false`. 

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png