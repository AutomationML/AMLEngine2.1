ObjectWithExternalInterface.AddInterfaceClassReference Method (IObjectWithExternalInterface, InterfaceFamilyType, Boolean, Boolean, String)
===========================================================================================================================================
Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][1] object.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static ExternalInterfaceType AddInterfaceClassReference(
	this IObjectWithExternalInterface ObjectWithExternalInterface,
	InterfaceFamilyType interfaceClass,
	bool addUnique = true,
	bool addInstance = false,
	string name = ""
)
```

#### Parameters

##### *ObjectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][3]  


##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceFamilyType][4]  
The InterfaceClass to be assigned to the ObjectWithExternalInterface.

##### *addUnique* (Optional)
Type: [System.Boolean][5]  
 if set to `true`, the InterfaceClass reference is not added, if a reference to the provided InterfaceClass already exists.

##### *addInstance* (Optional)
Type: [System.Boolean][5]  
 if set to `true`, the reference is created as am instance of the InterfaceClass, containing all ExternalInterfaces and Attributes of the InterfaceClass.

##### *name* (Optional)
Type: [System.String][6]  
Provides the name for the new external interface. If no name is given, the name is taken from the referenced class.

#### Return Value
Type: [ExternalInterfaceType][1]  
 The new added InterfaceClass reference. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][9] | interfaceClass 


Remarks
-------
 The default behaviour is, that only a reference to the interface class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the [CreateClassInstance()][10] and the CAEXSequenceOfCAEXObjects Insert(CAEXWrapper, bool) methods. 

Examples
--------
 This sample shows how to call the **AddInterfaceClassReference(IObjectWithExternalInterface, InterfaceFamilyType, Boolean, Boolean, String)** method using a standard base InterfaceClass from the [InterfaceClassLib(CAEXDocument)][11]
```csharp
var amlInterfaceClassLib = AutomationMLInterfaceClassLibType.InterfaceClassLib (myDocument);
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddInterfaceClassReference (amlInterfaceClassLib.AutomationMLBaseInterface);
```


See Also
--------

#### Reference
[ObjectWithExternalInterface Class][12]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[4]: ../../Aml.Engine.CAEX/InterfaceFamilyType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/api/system.string
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[10]: ../../Aml.Engine.CAEX/InterfaceFamilyType/CreateClassInstance.md
[11]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLibType/InterfaceClassLib.md
[12]: README.md
[13]: https://www.automationml.org
[14]: ../../icons/logoShade.png