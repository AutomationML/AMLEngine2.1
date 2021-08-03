# AttributeFamilyType.GetReferenceHierarchy(*T*) Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets the reference (inheritance) hierarchy. The reference hierarchy includes this instance and the reference hierarchy of an associated <a href="P_Aml_Engine_CAEX_AttributeFamilyType_BaseClass">BaseClass</a> defining a class to class relation.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the GetReferenceHierarchy returning IEnumerable instead.")]
public Queue<T> GetReferenceHierarchy<T>()
where T : IClassWithBaseClassReference

```

**VB**<br />
``` VB
<ObsoleteAttribute("Use the GetReferenceHierarchy returning IEnumerable instead.")>
Public Function GetReferenceHierarchy(Of T As IClassWithBaseClassReference) As Queue(Of T)
```

**C++**<br />
``` C++
public:
[ObsoleteAttribute(L"Use the GetReferenceHierarchy returning IEnumerable instead.")]
generic<typename T>
where T : IClassWithBaseClassReference
virtual Queue<T>^ GetReferenceHierarchy() sealed
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Type of the CAEX class.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.queue-1" target="_parent" rel="noopener noreferrer">Queue</a>(*T*)<br />Queue, containing this instance at the first element, followed by the reference hierarchy of a base class.

#### Implements
<a href="M_Aml_Engine_CAEX_IClassWithBaseClassReference_GetReferenceHierarchy__1">IClassWithBaseClassReference.GetReferenceHierarchy(T)()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_AttributeFamilyType_GetReferenceHierarchy">GetReferenceHierarchy Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />