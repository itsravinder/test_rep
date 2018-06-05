namespace FF_To_Sql {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FF_To_Sql.Xml_2_Sql",@"Record")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Record"})]
    public sealed class Xml_2_Sql : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FF_To_Sql.Xml_2_Sql"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FF_To_Sql.Xml_2_Sql"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Record"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Details"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ID"" type=""xs:string"" />
              <xs:element name=""FirstName"" type=""xs:string"" />
              <xs:element name=""LastName"" type=""xs:string"" />
              <xs:element name=""salary"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Xml_2_Sql() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Record";
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