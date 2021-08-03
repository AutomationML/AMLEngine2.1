CAEXSequenceOfCAEXObjects&lt;T> Constructor (XElement, String, Func&lt;XElement, T>, Predicate&lt;XElement>)
============================================================================================================
AutomationML 2.1 APIInitializes a new instance of the [CAEXSequenceOfCAEXObjects&lt;T>][1] class with condition.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXSequenceOfCAEXObjects(
	XElement owner,
	string caexName,
	Func<XElement, T> create,
	Predicate<XElement> condition
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][3]  


##### *caexName*
Type: [System.String][4]  


##### *create*
Type: [System.Func][5]&lt;[XElement][3], [T][1]>  


##### *condition*
Type: [System.Predicate][6]&lt;[XElement][3]>  



See Also
--------

#### Reference
[CAEXSequenceOfCAEXObjects&lt;T> Class][1]  
[Aml.Engine.CAEX Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.func-2
[6]: https://docs.microsoft.com/dotnet/api/system.predicate-1
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png