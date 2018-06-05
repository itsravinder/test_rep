namespace Parallel {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Parallel.Billing_details", typeof(global::Parallel.Billing_details))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Parallel.Customer_Details", typeof(global::Parallel.Customer_Details))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Parallel.Shopping_Details", typeof(global::Parallel.Shopping_Details))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Parallel.Output_schema", typeof(global::Parallel.Output_schema))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s3 s1 s2 userCSharp"" version=""1.0"" xmlns:s0=""http://Parallel.Shopping_Details"" xmlns:s3=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://Parallel.Output_schema"" xmlns:s2=""http://Parallel.Customer_Details"" xmlns:s1=""http://Parallel.Billing_details"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s3:Root"" />
  </xsl:template>
  <xsl:template match=""/s3:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(InputMessagePart_1/s2:Root/First_Name/text()) , string(InputMessagePart_1/s2:Root/Last_Name/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(InputMessagePart_0/s1:Root/Address1/text()) , string(InputMessagePart_0/s1:Root/Address2/text()))"" />
    <ns0:Root>
      <Customer_Id>
        <xsl:value-of select=""InputMessagePart_0/s1:Root/Cust_ID/text()"" />
      </Customer_Id>
      <Item_number>
        <xsl:value-of select=""InputMessagePart_2/s0:Shopping_details/Item_number/text()"" />
      </Item_number>
      <Item_price>
        <xsl:value-of select=""InputMessagePart_2/s0:Shopping_details/Price/text()"" />
      </Item_price>
      <Customer_name>
        <xsl:value-of select=""$var:v1"" />
      </Customer_name>
      <Address>
        <xsl:value-of select=""$var:v2"" />
      </Address>
      <city>
        <xsl:value-of select=""InputMessagePart_0/s1:Root/City/text()"" />
      </city>
      <State>
        <xsl:value-of select=""InputMessagePart_0/s1:Root/State/text()"" />
      </State>
      <Pincode>
        <xsl:value-of select=""InputMessagePart_0/s1:Root/PinCode/text()"" />
      </Pincode>
      <type>
        <xsl:value-of select=""InputMessagePart_2/s0:Shopping_details/Type/text()"" />
      </type>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Parallel.Billing_details";
        
        private const global::Parallel.Billing_details _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Parallel.Customer_Details";
        
        private const global::Parallel.Customer_Details _srcSchemaTypeReference1 = null;
        
        private const string _strSrcSchemasList2 = @"Parallel.Shopping_Details";
        
        private const global::Parallel.Shopping_Details _srcSchemaTypeReference2 = null;
        
        private const string _strTrgSchemasList0 = @"Parallel.Output_schema";
        
        private const global::Parallel.Output_schema _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [3];
                _SrcSchemas[0] = @"Parallel.Billing_details";
                _SrcSchemas[1] = @"Parallel.Customer_Details";
                _SrcSchemas[2] = @"Parallel.Shopping_Details";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Parallel.Output_schema";
                return _TrgSchemas;
            }
        }
    }
}
