XmlSchemaManager.Choices Method
===============================
AutomationML 2.1 APIGets the names of all alternative child nodes, which can be added to a parent node with the given name. The specified child itself is included. Choices only exists, if [IsChoice(String, String)][1] returns true for the defined child name.

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<XName> Choices(
	XName parentName,
	XName childName
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][3]  
Name of the child's parent

##### *childName*
Type: [System.Xml.Linq.XName][3]  
Name of the child

#### Return Value
Type: [IEnumerable][4]&lt;[XName][3]>  
 Enumeration of names, representing the possible alternatives for child elements. 

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][2]  

[1]: IsChoice.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png