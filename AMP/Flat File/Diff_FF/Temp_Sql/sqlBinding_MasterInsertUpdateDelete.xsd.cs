namespace Temp_Sql {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StoredProcedureResultSet0", @"ArrayOfStoredProcedureResultSet0"})]
    public sealed class sqlBinding_MasterInsertUpdateDelete : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete"" version=""1.0"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <annotation>
    <appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">ProcedureResultSet.dbo.MasterInsertUpdateDelete</fileNameHint>
    </appinfo>
  </annotation>
  <complexType name=""StoredProcedureResultSet0"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""1"" name=""id"" nillable=""true"" type=""int"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""first_name"" nillable=""true"" type=""string"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""last_name"" nillable=""true"" type=""string"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""salary"" nillable=""true"" type=""decimal"" />
      <element minOccurs=""0"" maxOccurs=""1"" name=""city"" nillable=""true"" type=""string"" />
    </sequence>
  </complexType>
  <element name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:StoredProcedureResultSet0"" />
  <complexType name=""ArrayOfStoredProcedureResultSet0"">
    <sequence>
      <element minOccurs=""0"" maxOccurs=""unbounded"" name=""StoredProcedureResultSet0"" type=""ns3:StoredProcedureResultSet0"" />
    </sequence>
  </complexType>
  <element name=""ArrayOfStoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0"" />
</schema>";
        
        public sqlBinding_MasterInsertUpdateDelete() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "StoredProcedureResultSet0";
                _RootElements[1] = "ArrayOfStoredProcedureResultSet0";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete",@"StoredProcedureResultSet0")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StoredProcedureResultSet0"})]
        public sealed class StoredProcedureResultSet0 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StoredProcedureResultSet0() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StoredProcedureResultSet0";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete",@"ArrayOfStoredProcedureResultSet0")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfStoredProcedureResultSet0"})]
        public sealed class ArrayOfStoredProcedureResultSet0 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfStoredProcedureResultSet0() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfStoredProcedureResultSet0";
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
