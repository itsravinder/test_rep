namespace sql_ForXML {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"sql_ForXML.Product_Details", typeof(global::sql_ForXML.Product_Details))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"sql_ForXML.Insert_ProductTypedProcedure_dbo+Insert_Product_x0020_", typeof(global::sql_ForXML.Insert_ProductTypedProcedure_dbo.Insert_Product_x0020_))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s0=""http://sql_ForXML.Product_Details"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Record"" />
  </xsl:template>
  <xsl:template match=""/s0:Record"">
    <ns0:Insert_Product_x0020_>
      <ns0:ID>
        <xsl:value-of select=""Product_details/ID/text()"" />
      </ns0:ID>
      <ns0:ProductID>
        <xsl:value-of select=""Product_details/Product_ID/text()"" />
      </ns0:ProductID>
      <ns0:Product_Name>
        <xsl:value-of select=""Product_details/Product_Name/text()"" />
      </ns0:Product_Name>
      <ns0:Qty>
        <xsl:value-of select=""Product_details/Qty/text()"" />
      </ns0:Qty>
      <ns0:Price>
        <xsl:value-of select=""Product_details/Price/text()"" />
      </ns0:Price>
      <ns0:TotalPrice>
        <xsl:value-of select=""Product_details/TotalPrice/text()"" />
      </ns0:TotalPrice>
      <ns0:User_name>
        <xsl:value-of select=""Product_details/UserName/text()"" />
      </ns0:User_name>
    </ns0:Insert_Product_x0020_>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"sql_ForXML.Product_Details";
        
        private const global::sql_ForXML.Product_Details _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"sql_ForXML.Insert_ProductTypedProcedure_dbo+Insert_Product_x0020_";
        
        private const global::sql_ForXML.Insert_ProductTypedProcedure_dbo.Insert_Product_x0020_ _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"sql_ForXML.Product_Details";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"sql_ForXML.Insert_ProductTypedProcedure_dbo+Insert_Product_x0020_";
                return _TrgSchemas;
            }
        }
    }
}
