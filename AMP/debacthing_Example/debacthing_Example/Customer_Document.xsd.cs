namespace debacthing_Example {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://debacthing_Example.Customer_Document",@"Customer")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customer"})]
    public sealed class Customer_Document : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://debacthing_Example.Customer_Document"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://debacthing_Example.Customer_Document"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Customer"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerID"" type=""xs:int"" />
        <xs:element name=""Name"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Customer_Document() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Customer";
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
