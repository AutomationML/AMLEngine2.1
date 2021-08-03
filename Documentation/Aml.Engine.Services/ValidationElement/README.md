ValidationElement Class
=======================
AutomationML 2.1 APIClass ValidationElement is a Tuple of an XElement and associated detailed Information about any inconsistencies, assigned with that Element.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.ValidationElement**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class ValidationElement : IValidationResult
```

The **ValidationElement** type exposes the following members.


Constructors
------------

                 | Name                   | Description                                                    
---------------- | ---------------------- | -------------------------------------------------------------- 
![Public method] | [ValidationElement][3] | Initializes a new instance of the **ValidationElement** class. 


Properties
----------

                   | Name                        | Description                                                                                                                                                                               
------------------ | --------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [AvailableRepairOptions][4] | Gets the available repair options.                                                                                                                                                        
![Public property] | [CAEXElement][5]            | Gets the CAEX element wrapper for the XElement.                                                                                                                                           
![Public property] | [Element][6]                | Gets the element which has been validated.                                                                                                                                                
![Public property] | [LongDescription][7]        | Gets a longer description containing more detailed information about a validation issue. To get this information, the informative mode shall be enabled when the validation is performed. 
![Public property] | [RepairResult][8]           | Gets information about the result of a repair operation for one element.                                                                                                                  
![Public property] | [ValidatedAttribute][9]     | Gets or sets the validated attribute.                                                                                                                                                     
![Public property] | [ValidationInformation][10] | Gets a short information about the validation of one element.                                                                                                                             
![Public property] | [ValidationType][11]        | Gets the type of the validation.                                                                                                                                                          


Methods
-------

                 | Name              | Description                                                                                                          
---------------- | ----------------- | -------------------------------------------------------------------------------------------------------------------- 
![Public method] | [Equals][12]      | Determines whether the specified object is identical to the current object. (Overrides [Object.Equals(Object)][13].) 
![Public method] | [GetHashCode][14] | Returns a hash code for this instance. (Overrides [Object.GetHashCode()][15].)                                       
![Public method] | [ReValidate][16]  | Checks the validation of the element                                                                                 


Fields
------

                                | Name               | Description                                                               
------------------------------- | ------------------ | ------------------------------------------------------------------------- 
![Public field]![Static member] | [NOT_REPAIRED][17] | constant string, defining validation elements which are yet not repaired. 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IValidationResult][18]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: AvailableRepairOptions.md
[5]: CAEXElement.md
[6]: Element.md
[7]: LongDescription.md
[8]: RepairResult.md
[9]: ValidatedAttribute.md
[10]: ValidationInformation.md
[11]: ValidationType.md
[12]: Equals.md
[13]: https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_
[14]: GetHashCode.md
[15]: https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode
[16]: ReValidate.md
[17]: NOT_REPAIRED.md
[18]: ../../Aml.Engine.Services.Interfaces/IValidationResult/README.md
[19]: https://www.automationml.org
[20]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public field]: ../../icons/pubfield.gif "Public field"
[Static member]: ../../icons/static.gif "Static member"