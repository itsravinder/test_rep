namespace Temp_Map {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Temp_Map.subscriber_Xyz",@"Payload")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Payload"})]
    public sealed class subscriber_Xyz : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Temp_Map.subscriber_Xyz"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Temp_Map.subscriber_Xyz"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Payload"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Data"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Age"" type=""xs:integer"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""SubmissionTimer"" type=""xs:dateTime"" />
              <xs:element name=""Submitter"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public subscriber_Xyz() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Payload";
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
