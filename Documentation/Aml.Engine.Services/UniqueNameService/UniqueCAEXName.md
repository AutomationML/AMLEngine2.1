UniqueNameService.UniqueCAEXName Method (XElement, String)
==========================================================
AutomationML 2.1 APICreates a unique CAEX Name for a child with the specified elementTagName in the specified sequence

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public string UniqueCAEXName(
	XElement sequence,
	string elementTagName
)
```

#### Parameters

##### *sequence*
Type: [System.Xml.Linq.XElement][2]  
The sequence of elements.

##### *elementTagName*
Type: [System.String][3]  
Name of the element tag.

#### Return Value
Type: [String][3]  
 a unique name using the registered default extended with an added number, representing the maximal number 
#### Implements
[IUniqueName.UniqueCAEXName(XElement, String)][4]  


Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][5] | elementTagName 


See Also
--------

#### Reference
[UniqueNameService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.Services.Interfaces/IUniqueName/UniqueCAEXName.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png