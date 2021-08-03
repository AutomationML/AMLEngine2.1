CAEXBasicObjectExtensions.FirstAncestor Method (ICAEXWrapper, Predicate&lt;ICAEXWrapper>)
=========================================================================================
AutomationML 2.1 APIFinds the first ancestor of the specified CAEX object which fulfils the specified predicate

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXWrapper FirstAncestor(
	this ICAEXWrapper caexObject,
	Predicate<ICAEXWrapper> predicate
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
The CAEX object.

##### *predicate*
Type: [System.Predicate][3]&lt;[ICAEXWrapper][2]>  
The condition for the ancestor object.

#### Return Value
Type: [CAEXWrapper][4]  
 First ancestor of the specified CAEX object or `null`, if no ancestor meeting the condition exists. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ICAEXWrapper][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][7] | caexObject 


See Also
--------

#### Reference
[CAEXBasicObjectExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ICAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.predicate-1
[4]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png