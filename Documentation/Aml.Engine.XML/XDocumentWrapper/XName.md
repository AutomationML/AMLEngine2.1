XDocumentWrapper.XName Method
=============================
Gets the correct XName for the provided element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema, no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the element name.

  **Namespace:**  [Aml.Engine.XML][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual XName XName(
	string tagname
)
```

#### Parameters

##### *tagname*
Type: [System.String][2]  
A Tag name which should be transformed to an XName.

#### Return Value
Type: [XName][3]  
The generated XName.

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | tag name  


See Also
--------

#### Reference
[XDocumentWrapper Class][5]  
[Aml.Engine.XML Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png