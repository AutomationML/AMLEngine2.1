ValueSequence&lt;TDataType>.ElementValueConverter&lt;T>.SetConverters Method
============================================================================
AutomationML 2.1 APISets custom value converters to support conversion from objects to user defined types.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void SetConverters(
	Func<XElement, T> convertFrom,
	Func<T, Object> convertTo
)
```

#### Parameters

##### *convertFrom*
Type: [System.Func][2]&lt;[XElement][3], [T][4]>  
The convert from.

##### *convertTo*
Type: [System.Func][2]&lt;[T][4], [Object][5]>  
The convert to.


See Also
--------

#### Reference
[ValueSequence&lt;TDataType>.ElementValueConverter&lt;T> Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.func-2
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: README.md
[5]: https://docs.microsoft.com/dotnet/api/system.object
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png