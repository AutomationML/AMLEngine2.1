# Document Validation

This topic contains the following sections:
&nbsp;<ul><li><a href="#validating-a-document">Validating a document</a></li>&nbsp;
<li><a href="#repair-a-validated-document">Repair a validated document</a></li>&nbsp;
<li><a href="#validation-of-names-and-ids">Validation of Names and IDs</a></li>&nbsp;
<li><a href="#see-also">See Also</a></li></ul>&nbsp;
To validate a document, a service, which implements the <a href="T_Aml_Engine_Services_Interfaces_IValidator_1">IValidator(RESULTTYPE)</a> interface has to be used. The Aml.Engine currently contains one implementation of this interface, the <a href="T_Aml_Engine_Services_ValidatorService">ValidatorService</a>. If validation issues are detected, also possible repair options are included in the validation result. See the <a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a> class, which information is included in the validation result.



## Validating a document

This example show, how a document can be validated and how the obtained result can be read using extension methods, defined in <a href="T_Aml_Engine_Services_ValidationResults">ValidationResults</a>.



## Example

**Validate document**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

void ValidateDocument (CAEXDocument document)
{
    // registration of the validation service
    var service = ValidatorService.Register();

    // document validation
    var validationResult = service.ValidateAll();

    // filter results, get all ID references which are not OK.
    var idReferenceValidationResult = validationResult.IDReferenceValidationResults();

    // filter results, get all Path references which are not OK.
    var pathReferenceValidationResult = validationResult.PathReferenceValidationResults();

    ValidatorService.UnRegister();
}
```

<a href="#">Back to the Top</a>



## Repair a validated document

This example is about repair IDs in a validated document.



## Example

**Repair IDs**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

void ValidateDocument (CAEXDocument document)
{
    // registration of the validation service
    var service = ValidatorService.Register();

    // document validation
    var validationResult = service.ValidateAll();

    // filter results, get all IDs which are repairable.
    var idValidationResult = validationResult.IDValidationResults().Where(v => v.AvailableRepairOptions != RepairTypeEnum.None).ToList();

    idValidationResult.ForEach((e) => service.Repair(e));

    ValidatorService.UnRegister();
}
```

<a href="#">Back to the Top</a>



## Validation of Names and IDs

These examples explain, how to validate a single ID or Name which should be assigned to an element.



## Example

**Validate a name**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX;

void ValidateName (CAEXDocument document)
{
    // registration of the validation service
    var service = ValidatorService.Register();

    var insHierarchy1 = document.CAEXFile.InstanceHierarchy.Append();

    insHierarchy1.Name = "InsHierarchy";
    result = _service.NameValidation(insHierarchy1, "InsHierarchy");
    Assert.IsTrue(result.IsValid);

    var insHierarchy2 = document.CAEXFile.InstanceHierarchy.Append("");

    // it is not allowed, to assign the same name to another InstanceHierarchy
    result = _service.NameValidation(insHierarchy2, "InsHierarchy");
    Assert.IsFalse(result.IsValid);


    // it is possible to register a UniqueNameService. The Aml.Engine recognizes, if such a service is present and
    // will automatically assign unique names to all generated or inserted objects.

    Console.WriteLine (result.Message);
}
```

<a href="#">Back to the Top</a>



## See Also


#### Reference
<a href="M_Aml_Engine_Services_ValidatorService_NameValidation">NameValidation</a><br /><a href="T_Aml_Engine_Services_UniqueNameService">UniqueNameService</a><br />