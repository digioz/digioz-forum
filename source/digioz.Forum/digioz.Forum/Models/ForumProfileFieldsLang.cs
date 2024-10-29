using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumProfileFieldsLang
{
    public long FieldId { get; set; }

    public long LangId { get; set; }

    public long OptionId { get; set; }

    public string FieldType { get; set; } = null!;

    public string LangValue { get; set; } = null!;
}
