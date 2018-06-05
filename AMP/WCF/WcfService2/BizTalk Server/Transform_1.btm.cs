namespace BizTalk_Server {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server.Input", typeof(global::BizTalk_Server.Input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server.Wcfservice2.Service1+Display", typeof(global::BizTalk_Server.Wcfservice2.Service1.Display))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BizTalk_Server.Input"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Input"" />
  </xsl:template>
  <xsl:template match=""/s0:Input"">
    <ns0:Display>
      <ns0:text>
        <xsl:value-of select=""Text/text()"" />
      </ns0:text>
    </ns0:Display>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalk_Server.Input";
        
        private const global::BizTalk_Server.Input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalk_Server.Wcfservice2.Service1+Display";
        
        private const global::BizTalk_Server.Wcfservice2.Service1.Display _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalk_Server.Input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalk_Server.Wcfservice2.Service1+Display";
                return _TrgSchemas;
            }
        }
    }
}
