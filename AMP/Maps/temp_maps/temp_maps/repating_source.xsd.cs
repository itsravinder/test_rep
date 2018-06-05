namespace temp_maps {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://temp_maps.repating_source",@"Source")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Source"})]
    public sealed class repating_source : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://temp_maps.repating_source"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://temp_maps.repating_source"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Source"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Main"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SomeField"" type=""xs:string"" />
              <xs:element name=""RepatingRecord"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Quad"" type=""xs:string"" />
                    <xs:element name=""String"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""SomeRecord"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SomeField"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public repating_source() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Source";
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
