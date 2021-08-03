UniqueNameService.UniqueCAEXName Method (XElement, String, String)
==================================================================
AutomationML 2.1 APICreates a unique CAEX Name for a child with the specified elementTagName in the specified sequence using the specified defaultName

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public string UniqueCAEXName(
	XElement sequence,
	string elementTagName,
	string defaultName
)
```

#### Parameters

##### *sequence*
Type: [System.Xml.Linq.XElement][2]  
The sequence.

##### *elementTagName*
Type: [System.String][3]  
Name of the element tag.

##### *defaultName*
Type: [System.String][3]  
The default name.

#### Return Value
Type: [String][3]  
 a unique name using the registered default extended with an added number, representing the maximal number 
#### Implements
[IUniqueName.UniqueCAEXName(XElement, String, String)][4]  


Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][5] | elementTagName 
[ArgumentNullException][5] | elementTagName 


See Also
--------

#### Reference
[UniqueNameService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.Services.Interfaces/IUniqueName/UniqueCAEXName_1.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png