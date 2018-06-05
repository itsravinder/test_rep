
#pragma warning disable 162

namespace BizTalk_Server_Project1
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.__messagetype_BizTalk_Server_Project1_IN_Xml)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class IN_Xml_Rcv_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public IN_Xml_Rcv_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public IN_Xml_Rcv_type(IN_Xml_Rcv_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            IN_Xml_Rcv_type p = new IN_Xml_Rcv_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(IN_Xml_Rcv_type),
            typeof(__messagetype_BizTalk_Server_Project1_IN_Xml),
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
            typeof(BizTalk_Server_Project1.__messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails), 
            typeof(BizTalk_Server_Project1.__messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Sql_Ins_Type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Sql_Ins_Type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Sql_Ins_Type(Sql_Ins_Type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Sql_Ins_Type p = new Sql_Ins_Type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(Sql_Ins_Type),
            typeof(__messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails),
            typeof(__messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse),
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
    //#line 232 "C:\AMP\sql\sqlbound\BizTalk Server Project1\BizTalk Server Project1\Sql_orders.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "IN_Xml_Rcv", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BizTalk_Server_Project1.IN_Xml_Rcv_type),
            typeof(BizTalk_Server_Project1.Sql_Ins_Type)
        },
        new System.String[] {
            "IN_Xml_Rcv",
            "Sql_req_Resp"
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
    sealed internal class Sql_orders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Sql_orders));
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

        static Sql_orders()
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
            _rootContext = new __Sql_orders_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Sql_orders(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Sql_orders", tracker)
        {
            ConstructorHelper();
        }

        public Sql_orders(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Sql_orders")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>744b4e49-2ef4-46c7-90d9-cbc061c933c8</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>46d7b8c9-d771-4111-b50f-efe8a1a8d413</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>805c8b91-08c1-40da-a3e1-f6de48b423c4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7ccf4b3f-d455-4767-980b-46d9b6f7e8b2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>73b4d45c-aaa5-4c4a-8a08-947880dab282</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e3cf1a76-f2bb-4248-8c36-d3688de55e4c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>9e7f9f55-daae-4762-bba9-df3b0e93ffa0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>12cce629-3892-48c6-b805-34c6e7133916</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e1f5a5d1-1448-4d77-8143-be9ebfe17771</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6ec6a31d-fe1c-4294-ac2f-285d42aa8cfc</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b8a560ee-fd2a-4c28-915a-683de6ceb243</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>8b70dad7-37d1-4c0d-b03f-1a8aee49d748</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>b9d98dcd-7088-46a6-8e13-3c1833b05012</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Sql_orders'</ActionName><IsAtomic>0</IsAtomic><Line>232</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>246</Line><Position>22</Position><ShapeID>'46d7b8c9-d771-4111-b50f-efe8a1a8d413'</ShapeID>
<Messages>
	<MsgInfo><name>Dummy_IN</name><part>part</part><schema>BizTalk_Server_Project1.IN_Xml</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>249</Line><Position>13</Position><ShapeID>'805c8b91-08c1-40da-a3e1-f6de48b423c4'</ShapeID>
<Messages>
	<MsgInfo><name>IN_Msg</name><part>part</part><schema>BizTalk_Server_Project1.IN_Xml</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>255</Line><Position>13</Position><ShapeID>'e3cf1a76-f2bb-4248-8c36-d3688de55e4c'</ShapeID>
<Messages>
	<MsgInfo><name>In_req</name><part>part</part><schema>BizTalk_Server_Project1.Procedure_dbo+uspInsertOrderDetails</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>IN_Msg</name><part>part</part><schema>BizTalk_Server_Project1.IN_Xml</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>261</Line><Position>13</Position><ShapeID>'b8a560ee-fd2a-4c28-915a-683de6ceb243'</ShapeID>
<Messages>
	<MsgInfo><name>In_req</name><part>part</part><schema>BizTalk_Server_Project1.Procedure_dbo+uspInsertOrderDetails</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>263</Line><Position>13</Position><ShapeID>'8b70dad7-37d1-4c0d-b03f-1a8aee49d748'</ShapeID>
<Messages>
	<MsgInfo><name>In_resp</name><part>part</part><schema>BizTalk_Server_Project1.Procedure_dbo+uspInsertOrderDetailsResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>266</Line><Position>17</Position><ShapeID>'b9d98dcd-7088-46a6-8e13-3c1833b05012'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='df34035e-0a29-4c1c-976a-e61a82a69e6a' LowerBound='1.1' HigherBound='58.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BizTalk_Server_Project1' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='0a2bd58a-be91-4ec3-aa07-f9302fdf5707' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='IN_Xml_Rcv_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='77cc9c9b-2d61-45a1-bd49-3bfeae9ebb15' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b8af644a-2a34-427e-9167-6c69680ea7b4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.19'>
                    <om:Property Name='Ref' Value='BizTalk_Server_Project1.IN_Xml' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f105f04c-e811-4256-8a53-9d84e43e0d46' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Sql_Ins_Type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fc2c02d9-7a8f-4e26-8433-20880fd9629f' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='805095d9-52d5-4b94-bc90-c0d8e7798dac' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.48'>
                    <om:Property Name='Ref' Value='BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='edc74a8e-b8c6-4313-bc8b-1bdc40b408cd' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.50' HigherBound='15.93'>
                    <om:Property Name='Ref' Value='BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetailsResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='44040593-6320-48f8-8bb7-d9a57ac22d9d' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='57.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Sql_orders' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='9b3bec60-8c13-4768-91aa-095e0a8d773d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Exp1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e2cff71d-5f10-4c43-94e8-5e9e56515b17' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.IN_Xml' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='IN_Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0c3d9d83-ede4-449c-afd5-aca013eda9e0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='In_req' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8c7eb7f1-17c7-4288-8940-bce9b4190d95' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetailsResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='In_resp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f055dc13-30b0-4cf2-8a0b-15b5c472b029' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='BizTalk_Server_Project1.IN_Xml' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Dummy_IN' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='744b4e49-2ef4-46c7-90d9-cbc061c933c8' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='46d7b8c9-d771-4111-b50f-efe8a1a8d413' ParentLink='ServiceBody_Statement' LowerBound='32.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='IN_Xml_Rcv' />
                    <om:Property Name='MessageName' Value='Dummy_IN' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='805c8b91-08c1-40da-a3e1-f6de48b423c4' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='41.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_2' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='7ccf4b3f-d455-4767-980b-46d9b6f7e8b2' ParentLink='ComplexStatement_Statement' LowerBound='38.1' HigherBound='40.1'>
                        <om:Property Name='Expression' Value=' IN_Msg = Dummy_IN;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='73b4d45c-aaa5-4c4a-8a08-947880dab282' ParentLink='Construct_MessageRef' LowerBound='36.23' HigherBound='36.29'>
                        <om:Property Name='Ref' Value='IN_Msg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='e3cf1a76-f2bb-4248-8c36-d3688de55e4c' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='47.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='9e7f9f55-daae-4762-bba9-df3b0e93ffa0' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                        <om:Property Name='ClassName' Value='BizTalk_Server_Project1.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='12cce629-3892-48c6-b805-34c6e7133916' ParentLink='Transform_InputMessagePartRef' LowerBound='45.75' HigherBound='45.81'>
                            <om:Property Name='MessageRef' Value='IN_Msg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='e1f5a5d1-1448-4d77-8143-be9ebfe17771' ParentLink='Transform_OutputMessagePartRef' LowerBound='45.28' HigherBound='45.34'>
                            <om:Property Name='MessageRef' Value='In_req' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='6ec6a31d-fe1c-4294-ac2f-285d42aa8cfc' ParentLink='Construct_MessageRef' LowerBound='42.23' HigherBound='42.29'>
                        <om:Property Name='Ref' Value='In_req' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='b8a560ee-fd2a-4c28-915a-683de6ceb243' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='PortName' Value='Sql_req_Resp' />
                    <om:Property Name='MessageName' Value='In_req' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='8b70dad7-37d1-4c0d-b03f-1a8aee49d748' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='51.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='Sql_req_Resp' />
                    <om:Property Name='MessageName' Value='In_resp' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='b9d98dcd-7088-46a6-8e13-3c1833b05012' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='55.1'>
                    <om:Property Name='Expression' Value='&#xD;&#xA;Exp1=System.Convert.ToString(In_resp.ReturnValue);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Event_Sucess&quot;,Exp1);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='56834b45-d9fc-4b50-a84e-22a2c88c4093' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk_Server_Project1.IN_Xml_Rcv_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='IN_Xml_Rcv' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='1a7cd3ad-297b-411b-9c1c-c5a0c9efd338' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='917aaa27-6ee1-4af2-a79f-02c4b68f5590' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk_Server_Project1.Sql_Ins_Type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Sql_req_Resp' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='3fc49135-ebe2-48cb-9a75-cb17bd25d2ea' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Sql_orders_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Sql_orders_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Sql_orders")
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
                Sql_orders __svc__ = (Sql_orders)_service;
                __Sql_orders_root_0 __ctx0__ = (__Sql_orders_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Sql_req_Resp != null)
                {
                    __svc__.Sql_req_Resp.Close(this, null);
                    __svc__.Sql_req_Resp = null;
                }
                if (__svc__.IN_Xml_Rcv != null)
                {
                    __svc__.IN_Xml_Rcv.Close(this, null);
                    __svc__.IN_Xml_Rcv = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Sql_orders_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Sql_orders_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Sql_orders")
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
                Sql_orders __svc__ = (Sql_orders)_service;
                __Sql_orders_1 __ctx1__ = (__Sql_orders_1)(__svc__._stateMgrs[1]);
                __Sql_orders_root_0 __ctx0__ = (__Sql_orders_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Dummy_IN != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Dummy_IN);
                    __ctx1__.__Dummy_IN = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Exp1 = null;
                if (__ctx1__ != null && __ctx1__.__In_req != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_req);
                    __ctx1__.__In_req = null;
                }
                if (__ctx1__ != null && __ctx1__.__In_resp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_resp);
                    __ctx1__.__In_resp = null;
                }
                if (__ctx1__ != null && __ctx1__.__IN_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__IN_Msg);
                    __ctx1__.__IN_Msg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("IN_Msg")]
            public __messagetype_BizTalk_Server_Project1_IN_Xml __IN_Msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("In_req")]
            public __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails __In_req;
            [Microsoft.XLANGs.Core.UserVariableAttribute("In_resp")]
            public __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse __In_resp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Dummy_IN")]
            public __messagetype_BizTalk_Server_Project1_IN_Xml __Dummy_IN;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Exp1")]
            internal System.String __Exp1;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("IN_Xml_Rcv")]
        internal IN_Xml_Rcv_type IN_Xml_Rcv;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Sql_req_Resp")]
        internal Sql_Ins_Type Sql_req_Resp;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {IN_Xml_Rcv_type.Operation_1},
                                               typeof(Sql_orders).GetField("IN_Xml_Rcv", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Sql_orders), "IN_Xml_Rcv"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Sql_Ins_Type.Operation_1},
                                               typeof(Sql_orders).GetField("Sql_req_Resp", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Sql_orders), "Sql_req_Resp"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "46d7b8c9-d771-4111-b50f-efe8a1a8d413", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "46d7b8c9-d771-4111-b50f-efe8a1a8d413", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "805c8b91-08c1-40da-a3e1-f6de48b423c4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "805c8b91-08c1-40da-a3e1-f6de48b423c4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "e3cf1a76-f2bb-4248-8c36-d3688de55e4c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "e3cf1a76-f2bb-4248-8c36-d3688de55e4c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "b8a560ee-fd2a-4c28-915a-683de6ceb243", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "b8a560ee-fd2a-4c28-915a-683de6ceb243", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "8b70dad7-37d1-4c0d-b03f-1a8aee49d748", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "8b70dad7-37d1-4c0d-b03f-1a8aee49d748", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "b9d98dcd-7088-46a6-8e13-3c1833b05012", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "b9d98dcd-7088-46a6-8e13-3c1833b05012", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,7,8,8,8,9,10,10,11,12,12,13,13,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Sql_orders_1 __ctx1__ = (__Sql_orders_1)_stateMgrs[1];
            __Sql_orders_root_0 __ctx0__ = (__Sql_orders_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                IN_Xml_Rcv = new IN_Xml_Rcv_type(0, this);
                Sql_req_Resp = new Sql_Ins_Type(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], IN_Xml_Rcv, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Sql_orders_1(this);
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
            __Sql_orders_1 __ctx1__ = (__Sql_orders_1)_stateMgrs[1];
            __Sql_orders_root_0 __ctx0__ = (__Sql_orders_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Exp1 = default(System.String);
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
                if (!IN_Xml_Rcv.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Dummy_IN != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Dummy_IN);
                __ctx1__.__Dummy_IN = new __messagetype_BizTalk_Server_Project1_IN_Xml("Dummy_IN", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Dummy_IN);
                IN_Xml_Rcv.ReceiveMessage(0, __msgEnv__, __ctx1__.__Dummy_IN, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (IN_Xml_Rcv != null)
                {
                    IN_Xml_Rcv.Close(__ctx1__, __seg__);
                    IN_Xml_Rcv = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Dummy_IN);
                    __edata.PortName = @"IN_Xml_Rcv";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__Exp1 = "";
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
                {
                    __messagetype_BizTalk_Server_Project1_IN_Xml __IN_Msg = new __messagetype_BizTalk_Server_Project1_IN_Xml("IN_Msg", __ctx1__);

                    __IN_Msg.CopyFrom(__ctx1__.__Dummy_IN);
                    if (__ctx1__ != null && __ctx1__.__Dummy_IN != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Dummy_IN);
                        __ctx1__.__Dummy_IN = null;
                    }

                    if (__ctx1__.__IN_Msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__IN_Msg);
                    __ctx1__.__IN_Msg = __IN_Msg;
                    __ctx1__.RefMessage(__ctx1__.__IN_Msg);
                }
                __ctx1__.__IN_Msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__IN_Msg);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails __In_req = new __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails("In_req", __ctx1__);

                    ApplyTransform(typeof(BizTalk_Server_Project1.Transform_1), new object[] {__In_req.part}, new object[] {__ctx1__.__IN_Msg.part});

                    if (__ctx1__.__In_req != null)
                        __ctx1__.UnrefMessage(__ctx1__.__In_req);
                    __ctx1__.__In_req = __In_req;
                    __ctx1__.RefMessage(__ctx1__.__In_req);
                }
                __ctx1__.__In_req.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__In_req);
                    __edata.Messages.Add(__ctx1__.__IN_Msg);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__IN_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__IN_Msg);
                    __ctx1__.__IN_Msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Sql_req_Resp.SendMessage(0, __ctx1__.__In_req, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__In_req);
                    __edata.PortName = @"Sql_req_Resp";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__In_req != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_req);
                    __ctx1__.__In_req = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!Sql_req_Resp.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__In_resp != null)
                    __ctx1__.UnrefMessage(__ctx1__.__In_resp);
                __ctx1__.__In_resp = new __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse("In_resp", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__In_resp);
                Sql_req_Resp.ReceiveMessage(0, __msgEnv__, __ctx1__.__In_resp, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Sql_req_Resp != null)
                {
                    Sql_req_Resp.Close(__ctx1__, __seg__);
                    Sql_req_Resp = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__In_resp);
                    __edata.PortName = @"Sql_req_Resp";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __ctx1__.__Exp1 = System.Convert.ToString((System.Int32)__ctx1__.__In_resp.part.GetDistinguishedField("ReturnValue"));
                if (__ctx1__ != null && __ctx1__.__In_resp != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_resp);
                    __ctx1__.__In_resp = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                System.Diagnostics.EventLog.WriteEntry("Event_Sucess", __ctx1__.__Exp1);
                if (__ctx1__ != null)
                    __ctx1__.__Exp1 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 26;
            case 26:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{324F6F88-8250-480E-95FF-6F5CD80088F5}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_Server_Project1_IN_Xml__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk_Server_Project1.IN_Xml _schema = new BizTalk_Server_Project1.IN_Xml();

        public __BizTalk_Server_Project1_IN_Xml__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk_Server_Project1.IN_Xml",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.IN_Xml)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_Server_Project1_IN_Xml__)
        },
        0,
        @"http://BizTalk_Server_Project1.IN_Xml#Order"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_Server_Project1_IN_Xml : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_Server_Project1_IN_Xml__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_Server_Project1_IN_Xml__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_Server_Project1_IN_Xml(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails _schema = new BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails();

        public __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetails)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo#uspInsertOrderDetails"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetails(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetailsResponse _schema = new BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetailsResponse();

        public __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetailsResponse",
        new System.Type[]{
            typeof(BizTalk_Server_Project1.Procedure_dbo.uspInsertOrderDetailsResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo#uspInsertOrderDetailsResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_Server_Project1_Procedure_dbo_uspInsertOrderDetailsResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
