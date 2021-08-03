InternalElementType.HasGenericRoleClassReference Method (String)
================================================================
Determines whether this InternalElement object has an associated RoleClass reference which is a generalization of the specified CAEX path role reference.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasGenericRoleClassReference(
	string roleReference
)
```

#### Parameters

##### *roleReference*
Type: [System.String][2]  
The role reference.

#### Return Value
Type: [Boolean][3]  
`true` if this InternalElement object has an associated RoleClass reference which is a generalization of the specified CAEX path role reference; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition     
-------------------------- | ------------- 
[ArgumentNullException][4] | roleReference 


See Also
--------

#### Reference
[InternalElementType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png