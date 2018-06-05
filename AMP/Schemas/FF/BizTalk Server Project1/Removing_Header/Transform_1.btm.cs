namespace Removing_Header {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Removing_Header.WithHeader", typeof(global::Removing_Header.WithHeader))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Removing_Header.NoHeader", typeof(global::Removing_Header.NoHeader))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://Removing_Header.NoHeader"" xmlns:s0=""http://Removing_Header.WithHeader"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <xsl:for-each select=""Data"">
        <Data>
          <FName>
            <xsl:value-of select=""FName/text()"" />
          </FName>
          <MName>
            <xsl:value-of select=""MName/text()"" />
          </MName>
          <LName>
            <xsl:value-of select=""LName/text()"" />
          </LName>
        </Data>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Removing_Header.WithHeader";
        
        private const global::Removing_Header.WithHeader _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Removing_Header.NoHeader";
        
        private const global::Removing_Header.NoHeader _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Removing_Header.WithHeader";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Removing_Header.NoHeader";
                return _TrgSchemas;
            }
        }
    }
}
