namespace ins_sql {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Sql_In_req", @"Sql_In_resp"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ins_sql.Procedure_dbo", typeof(global::ins_sql.Procedure_dbo))]
    public sealed class Bulk_Insert : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ins_sql.Bulk_Insert"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" targetNamespace=""http://ins_sql.Bulk_Insert"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ins_sql.Procedure_dbo"" namespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Sql_In_req"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""ns0:Insert_Product_details"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Sql_In_resp"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:Insert_Product_detailsResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Bulk_Insert() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Sql_In_req";
                _RootElements[1] = "Sql_In_resp";
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
        
        [Schema(@"http://ins_sql.Bulk_Insert",@"Sql_In_req")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Sql_In_req"})]
        public sealed class Sql_In_req : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Sql_In_req() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Sql_In_req";
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
        
        [Schema(@"http://ins_sql.Bulk_Insert",@"Sql_In_resp")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Sql_In_resp"})]
        public sealed class Sql_In_resp : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Sql_In_resp() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Sql_In_resp";
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
