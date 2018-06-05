namespace Count_comparision {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Count_comparision.Incoming_orders",@"Po")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Po"})]
    public sealed class Incoming_orders : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Count_comparision.Incoming_orders"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Count_comparision.Incoming_orders"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Po"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderNo"" type=""xs:integer"" />
              <xs:element name=""OrderType"" type=""xs:string"" />
              <xs:element name=""FristName"" type=""xs:string"" />
              <xs:element name=""LastName"" type=""xs:string"" />
              <xs:element name=""Amount"" type=""xs:integer"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Incoming_orders() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Po";
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
