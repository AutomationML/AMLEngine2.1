ExternalInterfaceType.Remove Method
===================================
Removes this ExternalInterface. After that it is no longer assigned to a document and has no owner anymore. If this ExternalInterfaces has InternalLink relations, the InternalLink relations are removed too.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override void Remove(
	bool removeRelations = true
)
```

#### Parameters

##### *removeRelations* (Optional)
Type: [System.Boolean][2]  

[Missing &lt;param name="removeRelations"/> documentation for "M:Aml.Engine.CAEX.ExternalInterfaceType.Remove(System.Boolean)"]


#### Implements
[ICAEXWrapper.Remove(Boolean)][3]  
[ICAEXWrapper.Remove(Boolean)][3]  


See Also
--------

#### Reference
[ExternalInterfaceType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: ../ICAEXWrapper/Remove.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png