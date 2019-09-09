// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: object_detection/protos/square_box_coder.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Models.ObjectDetection.Protos {

  /// <summary>Holder for reflection information generated from object_detection/protos/square_box_coder.proto</summary>
  public static partial class SquareBoxCoderReflection {

    #region Descriptor
    /// <summary>File descriptor for object_detection/protos/square_box_coder.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SquareBoxCoderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5vYmplY3RfZGV0ZWN0aW9uL3Byb3Rvcy9zcXVhcmVfYm94X2NvZGVyLnBy",
            "b3RvEhdvYmplY3RfZGV0ZWN0aW9uLnByb3RvcyJICg5TcXVhcmVCb3hDb2Rl",
            "chIPCgd5X3NjYWxlGAEgASgCEg8KB3hfc2NhbGUYAiABKAISFAoMbGVuZ3Ro",
            "X3NjYWxlGAMgASgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.SquareBoxCoder), global::Tensorflow.Models.ObjectDetection.Protos.SquareBoxCoder.Parser, new[]{ "YScale", "XScale", "LengthScale" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration proto for SquareBoxCoder. See
  /// box_coders/square_box_coder.py for details.
  /// </summary>
  public sealed partial class SquareBoxCoder : pb::IMessage<SquareBoxCoder> {
    private static readonly pb::MessageParser<SquareBoxCoder> _parser = new pb::MessageParser<SquareBoxCoder>(() => new SquareBoxCoder());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SquareBoxCoder> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.SquareBoxCoderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareBoxCoder() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareBoxCoder(SquareBoxCoder other) : this() {
      yScale_ = other.yScale_;
      xScale_ = other.xScale_;
      lengthScale_ = other.lengthScale_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquareBoxCoder Clone() {
      return new SquareBoxCoder(this);
    }

    /// <summary>Field number for the "y_scale" field.</summary>
    public const int YScaleFieldNumber = 1;
    private float yScale_;
    /// <summary>
    /// Scale factor for anchor encoded box center.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float YScale {
      get { return yScale_; }
      set {
        yScale_ = value;
      }
    }

    /// <summary>Field number for the "x_scale" field.</summary>
    public const int XScaleFieldNumber = 2;
    private float xScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float XScale {
      get { return xScale_; }
      set {
        xScale_ = value;
      }
    }

    /// <summary>Field number for the "length_scale" field.</summary>
    public const int LengthScaleFieldNumber = 3;
    private float lengthScale_;
    /// <summary>
    /// Scale factor for anchor encoded box length.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float LengthScale {
      get { return lengthScale_; }
      set {
        lengthScale_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SquareBoxCoder);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SquareBoxCoder other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(YScale, other.YScale)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(XScale, other.XScale)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LengthScale, other.LengthScale)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (YScale != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(YScale);
      if (XScale != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(XScale);
      if (LengthScale != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LengthScale);
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
      if (YScale != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(YScale);
      }
      if (XScale != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(XScale);
      }
      if (LengthScale != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(LengthScale);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (YScale != 0F) {
        size += 1 + 4;
      }
      if (XScale != 0F) {
        size += 1 + 4;
      }
      if (LengthScale != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SquareBoxCoder other) {
      if (other == null) {
        return;
      }
      if (other.YScale != 0F) {
        YScale = other.YScale;
      }
      if (other.XScale != 0F) {
        XScale = other.XScale;
      }
      if (other.LengthScale != 0F) {
        LengthScale = other.LengthScale;
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
          case 13: {
            YScale = input.ReadFloat();
            break;
          }
          case 21: {
            XScale = input.ReadFloat();
            break;
          }
          case 29: {
            LengthScale = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
