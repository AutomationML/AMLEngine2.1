CAEXWrapper.CAEXChildren Method
===============================
Gets all children of this CAEX object with the defined CAEX tag name.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<CAEXWrapper> CAEXChildren(
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
#### Implements
[ICAEXWrapper.CAEXChildren(String)][5]  


See Also
--------

#### Reference
[CAEXWrapper Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: README.md
[5]: ../ICAEXWrapper/CAEXChildren.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png