MappingElementType&lt;T>.AddRoleClassElement Method
===================================================
This method is an extension to the [RoleClassElement][1] setter in case of MultipleRole assignments in AutomationML 2.0 based on CAEX 2.15. The method can assign a qualified RoleClassElement as a mapping element and will eventually create a missing RoleRequirement element for the qualified element. For Documents, based on CAEX 3.0 the behaviour of this method is identical to the [RoleClassElement][1] setter.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void AddRoleClassElement(
	T element
)
```

#### Parameters

##### *element*
Type: [T][3]  
The element.


See Also
--------

#### Reference
[MappingElementType&lt;T> Class][3]  
[Aml.Engine.CAEX Namespace][2]  

[1]: RoleClassElement.md
[2]: ../README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png