CAEXSequence&lt;T>.ICAEXSequence.Item Property (Int32)
======================================================
AutomationML 2.1 APIGets a wrapper for the CAEX element in this sequence at the given position

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXWrapper ICAEXSequence.this[
	int i
] { get; set; }
```

#### Parameters

##### *i*
Type: [System.Int32][2]  
index position of the element

#### Return Value
Type: [ICAEXWrapper][3]  
The created CAEX wrapper.
#### Implements
[ICAEXSequence.Item[Int32]][4]  


See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.int32
[3]: ../ICAEXWrapper/README.md
[4]: ../ICAEXSequence/Item.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png