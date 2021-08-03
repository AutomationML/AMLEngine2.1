# AttributeFamilyType.GetReferenceHierarchy Method 
AutomationML 2.1 API 

Gets the reference (inheritance) hierarchy. The reference hierarchy includes this instance and the reference hierarchy of an associated <a href="P_Aml_Engine_CAEX_AttributeFamilyType_BaseClass">BaseClass</a> defining a class to class relation.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<AttributeFamilyType> GetReferenceHierarchy()
```

**VB**<br />
``` VB
Public Function GetReferenceHierarchy As IEnumerable(Of AttributeFamilyType)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<AttributeFamilyType^>^ GetReferenceHierarchy() sealed
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType</a>)<br />Collection, containing this instance and the reference hierarchy of a base class.

#### Implements
<a href="M_Aml_Engine_CAEX_IClassWithBaseClassReference_1_GetReferenceHierarchy">IClassWithBaseClassReference(T).GetReferenceHierarchy()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_AttributeFamilyType_GetReferenceHierarchy">GetReferenceHierarchy Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />