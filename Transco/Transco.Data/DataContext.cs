using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Transco.Data;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User Id=sys;Password=admin;Data Source=localhost:1521/xe;DBA Privilege=SYSDBA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("SYS");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER");

            entity.Property(e => e.Customerid)
                .HasColumnType("NUMBER")
                .HasColumnName("CUSTOMERID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LASTNAME");
        });
        modelBuilder.HasSequence("APPLY$_DEST_OBJ_ID");
        modelBuilder.HasSequence("APPLY$_ERROR_HANDLER_SEQUENCE");
        modelBuilder.HasSequence("APPLY$_SOURCE_OBJ_ID");
        modelBuilder.HasSequence("AQ$_ALERT_QT_N");
        modelBuilder.HasSequence("AQ$_AQ_PROP_TABLE_N");
        modelBuilder.HasSequence("AQ$_AQ$_MEM_MC_N");
        modelBuilder.HasSequence("AQ$_CHAINSEQ");
        modelBuilder.HasSequence("AQ$_IOTENQTXID");
        modelBuilder.HasSequence("AQ$_KUPC$DATAPUMP_QUETAB_N");
        modelBuilder.HasSequence("AQ$_NONDURSUB_SEQUENCE");
        modelBuilder.HasSequence("AQ$_PROPAGATION_SEQUENCE");
        modelBuilder.HasSequence("AQ$_PUBLISHER_SEQUENCE");
        modelBuilder.HasSequence("AQ$_RULE_SEQUENCE");
        modelBuilder.HasSequence("AQ$_RULE_SET_SEQUENCE");
        modelBuilder.HasSequence("AQ$_SCHEDULER_FILEWATCHER_QT_N");
        modelBuilder.HasSequence("AQ$_SCHEDULER$_EVENT_QTAB_N");
        modelBuilder.HasSequence("AQ$_SCHEDULER$_REMDB_JOBQTAB_N");
        modelBuilder.HasSequence("AQ$_SYS$SERVICE_METRICS_TAB_N");
        modelBuilder.HasSequence("AQ$_TRANS_SEQUENCE");
        modelBuilder.HasSequence("AUDSES$").IsCyclic();
        modelBuilder.HasSequence("AWLOGSEQ$");
        modelBuilder.HasSequence("AWSEQ$");
        modelBuilder.HasSequence("CACHE_STATS_SEQ_0");
        modelBuilder.HasSequence("CACHE_STATS_SEQ_1");
        modelBuilder.HasSequence("CDC_RSID_SEQ$");
        modelBuilder.HasSequence("CDC_SUBSCRIBE_SEQ$");
        modelBuilder.HasSequence("CHNF$_CLAUSEID_SEQ");
        modelBuilder.HasSequence("CHNF$_QUERYID_SEQ");
        modelBuilder.HasSequence("COMPARISON_SCAN_SEQ$").IsCyclic();
        modelBuilder.HasSequence("COMPARISON_SEQ$");
        modelBuilder.HasSequence("DAM_CLEANUP_SEQ$");
        modelBuilder.HasSequence("DBFS_HS$_ARCHIVEREFIDSEQ");
        modelBuilder.HasSequence("DBFS_HS$_BACKUPFILEIDSEQ");
        modelBuilder.HasSequence("DBFS_HS$_POLICYIDSEQ");
        modelBuilder.HasSequence("DBFS_HS$_RSEQ");
        modelBuilder.HasSequence("DBFS_HS$_STOREIDSEQ");
        modelBuilder.HasSequence("DBFS_HS$_TARBALLSEQ");
        modelBuilder.HasSequence("DBFS_SFS$_FSSEQ");
        modelBuilder.HasSequence("DBMS_LOCK_ID");
        modelBuilder.HasSequence("DBMS_PARALLEL_EXECUTE_SEQ$");
        modelBuilder.HasSequence("DM$EXPIMP_ID_SEQ");
        modelBuilder.HasSequence("FGR$_NAMES_S");
        modelBuilder.HasSequence("GENERATOR$_S");
        modelBuilder.HasSequence("GROUP_NUM_SEQ");
        modelBuilder.HasSequence("HS_BULK_SEQ");
        modelBuilder.HasSequence("HS$_BASE_DD_S");
        modelBuilder.HasSequence("HS$_CLASS_CAPS_S");
        modelBuilder.HasSequence("HS$_CLASS_DD_S");
        modelBuilder.HasSequence("HS$_CLASS_INIT_S");
        modelBuilder.HasSequence("HS$_FDS_CLASS_S");
        modelBuilder.HasSequence("HS$_FDS_INST_S");
        modelBuilder.HasSequence("HS$_INST_CAPS_S");
        modelBuilder.HasSequence("HS$_INST_DD_S");
        modelBuilder.HasSequence("HS$_INST_INIT_S");
        modelBuilder.HasSequence("IDGEN1$").IncrementsBy(50);
        modelBuilder.HasSequence("IDX_RB$JOBSEQ").IsCyclic();
        modelBuilder.HasSequence("INVALIDATION_REG_ID$");
        modelBuilder.HasSequence("JOBSEQ").IsCyclic();
        modelBuilder.HasSequence("JOBSEQLSBY").IsCyclic();
        modelBuilder.HasSequence("LOG$SEQUENCE");
        modelBuilder.HasSequence("MV_RF$JOBSEQ").IsCyclic();
        modelBuilder.HasSequence("OBJECT_GRANT");
        modelBuilder.HasSequence("ORA_PLAN_ID_SEQ$").IsCyclic();
        modelBuilder.HasSequence("ORA_TQ_BASE$").IsCyclic();
        modelBuilder.HasSequence("PARTITION_NAME$");
        modelBuilder.HasSequence("PROFNUM$");
        modelBuilder.HasSequence("PSINDEX_SEQ$");
        modelBuilder.HasSequence("REDEF_SEQ$");
        modelBuilder.HasSequence("RGROUPSEQ").IsCyclic();
        modelBuilder.HasSequence("SCHEDULER$_EVTSEQ");
        modelBuilder.HasSequence("SCHEDULER$_INSTANCE_S");
        modelBuilder.HasSequence("SCHEDULER$_JOBSUFFIX_S");
        modelBuilder.HasSequence("SCHEDULER$_LWJOB_OID_SEQ");
        modelBuilder.HasSequence("SCHEDULER$_RDB_SEQ");
        modelBuilder.HasSequence("SNAPSHOT_ID$");
        modelBuilder.HasSequence("SNAPSITE_ID$");
        modelBuilder.HasSequence("SQL_TK_CHK_ID");
        modelBuilder.HasSequence("SQLLOG$_SEQ").IsCyclic();
        modelBuilder.HasSequence("SSCR_CAP_SEQ$");
        modelBuilder.HasSequence("STREAMS$_APPLY_SPILL_TXNKEY_S").IsCyclic();
        modelBuilder.HasSequence("STREAMS$_CAP_SUB_INST").IsCyclic();
        modelBuilder.HasSequence("STREAMS$_CAPTURE_INST").IsCyclic();
        modelBuilder.HasSequence("STREAMS$_PROPAGATION_SEQNUM");
        modelBuilder.HasSequence("STREAMS$_RULE_NAME_S");
        modelBuilder.HasSequence("STREAMS$_SM_ID");
        modelBuilder.HasSequence("STREAMS$_STMT_HANDLER_SEQ");
        modelBuilder.HasSequence("SYNOPSIS_NUM_SEQ");
        modelBuilder.HasSequence("SYSTEM_GRANT");
        modelBuilder.HasSequence("TSM_MIG_SEQ$");
        modelBuilder.HasSequence("UGROUP_SEQUENCE");
        modelBuilder.HasSequence("UTL_RECOMP_SEQ");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_DIR");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_DIR_INST");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_EXEC");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_JOURNAL");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_MSGGROUP");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_SQLW_QUERY");
        modelBuilder.HasSequence("WRI$_ADV_SEQ_TASK");
        modelBuilder.HasSequence("WRI$_ADV_SQLT_PLAN_SEQ");
        modelBuilder.HasSequence("WRI$_ALERT_SEQUENCE");
        modelBuilder.HasSequence("WRI$_ALERT_THRSLOG_SEQUENCE");
        modelBuilder.HasSequence("WRI$_REPT_COMP_ID_SEQ");
        modelBuilder.HasSequence("WRI$_REPT_FILE_ID_SEQ");
        modelBuilder.HasSequence("WRI$_REPT_FORMAT_ID_SEQ");
        modelBuilder.HasSequence("WRI$_REPT_REPT_ID_SEQ");
        modelBuilder.HasSequence("WRI$_SQLSET_ID_SEQ");
        modelBuilder.HasSequence("WRI$_SQLSET_REF_ID_SEQ");
        modelBuilder.HasSequence("WRI$_SQLSET_STMT_ID_SEQ");
        modelBuilder.HasSequence("WRI$_SQLSET_WORKSPACE_PLAN_SEQ");
        modelBuilder.HasSequence("WRR$_CAPTURE_ID");
        modelBuilder.HasSequence("WRR$_REPLAY_ID");
        modelBuilder.HasSequence("XSPARAM_REG_SEQUENCE$");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
