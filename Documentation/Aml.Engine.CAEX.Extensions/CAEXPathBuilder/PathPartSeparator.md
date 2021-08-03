CAEXPathBuilder.PathPartSeparator Method (CAEXObject)
=====================================================
Returns the Path part separator for an element, which should be put before that element in a Path

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static char PathPartSeparator(
	CAEXObject element
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.CAEXObject][2]  
 The CAEX-Element.

#### Return Value
Type: [Char][3]  
 The Path Separation character for the given element 

Remarks
-------
 Since CAEX Version 3.0 the PathPartSeparator is element independent and always the [ObjectSeparator][4]. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.char
[4]: ObjectSeparator.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png