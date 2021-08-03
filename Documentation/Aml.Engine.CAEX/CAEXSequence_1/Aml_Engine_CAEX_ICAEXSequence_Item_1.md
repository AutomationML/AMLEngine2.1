CAEXSequence&lt;T>.ICAEXSequence.Item Property (ValueTuple&lt;String, String>)
==============================================================================
Gets the first CAEX object with a specific attribute value from the sequence of elements

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXWrapper ICAEXSequence.this[
	(string Name, string Value) attributeValuePair
] { get; }
```

#### Parameters

##### *attributeValuePair*
Type: [System.ValueTuple][2]&lt;[String][3], [String][3]>  
Pair of attribute name and attribute value

#### Return Value
Type: [ICAEXWrapper][4]  
the first CAEX object, which matches this condition.
#### Implements
[ICAEXSequence.Item[ValueTuple&lt;String, String>]][5]  


See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../ICAEXWrapper/README.md
[5]: ../ICAEXSequence/Item_1.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png