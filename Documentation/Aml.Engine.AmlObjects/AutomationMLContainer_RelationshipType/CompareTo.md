AutomationMLContainer.RelationshipType.CompareTo Method
=======================================================
AutomationML 2.1 APICompares the current instance's name to another object's name of the same type and returns an integer indicating whether the current instance's name occurs in the sort order before or after the other object or at the same position.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public int CompareTo(
	AutomationMLContainer.RelationshipType other
)
```

#### Parameters

##### *other*
Type: [Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType][2]  
An object to compare with this instance.

#### Return Value
Type: [Int32][3]  
 A value indicating the relative order of the objects being compared. The return value has the following meaning: Less than zero: This instance is in the sort order before *other*. Zero: This instance occurs in the sort order at the same position as *other*. Greater than zero: This instance follows in the sort order*other*. 
#### Implements
[IComparable&lt;T>.CompareTo(T)][4]  


See Also
--------

#### Reference
[AutomationMLContainer.RelationshipType Class][2]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: https://docs.microsoft.com/dotnet/api/system.int32
[4]: https://docs.microsoft.com/dotnet/api/system.icomparable-1.compareto#System_IComparable_1_CompareTo__0_
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png