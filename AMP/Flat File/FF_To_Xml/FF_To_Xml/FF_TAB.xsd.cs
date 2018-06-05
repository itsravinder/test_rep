namespace FF_To_Xml {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FF_To_Xml.FF_TAB",@"TSV")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TSV"})]
    public sealed class FF_TAB : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FF_To_Xml.FF_TAB"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FF_To_Xml.FF_TAB"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" standard=""Flat File"" root_reference=""TSV"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""TSV"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" child_delimiter_type=""hex"" child_delimiter=""0x0D 0x0A"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <b:groupInfo sequence_number=""0"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element name=""Record"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo sequence_number=""1"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x09"" child_order=""infix"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence minOccurs=""1"" maxOccurs=""unbounded"">
              <xs:annotation>
                <xs:appinfo>
                  <b:groupInfo sequence_number=""0"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element name=""Name"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo sequence_number=""1"" justification=""left"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""DOB"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo sequence_number=""2"" justification=""left"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Address"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo sequence_number=""3"" justification=""left"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public FF_TAB() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TSV";
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
