namespace Return_Sql {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Return_Sql.Product_ins", typeof(global::Return_Sql.Product_ins))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Return_Sql.Bulk_prd_ins+Product_ins_req", typeof(global::Return_Sql.Bulk_prd_ins.Product_ins_req))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns2=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:s0=""http://Return_Sql.Product_ins"" xmlns:ns1=""http://Return_Sql.Bulk_prd_ins"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Product"" />
  </xsl:template>
  <xsl:template match=""/s0:Product"">
    <ns1:Product_ins_req>
      <xsl:for-each select=""Details"">
        <ns0:Insert_Prd_return>
          <ns0:ID>
            <xsl:value-of select=""ID/text()"" />
          </ns0:ID>
          <ns0:ProductID>
            <xsl:value-of select=""Product_ID/text()"" />
          </ns0:ProductID>
          <ns0:Product_Name>
            <xsl:value-of select=""Product_Name/text()"" />
          </ns0:Product_Name>
          <ns0:Qty>
            <xsl:value-of select=""Qty/text()"" />
          </ns0:Qty>
          <ns0:Price>
            <xsl:value-of select=""Price/text()"" />
          </ns0:Price>
          <ns0:TotalPrice>
            <xsl:value-of select=""TotalPrice/text()"" />
          </ns0:TotalPrice>
          <ns0:User_name>
            <xsl:value-of select=""username/text()"" />
          </ns0:User_name>
        </ns0:Insert_Prd_return>
      </xsl:for-each>
    </ns1:Product_ins_req>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Return_Sql.Product_ins";
        
        private const global::Return_Sql.Product_ins _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Return_Sql.Bulk_prd_ins+Product_ins_req";
        
        private const global::Return_Sql.Bulk_prd_ins.Product_ins_req _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Return_Sql.Product_ins";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Return_Sql.Bulk_prd_ins+Product_ins_req";
                return _TrgSchemas;
            }
        }
    }
}
