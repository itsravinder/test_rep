namespace Try_email {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Try_email.Product_cat", typeof(global::Try_email.Product_cat))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Try_email.Product_cat", typeof(global::Try_email.Product_cat))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://Try_email.Product_cat"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Product"" />
  </xsl:template>
  <xsl:template match=""/ns0:Product"">
    <ns0:Product>
      <Type>
        <xsl:value-of select=""Type/text()"" />
      </Type>
      <Customer_details>
        <xsl:for-each select=""Customer_details/Details"">
          <Details>
            <First_name>
              <xsl:value-of select=""First_name/text()"" />
            </First_name>
            <Last_name>
              <xsl:value-of select=""Last_name/text()"" />
            </Last_name>
            <Product_name>
              <xsl:value-of select=""Product_name/text()"" />
            </Product_name>
            <Price>
              <xsl:value-of select=""Price/text()"" />
            </Price>
          </Details>
        </xsl:for-each>
      </Customer_details>
    </ns0:Product>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Try_email.Product_cat";
        
        private const global::Try_email.Product_cat _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Try_email.Product_cat";
        
        private const global::Try_email.Product_cat _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Try_email.Product_cat";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Try_email.Product_cat";
                return _TrgSchemas;
            }
        }
    }
}
