CAEXElementChangeEventArgs Constructor (XElement, XElement, CAEXDocument, XAttribute, String, Object, Object, CAEXElementChangeMode)
====================================================================================================================================
Constructs arguments for an element's attribute changing event

  **Namespace:**  [Aml.Engine.CAEX.Commands][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXElementChangeEventArgs(
	XElement caexElement,
	XElement caexParent,
	CAEXDocument document,
	XAttribute attribute,
	string attributeName,
	Object oldValue,
	Object newValue,
	CAEXElementChangeMode changeMode
)
```

#### Parameters

##### *caexElement*
Type: [System.Xml.Linq.XElement][2]  
The CAEX element.

##### *caexParent*
Type: [System.Xml.Linq.XElement][2]  
The CAEX parent.

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *attribute*
Type: [System.Xml.Linq.XAttribute][4]  
The attribute.

##### *attributeName*
Type: [System.String][5]  
Name of the attribute.

##### *oldValue*
Type: [System.Object][6]  
The old value.

##### *newValue*
Type: [System.Object][6]  
The new value.

##### *changeMode*
Type: [Aml.Engine.CAEX.Commands.CAEXElementChangeMode][7]  
The change mode.


See Also
--------

#### Reference
[CAEXElementChangeEventArgs Class][8]  
[Aml.Engine.CAEX.Commands Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xattribute
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://docs.microsoft.com/dotnet/api/system.object
[7]: ../CAEXElementChangeMode/README.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png