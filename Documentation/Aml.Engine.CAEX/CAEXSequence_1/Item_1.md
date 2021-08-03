CAEXSequence&lt;T>.Item Property (ValueTuple&lt;String, String>)
================================================================
AutomationML 2.1 APIGets the first CAEX object with a specific attribute value from the sequence of elements

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public T this[
	(string Name, string Value) attributeValuePair
] { get; }
```

#### Parameters

##### *attributeValuePair*
Type: [System.ValueTuple][2]&lt;[String][3], [String][3]>  
Pair of attribute name and attribute value

#### Return Value
Type: [T][4]  
the first CAEX object, which matches this condition.

See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png