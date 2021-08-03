XDocumentWrapper.Document Method (XElement)
===========================================
AutomationML 2.1 APIGets the XDocument wrapper which contains the specified XML node. If the node is not contained in an XML document, no document is returned.

  **Namespace:**  [Aml.Engine.XML][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IDocument Document(
	XElement node
)
```

#### Parameters

##### *node*
Type: [System.Xml.Linq.XElement][2]  
The XML node.

#### Return Value
Type: [IDocument][3]  
The XDocument wrapper, containing the XML node.

Exceptions
----------

Exception                  | Condition         
-------------------------- | ----------------- 
[ArgumentNullException][4] | XML node is null. 


See Also
--------

#### Reference
[XDocumentWrapper Class][5]  
[Aml.Engine.XML Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: ../IDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png