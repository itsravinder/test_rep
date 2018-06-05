namespace ff {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ff.FlatFileSchema", typeof(global::ff.FlatFileSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ff.FlatFileout", typeof(global::ff.FlatFileout))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://ff.FlatFileout"" xmlns:s0=""http://ff.FlatFileSchema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <xsl:for-each select=""Root_Child1"">
        <xsl:for-each select=""Root_Chlid"">
          <Root_Child1>
            <FName>
              <xsl:value-of select=""FNmae/text()"" />
            </FName>
            <LName>
              <xsl:value-of select=""Lname/text()"" />
            </LName>
            <Year>
              <xsl:value-of select=""Year/text()"" />
            </Year>
            <Place>
              <xsl:value-of select=""Place/text()"" />
            </Place>
            <Pin>
              <xsl:value-of select=""Pin/text()"" />
            </Pin>
          </Root_Child1>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ff.FlatFileSchema";
        
        private const global::ff.FlatFileSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ff.FlatFileout";
        
        private const global::ff.FlatFileout _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"ff.FlatFileSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ff.FlatFileout";
                return _TrgSchemas;
            }
        }
    }
}
