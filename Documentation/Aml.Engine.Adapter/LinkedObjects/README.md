LinkedObjects Class
===================
AutomationML 2.1 API

**Note: This API is now obsolete.**
This class can be used to access InternalLink data.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Adapter.LinkedObjects**  

  **Namespace:**  [Aml.Engine.Adapter][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("The properties are all directly supported in the InternalLinkType itself.")]
public class LinkedObjects
```

The **LinkedObjects** type exposes the following members.


Constructors
------------

                 | Name               | Description                                                
---------------- | ------------------ | ---------------------------------------------------------- 
![Public method] | [LinkedObjects][3] | Initializes a new instance of the **LinkedObjects** class. 


Properties
----------

                   | Name                                  | Description                                                                
------------------ | ------------------------------------- | -------------------------------------------------------------------------- 
![Public property] | [InternalLink][4]                     | Gets or sets the Internal Link.                                            
![Public property] | [RefPartnerSideAElement][5]           | **Obsolete.**Gets the reference partner side A Internal Element.           
![Public property] | [RefPartnerSideAExternalInterface][6] | **Obsolete.**Gets or sets the reference partner side A External Interface. 
![Public property] | [RefPartnerSideBElement][7]           | **Obsolete.**Gets or sets the reference partner side b Internal Element.   
![Public property] | [RefPartnerSideBExternalInterface][8] | **Obsolete.**Gets or sets the reference partner side B External Interface. 


Methods
-------

                 | Name          | Description                                                                                
---------------- | ------------- | ------------------------------------------------------------------------------------------ 
![Public method] | [ToString][9] | Returns a [String][10] that represents this instance. (Overrides [Object.ToString()][11].) 


See Also
--------

#### Reference
[Aml.Engine.Adapter Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: InternalLink.md
[5]: RefPartnerSideAElement.md
[6]: RefPartnerSideAExternalInterface.md
[7]: RefPartnerSideBElement.md
[8]: RefPartnerSideBExternalInterface.md
[9]: ToString.md
[10]: https://docs.microsoft.com/dotnet/api/system.string
[11]: https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"