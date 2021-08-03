StringExtensions Class
======================
Extension methods for string type CAEX attributes (i.e. GUID, Path, etc.)


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.StringExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class StringExtensions
```

The **StringExtensions** type exposes the following members.


Methods
-------

                                 | Name                              | Description                                                                                                               
-------------------------------- | --------------------------------- | ------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [IsClassReference][3]             | Determines whether the specified attribute is an attribute, containing a class reference.                                 
![Public method]![Static member] | [IsGUID][4]                       | string extension method to check if it as GUID                                                                            
![Public method]![Static member] | [IsInterfacePath][5]              | Determines whether the specified path is an interface path.                                                               
![Public method]![Static member] | [IsInterfacePathWithID][6]        | Determines whether the specified path is an interface path containing an ID                                               
![Public method]![Static member] | [IsInterfacePathWithInterface][7] | Determines whether the specified path is an interface path with this interface name.                                      
![Public method]![Static member] | [NormalizedGUID][8]               | String extension method to normalize a GUID. If the string cannot be identified as a GUID the original string is returned 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IsClassReference.md
[4]: IsGUID.md
[5]: IsInterfacePath.md
[6]: IsInterfacePathWithID.md
[7]: IsInterfacePathWithInterface.md
[8]: NormalizedGUID.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"