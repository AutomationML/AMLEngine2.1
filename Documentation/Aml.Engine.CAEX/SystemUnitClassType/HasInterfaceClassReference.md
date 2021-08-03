SystemUnitClassType.HasInterfaceClassReference Method
=====================================================
AutomationML 2.1 APIDetermines whether this CAEX Element has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasInterfaceClassReference(
	InterfaceFamilyType interfaceClass,
	bool regardInheritance = false
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceFamilyType][2]  
The InterfaceClass object.

##### *regardInheritance* (Optional)
Type: [System.Boolean][3]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][3]  
`true` if this CAEX Element object has an associated reference to the specified InterfaceClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


Examples
--------
 This sample shows how to call the **HasInterfaceClassReference(InterfaceFamilyType, Boolean)** method using a standard base InterfaceClass from the [InterfaceClassLib(CAEXDocument)][5]
```csharp
var amlInterfaceClassLib = AutomationMLInterfaceClassLibType.InterfaceClassLib (myDocument);
InternalElementType internalElement;
...
internalElement.HasInterfaceClassReference (amlInterfaceClassLib.COLLADAInterface);
```


See Also
--------

#### Reference
[SystemUnitClassType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../InterfaceFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLibType/InterfaceClassLib.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png