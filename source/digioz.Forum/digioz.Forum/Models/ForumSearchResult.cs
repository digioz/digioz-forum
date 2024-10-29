using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumSearchResult
{
    public string SearchKey { get; set; } = null!;

    public int SearchTime { get; set; }

    public string SearchKeywords { get; set; } = null!;

    public string SearchAuthors { get; set; } = null!;
}
