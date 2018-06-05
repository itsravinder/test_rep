namespace Envenlope {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Envenlope.order",@"Order")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    public sealed class order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Envenlope.order"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Envenlope.order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Order"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderID"" type=""xs:string"" />
        <xs:element name=""OrderAmount"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
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