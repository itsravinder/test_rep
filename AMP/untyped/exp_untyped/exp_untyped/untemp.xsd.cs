namespace exp_untyped {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://exp_untyped.untemp",@"services")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"services"})]
    public sealed class untemp : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://exp_untyped.untemp"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://exp_untyped.untemp"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""services"">
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""&lt;empty&gt;"" name=""Types"" type=""xs:string"" />
        <xs:element default=""&lt;empty&gt;"" name=""Names"" type=""xs:string"" />
        <xs:element default=""&lt;empty&gt;"" name=""Citi"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public untemp() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "services";
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
