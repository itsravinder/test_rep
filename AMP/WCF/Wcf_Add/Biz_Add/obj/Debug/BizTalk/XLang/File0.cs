
#pragma warning disable 162

namespace Biz_Add
{

    [System.SerializableAttribute]
    sealed public class __Biz_Add_wcfaDD_tempuri_org_add__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Biz_Add.wcfaDD_tempuri_org.add _schema = new Biz_Add.wcfaDD_tempuri_org.add();

        public __Biz_Add_wcfaDD_tempuri_org_add__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Biz_Add.wcfaDD_tempuri_org.add)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Biz_Add_wcfaDD_tempuri_org_add__)
        },
        0,
        @"http://tempuri.org/#add"
    )]
    [System.SerializableAttribute]
    sealed internal class IwcfaDD_add_InputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Biz_Add_wcfaDD_tempuri_org_add__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Biz_Add_wcfaDD_tempuri_org_add__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public IwcfaDD_add_InputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Biz_Add_wcfaDD_tempuri_org_addResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Biz_Add.wcfaDD_tempuri_org.addResponse _schema = new Biz_Add.wcfaDD_tempuri_org.addResponse();

        public __Biz_Add_wcfaDD_tempuri_org_addResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Biz_Add.wcfaDD_tempuri_org.addResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Biz_Add_wcfaDD_tempuri_org_addResponse__)
        },
        0,
        @"http://tempuri.org/#addResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class IwcfaDD_add_OutputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Biz_Add_wcfaDD_tempuri_org_addResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Biz_Add_wcfaDD_tempuri_org_addResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public IwcfaDD_add_OutputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "add",
        new System.Type[]{
            typeof(Biz_Add.IwcfaDD_add_InputMessage), 
            typeof(Biz_Add.IwcfaDD_add_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class IwcfaDD : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public IwcfaDD(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public IwcfaDD(IwcfaDD p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            IwcfaDD p = new IwcfaDD(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo add = new Microsoft.XLANGs.Core.OperationInfo
        (
            "add",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(IwcfaDD),
            typeof(IwcfaDD_add_InputMessage),
            typeof(IwcfaDD_add_OutputMessage),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "add" ] = add;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __Biz_Add_Input_schema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Biz_Add.Input_schema _schema = new Biz_Add.Input_schema();

        public __Biz_Add_Input_schema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Biz_Add.Input_schema",
        new System.Type[]{
            typeof(Biz_Add.Input_schema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Biz_Add_Input_schema__)
        },
        0,
        @"http://Biz_Add.Input_schema#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Biz_Add_Input_schema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Biz_Add_Input_schema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Biz_Add_Input_schema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Biz_Add_Input_schema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Biz_Add.__messagetype_Biz_Add_Input_schema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Rcv_input_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Rcv_input_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Rcv_input_type(Rcv_input_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Rcv_input_type p = new Rcv_input_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Rcv_input_type),
            typeof(__messagetype_Biz_Add_Input_schema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Biz_Add.IwcfaDD_add_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Output_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Output_response(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Output_response(Output_response p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Output_response p = new Output_response(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Output_response),
            typeof(IwcfaDD_add_OutputMessage),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 290 "C:\AMP\WCF\Wcf_Add\Biz_Add\wcfaDD.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Rcv_input", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Biz_Add.Rcv_input_type),
            typeof(Biz_Add.IwcfaDD),
            typeof(Biz_Add.Output_response)
        },
        new System.String[] {
            "Rcv_input",
            "Port_1",
            "OutPut"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class wcfaDDClient : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(wcfaDDClient));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static wcfaDDClient()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __wcfaDDClient_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public wcfaDDClient(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "wcfaDDClient", tracker)
        {
            ConstructorHelper();
        }

        public wcfaDDClient(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "wcfaDDClient")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>21e5baa1-70e9-4cff-981b-49aeeae53ffd</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>6c6ada16-1222-44ae-a667-97a2e4c1347e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c06e9dd8-9934-43f5-92f7-16d0d72cb5a4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>9ac65648-9018-4cfe-b3df-a6e22aaa1a8b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>542451e5-aed0-4c7e-8050-b6c7e0f85aea</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b15855ef-9627-44dd-97bd-b54db40a8da7</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8f7e61ce-d0b9-4f65-8b4d-ab949ea02a39</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>40418879-68a3-4bc9-947b-c287e94df28c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b69409d3-bc0c-4f25-b29c-4c3087bfc6f2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f3baa9c0-1656-4c57-be14-0648928efd40</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'wcfaDDClient'</ActionName><IsAtomic>0</IsAtomic><Line>290</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>304</Line><Position>22</Position><ShapeID>'6c6ada16-1222-44ae-a667-97a2e4c1347e'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>Biz_Add.Input_schema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>306</Line><Position>13</Position><ShapeID>'c06e9dd8-9934-43f5-92f7-16d0d72cb5a4'</ShapeID>
<Messages>
	<MsgInfo><name>Wcf_request</name><part>parameters</part><schema>Biz_Add.wcfaDD_tempuri_org+add</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Input</name><part>part</part><schema>Biz_Add.Input_schema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>312</Line><Position>13</Position><ShapeID>'40418879-68a3-4bc9-947b-c287e94df28c'</ShapeID>
<Messages>
	<MsgInfo><name>Wcf_request</name><part>parameters</part><schema>Biz_Add.wcfaDD_tempuri_org+add</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>314</Line><Position>13</Position><ShapeID>'b69409d3-bc0c-4f25-b29c-4c3087bfc6f2'</ShapeID>
<Messages>
	<MsgInfo><name>Wcf_Response</name><part>parameters</part><schema>Biz_Add.wcfaDD_tempuri_org+addResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>316</Line><Position>13</Position><ShapeID>'f3baa9c0-1656-4c57-be14-0648928efd40'</ShapeID>
<Messages>
	<MsgInfo><name>Wcf_Response</name><part>parameters</part><schema>Biz_Add.wcfaDD_tempuri_org+addResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='7a09a912-28a8-4615-b509-c6df671ed18b' LowerBound='1.1' HigherBound='64.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Biz_Add' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='905dda26-a12f-450c-ad4e-4dc824c317f8' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;IwcfaDD&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IwcfaDD' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='1b4975ca-d7e8-4634-a668-c06c5f08dd13' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;add&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='add' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='7a00c338-9bea-47e6-9c8c-da0d408a6c8b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.37'>
                    <om:Property Name='Ref' Value='Biz_Add.IwcfaDD_add_InputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://tempuri.org/:IwcfaDD_add_InputMessage&quot;/&gt;&#xD;&#xA;Action=&quot;http://tempuri.org/IwcfaDD/add&quot;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='97683ff2-777b-447c-aba3-7d8642dd821f' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.39' HigherBound='16.64'>
                    <om:Property Name='Ref' Value='Biz_Add.IwcfaDD_add_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://tempuri.org/:IwcfaDD_add_OutputMessage&quot;/&gt;&#xD;&#xA;Action=&quot;http://tempuri.org/IwcfaDD/addResponse&quot;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c5e07df2-e98f-4aea-b4ef-bde77ec55a2c' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Rcv_input_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='293de9c9-bb08-475f-8990-7f762a4285ea' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='2fba608b-5561-404a-848d-a5fdee81fa1b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.25'>
                    <om:Property Name='Ref' Value='Biz_Add.Input_schema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='cca8f62d-4681-4da0-bbb4-1cb6e257f35c' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Output_response' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d70c0abb-6936-4007-aacd-21485c0d4d6b' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b7686363-6b15-4c3d-a7f2-5660df36668d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.38'>
                    <om:Property Name='Ref' Value='Biz_Add.IwcfaDD_add_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='4256e943-f2f8-4d2d-9c86-090c405bc83c' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;IwcfaDD_add_InputMessage&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IwcfaDD_add_InputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='e2ca8592-e6ff-4e13-b9c4-150ecefff59f' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='Biz_Add.wcfaDD_tempuri_org.add' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='b590ca9c-ed8d-42da-9d0d-0ccb4fa69394' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;IwcfaDD_add_OutputMessage&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IwcfaDD_add_OutputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='96ce9864-b3d1-4118-9457-81686552d6b3' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='Biz_Add.wcfaDD_tempuri_org.addResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='ad8fb03a-7256-4670-9d07-578428b4ff61' ParentLink='Module_ServiceDeclaration' LowerBound='33.1' HigherBound='63.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:service name=&quot;wcfaDD&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='wcfaDDClient' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='21e5baa1-70e9-4cff-981b-49aeeae53ffd' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='6c6ada16-1222-44ae-a667-97a2e4c1347e' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Rcv_input' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='c06e9dd8-9934-43f5-92f7-16d0d72cb5a4' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='55.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='9ac65648-9018-4cfe-b3df-a6e22aaa1a8b' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='54.1'>
                        <om:Property Name='ClassName' Value='Biz_Add.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='542451e5-aed0-4c7e-8050-b6c7e0f85aea' ParentLink='Transform_InputMessagePartRef' LowerBound='53.75' HigherBound='53.80'>
                            <om:Property Name='MessageRef' Value='Input' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='b15855ef-9627-44dd-97bd-b54db40a8da7' ParentLink='Transform_OutputMessagePartRef' LowerBound='53.28' HigherBound='53.50'>
                            <om:Property Name='MessageRef' Value='Wcf_request' />
                            <om:Property Name='PartRef' Value='parameters' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='8f7e61ce-d0b9-4f65-8b4d-ab949ea02a39' ParentLink='Construct_MessageRef' LowerBound='50.23' HigherBound='50.34'>
                        <om:Property Name='Ref' Value='Wcf_request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='40418879-68a3-4bc9-947b-c287e94df28c' ParentLink='ServiceBody_Statement' LowerBound='55.1' HigherBound='57.1'>
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='Wcf_request' />
                    <om:Property Name='OperationName' Value='add' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='b69409d3-bc0c-4f25-b29c-4c3087bfc6f2' ParentLink='ServiceBody_Statement' LowerBound='57.1' HigherBound='59.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='Wcf_Response' />
                    <om:Property Name='OperationName' Value='add' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='f3baa9c0-1656-4c57-be14-0648928efd40' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='61.1'>
                    <om:Property Name='PortName' Value='OutPut' />
                    <om:Property Name='MessageName' Value='Wcf_Response' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7c1759a0-d91e-4ed3-bd0a-e408aaed3c32' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Biz_Add.Rcv_input_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Rcv_input' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5c253f16-467a-42ac-af5c-637e966f4040' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b158d0bc-7330-4bc7-be00-2d0a9f8221e2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='38.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Biz_Add.IwcfaDD' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='215d4119-983a-494f-9415-82cb17d3b61b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='38.1' HigherBound='39.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d25e0eb9-3079-4c9f-8417-e6e05d36721d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Biz_Add.Output_response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OutPut' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='71d2a64f-6066-490b-afd1-7b2c96264c34' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f22000b2-f68c-4865-95cc-393bb27841df' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='Biz_Add.Input_schema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Input' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='80862e78-7b0c-4377-bfd9-72179cf8aa26' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='Biz_Add.IwcfaDD_add_InputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Wcf_request' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='59320802-c991-40f4-b776-10b2fc80eabf' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='Biz_Add.IwcfaDD_add_OutputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Wcf_Response' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __wcfaDDClient_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __wcfaDDClient_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "wcfaDDClient")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                wcfaDDClient __svc__ = (wcfaDDClient)_service;
                __wcfaDDClient_root_0 __ctx0__ = (__wcfaDDClient_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.OutPut != null)
                {
                    __svc__.OutPut.Close(this, null);
                    __svc__.OutPut = null;
                }
                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                if (__svc__.Rcv_input != null)
                {
                    __svc__.Rcv_input.Close(this, null);
                    __svc__.Rcv_input = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __wcfaDDClient_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __wcfaDDClient_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "wcfaDDClient")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                wcfaDDClient __svc__ = (wcfaDDClient)_service;
                __wcfaDDClient_root_0 __ctx0__ = (__wcfaDDClient_root_0)(__svc__._stateMgrs[0]);
                __wcfaDDClient_1 __ctx1__ = (__wcfaDDClient_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Wcf_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Wcf_Response);
                    __ctx1__.__Wcf_Response = null;
                }
                if (__ctx1__ != null && __ctx1__.__Wcf_request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Wcf_request);
                    __ctx1__.__Wcf_request = null;
                }
                if (__ctx1__ != null && __ctx1__.__Input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                    __ctx1__.__Input = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Input")]
            public __messagetype_Biz_Add_Input_schema __Input;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Wcf_request")]
            internal IwcfaDD_add_InputMessage __Wcf_request;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Wcf_Response")]
            internal IwcfaDD_add_OutputMessage __Wcf_Response;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Rcv_input")]
        internal Rcv_input_type Rcv_input;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal IwcfaDD Port_1;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OutPut")]
        internal Output_response OutPut;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Rcv_input_type.Operation_1},
                                               typeof(wcfaDDClient).GetField("Rcv_input", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(wcfaDDClient), "Rcv_input"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {IwcfaDD.add},
                                               typeof(wcfaDDClient).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(wcfaDDClient), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Output_response.Operation_1},
                                               typeof(wcfaDDClient).GetField("OutPut", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(wcfaDDClient), "OutPut"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "6c6ada16-1222-44ae-a667-97a2e4c1347e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "6c6ada16-1222-44ae-a667-97a2e4c1347e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "c06e9dd8-9934-43f5-92f7-16d0d72cb5a4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "c06e9dd8-9934-43f5-92f7-16d0d72cb5a4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "40418879-68a3-4bc9-947b-c287e94df28c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "40418879-68a3-4bc9-947b-c287e94df28c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "b69409d3-bc0c-4f25-b29c-4c3087bfc6f2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "b69409d3-bc0c-4f25-b29c-4c3087bfc6f2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f3baa9c0-1656-4c57-be14-0648928efd40", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "f3baa9c0-1656-4c57-be14-0648928efd40", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __wcfaDDClient_root_0 __ctx0__ = (__wcfaDDClient_root_0)_stateMgrs[0];
            __wcfaDDClient_1 __ctx1__ = (__wcfaDDClient_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Rcv_input = new Rcv_input_type(0, this);
                Port_1 = new IwcfaDD(1, this);
                OutPut = new Output_response(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Rcv_input, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __wcfaDDClient_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __wcfaDDClient_root_0 __ctx0__ = (__wcfaDDClient_root_0)_stateMgrs[0];
            __wcfaDDClient_1 __ctx1__ = (__wcfaDDClient_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Rcv_input.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Input != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                __ctx1__.__Input = new __messagetype_Biz_Add_Input_schema("Input", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Input);
                Rcv_input.ReceiveMessage(0, __msgEnv__, __ctx1__.__Input, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Rcv_input != null)
                {
                    Rcv_input.Close(__ctx1__, __seg__);
                    Rcv_input = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Input);
                    __edata.PortName = @"Rcv_input";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    IwcfaDD_add_InputMessage __Wcf_request = new IwcfaDD_add_InputMessage("Wcf_request", __ctx1__);

                    ApplyTransform(typeof(Biz_Add.Transform_1), new object[] {__Wcf_request.parameters}, new object[] {__ctx1__.__Input.part});

                    if (__ctx1__.__Wcf_request != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Wcf_request);
                    __ctx1__.__Wcf_request = __Wcf_request;
                    __ctx1__.RefMessage(__ctx1__.__Wcf_request);
                }
                __ctx1__.__Wcf_request.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Wcf_request);
                    __edata.Messages.Add(__ctx1__.__Input);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                    __ctx1__.__Input = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_1.SendMessage(0, __ctx1__.__Wcf_request, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Wcf_request);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Wcf_request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Wcf_request);
                    __ctx1__.__Wcf_request = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__Wcf_Response != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Wcf_Response);
                __ctx1__.__Wcf_Response = new IwcfaDD_add_OutputMessage("Wcf_Response", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Wcf_Response);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__Wcf_Response, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Wcf_Response);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                OutPut.SendMessage(0, __ctx1__.__Wcf_Response, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (OutPut != null)
                {
                    OutPut.Close(__ctx1__, __seg__);
                    OutPut = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Wcf_Response);
                    __edata.PortName = @"OutPut";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Wcf_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Wcf_Response);
                    __ctx1__.__Wcf_Response = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 22;
            case 22:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{CCF3FF2F-5EDB-4CC9-8A27-49B50F47796D}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
