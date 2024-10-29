using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumProfileLang
{
    public long FieldId { get; set; }

    public long LangId { get; set; }

    public string LangName { get; set; } = null!;

    public string LangExplain { get; set; } = null!;

    public string LangDefaultValue { get; set; } = null!;
}
