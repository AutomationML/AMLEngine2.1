InstanceHierarchyTypeExtensions.InternalElementDescendants Method
=================================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Gets all descendant [InternalElementType][1] Objects in the InstanceHierarchy. InternalElements on all levels are returned.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use instanceHierarchy.Descendants<InternalElementType> instead.")]
public static IEnumerable<InternalElementType> InternalElementDescendants(
	this InstanceHierarchyType instanceHierarchy
)
```

#### Parameters

##### *instanceHierarchy*
Type: [Aml.Engine.CAEX.InstanceHierarchyType][3]  
The InstanceHierarchy.

#### Return Value
Type: [IEnumerable][4]&lt;[InternalElementType][1]>  
 Enumeration of the InternalElement objects. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InstanceHierarchyType][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[InstanceHierarchyTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/InstanceHierarchyType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png