namespace sql_ForXML {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Insert_Product_x0020_", @"Insert_Product_x0020_Response"})]
    public sealed class Insert_ProductTypedProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedProcedure.dbo</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Insert_Product_x0020_"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/Insert_Product_x0020_</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ID"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""10"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductID"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""30"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Product_Name"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""20"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Qty"" nillable=""true"" type=""xs:long"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Price"" nillable=""true"" type=""xs:long"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TotalPrice"" nillable=""true"" type=""xs:long"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""User_name"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""50"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Insert_Product_x0020_Response"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/Insert_Product_x0020_/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Insert_ProductTypedProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Insert_Product_x0020_";
                _RootElements[1] = "Insert_Product_x0020_Response";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"Insert_Product_x0020_")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Insert_Product_x0020_"})]
        public sealed class Insert_Product_x0020_ : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Insert_Product_x0020_() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Insert_Product_x0020_";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"Insert_Product_x0020_Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Insert_Product_x0020_Response"})]
        public sealed class Insert_Product_x0020_Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Insert_Product_x0020_Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Insert_Product_x0020_Response";
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
