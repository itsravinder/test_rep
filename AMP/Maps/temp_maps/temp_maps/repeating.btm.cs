namespace temp_maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"temp_maps.repating_source", typeof(global::temp_maps.repating_source))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"temp_maps.Repate_dest", typeof(global::temp_maps.Repate_dest))]
    public sealed class repeating : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://temp_maps.repating_source"" xmlns:ns0=""http://temp_maps.Repate_out"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Source"" />
  </xsl:template>
  <xsl:template match=""/s0:Source"">
    <ns0:Target>
      <xsl:variable name=""var:v1"" select=""userCSharp:InitCumulativeConcat(0)"" />
      <xsl:for-each select=""/s0:Source/Main/RepatingRecord"">
        <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(Quad/text()) , &quot;10&quot;)"" />
        <xsl:if test=""string($var:v2)='true'"">
          <xsl:variable name=""var:v3"" select=""String/text()"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v3),&quot;1000&quot;)"" />
        </xsl:if>
      </xsl:for-each>
      <xsl:variable name=""var:v5"" select=""userCSharp:GetCumulativeConcat(0)"" />
      <xsl:variable name=""var:v6"" select=""userCSharp:StringSubstring(string($var:v5) , &quot;1&quot; , &quot;3&quot;)"" />
      <First3Characters>
        <xsl:value-of select=""$var:v6"" />
      </First3Characters>
      <xsl:variable name=""var:v7"" select=""userCSharp:InitCumulativeConcat(0)"" />
      <xsl:for-each select=""/s0:Source/Main/RepatingRecord"">
        <xsl:variable name=""var:v8"" select=""string(Quad/text())"" />
        <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq($var:v8 , &quot;10&quot;)"" />
        <xsl:if test=""string($var:v9)='true'"">
          <xsl:variable name=""var:v10"" select=""String/text()"" />
          <xsl:variable name=""var:v11"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v10),&quot;1000&quot;)"" />
        </xsl:if>
      </xsl:for-each>
      <xsl:variable name=""var:v12"" select=""userCSharp:GetCumulativeConcat(0)"" />
      <xsl:variable name=""var:v13"" select=""userCSharp:StringSubstring(string($var:v12) , &quot;4&quot; , &quot;6&quot;)"" />
      <Next3characters>
        <xsl:value-of select=""$var:v13"" />
      </Next3characters>
      <xsl:variable name=""var:v14"" select=""userCSharp:InitCumulativeConcat(0)"" />
      <xsl:for-each select=""/s0:Source/Main/RepatingRecord"">
        <xsl:variable name=""var:v15"" select=""string(Quad/text())"" />
        <xsl:variable name=""var:v16"" select=""userCSharp:LogicalEq($var:v15 , &quot;10&quot;)"" />
        <xsl:if test=""string($var:v16)='true'"">
          <xsl:variable name=""var:v17"" select=""String/text()"" />
          <xsl:variable name=""var:v18"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v17),&quot;1000&quot;)"" />
        </xsl:if>
      </xsl:for-each>
      <xsl:variable name=""var:v19"" select=""userCSharp:GetCumulativeConcat(0)"" />
      <ConcanetatedString>
        <xsl:value-of select=""$var:v19"" />
      </ConcanetatedString>
    </ns0:Target>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string InitCumulativeConcat(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeConcatArray.Count)
		{
			int i = myCumulativeConcatArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeConcatArray.Add("""");
			}
		}
		else
		{
			myCumulativeConcatArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeConcatArray = new System.Collections.ArrayList();

public string AddToCumulativeConcat(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	myCumulativeConcatArray[index] = (string)(myCumulativeConcatArray[index]) + val;
	return myCumulativeConcatArray[index].ToString();
}

public string GetCumulativeConcat(int index)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	return myCumulativeConcatArray[index].ToString();
}

public string StringSubstring(string str, string left, string right)
{
	string retval = """";
	double dleft = 0;
	double dright = 0;
	if (str != null && IsNumeric(left, ref dleft) && IsNumeric(right, ref dright))
	{
		int lt = (int)dleft;
		int rt = (int)dright;
		lt--; rt--;
		if (lt >= 0 && rt >= lt && lt < str.Length)
		{
			if (rt < str.Length)
			{
				retval = str.Substring(lt, rt-lt+1);
			}
			else
			{
				retval = str.Substring(lt, str.Length-lt);
			}
		}
	}
	return retval;
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
        
        private const string _strSrcSchemasList0 = @"temp_maps.repating_source";
        
        private const global::temp_maps.repating_source _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"temp_maps.Repate_dest";
        
        private const global::temp_maps.Repate_dest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"temp_maps.repating_source";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"temp_maps.Repate_dest";
                return _TrgSchemas;
            }
        }
    }
}
