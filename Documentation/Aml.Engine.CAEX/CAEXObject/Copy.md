CAEXObject.Copy Method
======================
AutomationML 2.1 APICreates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override CAEXWrapper Copy(
	bool deepCopy = true,
	bool assignNewIDs = true,
	bool includeSubClasses = false
)
```

#### Parameters

##### *deepCopy* (Optional)
Type: [System.Boolean][2]  
 if set to `true` a deep copy is created; otherwise only the attributes are included in the copy. The default value is `true`.

##### *assignNewIDs* (Optional)
Type: [System.Boolean][2]  
 if set to `true` all elements with IDs get unique IDs and the ID references will be updated. The default value is `true`.

##### *includeSubClasses* (Optional)
Type: [System.Boolean][2]  
 if set to `true` sub classes of SystemUnitClasses, InterfacesClasses, RoleClasses and AttributeTypes are included in the copy. The default value is `false`.

#### Return Value
Type: [CAEXWrapper][3]  
 A copy of this CAEX object with unique IDs. 

See Also
--------

#### Reference
[CAEXObject Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: ../CAEXWrapper/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png