XmlSchemaManager.SiblingBefore Method
=====================================
AutomationML 2.1 APIThis method is a utility method for insert operations. The method will return the node which should be used as the sibling before a newly added child with the defined name. The Insertion has to be done after the returned node or prepended to the parent itself, if no node `null` is returned.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public XElement SiblingBefore(
	XElement parent,
	XName childName
)
```

#### Parameters

##### *parent*
Type: [System.Xml.Linq.XElement][2]  
The parent node

##### *childName*
Type: [System.Xml.Linq.XName][3]  
Name of the child.

#### Return Value
Type: [XElement][2]  
 The child node of the parent, which should be the sibling before a newly added node, or `null`, if no node exists. 

See Also
--------

#### Reference
[XmlSchemaManager Class][4]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png