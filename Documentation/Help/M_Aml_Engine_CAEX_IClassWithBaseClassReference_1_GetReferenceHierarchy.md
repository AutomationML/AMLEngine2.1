# IClassWithBaseClassReference(*T*).GetReferenceHierarchy Method 
AutomationML 2.1 API 

Gets the reference hierarchy for all class to class relations, starting with this class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<T> GetReferenceHierarchy()
```

**VB**<br />
``` VB
Function GetReferenceHierarchy As IEnumerable(Of T)
```

**C++**<br />
``` C++
IEnumerable<T>^ GetReferenceHierarchy()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference_1">*T*</a>)<br />A collection, containing this class and the reference hierarchy of the base class, if existing.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference_1">IClassWithBaseClassReference(T) Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />