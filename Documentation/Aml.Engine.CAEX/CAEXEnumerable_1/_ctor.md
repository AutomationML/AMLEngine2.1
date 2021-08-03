CAEXEnumerable&lt;T> Constructor (CAEXSequence&lt;T>, IEnumerable&lt;XElement>)
===============================================================================
Creates a new instance for a CAEXEnumerable with an associated CAEXSequence.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXEnumerable(
	CAEXSequence<T> sequence,
	IEnumerable<XElement> elements
)
```

#### Parameters

##### *sequence*
Type: [Aml.Engine.CAEX.CAEXSequence][2]&lt;[T][3]>  
 The CAEXSequence containing the Xml-Element collection. If `null`, the specified Xml-Element collection is not associated with a CAEXSequence.

##### *elements*
Type: [System.Collections.Generic.IEnumerable][4]&lt;[XElement][5]>  
 The Xml-Element collection. If not associated to a CAEXSequence the specified sequence should be set to `null`.


See Also
--------

#### Reference
[CAEXEnumerable&lt;T> Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../CAEXSequence_1/README.md
[3]: README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png