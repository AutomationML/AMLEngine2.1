SystemUnitClassType.AddInterfaceClassReference Method (InterfaceFamilyType, Boolean, Boolean, String)
=====================================================================================================
AutomationML 2.1 APIAdds an InterfaceClass reference to this SystemUnitClass object using the provided InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][1] object.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ExternalInterfaceType AddInterfaceClassReference(
	InterfaceFamilyType interfaceClass,
	bool addUnique = true,
	bool addInstance = false,
	string name = ""
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceFamilyType][3]  
The InterfaceClass to be assigned to the SystemUnitClass.

##### *addUnique* (Optional)
Type: [System.Boolean][4]  
 if set to `true`, the InterfaceClass reference is not added, if a reference to the provided InterfaceClass already exists.

##### *addInstance* (Optional)
Type: [System.Boolean][4]  
 if set to `true`, the reference is created as am instance of the InterfaceClass, containig all ExternalInterfaces and Attributes of the InterfaceClass.

##### *name* (Optional)
Type: [System.String][5]  
Provides the name for the new external interface.

#### Return Value
Type: [ExternalInterfaceType][1]  
 The new added InterfaceClass reference. 

Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][6] | interfaceClass 


Remarks
-------
 The default behaviour is, that only a reference to the interface class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the [CreateClassInstance()][7] and the [Insert(CAEXWrapper, Boolean)][8] methods. 

Examples
--------
 This sample shows how to call the **AddInterfaceClassReference(InterfaceFamilyType, Boolean, Boolean, String)** method using a standard base InterfaceClass from the [InterfaceClassLib(CAEXDocument)][9]
```csharp
var amlInterfaceClassLib = AutomationMLInterfaceClassLibType.InterfaceClassLib (myDocument);
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddInterfaceClassReference (amlInterfaceClassLib.AutomationMLBaseInterface);
```


See Also
--------

#### Reference
[SystemUnitClassType Class][10]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../ExternalInterfaceType/README.md
[2]: ../README.md
[3]: ../InterfaceFamilyType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: ../InterfaceFamilyType/CreateClassInstance.md
[8]: Insert.md
[9]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLibType/InterfaceClassLib.md
[10]: README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png