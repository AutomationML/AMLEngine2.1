XmlSchemaManager.ChildElementNames Method
=========================================
AutomationML 2.1 APIGets the Names for all elements, which can be added to the child which is defined with the name of it's parent and the name of itself.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<XName> ChildElementNames(
	XName parentName,
	XName childName,
	bool includeChoice
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
Name of the child's parent.

##### *childName*
Type: [System.Xml.Linq.XName][2]  
Name of the child

##### *includeChoice*
Type: [System.Boolean][3]  
if set to `true` [include choice].

#### Return Value
Type: [IEnumerable][4]&lt;[XName][2]>  
Enumeration of all names of possible child elements.

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png