XmlSchemaManager.IsChoice Method
================================
Determines, whether the occurrence of a child with that name under a parent with that name is part of a choice (means that there are other exclusive alternatives for child nodes). If not, the child is defined in a sequence. For choices, the names of alternatives are available with [Choices(XName, XName)][1].

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsChoice(
	string parentName,
	string childName
)
```

#### Parameters

##### *parentName*
Type: [System.String][3]  
Name of the child's parent

##### *childName*
Type: [System.String][3]  
Name of the child

#### Return Value
Type: [Boolean][4]  
`true` if the defining collection is a choice; otherwise the collection of child's is defined as a sequence. 

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][2]  

[1]: Choices.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png