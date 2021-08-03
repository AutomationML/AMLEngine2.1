CAEXSequence&lt;T> Constructor
==============================
AutomationML 2.1 APICreates a new instance of the CAEXSequencce for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXSequence(
	XElement owner,
	string caexName,
	Func<XElement, T> create
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][2]  
The owner

##### *caexName*
Type: [System.String][3]  
CAEX-Name of the items in this sequence

##### *create*
Type: [System.Func][4]&lt;[XElement][2], [T][5]>  
The constructor function


See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.func-2
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png