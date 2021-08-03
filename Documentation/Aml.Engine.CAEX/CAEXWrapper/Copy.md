CAEXWrapper.Copy Method
=======================
Creates a deep copy of this CAEX object

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual CAEXWrapper Copy(
	bool deepCopy = true,
	bool assignNewIDs = true,
	bool includeSubClasses = false
)
```

#### Parameters

##### *deepCopy* (Optional)
Type: [System.Boolean][2]  
 if set to `true` a deep copy is created; otherwise only the attributes are included in the copy.

##### *assignNewIDs* (Optional)
Type: [System.Boolean][2]  
 if set to `true` all IDs, defined in the Node and the descendants get new IDs.

##### *includeSubClasses* (Optional)
Type: [System.Boolean][2]  
 if set to `true` sub classes of SystemUnitClasses, InterfacesClasses, RoleClasses and AttributeTypes are included in the copy. The default value is `false`.

#### Return Value
Type: [CAEXWrapper][3]  
 The copied CAEX object. 

See Also
--------

#### Reference
[CAEXWrapper Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png