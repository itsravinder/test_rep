namespace Test_Email_Notification {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Test_Email_Notification.Dummy_data",@"Dummy_Cus")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Dummy_Cus"})]
    public sealed class Dummy_data : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Test_Email_Notification.Dummy_data"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Test_Email_Notification.Dummy_data"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Dummy_Cus"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Data"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""First_Name"" type=""xs:string"" />
              <xs:element name=""Last_Name"" type=""xs:string"" />
              <xs:element name=""Product_name"" type=""xs:string"" />
              <xs:element name=""Product_ID"" type=""xs:string"" />
              <xs:element name=""Price"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Dummy_data() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Dummy_Cus";
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
