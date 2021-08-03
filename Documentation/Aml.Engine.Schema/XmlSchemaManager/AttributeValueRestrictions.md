XmlSchemaManager.AttributeValueRestrictions Method
==================================================
AutomationML 2.1 APIGets the List of Attribute value restrictions for the attribute with the defined name. The Attribute should be an attribute of a child defined by the given name, which exists in the defined parent child relation defined by the parent name.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<Object> AttributeValueRestrictions(
	XName parentName,
	XName childName,
	string attributeName
)
```

#### Parameters

##### *parentName*
Type: [System.Xml.Linq.XName][2]  
The name of the child's parent

##### *childName*
Type: [System.Xml.Linq.XName][2]  
the name of the child (owner of the attribute)

##### *attributeName*
Type: [System.String][3]  
Name of the attribute.

#### Return Value
Type: [IEnumerable][4]&lt;[Object][5]>  
 list of restrictions for an attribute value - object type has to be interpreted by the caller 

See Also
--------

#### Reference
[XmlSchemaManager Class][6]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/api/system.object
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png