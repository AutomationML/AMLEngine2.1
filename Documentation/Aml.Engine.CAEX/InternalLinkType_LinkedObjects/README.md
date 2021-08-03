InternalLinkType.LinkedObjects Class
====================================
AutomationML 2.1 APIThis class allows accessing the related objects of an InternalLink without recalculation which improves the performance for consecutive access of the related objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.InternalLinkType.LinkedObjects**  

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class LinkedObjects
```

The **InternalLinkType.LinkedObjects** type exposes the following members.


Constructors
------------

                 | Name                                | Description                                                                
---------------- | ----------------------------------- | -------------------------------------------------------------------------- 
![Public method] | [InternalLinkType.LinkedObjects][3] | Initializes a new instance of the **InternalLinkType.LinkedObjects** class 


Properties
----------

                   | Name                   | Description                                                                                                                                                                                                                                                                                
------------------ | ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [AInterface][4]        | Gets the A-Interface of the InternalLink by interpretation of the [RefPartnerSideA][5] Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property [AInterface][6] is read or set.  
![Public property] | [ASystemUnitClass][7]  | Gets the A-SystemUnitClass using the preserved value [AInterface][4]. If this value has not been calculated, a recalculation is performed.                                                                                                                                                 
![Public property] | [BInterface][8]        | Gets the B-Interface of the InternalLink by interpretation of the [RefPartnerSideB][9] Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property [BInterface][10] is read or set. 
![Public property] | [BSystemUnitClass][11] | Gets the B-SystemUnitClass using the preserved value [BInterface][8]. If this value has not been calculated, a recalculation is performed.                                                                                                                                                 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: AInterface.md
[5]: ../InternalLinkType/RefPartnerSideA.md
[6]: ../InternalLinkType/AInterface.md
[7]: ASystemUnitClass.md
[8]: BInterface.md
[9]: ../InternalLinkType/RefPartnerSideB.md
[10]: ../InternalLinkType/BInterface.md
[11]: BSystemUnitClass.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"