CaexCommand.OnCAEXElementChangedEvent Method
============================================
AutomationML 2.1 APIRaises the [CAEXElementChangedEvent][1] for the provided document.

  **Namespace:**  [Aml.Engine.CAEX.Commands][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void OnCAEXElementChangedEvent(
	XDocument document,
	CAEXElementChangeEventArgs args
)
```

#### Parameters

##### *document*
Type: [System.Xml.Linq.XDocument][3]  
The document.

##### *args*
Type: [Aml.Engine.CAEX.Commands.CAEXElementChangeEventArgs][4]  
The [CAEXElementChangeEventArgs][4] instance containing the event data.


See Also
--------

#### Reference
[CaexCommand Class][5]  
[Aml.Engine.CAEX.Commands Namespace][2]  

[1]: CAEXElementChangedEvent.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xdocument
[4]: ../CAEXElementChangeEventArgs/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png