namespace Map_database {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Map_database.Incoming_Data", typeof(global::Map_database.Incoming_Data))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Map_database.Outcoming_Data", typeof(global::Map_database.Outcoming_Data))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0"" version=""1.0"" xmlns:ns0=""http://Map_database.Outcoming_Data"" xmlns:s0=""http://Map_database.Incoming_Data"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <xsl:variable name=""var:v3"" select=""string(Product_details/ID/text())"" />
    <ns0:Customer>
      <ProductDetails>
        <xsl:variable name=""var:v1"" select=""ScriptNS0:DBLookup(0 , string(Product_details/ID/text()) , &quot;Provider=SQLOLEDB;server=localhost;Database=Biz_EX;&quot; , &quot;Product_details&quot; , &quot;ID&quot;)"" />
        <xsl:variable name=""var:v2"" select=""ScriptNS0:DBValueExtract(string($var:v1) , &quot;ID&quot;)"" />
        <ID>
          <xsl:value-of select=""$var:v2"" />
        </ID>
        <xsl:variable name=""var:v4"" select=""ScriptNS0:DBLookup(0 , $var:v3 , &quot;Provider=SQLOLEDB;server=localhost;Database=Biz_EX;&quot; , &quot;Product_details&quot; , &quot;ID&quot;)"" />
        <xsl:variable name=""var:v5"" select=""ScriptNS0:DBValueExtract(string($var:v4) , &quot;ProdcutName&quot;)"" />
        <ProductName>
          <xsl:value-of select=""$var:v5"" />
        </ProductName>
        <xsl:variable name=""var:v6"" select=""ScriptNS0:DBLookup(0 , $var:v3 , &quot;Provider=SQLOLEDB;server=localhost;Database=Biz_EX;&quot; , &quot;Product_details&quot; , &quot;ID&quot;)"" />
        <xsl:variable name=""var:v7"" select=""ScriptNS0:DBValueExtract(string($var:v6) , &quot;Qty&quot;)"" />
        <Qty>
          <xsl:value-of select=""$var:v7"" />
        </Qty>
        <xsl:variable name=""var:v8"" select=""ScriptNS0:DBLookup(0 , $var:v3 , &quot;Provider=SQLOLEDB;server=localhost;Database=Biz_EX;&quot; , &quot;Product_details&quot; , &quot;ID&quot;)"" />
        <xsl:variable name=""var:v9"" select=""ScriptNS0:DBValueExtract(string($var:v8) , &quot;Price&quot;)"" />
        <Date>
          <xsl:value-of select=""$var:v9"" />
        </Date>
        <xsl:variable name=""var:v10"" select=""ScriptNS0:DBLookup(0 , $var:v3 , &quot;Provider=SQLOLEDB;server=localhost;Database=Biz_EX;&quot; , &quot;Product_details&quot; , &quot;ID&quot;)"" />
        <xsl:variable name=""var:v11"" select=""ScriptNS0:DBValueExtract(string($var:v10) , &quot;Price&quot;)"" />
        <Price>
          <xsl:value-of select=""$var:v11"" />
        </Price>
        <xsl:variable name=""var:v12"" select=""ScriptNS0:DBLookup(0 , $var:v3 , &quot;Provider=SQLOLEDB;server=localhost;Database=Biz_EX;&quot; , &quot;Product_details&quot; , &quot;ID&quot;)"" />
        <xsl:variable name=""var:v13"" select=""ScriptNS0:DBValueExtract(string($var:v12) , &quot;TotalAmount&quot;)"" />
        <Totalamount>
          <xsl:value-of select=""$var:v13"" />
        </Totalamount>
      </ProductDetails>
    </ns0:Customer>
    <xsl:variable name=""var:v14"" select=""ScriptNS0:DBLookupShutdown()"" />
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Map_database.Incoming_Data";
        
        private const global::Map_database.Incoming_Data _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Map_database.Outcoming_Data";
        
        private const global::Map_database.Outcoming_Data _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Map_database.Incoming_Data";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Map_database.Outcoming_Data";
                return _TrgSchemas;
            }
        }
    }
}
