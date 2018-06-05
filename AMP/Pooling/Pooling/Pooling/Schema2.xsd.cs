namespace Pooling {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Pooling.Schema2",@"IncomingSchema")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"IncomingSchema"})]
    public sealed class Schema2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Pooling.Schema2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Pooling.Schema2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""IncomingSchema"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FeedProcessFileInfoID"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FileName"" type=""xs:string"" />
              <xs:element name=""OrderCount"" type=""xs:string"" />
              <xs:element name=""ProcessName"" type=""xs:string"" />
              <xs:element name=""Username"" type=""xs:string"" />
              <xs:element name=""OrderUrl"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""FeedProcessOrderHeadersID"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FirstName"" type=""xs:string"" />
              <xs:element name=""LastName"" type=""xs:string"" />
              <xs:element name=""Address1"" type=""xs:string"" />
              <xs:element name=""Address2"" type=""xs:string"" />
              <xs:element name=""Address3"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
              <xs:element name=""State"" type=""xs:string"" />
              <xs:element name=""PostalCode"" type=""xs:string"" />
              <xs:element name=""country"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "IncomingSchema";
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
