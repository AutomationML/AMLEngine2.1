ICAEXWrapper.CAEXChildren Method
================================
AutomationML 2.1 APIGets all children of this CAEX object with the defined CAEX tag name.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<CAEXWrapper> CAEXChildren(
	string tagName
)
```

#### Parameters

##### *tagName*
Type: [System.String][2]  
The CAEX tag name of the child.

#### Return Value
Type: [IEnumerable][3]&lt;[CAEXWrapper][4]>  
The children, if existing; otherwise `Enumerable.Empty`.

See Also
--------

#### Reference
[ICAEXWrapper Interface][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../CAEXWrapper/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png