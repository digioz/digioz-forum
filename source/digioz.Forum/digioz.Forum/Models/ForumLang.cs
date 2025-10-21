using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumLang
{
    public short LangId { get; set; }

    public string LangIso { get; set; } = null!;

    public string LangDir { get; set; } = null!;

    public string LangEnglishName { get; set; } = null!;

    public string LangLocalName { get; set; } = null!;

    public string LangAuthor { get; set; } = null!;
}
