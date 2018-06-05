namespace Return_Sql {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Product_ins_req", @"Product_ins_resp"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Return_Sql.Procedure_dbo", typeof(global::Return_Sql.Procedure_dbo))]
    public sealed class Bulk_prd_ins : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Return_Sql.Bulk_prd_ins"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" targetNamespace=""http://Return_Sql.Bulk_prd_ins"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Return_Sql.Procedure_dbo"" namespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Data"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Product_ins_req"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:Insert_Prd_return"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Product_ins_resp"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:Insert_Prd_returnResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Bulk_prd_ins() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Product_ins_req";
                _RootElements[1] = "Product_ins_resp";
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
        
        [Schema(@"http://Return_Sql.Bulk_prd_ins",@"Product_ins_req")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Product_ins_req"})]
        public sealed class Product_ins_req : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Product_ins_req() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Product_ins_req";
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
        
        [Schema(@"http://Return_Sql.Bulk_prd_ins",@"Product_ins_resp")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Product_ins_resp"})]
        public sealed class Product_ins_resp : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Product_ins_resp() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Product_ins_resp";
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
