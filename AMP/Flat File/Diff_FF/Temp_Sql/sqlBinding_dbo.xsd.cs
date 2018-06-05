namespace Temp_Sql {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MasterInsertUpdateDelete", @"MasterInsertUpdateDeleteResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_Sql.sqlBinding_MasterInsertUpdateDelete", typeof(global::Temp_Sql.sqlBinding_MasterInsertUpdateDelete))]
    public sealed class sqlBinding_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""Temp_Sql.sqlBinding_MasterInsertUpdateDelete"" namespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete"" />
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedProcedure.dbo</fileNameHint>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete"" />
      </references>
    </appinfo>
  </annotation>
  <element name=""MasterInsertUpdateDelete"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/MasterInsertUpdateDelete</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""id"" nillable=""true"" type=""int"" />
        <element minOccurs=""0"" maxOccurs=""1"" name=""first_name"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""10"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""last_name"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""10"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""salary"" nillable=""true"">
          <simpleType>
            <restriction base=""decimal"">
              <totalDigits value=""10"" />
              <fractionDigits value=""2"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""city"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""20"" />
            </restriction>
          </simpleType>
        </element>
        <element minOccurs=""0"" maxOccurs=""1"" name=""StatementType"" nillable=""true"">
          <simpleType>
            <restriction base=""string"">
              <maxLength value=""20"" />
            </restriction>
          </simpleType>
        </element>
      </sequence>
    </complexType>
  </element>
  <element name=""MasterInsertUpdateDeleteResponse"">
    <annotation>
      <documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/MasterInsertUpdateDelete/response</doc:action>
      </documentation>
    </annotation>
    <complexType>
      <sequence>
        <element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0"" />
        <element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""int"" />
      </sequence>
    </complexType>
  </element>
</schema>";
        
        public sqlBinding_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "MasterInsertUpdateDelete";
                _RootElements[1] = "MasterInsertUpdateDeleteResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"MasterInsertUpdateDelete")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MasterInsertUpdateDelete"})]
        public sealed class MasterInsertUpdateDelete : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MasterInsertUpdateDelete() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MasterInsertUpdateDelete";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"MasterInsertUpdateDeleteResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MasterInsertUpdateDeleteResponse"})]
        public sealed class MasterInsertUpdateDeleteResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MasterInsertUpdateDeleteResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MasterInsertUpdateDeleteResponse";
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
