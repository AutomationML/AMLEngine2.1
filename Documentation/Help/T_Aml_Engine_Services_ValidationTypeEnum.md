# ValidationTypeEnum Enumeration
AutomationML 2.1 API 

Enumeration ValidationTypeEnum

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public enum ValidationTypeEnum
```

**VB**<br />
``` VB
Public Enumeration ValidationTypeEnum
```

**C++**<br />
``` C++
public enum class ValidationTypeEnum
```


## Members
&nbsp;<table><tr><th></th><th>Member name</th><th>Value</th><th>Description</th></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.IDValidation">**IDValidation**</td><td>0</td><td>The identifier validation indicates ID related issues. like a double or missing ID or a wrong formatted ID. The issues are repairable, if the ID is not referenced.</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.ClassPathValidation">**ClassPathValidation**</td><td>1</td><td>The class path validation indicates a double ClassPath or missing Path</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.AttributePathValidation">**AttributePathValidation**</td><td>2</td><td>The attribute path validation indicates a double AttributePath or missing Path</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.PathReferenceValidation">**PathReferenceValidation**</td><td>3</td><td>The path reference validation indicates a missing or unresolved reference to a class</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.NameValidation">**NameValidation**</td><td>4</td><td>The name validation indicates a missing or not allowed name</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.IDReferenceValidation">**IDReferenceValidation**</td><td>5</td><td>The ID reference validation indicates a missing or unresolved reference to an object with an ID</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.AliasValidation">**AliasValidation**</td><td>6</td><td>The alias validation</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.MergableAliasReferenceValidation">**MergableAliasReferenceValidation**</td><td>7</td><td>The validation result has constituted an alias in an external reference which is not merged</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.MissingAliasReferenceValidation">**MissingAliasReferenceValidation**</td><td>8</td><td>The validation result has constituted a missing alias in an external reference</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.FileReferenceValidation">**FileReferenceValidation**</td><td>9</td><td>The file reference validation indicates a wrong FilePath in an external reference, which couldn't be resolved to an existing file</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.RoleAttributeReferenceValidation">**RoleAttributeReferenceValidation**</td><td>10</td><td>The role attribute reference validation indicates a wrong reference to a role Attribute in a Mapping</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.RoleInterfaceReferenceValidation">**RoleInterfaceReferenceValidation**</td><td>11</td><td>The role Interface reference validation indicates a wrong reference to a role Interface in a Mapping</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.SystemUnitClassAttributeReferenceValidation">**SystemUnitClassAttributeReferenceValidation**</td><td>12</td><td>The SystemUnitClass attribute reference validation indicates a wrong reference to a SystemUnitClass Attribute in a Mapping</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.SystemUnitClassInterfaceReferenceValidation">**SystemUnitClassInterfaceReferenceValidation**</td><td>13</td><td>The SystemUnitClass Interface reference validation indicates a wrong reference to a SystemUnitClass Interface in a Mapping</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.CyclicDependency">**CyclicDependency**</td><td>14</td><td>This Flag indicates a cyclic dependency between classes</td></tr><tr><td /><td target="F:Aml.Engine.Services.ValidationTypeEnum.AutomationMLMetaDataValidation">**AutomationMLMetaDataValidation**</td><td>15</td><td>The automationML meta data validation indicates a couple of validation issues with metaData, as a missing schema name or writerHeader</td></tr></table>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />