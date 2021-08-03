XmlSchemaManager.InsertNew Method
=================================
AutomationML 2.1 APICreates a new node with the defined child name and inserts the newly created child into the child nodes collection of the specified parent. Optional, it can be specified, if the new node should get all attributes, which are defined in the schema, or only those attributes which are required (default behaviour). The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual XElement InsertNew(
	XElement parent,
	XName childName,
	bool allAttributes = false
)
```

#### Parameters

##### *parent*
Type: [System.Xml.Linq.XElement][2]  
The parent node for insertion.

##### *childName*
Type: [System.Xml.Linq.XName][3]  
Name of the child

##### *allAttributes* (Optional)
Type: [System.Boolean][4]  
 optional parameter to specify, that all attributes should be added automatically to the created node.

#### Return Value
Type: [XElement][2]  
 the created and inserted node. 

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png