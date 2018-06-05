
#pragma warning disable 162

namespace Temp_biz
{

    [System.SerializableAttribute]
    sealed public class __Temp_biz_Service1_tempuri_org_Display__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Temp_biz.Service1_tempuri_org.Display _schema = new Temp_biz.Service1_tempuri_org.Display();

        public __Temp_biz_Service1_tempuri_org_Display__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Temp_biz.Service1_tempuri_org.Display)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Temp_biz_Service1_tempuri_org_Display__)
        },
        0,
        @"http://tempuri.org/#Display"
    )]
    [System.SerializableAttribute]
    sealed internal class IService1_Display_InputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Temp_biz_Service1_tempuri_org_Display__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Temp_biz_Service1_tempuri_org_Display__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public IService1_Display_InputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Temp_biz_Service1_tempuri_org_DisplayResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Temp_biz.Service1_tempuri_org.DisplayResponse _schema = new Temp_biz.Service1_tempuri_org.DisplayResponse();

        public __Temp_biz_Service1_tempuri_org_DisplayResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Temp_biz.Service1_tempuri_org.DisplayResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Temp_biz_Service1_tempuri_org_DisplayResponse__)
        },
        0,
        @"http://tempuri.org/#DisplayResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class IService1_Display_OutputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Temp_biz_Service1_tempuri_org_DisplayResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Temp_biz_Service1_tempuri_org_DisplayResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public IService1_Display_OutputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Display",
        new System.Type[]{
            typeof(Temp_biz.IService1_Display_InputMessage), 
            typeof(Temp_biz.IService1_Display_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class IService1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public IService1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public IService1(IService1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            IService1 p = new IService1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Display = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Display",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(IService1),
            typeof(IService1_Display_InputMessage),
            typeof(IService1_Display_OutputMessage),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Display" ] = Display;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __Temp_biz_input__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Temp_biz.input _schema = new Temp_biz.input();

        public __Temp_biz_input__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Temp_biz.input",
        new System.Type[]{
            typeof(Temp_biz.input)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Temp_biz_input__)
        },
        0,
        @"http://Temp_biz.input#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Temp_biz_input : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Temp_biz_input__ part;

        private void __CreatePartWrappers()
        {
            part = new __Temp_biz_input__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Temp_biz_input(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Temp_biz.__messagetype_Temp_biz_input)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class rcv_input_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public rcv_input_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public rcv_input_type(rcv_input_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            rcv_input_type p = new rcv_input_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(rcv_input_type),
            typeof(__messagetype_Temp_biz_input),
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
            typeof(Temp_biz.IService1_Display_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Resp_outputType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Resp_outputType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Resp_outputType(Resp_outputType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Resp_outputType p = new Resp_outputType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Resp_outputType),
            typeof(IService1_Display_OutputMessage),
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
    //#line 290 "C:\AMP\WCF\temp_wcf\Temp_biz\Service1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "rcv_input", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Temp_biz.rcv_input_type),
            typeof(Temp_biz.IService1),
            typeof(Temp_biz.Resp_outputType)
        },
        new System.String[] {
            "rcv_input",
            "web",
            "Resp_output"
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
    sealed internal class Service1Client : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Service1Client));
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

        static Service1Client()
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
            _rootContext = new __Service1Client_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Service1Client(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Service1Client", tracker)
        {
            ConstructorHelper();
        }

        public Service1Client(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Service1Client")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>d71cbf72-668c-4c7e-ae12-9c1b314e5498</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f3ce82d5-8d63-4f01-81f7-a48b76ba1494</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>80f445e4-491c-4ceb-8ffe-ce554bd1f034</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6025f61c-fe6a-46b5-b3bd-f445cbe82972</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fcc3030e-b919-4a73-a40d-c66bed77dde5</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e325d5f9-b0fe-48ff-bafe-6df94396e7e1</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c966c04b-7cae-47cc-b797-1dedeb47b089</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>372da80f-bbba-478e-97c5-f4fb7113a854</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>23301b06-53c1-4fcf-90df-c255aa839b6c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9b8c9637-4be2-4575-bb2b-69dc1c46034b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Service1Client'</ActionName><IsAtomic>0</IsAtomic><Line>290</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>304</Line><Position>22</Position><ShapeID>'f3ce82d5-8d63-4f01-81f7-a48b76ba1494'</ShapeID>
<Messages>
	<MsgInfo><name>recv</name><part>part</part><schema>Temp_biz.input</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>306</Line><Position>13</Position><ShapeID>'80f445e4-491c-4ceb-8ffe-ce554bd1f034'</ShapeID>
<Messages>
	<MsgInfo><name>web_rcv</name><part>parameters</part><schema>Temp_biz.Service1_tempuri_org+Display</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>recv</name><part>part</part><schema>Temp_biz.input</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>312</Line><Position>13</Position><ShapeID>'372da80f-bbba-478e-97c5-f4fb7113a854'</ShapeID>
<Messages>
	<MsgInfo><name>web_rcv</name><part>parameters</part><schema>Temp_biz.Service1_tempuri_org+Display</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>314</Line><Position>13</Position><ShapeID>'23301b06-53c1-4fcf-90df-c255aa839b6c'</ShapeID>
<Messages>
	<MsgInfo><name>web_resp</name><part>parameters</part><schema>Temp_biz.Service1_tempuri_org+DisplayResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>316</Line><Position>13</Position><ShapeID>'9b8c9637-4be2-4575-bb2b-69dc1c46034b'</ShapeID>
<Messages>
	<MsgInfo><name>web_resp</name><part>parameters</part><schema>Temp_biz.Service1_tempuri_org+DisplayResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='3d173d1d-5932-4cc7-8a06-8e758d36e7c6' LowerBound='1.1' HigherBound='64.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Temp_biz' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='f8653928-fbf2-4d1e-85b8-79d1293ac85e' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:portType name=&quot;IService1&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IService1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6705727a-b7b1-431c-a046-a5679668e565' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:operation name=&quot;Display&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='Display' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b2b3bffe-3503-4bf6-b70d-2e11d41ea62e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.43'>
                    <om:Property Name='Ref' Value='Temp_biz.IService1_Display_InputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:input message=&quot;http://tempuri.org/:IService1_Display_InputMessage&quot;/&gt;&#xD;&#xA;Action=&quot;http://tempuri.org/IService1/Display&quot;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='0fcabd2e-68e3-4eb6-aa3f-2554ccba5775' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.45' HigherBound='16.76'>
                    <om:Property Name='Ref' Value='Temp_biz.IService1_Display_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='&lt;wsdl:output message=&quot;http://tempuri.org/:IService1_Display_OutputMessage&quot;/&gt;&#xD;&#xA;Action=&quot;http://tempuri.org/IService1/DisplayResponse&quot;&#xD;&#xA;' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='2d53b5d4-ea6c-4580-8ac8-5f473b0cfaf2' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='rcv_input_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3887a8ab-40b0-47d5-b7c8-04d5ee995c91' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='625402c0-4c33-4ac2-b07f-a013614480db' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.18'>
                    <om:Property Name='Ref' Value='Temp_biz.input' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e85047f4-0239-489b-996b-48b506235651' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Resp_outputType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d66d0fbe-02dd-476f-be8e-4c7ec156e860' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='147c10a4-a06a-494e-a21c-01206321d6e7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.44'>
                    <om:Property Name='Ref' Value='Temp_biz.IService1_Display_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='62b8cb17-e441-4bb9-a07a-38bf84b77dd8' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;IService1_Display_InputMessage&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IService1_Display_InputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='0bb342a0-3ad4-4719-bc3c-04f34e25a378' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='Temp_biz.Service1_tempuri_org.Display' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='943a3509-9d85-4094-aaeb-eb0939ee57ce' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:message name=&quot;IService1_Display_OutputMessage&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='IService1_Display_OutputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='d245b484-a99b-4e68-978d-bade059f57b3' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='Temp_biz.Service1_tempuri_org.DisplayResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='&lt;wsdl:part name=&quot;parameters&quot;/&gt;&#xD;&#xA;' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='4209d931-a36a-44b6-b96b-ef53977ee6c0' ParentLink='Module_ServiceDeclaration' LowerBound='33.1' HigherBound='63.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='&lt;wsdl:service name=&quot;Service1&quot;/&gt;&#xD;&#xA;' />
            <om:Property Name='Name' Value='Service1Client' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='d71cbf72-668c-4c7e-ae12-9c1b314e5498' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='f3ce82d5-8d63-4f01-81f7-a48b76ba1494' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='rcv_input' />
                    <om:Property Name='MessageName' Value='recv' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='80f445e4-491c-4ceb-8ffe-ce554bd1f034' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='55.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='6025f61c-fe6a-46b5-b3bd-f445cbe82972' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='54.1'>
                        <om:Property Name='ClassName' Value='Temp_biz.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='fcc3030e-b919-4a73-a40d-c66bed77dde5' ParentLink='Transform_InputMessagePartRef' LowerBound='53.72' HigherBound='53.76'>
                            <om:Property Name='MessageRef' Value='recv' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='e325d5f9-b0fe-48ff-bafe-6df94396e7e1' ParentLink='Transform_OutputMessagePartRef' LowerBound='53.28' HigherBound='53.46'>
                            <om:Property Name='MessageRef' Value='web_rcv' />
                            <om:Property Name='PartRef' Value='parameters' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='c966c04b-7cae-47cc-b797-1dedeb47b089' ParentLink='Construct_MessageRef' LowerBound='50.23' HigherBound='50.30'>
                        <om:Property Name='Ref' Value='web_rcv' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='372da80f-bbba-478e-97c5-f4fb7113a854' ParentLink='ServiceBody_Statement' LowerBound='55.1' HigherBound='57.1'>
                    <om:Property Name='PortName' Value='web' />
                    <om:Property Name='MessageName' Value='web_rcv' />
                    <om:Property Name='OperationName' Value='Display' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='23301b06-53c1-4fcf-90df-c255aa839b6c' ParentLink='ServiceBody_Statement' LowerBound='57.1' HigherBound='59.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='web' />
                    <om:Property Name='MessageName' Value='web_resp' />
                    <om:Property Name='OperationName' Value='Display' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='9b8c9637-4be2-4575-bb2b-69dc1c46034b' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='61.1'>
                    <om:Property Name='PortName' Value='Resp_output' />
                    <om:Property Name='MessageName' Value='web_resp' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1356eb2c-0bd4-42c6-ab3d-a991af780fde' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Temp_biz.rcv_input_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='rcv_input' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f44cf12e-1337-4cee-8ec8-761f973fe531' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='fb434470-8e6d-4a67-82ea-c19803807c5e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='38.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Temp_biz.IService1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='web' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='d40fa3fc-8be3-4327-86f4-5d34919bcb1b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='38.1' HigherBound='39.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ae9c7458-bf9f-459b-b910-c55d309092dd' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Temp_biz.Resp_outputType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Resp_output' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='30dd3104-e0b8-416c-8067-fab865e2c309' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='45629183-fef3-41ad-a424-7ae43d5ae631' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='Temp_biz.input' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='recv' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3f35d4cb-a198-47f4-b969-c204a219662d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='Temp_biz.IService1_Display_InputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='web_rcv' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='59d48031-3c60-4754-b269-b7d07d89fa96' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='Temp_biz.IService1_Display_OutputMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='web_resp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Service1Client_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Service1Client_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Service1Client")
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
                Service1Client __svc__ = (Service1Client)_service;
                __Service1Client_root_0 __ctx0__ = (__Service1Client_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Resp_output != null)
                {
                    __svc__.Resp_output.Close(this, null);
                    __svc__.Resp_output = null;
                }
                if (__svc__.web != null)
                {
                    __svc__.web.Close(this, null);
                    __svc__.web = null;
                }
                if (__svc__.rcv_input != null)
                {
                    __svc__.rcv_input.Close(this, null);
                    __svc__.rcv_input = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Service1Client_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Service1Client_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Service1Client")
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
                Service1Client __svc__ = (Service1Client)_service;
                __Service1Client_root_0 __ctx0__ = (__Service1Client_root_0)(__svc__._stateMgrs[0]);
                __Service1Client_1 __ctx1__ = (__Service1Client_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__recv != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__recv);
                    __ctx1__.__recv = null;
                }
                if (__ctx1__ != null && __ctx1__.__web_resp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__web_resp);
                    __ctx1__.__web_resp = null;
                }
                if (__ctx1__ != null && __ctx1__.__web_rcv != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__web_rcv);
                    __ctx1__.__web_rcv = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("recv")]
            public __messagetype_Temp_biz_input __recv;
            [Microsoft.XLANGs.Core.UserVariableAttribute("web_rcv")]
            internal IService1_Display_InputMessage __web_rcv;
            [Microsoft.XLANGs.Core.UserVariableAttribute("web_resp")]
            internal IService1_Display_OutputMessage __web_resp;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("rcv_input")]
        internal rcv_input_type rcv_input;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("web")]
        internal IService1 web;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Resp_output")]
        internal Resp_outputType Resp_output;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {rcv_input_type.Operation_1},
                                               typeof(Service1Client).GetField("rcv_input", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Service1Client), "rcv_input"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {IService1.Display},
                                               typeof(Service1Client).GetField("web", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Service1Client), "web"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Resp_outputType.Operation_1},
                                               typeof(Service1Client).GetField("Resp_output", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Service1Client), "Resp_output"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "f3ce82d5-8d63-4f01-81f7-a48b76ba1494", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f3ce82d5-8d63-4f01-81f7-a48b76ba1494", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "80f445e4-491c-4ceb-8ffe-ce554bd1f034", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "80f445e4-491c-4ceb-8ffe-ce554bd1f034", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "372da80f-bbba-478e-97c5-f4fb7113a854", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "372da80f-bbba-478e-97c5-f4fb7113a854", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "23301b06-53c1-4fcf-90df-c255aa839b6c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "23301b06-53c1-4fcf-90df-c255aa839b6c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9b8c9637-4be2-4575-bb2b-69dc1c46034b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "9b8c9637-4be2-4575-bb2b-69dc1c46034b", 1, false),
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
            __Service1Client_root_0 __ctx0__ = (__Service1Client_root_0)_stateMgrs[0];
            __Service1Client_1 __ctx1__ = (__Service1Client_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                rcv_input = new rcv_input_type(0, this);
                web = new IService1(1, this);
                Resp_output = new Resp_outputType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], rcv_input, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Service1Client_1(this);
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
            __Service1Client_root_0 __ctx0__ = (__Service1Client_root_0)_stateMgrs[0];
            __Service1Client_1 __ctx1__ = (__Service1Client_1)_stateMgrs[1];

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
                if (!rcv_input.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__recv != null)
                    __ctx1__.UnrefMessage(__ctx1__.__recv);
                __ctx1__.__recv = new __messagetype_Temp_biz_input("recv", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__recv);
                rcv_input.ReceiveMessage(0, __msgEnv__, __ctx1__.__recv, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (rcv_input != null)
                {
                    rcv_input.Close(__ctx1__, __seg__);
                    rcv_input = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__recv);
                    __edata.PortName = @"rcv_input";
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
                    IService1_Display_InputMessage __web_rcv = new IService1_Display_InputMessage("web_rcv", __ctx1__);

                    ApplyTransform(typeof(Temp_biz.Transform_1), new object[] {__web_rcv.parameters}, new object[] {__ctx1__.__recv.part});

                    if (__ctx1__.__web_rcv != null)
                        __ctx1__.UnrefMessage(__ctx1__.__web_rcv);
                    __ctx1__.__web_rcv = __web_rcv;
                    __ctx1__.RefMessage(__ctx1__.__web_rcv);
                }
                __ctx1__.__web_rcv.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__web_rcv);
                    __edata.Messages.Add(__ctx1__.__recv);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__recv != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__recv);
                    __ctx1__.__recv = null;
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
                web.SendMessage(0, __ctx1__.__web_rcv, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__web_rcv);
                    __edata.PortName = @"web";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__web_rcv != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__web_rcv);
                    __ctx1__.__web_rcv = null;
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
                if (!web.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__web_resp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__web_resp);
                __ctx1__.__web_resp = new IService1_Display_OutputMessage("web_resp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__web_resp);
                web.ReceiveMessage(0, __msgEnv__, __ctx1__.__web_resp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (web != null)
                {
                    web.Close(__ctx1__, __seg__);
                    web = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__web_resp);
                    __edata.PortName = @"web";
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
                Resp_output.SendMessage(0, __ctx1__.__web_resp, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Resp_output != null)
                {
                    Resp_output.Close(__ctx1__, __seg__);
                    Resp_output = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__web_resp);
                    __edata.PortName = @"Resp_output";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__web_resp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__web_resp);
                    __ctx1__.__web_resp = null;
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{03A77A47-ADAB-484F-8542-E2B5DDE236AF}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
