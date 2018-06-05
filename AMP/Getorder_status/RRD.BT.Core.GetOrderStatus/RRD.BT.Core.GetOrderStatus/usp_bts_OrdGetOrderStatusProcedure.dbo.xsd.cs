namespace RRD.BT.Core.GetOrderStatus.ExternalSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"usp_bts_OrdGetOrderStatus", @"usp_bts_OrdGetOrderStatusResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RRD.BT.Core.GetOrderStatus.ExternalSchemas.usp_bts_OrdGetOrderStatusTableType_dbo", typeof(global::RRD.BT.Core.GetOrderStatus.ExternalSchemas.usp_bts_OrdGetOrderStatusTableType_dbo))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RRD.BT.Core.GetOrderStatus.ExternalSchemas.usp_bts_OrdGetOrderStatusDataSetSchema", typeof(global::RRD.BT.Core.GetOrderStatus.ExternalSchemas.usp_bts_OrdGetOrderStatusDataSetSchema))]
    public sealed class usp_bts_OrdGetOrderStatusProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns4=""http://schemas.datacontract.org/2004/07/System.Data"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RRD.BT.Core.GetOrderStatus.ExternalSchemas.usp_bts_OrdGetOrderStatusTableType_dbo"" namespace=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" />
  <xs:import schemaLocation=""RRD.BT.Core.GetOrderStatus.ExternalSchemas.usp_bts_OrdGetOrderStatusDataSetSchema"" namespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">Procedure.dbo</fileNameHint>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" />
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""usp_bts_OrdGetOrderStatus"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/usp_bts_OrdGetOrderStatus</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FromIdentity"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FromPasscode"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""50"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrdersTVP"" nillable=""true"" type=""ns3:ArrayOfTTOrders"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""usp_bts_OrdGetOrderStatusResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">Procedure/dbo/usp_bts_OrdGetOrderStatus/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""usp_bts_OrdGetOrderStatusResult"" nillable=""true"" type=""ns4:ArrayOfDataSet"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public usp_bts_OrdGetOrderStatusProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "usp_bts_OrdGetOrderStatus";
                _RootElements[1] = "usp_bts_OrdGetOrderStatusResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"usp_bts_OrdGetOrderStatus")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"usp_bts_OrdGetOrderStatus"})]
        public sealed class usp_bts_OrdGetOrderStatus : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public usp_bts_OrdGetOrderStatus() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "usp_bts_OrdGetOrderStatus";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo",@"usp_bts_OrdGetOrderStatusResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"usp_bts_OrdGetOrderStatusResponse"})]
        public sealed class usp_bts_OrdGetOrderStatusResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public usp_bts_OrdGetOrderStatusResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "usp_bts_OrdGetOrderStatusResponse";
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
