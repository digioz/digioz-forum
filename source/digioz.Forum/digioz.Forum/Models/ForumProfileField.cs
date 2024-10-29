using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumProfileField
{
    public long FieldId { get; set; }

    public string FieldName { get; set; } = null!;

    public string FieldType { get; set; } = null!;

    public string FieldIdent { get; set; } = null!;

    public string FieldLength { get; set; } = null!;

    public string FieldMinlen { get; set; } = null!;

    public string FieldMaxlen { get; set; } = null!;

    public string FieldNovalue { get; set; } = null!;

    public string FieldDefaultValue { get; set; } = null!;

    public string FieldValidation { get; set; } = null!;

    public byte FieldRequired { get; set; }

    public byte FieldShowOnReg { get; set; }

    public byte FieldHide { get; set; }

    public byte FieldNoView { get; set; }

    public byte FieldActive { get; set; }

    public long FieldOrder { get; set; }

    public byte FieldShowProfile { get; set; }

    public byte FieldShowOnVt { get; set; }

    public byte FieldShowNovalue { get; set; }

    public byte FieldShowOnPm { get; set; }

    public byte FieldShowOnMl { get; set; }

    public byte FieldIsContact { get; set; }

    public string FieldContactDesc { get; set; } = null!;

    public string FieldContactUrl { get; set; } = null!;
}
