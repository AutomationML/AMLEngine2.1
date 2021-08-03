InternalLinkType.New_InternalLink Method
========================================
AutomationML 2.1 APICreates a new InternalLink object and append it to the lowest common parent of the SystemUnitClass objects, associated with the provided ExternalInterface objects. If no common parent exists, the InternalLink will be associated with the owner of the *aInterface*.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InternalLinkType New_InternalLink(
	ExternalInterfaceType aInterface,
	ExternalInterfaceType bInterface,
	string name
)
```

#### Parameters

##### *aInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The ExternalInterface object, representing the A-Side of the relation.

##### *bInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The ExternalInterface object, representing the B-Side of the relation.

##### *name*
Type: [System.String][3]  
The name for the InternalLink

#### Return Value
Type: [InternalLinkType][4]  
The newly created InternalLink object.

Exceptions
----------

Exception                      | Condition                                                                             
------------------------------ | ------------------------------------------------------------------------------------- 
[ArgumentNullException][5]     | If AInterface or BInterface is null                                                   
[CAEXException][6]             | One of the provided ExternalInterface objects is not associated to a SystemUnitClass. 
[InvalidOperationException][7] | It is not allowed to link an ExternalInterface to itself.                             


See Also
--------

#### Reference
[InternalLinkType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: ../CAEXException/README.md
[7]: https://docs.microsoft.com/dotnet/api/system.invalidoperationexception
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png