FrameAttributeType Constructor (XElement, FrameValues)
======================================================
Initializes a new instance of the [FrameAttributeType][1] class. It is not checked, if the provided attribute Node represents a valid Frame attribute. If Frame attributes exist, they are initialized using the specified frame values.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public FrameAttributeType(
	XElement init,
	FrameValues frameValues
)
```

#### Parameters

##### *init*
Type: [System.Xml.Linq.XElement][3]  
The initialize.

##### *frameValues*
Type: [Aml.Engine.AmlObjects.FrameValues][4]  
The frame values.


See Also
--------

#### Reference
[FrameAttributeType Class][1]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: ../FrameValues/README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png