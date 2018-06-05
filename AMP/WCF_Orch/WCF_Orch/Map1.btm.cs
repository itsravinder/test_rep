namespace WCF_Orch {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WCF_Orch.Scr_Schema", typeof(global::WCF_Orch.Scr_Schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"WCF_Orch.Dest_Schema", typeof(global::WCF_Orch.Dest_Schema))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://WCF_Orch.Scr_Schema"" xmlns:ns0=""http://WCF_Orch.Dest_Schema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <Field1>
        <xsl:value-of select=""Field2/text()"" />
      </Field1>
      <Field2>
        <xsl:value-of select=""Field1/text()"" />
      </Field2>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"WCF_Orch.Scr_Schema";
        
        private const global::WCF_Orch.Scr_Schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"WCF_Orch.Dest_Schema";
        
        private const global::WCF_Orch.Dest_Schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"WCF_Orch.Scr_Schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"WCF_Orch.Dest_Schema";
                return _TrgSchemas;
            }
        }
    }
}
