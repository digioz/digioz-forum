using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumZebra
{
    public int UserId { get; set; }

    public int ZebraId { get; set; }

    public byte Friend { get; set; }

    public byte Foe { get; set; }
}
