namespace Count_comparision {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://record_count.Incoming_schema",@"Purchase_order")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Purchase_order"})]
    public sealed class Incoming_schema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://record_count.Incoming_schema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://record_count.Incoming_schema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Purchase_order"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderNo"" type=""xs:int"" />
              <xs:element name=""OrderType"" type=""xs:string"" />
              <xs:element name=""FirstName"" type=""xs:string"" />
              <xs:element name=""LastName"" type=""xs:string"" />
              <xs:element name=""Amount"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Incoming_schema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Purchase_order";
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
