// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Logging.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ResourceUpgradeTest {

  /// <summary>Holder for reflection information generated from Logging.proto</summary>
  public static partial class LoggingReflection {

    #region Descriptor
    /// <summary>File descriptor for Logging.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoggingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1Mb2dnaW5nLnByb3RvEhNyZXNvdXJjZXVwZ3JhZGV0ZXN0Ghxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnBy",
            "b3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90byIsChBEZWxldGVMb2dSZXF1",
            "ZXN0EhgKCGxvZ19uYW1lGAEgASgJQgb6QQNMb2ciVAoPTGlzdExvZ3NSZXF1",
            "ZXN0EhoKBnBhcmVudBgBIAEoCUIK+kEHUHJvamVjdBIRCglwYWdlX3NpemUY",
            "AiABKAUSEgoKcGFnZV90b2tlbhgDIAEoCSI+ChBMaXN0TG9nc1Jlc3BvbnNl",
            "EhEKCWxvZ19uYW1lcxgDIAMoCRIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAki",
            "BwoFRW1wdHkyoAQKEExvZ2dpbmdTZXJ2aWNlVjIS/AEKCURlbGV0ZUxvZxIl",
            "LnJlc291cmNldXBncmFkZXRlc3QuRGVsZXRlTG9nUmVxdWVzdBoaLnJlc291",
            "cmNldXBncmFkZXRlc3QuRW1wdHkiqwGC0+STApkBKiAvdjIve2xvZ19uYW1l",
            "PXByb2plY3RzLyovbG9ncy8qfVonKiUvdjIve2xvZ19uYW1lPW9yZ2FuaXph",
            "dGlvbnMvKi9sb2dzLyp9WiEqHy92Mi97bG9nX25hbWU9Zm9sZGVycy8qL2xv",
            "Z3MvKn1aKSonL3YyL3tsb2dfbmFtZT1iaWxsaW5nQWNjb3VudHMvKi9sb2dz",
            "Lyp92kEIbG9nX25hbWUSjAIKCExpc3RMb2dzEiQucmVzb3VyY2V1cGdyYWRl",
            "dGVzdC5MaXN0TG9nc1JlcXVlc3QaJS5yZXNvdXJjZXVwZ3JhZGV0ZXN0Lkxp",
            "c3RMb2dzUmVzcG9uc2UisgGC0+STAqIBEhUvdjIve3BhcmVudD0qLyp9L2xv",
            "Z3NaHhIcL3YyL3twYXJlbnQ9cHJvamVjdHMvKn0vbG9nc1ojEiEvdjIve3Bh",
            "cmVudD1vcmdhbml6YXRpb25zLyp9L2xvZ3NaHRIbL3YyL3twYXJlbnQ9Zm9s",
            "ZGVycy8qfS9sb2dzWiUSIy92Mi97cGFyZW50PWJpbGxpbmdBY2NvdW50cy8q",
            "fS9sb2dz2kEGcGFyZW50Ql2qAhNSZXNvdXJjZVVwZ3JhZGVUZXN06kEkCh1w",
            "cm9qZWN0cy97cHJvamVjdH0vbG9ncy97bG9nfRIDTG9n6kEdChJwcm9qZWN0",
            "cy97cHJvamVjdH0SB1Byb2plY3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ResourceUpgradeTest.DeleteLogRequest), global::ResourceUpgradeTest.DeleteLogRequest.Parser, new[]{ "LogName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ResourceUpgradeTest.ListLogsRequest), global::ResourceUpgradeTest.ListLogsRequest.Parser, new[]{ "Parent", "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ResourceUpgradeTest.ListLogsResponse), global::ResourceUpgradeTest.ListLogsResponse.Parser, new[]{ "LogNames", "NextPageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ResourceUpgradeTest.Empty), global::ResourceUpgradeTest.Empty.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeleteLogRequest : pb::IMessage<DeleteLogRequest> {
    private static readonly pb::MessageParser<DeleteLogRequest> _parser = new pb::MessageParser<DeleteLogRequest>(() => new DeleteLogRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeleteLogRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ResourceUpgradeTest.LoggingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteLogRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteLogRequest(DeleteLogRequest other) : this() {
      logName_ = other.logName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteLogRequest Clone() {
      return new DeleteLogRequest(this);
    }

    /// <summary>Field number for the "log_name" field.</summary>
    public const int LogNameFieldNumber = 1;
    private string logName_ = "";
    /// <summary>
    /// Required. The resource name of the log to delete:
    ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
    ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
    ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
    ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LogName {
      get { return logName_; }
      set {
        logName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeleteLogRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeleteLogRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LogName != other.LogName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LogName.Length != 0) hash ^= LogName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (LogName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LogName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LogName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeleteLogRequest other) {
      if (other == null) {
        return;
      }
      if (other.LogName.Length != 0) {
        LogName = other.LogName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            LogName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ListLogsRequest : pb::IMessage<ListLogsRequest> {
    private static readonly pb::MessageParser<ListLogsRequest> _parser = new pb::MessageParser<ListLogsRequest>(() => new ListLogsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListLogsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ResourceUpgradeTest.LoggingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLogsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLogsRequest(ListLogsRequest other) : this() {
      parent_ = other.parent_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLogsRequest Clone() {
      return new ListLogsRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required. The resource name that owns the logs:
    ///     "projects/[PROJECT_ID]"
    ///     "organizations/[ORGANIZATION_ID]"
    ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
    ///     "folders/[FOLDER_ID]"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private int pageSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 3;
    private string pageToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListLogsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListLogsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListLogsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ListLogsResponse : pb::IMessage<ListLogsResponse> {
    private static readonly pb::MessageParser<ListLogsResponse> _parser = new pb::MessageParser<ListLogsResponse>(() => new ListLogsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListLogsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ResourceUpgradeTest.LoggingReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLogsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLogsResponse(ListLogsResponse other) : this() {
      logNames_ = other.logNames_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLogsResponse Clone() {
      return new ListLogsResponse(this);
    }

    /// <summary>Field number for the "log_names" field.</summary>
    public const int LogNamesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_logNames_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> logNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> LogNames {
      get { return logNames_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListLogsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListLogsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!logNames_.Equals(other.logNames_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= logNames_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      logNames_.WriteTo(output, _repeated_logNames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += logNames_.CalculateSize(_repeated_logNames_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListLogsResponse other) {
      if (other == null) {
        return;
      }
      logNames_.Add(other.logNames_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 26: {
            logNames_.AddEntriesFrom(input, _repeated_logNames_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Empty : pb::IMessage<Empty> {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ResourceUpgradeTest.LoggingReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty(Empty other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty Clone() {
      return new Empty(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
