ObjectWithExternalInterface.AddInterfaceClassReference Method (IObjectWithExternalInterface, String, Boolean, Boolean, String)
==============================================================================================================================
Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a [ExternalInterfaceType][1] object.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static ExternalInterfaceType AddInterfaceClassReference(
	this IObjectWithExternalInterface ObjectWithExternalInterface,
	string interfaceClassReference,
	bool addUnique = true,
	bool addInstance = false,
	string name = ""
)
```

#### Parameters

##### *ObjectWithExternalInterface*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][3]  


##### *interfaceClassReference*
Type: [System.String][4]  
 The CAEX path referencing a InterfaceClass to be assigned to the ObjectWithExternalInterface.

##### *addUnique* (Optional)
Type: [System.Boolean][5]  
 if set to `true` the reference is not added, if the same reference already exists.

##### *addInstance* (Optional)
Type: [System.Boolean][5]  
 if set to `true`, the reference is created as an instance of the InterfaceClass, identified by the provided interfaceClassReference, containing all ExternalInterfaces and Attributes of the InterfaceClass.

##### *name* (Optional)
Type: [System.String][4]  
Provides the name for the new external interface. If no name is provided, the name is taken from the referenced class.

#### Return Value
Type: [ExternalInterfaceType][1]  
 The new added InterfaceClass reference. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

Exceptions
----------

Exception                  | Condition               
-------------------------- | ----------------------- 
[ArgumentNullException][8] | interfaceClassReference 


Remarks
-------
 The default behaviour is, that only a reference to the interface class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the [CreateClassInstance()][9] and the CAEXSequenceOfCAEXObjects Insert(CAEXWrapper, bool) methods, 

Examples
--------
 This sample shows how to call the **AddInterfaceClassReference(IObjectWithExternalInterface, String, Boolean, Boolean, String)** method using a standard InterfaceClass path defined in the [AutomationMLInterfaceClassLib][10]
```csharp
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddInterfaceClassReference (AutomationMLInterfaceClassLib.AutomationMLBaseInterface);
```


See Also
--------

#### Reference
[ObjectWithExternalInterface Class][11]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[9]: ../../Aml.Engine.CAEX/InterfaceFamilyType/CreateClassInstance.md
[10]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/README.md
[11]: README.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png