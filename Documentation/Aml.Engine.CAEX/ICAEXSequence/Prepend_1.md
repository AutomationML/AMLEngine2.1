ICAEXSequence.Prepend Method (ValueTuple&lt;String, Object>[])
==============================================================
AutomationML 2.1 APICreates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXWrapper Prepend(
	params (string , Object )[] attributeValueTuples
)
```

#### Parameters

##### *attributeValueTuples*
Type: [System.ValueTuple][2]&lt;[String][3], [Object][4]>[]  
The attribute value tuples.

#### Return Value
Type: [ICAEXWrapper][5]  
The created CAEX object.

See Also
--------

#### Reference
[ICAEXSequence Interface][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: ../ICAEXWrapper/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png