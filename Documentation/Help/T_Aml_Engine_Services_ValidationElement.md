# ValidationElement Class
AutomationML 2.1 API 

Class ValidationElement is a Tuple of an XElement and associated detailed Information about any inconsistencies, assigned with that Element.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.ValidationElement<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class ValidationElement : IValidationResult
```

**VB**<br />
``` VB
Public Class ValidationElement
	Implements IValidationResult
```

**C++**<br />
``` C++
public ref class ValidationElement : IValidationResult
```

The ValidationElement type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidationElement__ctor">ValidationElement</a></td><td>
Initializes a new instance of the ValidationElement class.</td></tr></table>&nbsp;
<a href="#validationelement-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_AvailableRepairOptions">AvailableRepairOptions</a></td><td>
Gets the available repair options.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_CAEXElement">CAEXElement</a></td><td>
Gets the CAEX element wrapper for the XElement.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_Element">Element</a></td><td>
Gets the element which has been validated.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_LongDescription">LongDescription</a></td><td>
Gets a longer description containing more detailed information about a validation issue. To get this information, the informative mode shall be enabled when the validation is performed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_RepairResult">RepairResult</a></td><td>
Gets information about the result of a repair operation for one element.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_ValidatedAttribute">ValidatedAttribute</a></td><td>
Gets or sets the validated attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_ValidationInformation">ValidationInformation</a></td><td>
Gets a short information about the validation of one element.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ValidationElement_ValidationType">ValidationType</a></td><td>
Gets the type of the validation.</td></tr></table>&nbsp;
<a href="#validationelement-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidationElement_Equals">Equals</a></td><td>
Determines whether the specified object is identical to the current object.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_parent" rel="noopener noreferrer">Object.Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidationElement_GetHashCode">GetHashCode</a></td><td>
Returns a hash code for this instance.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_parent" rel="noopener noreferrer">Object.GetHashCode()</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ValidationElement_ReValidate">ReValidate</a></td><td>
Checks the validation of the element</td></tr></table>&nbsp;
<a href="#validationelement-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_Services_ValidationElement_NOT_REPAIRED">NOT_REPAIRED</a></td><td>
constant string, defining validation elements which are yet not repaired.</td></tr></table>&nbsp;
<a href="#validationelement-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IValidationResult">Aml.Engine.Services.Interfaces.IValidationResult</a><br />