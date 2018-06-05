
#pragma warning disable 162

namespace FF_To_Sql
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FF_To_Sql.__messagetype_FF_To_Sql_Xml_2_Sql)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_FF_To_Sql_Xml_2_Sql),
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
            typeof(FF_To_Sql.__messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert), 
            typeof(FF_To_Sql.__messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_2(PortType_2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_2 p = new PortType_2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_2),
            typeof(__messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert),
            typeof(__messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse),
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
    //#line 224 "C:\AMP\Flat File\FF_To_Sql\FF_To_Sql\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(FF_To_Sql.PortType_1),
            typeof(FF_To_Sql.PortType_2)
        },
        new System.String[] {
            "Port_1",
            "Port_2"
        },
        new System.Type[] {
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
    sealed internal class BizTalk_Orchestration1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BizTalk_Orchestration1));
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

        static BizTalk_Orchestration1()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BizTalk_Orchestration1(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BizTalk_Orchestration1", tracker)
        {
            ConstructorHelper();
        }

        public BizTalk_Orchestration1(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BizTalk_Orchestration1")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>a53ca370-afd7-4fc5-9063-75112856e209</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>8235fb49-ebd2-42db-ba16-d6a69ac38d10</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>3ceb07f6-5628-41d5-b43e-12bca05ed499</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>6e5582d3-37ad-4ac7-93e0-cf285c0cf86b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>79f49fea-5a11-4018-bd2e-9be2e0d83aa6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8006c5e0-dcc2-46fa-951a-72c92871b888</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7225dc4e-1498-404c-8c1b-86ead5db3a0f</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a01cb3b6-2b20-4160-9606-78d81318a4af</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>871d6a9a-b29b-47f2-86b4-3208b9e75a77</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>fe444f5d-73fb-4c49-b8d6-3e0d2e4abc0f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>2715f784-bc67-4d4c-b110-1bb8d6f21468</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Net.WebException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>29a4540c-e589-4552-90a2-6124518f0249</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>224</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>237</Line><Position>22</Position><ShapeID>'8235fb49-ebd2-42db-ba16-d6a69ac38d10'</ShapeID>
<Messages>
	<MsgInfo><name>IN</name><part>part</part><schema>FF_To_Sql.Xml_2_Sql</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>240</Line><Position>13</Position><ShapeID>'3ceb07f6-5628-41d5-b43e-12bca05ed499'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>245</Line><Position>21</Position><ShapeID>'6e5582d3-37ad-4ac7-93e0-cf285c0cf86b'</ShapeID>
<Messages>
	<MsgInfo><name>sql_req</name><part>part</part><schema>FF_To_Sql.TypedProcedure_dbo+MasterInsert</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>IN</name><part>part</part><schema>FF_To_Sql.Xml_2_Sql</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>251</Line><Position>21</Position><ShapeID>'871d6a9a-b29b-47f2-86b4-3208b9e75a77'</ShapeID>
<Messages>
	<MsgInfo><name>sql_req</name><part>part</part><schema>FF_To_Sql.TypedProcedure_dbo+MasterInsert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>253</Line><Position>21</Position><ShapeID>'fe444f5d-73fb-4c49-b8d6-3e0d2e4abc0f'</ShapeID>
<Messages>
	<MsgInfo><name>sql_resp</name><part>part</part><schema>FF_To_Sql.TypedProcedure_dbo+MasterInsertResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>258</Line><Position>21</Position><ShapeID>'2715f784-bc67-4d4c-b110-1bb8d6f21468'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>261</Line><Position>39</Position><ShapeID>'29a4540c-e589-4552-90a2-6124518f0249'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='9457f5ee-4e29-422d-92c1-d7eb66bf689c' LowerBound='1.1' HigherBound='64.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='FF_To_Sql' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5098a74d-4d8a-4009-812f-e9f4ffed682b' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3a4dac5a-4d6f-4b49-9373-5ef12811f8aa' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9c0332d5-a2b8-437c-9f77-b2527d8330bd' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='FF_To_Sql.Xml_2_Sql' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='a5f9229e-25a8-43ae-9bbe-3b9f61164d3c' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b133f853-4db9-4ed0-b7e3-3a5e8b6cbe00' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6baf7a4a-ff39-4091-a7a3-b85b83779c0f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.44'>
                    <om:Property Name='Ref' Value='FF_To_Sql.TypedProcedure_dbo.MasterInsert' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d956f7ad-b83d-41d8-bad8-f412e9be3cb6' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.46' HigherBound='15.85'>
                    <om:Property Name='Ref' Value='FF_To_Sql.TypedProcedure_dbo.MasterInsertResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5c9bdc2c-df04-4f01-adc3-6210d9e143f1' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='63.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='a64deef4-2317-46a4-984f-955e2a06921c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Web_Exception' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='90cb5dd6-644a-4a0f-8491-47afcb0c8efc' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='FF_To_Sql.Xml_2_Sql' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='IN' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='a921785b-9245-4790-82e0-0f25f27c2c88' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='FF_To_Sql.TypedProcedure_dbo.MasterInsert' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sql_req' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cb7e08e6-2cb3-45f7-ab15-0b3fc24e0913' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='FF_To_Sql.TypedProcedure_dbo.MasterInsertResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sql_resp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='a53ca370-afd7-4fc5-9063-75112856e209' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='8235fb49-ebd2-42db-ba16-d6a69ac38d10' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='34.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='IN' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='3ceb07f6-5628-41d5-b43e-12bca05ed499' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='61.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='6e5582d3-37ad-4ac7-93e0-cf285c0cf86b' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='45.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Transform' OID='79f49fea-5a11-4018-bd2e-9be2e0d83aa6' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='44.1'>
                            <om:Property Name='ClassName' Value='FF_To_Sql.Transform_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='8006c5e0-dcc2-46fa-951a-72c92871b888' ParentLink='Transform_InputMessagePartRef' LowerBound='43.70' HigherBound='43.72'>
                                <om:Property Name='MessageRef' Value='IN' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='7225dc4e-1498-404c-8c1b-86ead5db3a0f' ParentLink='Transform_OutputMessagePartRef' LowerBound='43.36' HigherBound='43.43'>
                                <om:Property Name='MessageRef' Value='sql_req' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='a01cb3b6-2b20-4160-9606-78d81318a4af' ParentLink='Construct_MessageRef' LowerBound='40.31' HigherBound='40.38'>
                            <om:Property Name='Ref' Value='sql_req' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='871d6a9a-b29b-47f2-86b4-3208b9e75a77' ParentLink='ComplexStatement_Statement' LowerBound='45.1' HigherBound='47.1'>
                        <om:Property Name='PortName' Value='Port_2' />
                        <om:Property Name='MessageName' Value='sql_req' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Receive' OID='fe444f5d-73fb-4c49-b8d6-3e0d2e4abc0f' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='49.1'>
                        <om:Property Name='Activate' Value='False' />
                        <om:Property Name='PortName' Value='Port_2' />
                        <om:Property Name='MessageName' Value='sql_resp' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Receive_2' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='2715f784-bc67-4d4c-b110-1bb8d6f21468' ParentLink='Scope_Catch' LowerBound='52.1' HigherBound='59.1'>
                        <om:Property Name='ExceptionName' Value='WebEx' />
                        <om:Property Name='ExceptionType' Value='System.Net.WebException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='29a4540c-e589-4552-90a2-6124518f0249' ParentLink='Catch_Statement' LowerBound='55.1' HigherBound='58.1'>
                            <om:Property Name='Expression' Value='Web_Exception = WebEx.Message;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Web Exception&quot;,Web_Exception);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b6603729-783a-4fc8-87f9-2fe21ab82253' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FF_To_Sql.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='03b33f6c-f9eb-4616-b270-36441adff308' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e575770c-fc76-4828-b771-27710eb55067' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FF_To_Sql.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_2' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='b5cb8146-69f2-459f-83ff-f9fd7f645d5c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BizTalk_Orchestration1_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_2 != null)
                {
                    __svc__.Port_2.Close(this, null);
                    __svc__.Port_2 = null;
                }
                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BizTalk_Orchestration1_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__IN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__IN);
                    __ctx1__.__IN = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Web_Exception = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("IN")]
            public __messagetype_FF_To_Sql_Xml_2_Sql __IN;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sql_req")]
            public __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert __sql_req;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sql_resp")]
            public __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse __sql_resp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Web_Exception")]
            internal System.String __Web_Exception;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Net.WebException))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)(__svc__._stateMgrs[0]);
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__WebEx_0 = null;
                if (__ctx1__ != null && __ctx1__.__sql_resp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__sql_resp);
                    __ctx1__.__sql_resp = null;
                }
                if (__ctx1__ != null && __ctx1__.__sql_req != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__sql_req);
                    __ctx1__.__sql_req = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Net.WebException __WebEx_0
            {
                get { return (System.Net.WebException)__exv__; }
                set { __exv__ = value; }
            }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_2")]
        internal PortType_2 Port_2;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_2"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "8235fb49-ebd2-42db-ba16-d6a69ac38d10", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "8235fb49-ebd2-42db-ba16-d6a69ac38d10", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "3ceb07f6-5628-41d5-b43e-12bca05ed499", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "6e5582d3-37ad-4ac7-93e0-cf285c0cf86b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "6e5582d3-37ad-4ac7-93e0-cf285c0cf86b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "871d6a9a-b29b-47f2-86b4-3208b9e75a77", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "871d6a9a-b29b-47f2-86b4-3208b9e75a77", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "fe444f5d-73fb-4c49-b8d6-3e0d2e4abc0f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "fe444f5d-73fb-4c49-b8d6-3e0d2e4abc0f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "2715f784-bc67-4d4c-b110-1bb8d6f21468", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "29a4540c-e589-4552-90a2-6124518f0249", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "29a4540c-e589-4552-90a2-6124518f0249", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "2715f784-bc67-4d4c-b110-1bb8d6f21468", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "3ceb07f6-5628-41d5-b43e-12bca05ed499", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,4,18,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,8,8,9,10,10,11,11,11,11,};
        public static int[] __progressLocation3 = new int[] { 12,12,13,13,14,14,17,17,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_1 = new PortType_1(0, this);
                Port_2 = new PortType_2(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BizTalk_Orchestration1_1(this);
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
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Web_Exception = default(System.String);
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
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__IN != null)
                    __ctx1__.UnrefMessage(__ctx1__.__IN);
                __ctx1__.__IN = new __messagetype_FF_To_Sql_Xml_2_Sql("IN", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__IN);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__IN, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__IN);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__Web_Exception = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__Web_Exception = null;
                if (__ctx1__ != null && __ctx1__.__IN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__IN);
                    __ctx1__.__IN = null;
                }
                if (Port_2 != null)
                {
                    Port_2.Close(__ctx1__, __seg__);
                    Port_2 = null;
                }
                Tracker.FireEvent(__eventLocations[18],__eventData[9],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

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
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert __sql_req = new __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert("sql_req", __ctx1__);

                    ApplyTransform(typeof(FF_To_Sql.Transform_1), new object[] {__sql_req.part}, new object[] {__ctx1__.__IN.part});

                    if (__ctx1__.__sql_req != null)
                        __ctx1__.UnrefMessage(__ctx1__.__sql_req);
                    __ctx1__.__sql_req = __sql_req;
                    __ctx1__.RefMessage(__ctx1__.__sql_req);
                }
                __ctx1__.__sql_req.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__sql_req);
                    __edata.Messages.Add(__ctx1__.__IN);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_2.SendMessage(0, __ctx1__.__sql_req, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__sql_req);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__sql_req != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__sql_req);
                    __ctx1__.__sql_req = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!Port_2.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__sql_resp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__sql_resp);
                __ctx1__.__sql_resp = new __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse("sql_resp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__sql_resp);
                Port_2.ReceiveMessage(0, __msgEnv__, __ctx1__.__sql_resp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__sql_resp);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__sql_resp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__sql_resp);
                    __ctx1__.__sql_resp = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__Web_Exception = __ctx2__.__WebEx_0.Message;
                if (__ctx2__ != null)
                    __ctx2__.__WebEx_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.EventLog.WriteEntry("Web Exception", __ctx1__.__Web_Exception);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{CBD3348C-DED7-40DE-9569-430D19DAF79F}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __FF_To_Sql_Xml_2_Sql__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FF_To_Sql.Xml_2_Sql _schema = new FF_To_Sql.Xml_2_Sql();

        public __FF_To_Sql_Xml_2_Sql__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FF_To_Sql.Xml_2_Sql",
        new System.Type[]{
            typeof(FF_To_Sql.Xml_2_Sql)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FF_To_Sql_Xml_2_Sql__)
        },
        0,
        @"http://FF_To_Sql.Xml_2_Sql#Record"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FF_To_Sql_Xml_2_Sql : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FF_To_Sql_Xml_2_Sql__ part;

        private void __CreatePartWrappers()
        {
            part = new __FF_To_Sql_Xml_2_Sql__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FF_To_Sql_Xml_2_Sql(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __FF_To_Sql_TypedProcedure_dbo_MasterInsert__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FF_To_Sql.TypedProcedure_dbo.MasterInsert _schema = new FF_To_Sql.TypedProcedure_dbo.MasterInsert();

        public __FF_To_Sql_TypedProcedure_dbo_MasterInsert__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FF_To_Sql.TypedProcedure_dbo.MasterInsert",
        new System.Type[]{
            typeof(FF_To_Sql.TypedProcedure_dbo.MasterInsert)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FF_To_Sql_TypedProcedure_dbo_MasterInsert__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#MasterInsert"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FF_To_Sql_TypedProcedure_dbo_MasterInsert__ part;

        private void __CreatePartWrappers()
        {
            part = new __FF_To_Sql_TypedProcedure_dbo_MasterInsert__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsert(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FF_To_Sql.TypedProcedure_dbo.MasterInsertResponse _schema = new FF_To_Sql.TypedProcedure_dbo.MasterInsertResponse();

        public __FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FF_To_Sql.TypedProcedure_dbo.MasterInsertResponse",
        new System.Type[]{
            typeof(FF_To_Sql.TypedProcedure_dbo.MasterInsertResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#MasterInsertResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FF_To_Sql_TypedProcedure_dbo_MasterInsertResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
