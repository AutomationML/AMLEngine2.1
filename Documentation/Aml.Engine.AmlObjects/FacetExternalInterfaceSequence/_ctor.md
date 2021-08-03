FacetExternalInterfaceSequence Constructor
==========================================
AutomationML 2.1 APIInitializes a new instance of the [FacetExternalInterfaceSequence][1] class.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public FacetExternalInterfaceSequence(
	XElement owner,
	Func<XElement, ExternalInterfaceType> create
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][3]  
The owner.

##### *create*
Type: [System.Func][4]&lt;[XElement][3], [ExternalInterfaceType][5]>  
The constructor function to create an ExternalInterface object.


See Also
--------

#### Reference
[FacetExternalInterfaceSequence Class][1]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.func-2
[5]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png