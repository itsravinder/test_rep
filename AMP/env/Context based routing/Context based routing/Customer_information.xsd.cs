namespace Context_based_routing {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Context_based_routing.Customer_information",@"CustomerInformation")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerInformation"})]
    public sealed class Customer_information : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Context_based_routing.Customer_information"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Context_based_routing.Customer_information"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerInformation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""CustomerID"" type=""xs:string"" />
        <xs:element name=""CustomerDetails"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Homephno"" type=""xs:string"" />
              <xs:element name=""Moblieno"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Customer_information() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerInformation";
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
