namespace RRD.BT.Core.GetOrderStatus {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TTOrders", @"ArrayOfTTOrders"})]
    public sealed class GetOrderStatusTableType_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TableType.dbo</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""TTOrders"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderNum"" nillable=""true"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:maxLength value=""100"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""TTOrders"" nillable=""true"" type=""ns3:TTOrders"" />
  <xs:complexType name=""ArrayOfTTOrders"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TTOrders"" type=""ns3:TTOrders"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfTTOrders"" nillable=""true"" type=""ns3:ArrayOfTTOrders"" />
</xs:schema>";
        
        public GetOrderStatusTableType_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "TTOrders";
                _RootElements[1] = "ArrayOfTTOrders";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo",@"TTOrders")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TTOrders"})]
        public sealed class TTOrders : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TTOrders() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TTOrders";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo",@"ArrayOfTTOrders")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfTTOrders"})]
        public sealed class ArrayOfTTOrders : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfTTOrders() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfTTOrders";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
