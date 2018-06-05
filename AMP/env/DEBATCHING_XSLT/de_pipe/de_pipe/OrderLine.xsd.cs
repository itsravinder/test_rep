namespace de_pipe {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://de_pipe.OrderLine",@"OrderLine")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderLine"})]
    public sealed class OrderLine : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://de_pipe.OrderLine"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://de_pipe.OrderLine"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""OrderLine"">
    <xs:complexType>
      <xs:attribute name=""price"" type=""xs:string"" />
      <xs:attribute name=""Store"" type=""xs:string"" />
      <xs:attribute name=""Code"" type=""xs:string"" />
      <xs:attribute name=""Qty"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderLine() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderLine";
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
