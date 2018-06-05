namespace sql_ForXML {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://sql_ForXML.Product_Details",@"Record")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Record"})]
    public sealed class Product_Details : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://sql_ForXML.Product_Details"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://sql_ForXML.Product_Details"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Record"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Product_details"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ID"" type=""xs:int"" />
              <xs:element name=""Product_ID"" type=""xs:string"" />
              <xs:element name=""Product_Name"" type=""xs:string"" />
              <xs:element name=""Qty"" type=""xs:int"" />
              <xs:element name=""Price"" type=""xs:int"" />
              <xs:element name=""TotalPrice"" type=""xs:int"" />
              <xs:element name=""UserName"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Product_Details() {
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
