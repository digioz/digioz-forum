using System;
using System.Collections.Generic;
using System.Configuration;
using digioz.Forum.Data;
using Microsoft.EntityFrameworkCore;

namespace digioz.Forum.Models;

public partial class DigiozForumContext : DbContext
{
    public string ConnectionString { get; set; }

    public DigiozForumContext()
    {
    }

    public DigiozForumContext(DbContextOptions<DigiozForumContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
        var configuration = builder.Build();
        ConnectionString = configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(ConnectionString);
    }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Forum> Forums { get; set; }

    public virtual DbSet<ForumAttachment> ForumAttachments { get; set; }

    public virtual DbSet<ForumBanlist> ForumBanlists { get; set; }

    public virtual DbSet<ForumBbcode> ForumBbcodes { get; set; }

    public virtual DbSet<ForumBookmark> ForumBookmarks { get; set; }

    public virtual DbSet<ForumBot> ForumBots { get; set; }

    public virtual DbSet<ForumConfig> ForumConfigs { get; set; }

    public virtual DbSet<ForumDraft> ForumDrafts { get; set; }

    public virtual DbSet<ForumExt> ForumExts { get; set; }

    public virtual DbSet<ForumExtension> ForumExtensions { get; set; }

    public virtual DbSet<ForumExtensionGroup> ForumExtensionGroups { get; set; }

    public virtual DbSet<ForumIcon> ForumIcons { get; set; }

    public virtual DbSet<ForumLang> ForumLangs { get; set; }

    public virtual DbSet<ForumLog> ForumLogs { get; set; }

    public virtual DbSet<ForumLoginAttempt> ForumLoginAttempts { get; set; }

    public virtual DbSet<ForumModule> ForumModules { get; set; }

    public virtual DbSet<ForumPermission> ForumPermissions { get; set; }

    public virtual DbSet<ForumPollOption> ForumPollOptions { get; set; }

    public virtual DbSet<ForumPollVote> ForumPollVotes { get; set; }

    public virtual DbSet<ForumPost> ForumPosts { get; set; }

    public virtual DbSet<ForumPrivmsg> ForumPrivmsgs { get; set; }

    public virtual DbSet<ForumPrivmsgsFolder> ForumPrivmsgsFolders { get; set; }

    public virtual DbSet<ForumPrivmsgsRule> ForumPrivmsgsRules { get; set; }

    public virtual DbSet<ForumPrivmsgsTo> ForumPrivmsgsTos { get; set; }

    public virtual DbSet<ForumProfileField> ForumProfileFields { get; set; }

    public virtual DbSet<ForumProfileFieldsData> ForumProfileFieldsData { get; set; }

    public virtual DbSet<ForumProfileFieldsLang> ForumProfileFieldsLangs { get; set; }

    public virtual DbSet<ForumProfileLang> ForumProfileLangs { get; set; }

    public virtual DbSet<ForumReport> ForumReports { get; set; }

    public virtual DbSet<ForumReportsReason> ForumReportsReasons { get; set; }

    public virtual DbSet<ForumSession> ForumSessions { get; set; }

    public virtual DbSet<ForumSmilie> ForumSmilies { get; set; }

    public virtual DbSet<ForumStyle> ForumStyles { get; set; }

    public virtual DbSet<ForumTopic> ForumTopics { get; set; }

    public virtual DbSet<ForumTopicsPosted> ForumTopicsPosteds { get; set; }

    public virtual DbSet<ForumTopicsTrack> ForumTopicsTracks { get; set; }

    public virtual DbSet<ForumTopicsWatch> ForumTopicsWatches { get; set; }

    public virtual DbSet<ForumTrack> ForumTracks { get; set; }

    public virtual DbSet<ForumUser> ForumUsers { get; set; }

    public virtual DbSet<ForumWarning> ForumWarnings { get; set; }

    public virtual DbSet<ForumWord> ForumWords { get; set; }

