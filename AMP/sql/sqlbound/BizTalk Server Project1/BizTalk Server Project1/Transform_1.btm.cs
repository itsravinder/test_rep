namespace BizTalk_Server_Project1 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.IN_Xml", typeof(global::BizTalk_Server_Project1.IN_Xml))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk_Server_Project1.Procedure_dbo+uspInsertOrderDetails", typeof(global::BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:s0=""http://BizTalk_Server_Project1.IN_Xml"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <ns0:uspInsertOrderDetails>
      <ns0:OrderID>
        <xsl:value-of select=""Details/OrderID/text()"" />
      </ns0:OrderID>
      <ns0:OrderDate>
        <xsl:value-of select=""Details/OrderDate/text()"" />
      </ns0:OrderDate>
      <ns0:BillToID>
        <xsl:value-of select=""Details/BillToID/text()"" />
      </ns0:BillToID>
      <ns0:ShipToID>
        <xsl:value-of select=""Details/ShipToID/text()"" />
      </ns0:ShipToID>
      <ns0:BillToName>
        <xsl:value-of select=""Details/BillToName/text()"" />
      </ns0:BillToName>
      <ns0:BillToCity>
        <xsl:value-of select=""Details/BillToCity/text()"" />
      </ns0:BillToCity>
      <ns0:ShipToName>
        <xsl:value-of select=""Details/ShipToName/text()"" />
      </ns0:ShipToName>
      <ns0:ShipToCity>
        <xsl:value-of select=""Details/ShipToCity/text()"" />
      </ns0:ShipToCity>
      <ns0:Comments>
        <xsl:value-of select=""Details/Comments/text()"" />
      </ns0:Comments>
      <ns0:TotalAmount>
        <xsl:value-of select=""Details/Amount/text()"" />
      </ns0:TotalAmount>
    </ns0:uspInsertOrderDetails>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalk_Server_Project1.IN_Xml";
        
        private const global::BizTalk_Server_Project1.IN_Xml _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalk_Server_Project1.Procedure_dbo+uspInsertOrderDetails";
        
        private const global::BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalk_Server_Project1.IN_Xml";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalk_Server_Project1.Procedure_dbo+uspInsertOrderDetails";
                return _TrgSchemas;
            }
        }
    }
}
