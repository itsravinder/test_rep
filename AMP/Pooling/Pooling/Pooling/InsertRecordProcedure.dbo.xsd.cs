namespace Pooling {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"insertFeedProcessfileDetails", @"insertFeedProcessfileDetailsResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Pooling.InsertRecordDataSetSchema", typeof(global::Pooling.InsertRecordDataSetSchema))]
    public sealed class InsertRecordProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Pooling.InsertRecordDataSetSchema"" namespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Procedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""insertFeedProcessfileDetails"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/insertFeedProcessfileDetails</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Filename"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""100"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderCount"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""100"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProcessName"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""100"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AppIdentity"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""100"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UserName"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""100"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SharedSecret"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""50"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProcessStartDate"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProcessCompletionDate"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ModifiedDate"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CreateDate"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderURL"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""200"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""insertFeedProcessfileDetailsResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/insertFeedProcessfileDetails/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""insertFeedProcessfileDetailsResult"" nillable=""true"" type=""ns3:ArrayOfDataSet"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InsertRecordProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "insertFeedProcessfileDetails";
                _RootElements[1] = "insertFeedProcessfileDetailsResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"insertFeedProcessfileDetails")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"insertFeedProcessfileDetails"})]
        public sealed class insertFeedProcessfileDetails : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public insertFeedProcessfileDetails() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "insertFeedProcessfileDetails";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"insertFeedProcessfileDetailsResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"insertFeedProcessfileDetailsResponse"})]
        public sealed class insertFeedProcessfileDetailsResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public insertFeedProcessfileDetailsResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "insertFeedProcessfileDetailsResponse";
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
