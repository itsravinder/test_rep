namespace Bre_Scope {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Bre_Scope.LoanApplication", typeof(global::Bre_Scope.LoanApplication))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Bre_Scope.LoanApproval", typeof(global::Bre_Scope.LoanApproval))]
    public sealed class LoanApprovalMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Bre_Scope.LoanApproval"" xmlns:s0=""http://Bre_Scope.LoanApplication"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:Root>
      <Status>
        <xsl:value-of select=""$var:v1"" />
      </Status>
      <Comments>
        <xsl:value-of select=""$var:v1"" />
      </Comments>
      <Amount>
        <xsl:value-of select=""Amount/text()"" />
      </Amount>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Bre_Scope.LoanApplication";
        
        private const global::Bre_Scope.LoanApplication _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Bre_Scope.LoanApproval";
        
        private const global::Bre_Scope.LoanApproval _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Bre_Scope.LoanApplication";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Bre_Scope.LoanApproval";
                return _TrgSchemas;
            }
        }
    }
}
