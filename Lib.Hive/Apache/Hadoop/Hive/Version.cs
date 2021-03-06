/**
 * Autogenerated by Thrift Compiler (0.7.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Hadoop.Hive
{

    [Serializable]
    public partial class Version : TBase
    {
        private string _version;
        private string _comments;

        public string version
        {
            get
            {
                return _version;
            }
            set
            {
                __isset.version = true;
                this._version = value;
            }
        }

        public string Comments
        {
            get
            {
                return _comments;
            }
            set
            {
                __isset.comments = true;
                this._comments = value;
            }
        }


        public Isset __isset;
        [Serializable]
        public struct Isset
        {
            public bool version;
            public bool comments;
        }

        public Version()
        {
        }

        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.String)
                        {
                            version = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == TType.String)
                        {
                            Comments = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("Version");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (version != null && __isset.version)
            {
                field.Name = "version";
                field.Type = TType.String;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(version);
                oprot.WriteFieldEnd();
            }
            if (Comments != null && __isset.comments)
            {
                field.Name = "comments";
                field.Type = TType.String;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(Comments);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Version(");
            sb.Append("Version: ");
            sb.Append(version);
            sb.Append(",Comments: ");
            sb.Append(Comments);
            sb.Append(")");
            return sb.ToString();
        }

    }

}
