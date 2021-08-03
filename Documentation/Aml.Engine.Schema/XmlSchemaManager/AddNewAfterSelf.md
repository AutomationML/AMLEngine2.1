XmlSchemaManager.AddNewAfterSelf Method
=======================================
AutomationML 2.1 APICreates a new Xml-Element with the provided content and inserts it behind the provided sibling according to this schema instance.

  **Namespace:**  [Aml.Engine.Schema][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual XElement AddNewAfterSelf(
	XElement siblingBefore,
	XName childName,
	Object content
)
```

#### Parameters

##### *siblingBefore*
Type: [System.Xml.Linq.XElement][2]  
the sibling of the new added element.

##### *childName*
Type: [System.Xml.Linq.XName][3]  
the name of the new added element.

##### *content*
Type: [System.Object][4]  
the content of the new added element.

#### Return Value
Type: [XElement][2]  
The created XML element.

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png