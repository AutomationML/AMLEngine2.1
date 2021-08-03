RoleRequirementsType.AssignQualifiedRoleClassAttribute Method
=============================================================
This method supports the Multiple Roles concept in AutomationML 2.0, based on CAEX 2.15. The method is not applicable for documents, based on CAEX 3.0 and later. It tests, if the provided Attribute object is a role class attribute of a supported role class object which can be used in a Multiple role mapping and assigns it to this RoleRequirements instance.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AttributeType AssignQualifiedRoleClassAttribute(
	AttributeType attribute
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The tested attribute.

#### Return Value
Type: [AttributeType][2]  
 the newly created and assigned Attribute, if the Attribute object is assigned to the role class interface; otherwise, `null`. 

See Also
--------

#### Reference
[RoleRequirementsType Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../AttributeType/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png