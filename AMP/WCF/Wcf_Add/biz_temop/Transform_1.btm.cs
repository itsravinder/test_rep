namespace biz_temop {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"biz_temop.inputxsd", typeof(global::biz_temop.inputxsd))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"biz_temop.output", typeof(global::biz_temop.output))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://biz_temop.output"" xmlns:s0=""http://biz_temop.inputxsd"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:MathAdd(string(A/text()) , string(B/text()))"" />
    <ns0:Root>
      <Res>
        <xsl:value-of select=""$var:v1"" />
      </Res>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathAdd(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 0;
	foreach (string obj in listValues)
	{
	double d = 0;
		if (IsNumeric(obj, ref d))
		{
			ret += d;
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"biz_temop.inputxsd";
        
        private const global::biz_temop.inputxsd _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"biz_temop.output";
        
        private const global::biz_temop.output _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"biz_temop.inputxsd";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"biz_temop.output";
                return _TrgSchemas;
            }
        }
    }
}
