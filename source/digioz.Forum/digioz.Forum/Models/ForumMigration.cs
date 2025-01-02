using System;
using System.Collections.Generic;

namespace digioz.Forum.Models;

public partial class ForumMigration
{
    public string MigrationName { get; set; } = null!;

    public string MigrationDependsOn { get; set; } = null!;

    public byte MigrationSchemaDone { get; set; }

    public byte MigrationDataDone { get; set; }

    public string MigrationDataState { get; set; } = null!;

    public long MigrationStartTime { get; set; }

    public long MigrationEndTime { get; set; }
}