    public virtual DbSet<ForumZebra> ForumZebras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Forum>(entity =>
        {
            entity.HasKey(e => e.ForumId).HasName("PK__Forum__E210AC6F87795C2A");

            entity.ToTable("Forum");

            entity.Property(e => e.DisplayOnIndex).HasDefaultValue((byte)1);
            entity.Property(e => e.DisplaySubforumList).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableIcons).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableIndexing).HasDefaultValue((byte)1);
            entity.Property(e => e.ForumDesc).HasColumnType("text");
            entity.Property(e => e.ForumDescBitfield)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumDescOptions).HasDefaultValue(7);
            entity.Property(e => e.ForumDescUid)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumFlags).HasDefaultValueSql("('32')");
            entity.Property(e => e.ForumImage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumLastPostSubject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumLastPosterColour)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumLastPosterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumLink)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumParents).HasColumnType("text");
            entity.Property(e => e.ForumPassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            //entity.Property(e => e.ForumPostsApproved).HasColumnName("ForumPosts_approved");
            //entity.Property(e => e.ForumPostsSoftdeleted).HasColumnName("ForumPosts_softdeleted");
            //entity.Property(e => e.ForumPostsUnapproved).HasColumnName("ForumPosts_unapproved");
            entity.Property(e => e.ForumRules).HasColumnType("text");
            entity.Property(e => e.ForumRulesBitfield)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumRulesLink)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ForumRulesOptions).HasDefaultValue(7);
            entity.Property(e => e.ForumRulesUid)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("");
            //entity.Property(e => e.ForumTopicsApproved).HasColumnName("ForumTopics_approved");
            //entity.Property(e => e.ForumTopicsSoftdeleted).HasColumnName("ForumTopics_softdeleted");
            //entity.Property(e => e.ForumTopicsUnapproved).HasColumnName("ForumTopics_unapproved");
            entity.Property(e => e.PruneShadowDays).HasDefaultValue(7L);
            entity.Property(e => e.PruneShadowFreq).HasDefaultValue(1L);
        });

        modelBuilder.Entity<ForumAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachId).HasName("PK__ForumAtt__F517C3F52C50DBE6");

            entity.ToTable("ForumAttachment");

            entity.Property(e => e.AttachComment).HasColumnType("text");
            entity.Property(e => e.Extension)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.IsOrphan).HasDefaultValue((byte)1);
            entity.Property(e => e.MimeType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PhysicalFilename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RealFilename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumBanlist>(entity =>
        {
            entity.HasKey(e => e.BanId).HasName("PK__ForumBan__991CE7455853CDC8");

            entity.ToTable("ForumBanlist");

            entity.Property(e => e.BanEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BanGiveReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BanIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BanReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumBbcode>(entity =>
        {
            entity.HasKey(e => e.BbcodeId).HasName("PK__ForumBbc__40E984D19D85BBC7");

            entity.ToTable("ForumBbcode");

            entity.Property(e => e.BbcodeHelpline).HasColumnType("text");
            entity.Property(e => e.BbcodeMatch).HasColumnType("text");
            entity.Property(e => e.BbcodeTag)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BbcodeTpl).HasColumnType("text");
            entity.Property(e => e.FirstPassMatch).HasColumnType("text");
            entity.Property(e => e.FirstPassReplace).HasColumnType("text");
            entity.Property(e => e.SecondPassMatch).HasColumnType("text");
            entity.Property(e => e.SecondPassReplace).HasColumnType("text");
        });

        modelBuilder.Entity<ForumBookmark>(entity =>
        {
            entity.HasKey(e => new { e.TopicId, e.UserId }).HasName("PK__ForumBoo__D35683998CFECEF4");

            entity.ToTable("ForumBookmark");
        });

        modelBuilder.Entity<ForumBot>(entity =>
        {
            entity.HasKey(e => e.BotId).HasName("PK__ForumBot__160546623F5592F0");

            entity.ToTable("ForumBot");

            entity.Property(e => e.BotActive).HasDefaultValue((byte)1);
            entity.Property(e => e.BotAgent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BotIp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BotName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumConfig>(entity =>
        {
            entity.HasKey(e => e.ConfigName).HasName("PK__ForumCon__A89A7DB36E2259BC");

            entity.ToTable("ForumConfig");

            entity.Property(e => e.ConfigName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ConfigValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumDraft>(entity =>
        {
            entity.HasKey(e => e.DraftId).HasName("PK__ForumDra__3E93D65B31BD1546");

            entity.Property(e => e.DraftMessage).HasColumnType("text");
            entity.Property(e => e.DraftSubject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumExt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForumExt");

            entity.HasIndex(e => e.ExtName, "UQ__ForumExt__36D5A8EC88162981").IsUnique();

            entity.Property(e => e.ExtName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ExtState).HasColumnType("text");
        });

        modelBuilder.Entity<ForumExtension>(entity =>
        {
            entity.HasKey(e => e.ExtensionId).HasName("PK__ForumExt__5581AF2C7E8240C4");

            entity.ToTable("ForumExtension");

            entity.Property(e => e.Extension)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumExtensionGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__ForumExt__149AF36AEF8E316E");

            entity.ToTable("ForumExtensionGroup");

            entity.Property(e => e.AllowedForums).HasColumnType("text");
            entity.Property(e => e.DownloadMode).HasDefaultValue((byte)1);
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UploadIcon)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumIcon>(entity =>
        {
            entity.HasKey(e => e.IconsId).HasName("PK__ForumIco__DC606E7B2C9DE861");

            entity.ToTable("ForumIcon");

            entity.Property(e => e.DisplayOnPosting).HasDefaultValue((byte)1);
            entity.Property(e => e.IconsAlt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.IconsUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumLang>(entity =>
        {
            entity.HasKey(e => e.LangId).HasName("PK__ForumLan__A5F312DEEF29275E");

            entity.ToTable("ForumLang");

            entity.Property(e => e.LangId).ValueGeneratedOnAdd();
            entity.Property(e => e.LangAuthor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LangDir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LangEnglishName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LangIso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LangLocalName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__ForumLog__5E548648207F8137");

            entity.ToTable("ForumLog");

            entity.Property(e => e.LogData).HasColumnType("text");
            entity.Property(e => e.LogIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LogOperation).HasColumnType("text");
            entity.Property(e => e.PostId).HasColumnName("postId");
        });

        modelBuilder.Entity<ForumLoginAttempt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForumLoginAttempt");

            entity.Property(e => e.AttemptBrowser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.AttemptForwardedFor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.AttemptIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.UsernameClean)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<ForumModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__ForumMod__2B7477A7CF7B72AC");

            entity.ToTable("ForumModule");

            entity.Property(e => e.ModuleAuth)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ModuleBasename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ModuleClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ModuleDisplay).HasDefaultValue((byte)1);
            entity.Property(e => e.ModuleEnabled).HasDefaultValue((byte)1);
            entity.Property(e => e.ModuleLangname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ModuleMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumPermission>(entity =>
        {
            entity.HasKey(e => e.ForumPermissionId).HasName("PK__ForumPer__D3A3E3A3A3A3A3A3");
            entity.ToTable("ForumPermission");
            entity.Property(e => e.RoleId)
                .HasMaxLength(450)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumPollOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForumPollOption");

            entity.Property(e => e.PollOptionText).HasColumnType("text");
        });

        modelBuilder.Entity<ForumPollVote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForumPollVote");

            entity.Property(e => e.VoteUserIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumPost>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__ForumPos__AA126018F8B661F7");

            entity.ToTable("ForumPost");

            entity.Property(e => e.BbcodeBitfield)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BbcodeUid)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.EnableBbcode).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableMagicUrl).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableSig).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableSmilies).HasDefaultValue((byte)1);
            entity.Property(e => e.PostChecksum)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PostCount).HasDefaultValue((byte)1);
            entity.Property(e => e.PostDeleteReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PostEditReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PostSubject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PostText).HasColumnType("text");
            entity.Property(e => e.PostUsername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PosterIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumPrivmsg>(entity =>
        {
            entity.HasKey(e => e.MsgId).HasName("PK__ForumPri__6623587290DD6068");

            entity.ToTable("ForumPrivmsg");

            entity.Property(e => e.AuthorIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BbcodeBitfield)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BbcodeUid)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BccAddress).HasColumnType("text");
            entity.Property(e => e.EnableBbcode).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableMagicUrl).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableSig).HasDefaultValue((byte)1);
            entity.Property(e => e.EnableSmilies).HasDefaultValue((byte)1);
            entity.Property(e => e.MessageEditReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.MessageSubject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.MessageText).HasColumnType("text");
            entity.Property(e => e.ToAddress).HasColumnType("text");
        });

        modelBuilder.Entity<ForumPrivmsgsFolder>(entity =>
        {
            entity.HasKey(e => e.FolderId).HasName("PK__ForumPri__ACD7107FB09BE1F1");

            entity.ToTable("ForumPrivmsgsFolder");

            entity.Property(e => e.FolderName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumPrivmsgsRule>(entity =>
        {
            entity.HasKey(e => e.RuleId).HasName("PK__ForumPri__110458E2A59E3794");

            entity.ToTable("ForumPrivmsgsRule");

            entity.Property(e => e.RuleFolderId).HasColumnName("RuleFolder_id");
            entity.Property(e => e.RuleString)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumPrivmsgsTo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForumPrivmsgsTo");

            entity.Property(e => e.PmNew).HasDefaultValue((byte)1);
            entity.Property(e => e.PmUnread).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<ForumProfileField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PK__ForumPro__C8B6FF0783D0C6A5");

            entity.ToTable("ForumProfileField");

            entity.Property(e => e.FieldContactDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldContactUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldDefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldIdent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldLength)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldMaxlen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldMinlen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldNovalue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FieldValidation)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumProfileFieldsData>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__ForumPro__1788CC4C534BC8FE");

            entity.Property(e => e.PfForumFacebook)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumIcq)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumInterests).HasColumnType("text");
            entity.Property(e => e.PfForumLocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumOccupation).HasColumnType("text");
            entity.Property(e => e.PfForumSkype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumTwitter)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumWebsite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumYahoo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PfForumYoutube)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumProfileFieldsLang>(entity =>
        {
            entity.HasKey(e => new { e.FieldId, e.LangId, e.OptionId }).HasName("PK__ForumPro__CC7B098B37D03926");

            entity.ToTable("ForumProfileFieldsLang");

            entity.Property(e => e.FieldType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LangValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumProfileLang>(entity =>
        {
            entity.HasKey(e => new { e.FieldId, e.LangId }).HasName("PK__ForumPro__32E9CE2A55110BBB");

            entity.ToTable("ForumProfileLang");

            entity.Property(e => e.LangDefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LangExplain).HasColumnType("text");
            entity.Property(e => e.LangName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumReport>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__ForumRep__D5BD48054E720D33");

            entity.ToTable("ForumReport");

            entity.Property(e => e.ReportText).HasColumnType("text");
            entity.Property(e => e.ReportedPostBitfield)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ReportedPostEnableBbcode).HasDefaultValue((byte)1);
            entity.Property(e => e.ReportedPostEnableMagicUrl).HasDefaultValue((byte)1);
            entity.Property(e => e.ReportedPostEnableSmilies).HasDefaultValue((byte)1);
            entity.Property(e => e.ReportedPostText).HasColumnType("text");
            entity.Property(e => e.ReportedPostUid)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumReportsReason>(entity =>
        {
            entity.HasKey(e => e.ReasonId).HasName("PK__ForumRep__A4F8C0E7D9DD86CF");

            entity.ToTable("ForumReportsReason");

            entity.Property(e => e.ReasonDescription).HasColumnType("text");
            entity.Property(e => e.ReasonTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK__ForumSes__C9F49290E5162354");

            entity.ToTable("ForumSession");

            entity.Property(e => e.SessionId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.SessionBrowser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SessionForwardedFor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SessionIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SessionPage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SessionViewOnline).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<ForumSmilie>(entity =>
        {
            entity.HasKey(e => e.SmileyId).HasName("PK__ForumSmi__F986B7E4CBA18D23");

            entity.ToTable("ForumSmilie");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DisplayOnPosting).HasDefaultValue((byte)1);
            entity.Property(e => e.Emotion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SmileyUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumStyle>(entity =>
        {
            entity.HasKey(e => e.StyleId).HasName("PK__ForumSty__8AD146404659C57D");

            entity.ToTable("ForumStyle");

            entity.HasIndex(e => e.StyleName, "UQ__ForumSty__23564EE674CCD59E").IsUnique();

            entity.Property(e => e.BbcodeBitField)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("kNg=");
            entity.Property(e => e.StyleActive).HasDefaultValue((byte)1);
            entity.Property(e => e.StyleCopyright)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StyleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StyleParentTree).HasColumnType("text");
            entity.Property(e => e.StylePath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumTopic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__ForumTop__022E0F5DCAAAEA1A");

            entity.ToTable("ForumTopic");

            entity.Property(e => e.PollMaxOptions).HasDefaultValue((byte)1);
            entity.Property(e => e.PollTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicDeleteReason)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicFirstPosterColor)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicFirstPosterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicLastPostSubject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicLastPosterColor)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicLastPosterName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TopicTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumTopicsPosted>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.TopicId }).HasName("PK__ForumTop__D7AA2CB9D149E388");

            entity.ToTable("ForumTopicsPosted");
        });

        modelBuilder.Entity<ForumTopicsTrack>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.TopicId }).HasName("PK__ForumTop__D7AA2CB9DDC7EB24");

            entity.ToTable("ForumTopicsTrack");
        });

        modelBuilder.Entity<ForumTopicsWatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ForumTopicsWatch");
        });

        modelBuilder.Entity<ForumTrack>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ForumId }).HasName("PK__ForumTra__F9A9C68ABD8B0169");

            entity.ToTable("ForumTrack");
        });

        modelBuilder.Entity<ForumUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__ForumUse__1788CC4C40559146");

            entity.ToTable("ForumUser");

            entity.HasIndex(e => e.UserNameClean, "UQ__ForumUse__50B534DA8FF36971").IsUnique();

            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ForumUserId).ValueGeneratedOnAdd();
            entity.Property(e => e.GroupId).HasDefaultValue(3L);
            entity.Property(e => e.ResetToken)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserActkey)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserAllowMassemail).HasDefaultValue((byte)1);
            entity.Property(e => e.UserAllowPm).HasDefaultValue((byte)1);
            entity.Property(e => e.UserAllowViewEmail).HasDefaultValue((byte)1);
            entity.Property(e => e.UserAllowViewOnline).HasDefaultValue((byte)1);
            entity.Property(e => e.UserAvatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserAvatarType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserBirthday)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserColor)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserDateFormat)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValue("d M Y H:i");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserFormSalt)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserFullFolder).HasDefaultValueSql("('-3')");
            entity.Property(e => e.UserIp)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserJabber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserLang)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserLastConfirmKey)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserLastPage)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserNameClean)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserNew).HasDefaultValue((byte)1);
            entity.Property(e => e.UserNewpasswd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserNotifyPm).HasDefaultValue((byte)1);
            entity.Property(e => e.UserPermissions).HasColumnType("text");
            entity.Property(e => e.UserPostSortbyDir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("a");
            entity.Property(e => e.UserPostSortbyType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("t");
            entity.Property(e => e.UserSig).HasColumnType("text");
            entity.Property(e => e.UserSigBbcodeBitfield)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserSigBbcodeUid)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserTimeZone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserTopicSortbyDir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("d");
            entity.Property(e => e.UserTopicSortbyType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("t");
        });

        modelBuilder.Entity<ForumWarning>(entity =>
        {
            entity.HasKey(e => e.WarningId).HasName("PK__ForumWar__214571586C77902C");

            entity.ToTable("ForumWarning");
        });

        modelBuilder.Entity<ForumWord>(entity =>
        {
            entity.HasKey(e => e.WordId).HasName("PK__ForumWor__2C20F0666573E09D");

            entity.ToTable("ForumWord");

            entity.Property(e => e.Replacement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Word)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ForumZebra>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ZebraId }).HasName("PK__ForumZeb__8D93AE018FB8D7F2");

            entity.ToTable("ForumZebra");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
