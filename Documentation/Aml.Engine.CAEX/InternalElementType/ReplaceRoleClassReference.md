InternalElementType.ReplaceRoleClassReference Method
====================================================
AutomationML 2.1 APIReplaces an existing role class reference to the provided role or any generic base role of the provided role by a new instance of the role class.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IObjectWithRoleReference ReplaceRoleClassReference(
	RoleFamilyType roleClass,
	bool addSupportedRoleClass = false
)
```

#### Parameters

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][2]  
The role class.

##### *addSupportedRoleClass* (Optional)
Type: [System.Boolean][3]  
if set to `true` a supported role class is created.

#### Return Value
Type: [IObjectWithRoleReference][4]  

[Missing &lt;returns> documentation for "M:Aml.Engine.CAEX.InternalElementType.ReplaceRoleClassReference(Aml.Engine.CAEX.RoleFamilyType,System.Boolean)"]


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][5] | roleClass 
[ArgumentNullException][5] | roleClass 


See Also
--------

#### Reference
[InternalElementType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../RoleFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../IObjectWithRoleReference/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png