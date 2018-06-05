namespace FF_SQL_INS {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"requesting", @"Response"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FF_SQL_INS.DataSetSchema", typeof(global::FF_SQL_INS.DataSetSchema))]
    public sealed class Procedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""FF_SQL_INS.DataSetSchema"" namespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Procedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""requesting"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""insertTransactions"">
          <xs:annotation>
            <xs:documentation>
              <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/insertTransactions</doc:action>
            </xs:documentation>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence maxOccurs=""unbounded"">
              <xs:element minOccurs=""0"" name=""Recordcount"" nillable=""true"" type=""xs:long"" />
              <xs:element minOccurs=""0"" name=""RecordType"" nillable=""true"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""10"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""Image"" nillable=""true"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""50"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""insertTransactionsResponse"">
          <xs:annotation>
            <xs:documentation>
              <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/insertTransactions/response</doc:action>
            </xs:documentation>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""insertTransactionsResult"" nillable=""true"" type=""ns3:ArrayOfDataSet"" />
              <xs:element name=""ReturnValue"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Procedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "requesting";
                _RootElements[1] = "Response";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"requesting")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"requesting"})]
        public sealed class requesting : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public requesting() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "requesting";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Response"})]
        public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Response";
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
