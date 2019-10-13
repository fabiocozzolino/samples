// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MyService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

namespace gRPC.Bidirectional.Core
{
    /// <summary>Holder for reflection information generated from MyService.proto</summary>
    public static partial class MyServiceReflection
    {

        #region Descriptor
        /// <summary>File descriptor for MyService.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static MyServiceReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Cg9NeVNlcnZpY2UucHJvdG8iFwoJRG9SZXF1ZXN0EgoKAmluGAEgASgJIhkK",
                  "CkRvUmVzcG9uc2USCwoDb3V0GAEgASgJMjAKCU15U2VydmljZRIjCgJEbxIK",
                  "LkRvUmVxdWVzdBoLLkRvUmVzcG9uc2UiACgBMAFiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.Bidirectional.Core.DoRequest), global::gRPC.Bidirectional.Core.DoRequest.Parser, new[]{ "In" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::gRPC.Bidirectional.Core.DoResponse), global::gRPC.Bidirectional.Core.DoResponse.Parser, new[]{ "Out" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class DoRequest : pb::IMessage<DoRequest>
    {
        private static readonly pb::MessageParser<DoRequest> _parser = new pb::MessageParser<DoRequest>(() => new DoRequest());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DoRequest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::gRPC.Bidirectional.Core.MyServiceReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoRequest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoRequest(DoRequest other) : this()
        {
            in_ = other.in_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoRequest Clone()
        {
            return new DoRequest(this);
        }

        /// <summary>Field number for the "in" field.</summary>
        public const int InFieldNumber = 1;
        private string in_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string In
        {
            get { return in_; }
            set
            {
                in_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as DoRequest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DoRequest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (In != other.In) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (In.Length != 0) hash ^= In.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (In.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(In);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (In.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(In);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DoRequest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.In.Length != 0)
            {
                In = other.In;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            In = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    public sealed partial class DoResponse : pb::IMessage<DoResponse>
    {
        private static readonly pb::MessageParser<DoResponse> _parser = new pb::MessageParser<DoResponse>(() => new DoResponse());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DoResponse> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::gRPC.Bidirectional.Core.MyServiceReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoResponse()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoResponse(DoResponse other) : this()
        {
            out_ = other.out_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoResponse Clone()
        {
            return new DoResponse(this);
        }

        /// <summary>Field number for the "out" field.</summary>
        public const int OutFieldNumber = 1;
        private string out_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Out
        {
            get { return out_; }
            set
            {
                out_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as DoResponse);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DoResponse other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Out != other.Out) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Out.Length != 0) hash ^= Out.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Out.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Out);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Out.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Out);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DoResponse other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Out.Length != 0)
            {
                Out = other.Out;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            Out = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    #endregion


    #endregion Designer generated code
}