CAEXElementChangeEventArgs Constructor (XElement, XElement, CAEXDocument, CAEXElementChangeMode)
================================================================================================
AutomationML 2.1 APIConstructs arguments for an element changing event

  **Namespace:**  [Aml.Engine.CAEX.Commands][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXElementChangeEventArgs(
	XElement caexElement,
	XElement caexParent,
	CAEXDocument document,
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

##### *changeMode*
Type: [Aml.Engine.CAEX.Commands.CAEXElementChangeMode][4]  
The change mode.


See Also
--------

#### Reference
[CAEXElementChangeEventArgs Class][5]  
[Aml.Engine.CAEX.Commands Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: ../CAEXElementChangeMode/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png