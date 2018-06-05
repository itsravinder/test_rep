namespace BizTalk_Server_Project1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.NormalFF", typeof(global::BizTalk_Server_Project1.NormalFF))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.NormalXML", typeof(global::BizTalk_Server_Project1.NormalXML))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalk_Server_Project1.NormalFF"" xmlns:ns0=""http://BizTalk_Server_Project1.NormalXML"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Customer>
      <xsl:for-each select=""Root_Child1"">
        <xsl:for-each select=""FName"">
          <Details>
            <FName>
              <xsl:value-of select=""./text()"" />
            </FName>
            <LName>
              <xsl:value-of select=""../LName/text()"" />
            </LName>
            <Year>
              <xsl:value-of select=""../Year/text()"" />
            </Year>
            <City>
              <xsl:value-of select=""../City/text()"" />
            </City>
            <Pin>
              <xsl:value-of select=""../Pin/text()"" />
            </Pin>
          </Details>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:Customer>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalk_Server_Project1.NormalFF";
        
        private const global::BizTalk_Server_Project1.NormalFF _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalk_Server_Project1.NormalFF";
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
