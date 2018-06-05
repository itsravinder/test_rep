namespace seq {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"seq.Customer_info", typeof(global::seq.Customer_info))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"seq.Purchase_info", typeof(global::seq.Purchase_info))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"seq.Output_schema", typeof(global::seq.Output_schema))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1"" version=""1.0"" xmlns:s0=""http://seq.Purchase_info"" xmlns:ns0=""http://seq.Output_schema"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s1=""http://seq.Customer_info"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:Root>
      <First_name>
        <xsl:value-of select=""InputMessagePart_0/s1:Customer_Details/First_name/text()"" />
      </First_name>
      <Last_name>
        <xsl:value-of select=""InputMessagePart_0/s1:Customer_Details/Last_name/text()"" />
      </Last_name>
      <PoNo>
        <xsl:value-of select=""InputMessagePart_0/s1:Customer_Details/PoNo/text()"" />
      </PoNo>
      <Items>
        <xsl:value-of select=""InputMessagePart_1/s0:Purchase_Details/ItemDetails/text()"" />
      </Items>
      <DateOfPurchase>
        <xsl:value-of select=""InputMessagePart_1/s0:Purchase_Details/DateofPurchase/text()"" />
      </DateOfPurchase>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"seq.Customer_info";
        
        private const global::seq.Customer_info _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"seq.Purchase_info";
        
        private const global::seq.Purchase_info _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"seq.Output_schema";
        
        private const global::seq.Output_schema _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"seq.Customer_info";
                _SrcSchemas[1] = @"seq.Purchase_info";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"seq.Output_schema";
                return _TrgSchemas;
            }
        }
    }
}
