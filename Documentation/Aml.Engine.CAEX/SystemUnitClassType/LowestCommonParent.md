SystemUnitClassType.LowestCommonParent Method
=============================================
Gets the Lowest common parent to this SystemUnitClass and the provided SystemUnitClass. The common parent is used to store an InternalLink relating this two SystemUnitClass objects. An InternalLink is not allowed to leave the boundary of a SystemUnitClass which means, that no common parent is defined for two different SystemUnitClass objects. If one Element is a SystemUnitClass the other one should be an InternalElement descendant of the SystemUnitClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public SystemUnitClassType LowestCommonParent(
	SystemUnitClassType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The system unit class.

#### Return Value
Type: [SystemUnitClassType][2]  
the SystemUnitClass object which is the lowest common parent

Exceptions
----------

Exception                  | Condition       
-------------------------- | --------------- 
[ArgumentNullException][3] | systemUnitClass 


See Also
--------

#### Reference
[SystemUnitClassType Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png