SystemUnitClassType.AddInterfaceClassReference Method (String, Boolean, Boolean, String)
========================================================================================
Adds an InterfaceClass reference to this SystemUnitClass object using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][1] object.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType AddInterfaceClassReference(
	string interfaceClassReference,
	bool addUnique = true,
	bool addInstance = false,
	string name = ""
)
```

#### Parameters

##### *interfaceClassReference*
Type: [System.String][3]  
 The CAEX path referencing a InterfaceClass to be assigned to the SystemUnitClass.

##### *addUnique* (Optional)
Type: [System.Boolean][4]  
 if set to `true` the reference is not added, if the same reference already exists.

##### *addInstance* (Optional)
Type: [System.Boolean][4]  
 if set to `true`, the reference is created as an instance of the InterfaceClass, identified by the provided interfaceClassReference, containing all ExternalInterfaces and Attributes of the InterfaceClass.

##### *name* (Optional)
Type: [System.String][3]  
Provides the name for the new external interface.

#### Return Value
Type: [ExternalInterfaceType][1]  
 The new added InterfaceClass reference. 

Exceptions
----------

Exception                  | Condition               
-------------------------- | ----------------------- 
[ArgumentNullException][5] | interfaceClassReference 


Remarks
-------
 The default behaviour is, that only a reference to the interface class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the [CreateClassInstance()][6] and the [Insert(CAEXWrapper, Boolean)][7] methods, 

Examples
--------
 This sample shows how to call the **AddInterfaceClassReference(String, Boolean, Boolean, String)** method using a standard InterfaceClass path defined in the [AutomationMLInterfaceClassLib][8]
```csharp
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddInterfaceClassReference (AutomationMLInterfaceClassLib.AutomationMLBaseInterface);
```


See Also
--------

#### Reference
[SystemUnitClassType Class][9]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../ExternalInterfaceType/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: ../InterfaceFamilyType/CreateClassInstance.md
[7]: Insert.md
[8]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/README.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png