XmlSchemaManager.CreateElement Method
=====================================
AutomationML 2.1 APICreates a new node with the specified child name in the given xmlDocument. The node is created with all required attributes and elements but is not inserted in the document tree at this point. Use [Insert(XElement, XElement)][1] for insertion or [InsertNew(XElement, XName, Boolean)][2] for a combined creation and insertion.

  **Namespace:**  [Aml.Engine.Schema][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual XElement CreateElement(
	XName parentName,
	XName childName,
	bool allAttributes = false
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][4]  
Name of the child's parent

##### *childName*
Type: [System.Xml.Linq.XName][4]  
Name of the child

##### *allAttributes* (Optional)
Type: [System.Boolean][5]  
 Optional parameter to define, that not only required attributes, but all possible attributes should be created.

#### Return Value
Type: [XElement][6]  
 The created XML element. 

Remarks
-------
 The Method can be overridden by specific schema managers, to add additional properties to the created node, which can not be derived directly from the schema. 

See Also
--------

#### Reference
[XmlSchemaManager Class][7]  
[Aml.Engine.Schema Namespace][3]  

[1]: Insert.md
[2]: InsertNew.md
[3]: ../README.md
[4]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png