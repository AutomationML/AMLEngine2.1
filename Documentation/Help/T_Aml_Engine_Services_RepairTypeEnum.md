# RepairTypeEnum Enumeration
AutomationML 2.1 API 

Enumeration RepairTypeEnum

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[FlagsAttribute]
public enum RepairTypeEnum
```

**VB**<br />
``` VB
<FlagsAttribute>
Public Enumeration RepairTypeEnum
```

**C++**<br />
``` C++
[FlagsAttribute]
public enum class RepairTypeEnum
```


## Members
&nbsp;<table><tr><th></th><th>Member name</th><th>Value</th><th>Description</th></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.IDDefinitionOption">**IDDefinitionOption**</td><td>8197</td><td>The options which are related to ID validation issues</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.NameDefinitionOption">**NameDefinitionOption**</td><td>136</td><td>The options which are related to Name validation issues</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.IDReferenceOption">**IDReferenceOption**</td><td>32</td><td>The options which are related to ID reference validation issues</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.PathReferenceOption">**PathReferenceOption**</td><td>64</td><td>The options which are related to Path reference validation issues</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.GenerateUniqueIDWhenEmpty">**GenerateUniqueIDWhenEmpty**</td><td>1</td><td>This Flag cause the generation of a unique ID for all Empty IDs</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.GenerateUniqueIDForDoubles">**GenerateUniqueIDForDoubles**</td><td>4</td><td>This Flag cause the generation of a unique ID for all Double IDs</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.GenerateNameWhenEmpty">**GenerateNameWhenEmpty**</td><td>8</td><td>This Flag cause the renaming of all empty Names with an automatic name generation algorithm. To apply this method, a <a href="T_Aml_Engine_Services_UniqueNameService">UniqueNameService</a> has to be registered,</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveEmptyReference">**RemoveEmptyReference**</td><td>16</td><td>This Flag cause the removal of all references where the Reference Value is empty</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveUnresolvedIDReference">**RemoveUnresolvedIDReference**</td><td>32</td><td>This Flag cause the removal of all ID References where the ID Value has not been resolved</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveUnresolvedPathReference">**RemoveUnresolvedPathReference**</td><td>64</td><td>This Flag cause the removal of all Path References where the Path reference Value has not been resolved</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RenameClassPathForDoubles">**RenameClassPathForDoubles**</td><td>128</td><td>This Flag cause the generation of a new name for an element, when it's CAEX-Path is double so that the Path is unique. To apply this method, a <a href="T_Aml_Engine_Services_UniqueNameService">UniqueNameService</a> has to be registered.</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.CreateWriterHeader">**CreateWriterHeader**</td><td>256</td><td>This Flag cause the generation of a writer header</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.CreateAutomationMLVersion">**CreateAutomationMLVersion**</td><td>512</td><td>This Flag cause the generation of an AutomationML Version header</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.SetSchemaVersion">**SetSchemaVersion**</td><td>2048</td><td>This Flag cause the correction of the Schema Version</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.GenerateValidGUID">**GenerateValidGUID**</td><td>8192</td><td>This Flag cause the generation of a new GUID for existing GUID's with invalid formats</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveAlias">**RemoveAlias**</td><td>32768</td><td>This Flag cause the generation of a new reference without the alias</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.CreateSourceDocumentInformation">**CreateSourceDocumentInformation**</td><td>131072</td><td>This Flag cause the generation of source document information</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveElement">**RemoveElement**</td><td>262144</td><td>This Flag cause the deletion of an element</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveElementNotInScope">**RemoveElementNotInScope**</td><td>524288</td><td>This Flag cause the deletion of an element which reference an element out of the allowed scope.</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.ChangeFileURL">**ChangeFileURL**</td><td>1048576</td><td>This Flag cause the generation of a valid file URL in an ExternalDataConnector to a localized file.</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.RemoveUnresolvedNameReference">**RemoveUnresolvedNameReference**</td><td>2097152</td><td>This Flag cause the removal of all Name References where the Name reference Value has not been resolved</td></tr><tr><td /><td target="F:Aml.Engine.Services.RepairTypeEnum.None">**None**</td><td>0</td><td>The Option None indicates, that nothing should be done</td></tr></table>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />