# LookupService.IsAutoUpdateEnabled Property 
AutomationML 2.1 API 

Gets or sets a value indicating whether this instance will automatically update cross references between AutomationML objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsAutoUpdateEnabled { get; set; }
```

**VB**<br />
``` VB
Public Property IsAutoUpdateEnabled As Boolean
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property bool IsAutoUpdateEnabled {
	bool get () sealed;
	void set (bool value) sealed;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the automatic update is enabled; otherwise, `false`.

#### Implements
<a href="P_Aml_Engine_Services_Interfaces_IAutoUpdate_IsAutoUpdateEnabled">IAutoUpdate.IsAutoUpdateEnabled</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_LookupService">LookupService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />