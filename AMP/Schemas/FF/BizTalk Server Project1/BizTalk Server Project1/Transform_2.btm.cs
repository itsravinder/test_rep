namespace BizTalk_Server_Project1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.FlatFileSchema1", typeof(global::BizTalk_Server_Project1.FlatFileSchema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.NormalXML", typeof(global::BizTalk_Server_Project1.NormalXML))]
    public sealed class Transform_2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalk_Server_Project1.FlatFileSchema1"" xmlns:ns0=""http://BizTalk_Server_Project1.NormalXML"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Customer>
      <xsl:for-each select=""Root_Child1"">
        <Details>
          <FName>
            <xsl:value-of select=""f/text()"" />
          </FName>
          <LName>
            <xsl:value-of select=""l/text()"" />
          </LName>
          <Year>
            <xsl:value-of select=""y/text()"" />
          </Year>
          <City>
            <xsl:value-of select=""c/text()"" />
          </City>
          <Pin>
            <xsl:value-of select=""p/text()"" />
          </Pin>
        </Details>
      </xsl:for-each>
    </ns0:Customer>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalk_Server_Project1.FlatFileSchema1";
        
        private const global::BizTalk_Server_Project1.FlatFileSchema1 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalk_Server_Project1.NormalXML";
        
        private const global::BizTalk_Server_Project1.NormalXML _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalk_Server_Project1.FlatFileSchema1";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalk_Server_Project1.NormalXML";
                return _TrgSchemas;
            }
        }
    }
}
