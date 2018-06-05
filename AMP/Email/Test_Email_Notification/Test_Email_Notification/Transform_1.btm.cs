namespace Test_Email_Notification {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Test_Email_Notification.Data_File", typeof(global::Test_Email_Notification.Data_File))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Test_Email_Notification.Dummy_data", typeof(global::Test_Email_Notification.Dummy_data))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Test_Email_Notification.Data_File"" xmlns:ns0=""http://Test_Email_Notification.Dummy_data"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <ns0:Dummy_Cus>
      <Data>
        <First_Name>
          <xsl:value-of select=""Data_Record/FirstName/text()"" />
        </First_Name>
        <Last_Name>
          <xsl:value-of select=""Data_Record/LastName/text()"" />
        </Last_Name>
        <Product_name>
          <xsl:value-of select=""Data_Record/Product_name/text()"" />
        </Product_name>
        <Product_ID>
          <xsl:value-of select=""Data_Record/Product_Id/text()"" />
        </Product_ID>
        <Price>
          <xsl:value-of select=""Data_Record/Price/text()"" />
        </Price>
      </Data>
    </ns0:Dummy_Cus>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Test_Email_Notification.Data_File";
        
        private const global::Test_Email_Notification.Data_File _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Test_Email_Notification.Dummy_data";
        
        private const global::Test_Email_Notification.Dummy_data _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Test_Email_Notification.Data_File";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Test_Email_Notification.Dummy_data";
                return _TrgSchemas;
            }
        }
    }
}
