
#pragma warning disable 162

namespace Diff_FF
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Diff_FF.__messagetype_Diff_FF_FlatFile_To_Sql)
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
            typeof(__messagetype_Diff_FF_FlatFile_To_Sql),
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
            typeof(Diff_FF.__messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details)
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
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2),
            typeof(__messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details),
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
    //#line 186 "C:\AMP\Flat File\Diff_FF\Diff_FF\FF_Sql_insert.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Diff_FF.PortType_1),
            typeof(Diff_FF.PortType_2)
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
    sealed internal class FF_Sql_insert : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(FF_Sql_insert));
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

        static FF_Sql_insert()
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
            _rootContext = new __FF_Sql_insert_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public FF_Sql_insert(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "FF_Sql_insert", tracker)
        {
            ConstructorHelper();
        }

        public FF_Sql_insert(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "FF_Sql_insert")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>fa6c3f1d-36db-45ae-a991-7ab6a41a81fb</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>a0312ddf-e830-4142-8cd4-58a9575dbfd1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>6e41c05b-eac9-4f44-be62-3f6956389b07</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>291d1652-336c-4d70-b0fb-a386aa5b3bcd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b146d4cc-4a1f-4588-b355-83c4c65b6462</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>46a9f711-2dc5-4ae2-b48d-a6d18f393fa7</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a1cd46e5-a268-4f9a-ae78-f790923eb33d</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ec30f558-7e9b-444c-b486-2baf4484830c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'FF_Sql_insert'</ActionName><IsAtomic>0</IsAtomic><Line>186</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>199</Line><Position>22</Position><ShapeID>'a0312ddf-e830-4142-8cd4-58a9575dbfd1'</ShapeID>
<Messages>
	<MsgInfo><name>FF_In</name><part>part</part><schema>Diff_FF.FlatFile_To_Sql</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>201</Line><Position>13</Position><ShapeID>'6e41c05b-eac9-4f44-be62-3f6956389b07'</ShapeID>
<Messages>
	<MsgInfo><name>Sql_inserting</name><part>part</part><schema>Diff_FF.TypedProcedure_dbo+usp_Customer_Details</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>FF_In</name><part>part</part><schema>Diff_FF.FlatFile_To_Sql</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>207</Line><Position>13</Position><ShapeID>'ec30f558-7e9b-444c-b486-2baf4484830c'</ShapeID>
<Messages>
	<MsgInfo><name>Sql_inserting</name><part>part</part><schema>Diff_FF.TypedProcedure_dbo+usp_Customer_Details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='55ae48b1-7298-454a-a742-51ed5b7b67a5' LowerBound='1.1' HigherBound='44.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Diff_FF' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='34be3e87-7d0f-4a3a-afcf-1d25028e2e1d' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3a5cf15f-5160-4319-b259-5c7547e57dd5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='690f563b-df86-468a-9798-9a401d328934' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.28'>
                    <om:Property Name='Ref' Value='Diff_FF.FlatFile_To_Sql' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4dc2b627-b93f-4733-a2ca-0084a92c7b90' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cdb1016c-a3da-48a3-a3ec-029893ff0ba6' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='dc6f6388-e4a0-4a75-a7f4-2cc55d5d482b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.52'>
                    <om:Property Name='Ref' Value='Diff_FF.TypedProcedure_dbo.usp_Customer_Details' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='2452bf61-0e33-466b-87af-35812e916a6a' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='43.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FF_Sql_insert' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PortDeclaration' OID='c202e8f8-50ca-46c5-8a4b-0fddbfb2b903' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Diff_FF.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e701f606-4d55-434a-843b-4035a42a4486' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='158933e4-74bf-4a15-80d9-737107d25d29' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Diff_FF.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_2' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='028bc9d3-0abf-4392-a220-2a3215ac8bd8' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8a5faa42-0779-4c36-b58c-3b7ab1b67fc4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Diff_FF.FlatFile_To_Sql' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FF_In' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='94e3c61d-7d37-43bf-bd13-6ac900970999' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Diff_FF.TypedProcedure_dbo.usp_Customer_Details' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Sql_inserting' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9dd9d4ca-e0d3-4581-b0d6-012a055a4d5e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sql_response' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4a0d96bf-bc5f-4662-8a8d-8ebc1771146f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='Diff_FF.Status' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Out_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='fa6c3f1d-36db-45ae-a991-7ab6a41a81fb' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='a0312ddf-e830-4142-8cd4-58a9575dbfd1' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='33.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='FF_In' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='6e41c05b-eac9-4f44-be62-3f6956389b07' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='39.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='291d1652-336c-4d70-b0fb-a386aa5b3bcd' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='38.1'>
                        <om:Property Name='ClassName' Value='Diff_FF.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='b146d4cc-4a1f-4588-b355-83c4c65b6462' ParentLink='Transform_OutputMessagePartRef' LowerBound='37.28' HigherBound='37.41'>
                            <om:Property Name='MessageRef' Value='Sql_inserting' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='46a9f711-2dc5-4ae2-b48d-a6d18f393fa7' ParentLink='Transform_InputMessagePartRef' LowerBound='37.66' HigherBound='37.71'>
                            <om:Property Name='MessageRef' Value='FF_In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='a1cd46e5-a268-4f9a-ae78-f790923eb33d' ParentLink='Construct_MessageRef' LowerBound='34.23' HigherBound='34.36'>
                        <om:Property Name='Ref' Value='Sql_inserting' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='ec30f558-7e9b-444c-b486-2baf4484830c' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='PortName' Value='Port_2' />
                    <om:Property Name='MessageName' Value='Sql_inserting' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __FF_Sql_insert_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __FF_Sql_insert_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FF_Sql_insert")
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
                FF_Sql_insert __svc__ = (FF_Sql_insert)_service;
                __FF_Sql_insert_root_0 __ctx0__ = (__FF_Sql_insert_root_0)(__svc__._stateMgrs[0]);

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
        }


        [System.SerializableAttribute]
        public class __FF_Sql_insert_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __FF_Sql_insert_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FF_Sql_insert")
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
                FF_Sql_insert __svc__ = (FF_Sql_insert)_service;
                __FF_Sql_insert_1 __ctx1__ = (__FF_Sql_insert_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Sql_inserting != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Sql_inserting);
                    __ctx1__.__Sql_inserting = null;
                }
                if (__ctx1__ != null && __ctx1__.__FF_In != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FF_In);
                    __ctx1__.__FF_In = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("FF_In")]
            public __messagetype_Diff_FF_FlatFile_To_Sql __FF_In;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Sql_inserting")]
            public __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details __Sql_inserting;
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
                                               typeof(FF_Sql_insert).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FF_Sql_insert), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(FF_Sql_insert).GetField("Port_2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FF_Sql_insert), "Port_2"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "a0312ddf-e830-4142-8cd4-58a9575dbfd1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "a0312ddf-e830-4142-8cd4-58a9575dbfd1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "6e41c05b-eac9-4f44-be62-3f6956389b07", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6e41c05b-eac9-4f44-be62-3f6956389b07", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "ec30f558-7e9b-444c-b486-2baf4484830c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "ec30f558-7e9b-444c-b486-2baf4484830c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
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

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __FF_Sql_insert_root_0 __ctx0__ = (__FF_Sql_insert_root_0)_stateMgrs[0];
            __FF_Sql_insert_1 __ctx1__ = (__FF_Sql_insert_1)_stateMgrs[1];

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
                __ctx1__ = new __FF_Sql_insert_1(this);
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
            __FF_Sql_insert_root_0 __ctx0__ = (__FF_Sql_insert_root_0)_stateMgrs[0];
            __FF_Sql_insert_1 __ctx1__ = (__FF_Sql_insert_1)_stateMgrs[1];

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
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__FF_In != null)
                    __ctx1__.UnrefMessage(__ctx1__.__FF_In);
                __ctx1__.__FF_In = new __messagetype_Diff_FF_FlatFile_To_Sql("FF_In", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__FF_In);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__FF_In, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__FF_In);
                    __edata.PortName = @"Port_1";
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
                    __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details __Sql_inserting = new __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details("Sql_inserting", __ctx1__);

                    ApplyTransform(typeof(Diff_FF.Transform_1), new object[] {__Sql_inserting.part}, new object[] {__ctx1__.__FF_In.part});

                    if (__ctx1__.__Sql_inserting != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Sql_inserting);
                    __ctx1__.__Sql_inserting = __Sql_inserting;
                    __ctx1__.RefMessage(__ctx1__.__Sql_inserting);
                }
                __ctx1__.__Sql_inserting.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Sql_inserting);
                    __edata.Messages.Add(__ctx1__.__FF_In);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__FF_In != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__FF_In);
                    __ctx1__.__FF_In = null;
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
                Port_2.SendMessage(0, __ctx1__.__Sql_inserting, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_2 != null)
                {
                    Port_2.Close(__ctx1__, __seg__);
                    Port_2 = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Sql_inserting);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Sql_inserting != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Sql_inserting);
                    __ctx1__.__Sql_inserting = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Diff_FF_FlatFile_To_Sql__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Diff_FF.FlatFile_To_Sql _schema = new Diff_FF.FlatFile_To_Sql();

        public __Diff_FF_FlatFile_To_Sql__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Diff_FF.FlatFile_To_Sql",
        new System.Type[]{
            typeof(Diff_FF.FlatFile_To_Sql)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Diff_FF_FlatFile_To_Sql__)
        },
        0,
        @"http://Diff_FF.FlatFile_To_Sql#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Diff_FF_FlatFile_To_Sql : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Diff_FF_FlatFile_To_Sql__ part;

        private void __CreatePartWrappers()
        {
            part = new __Diff_FF_FlatFile_To_Sql__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Diff_FF_FlatFile_To_Sql(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Diff_FF_TypedProcedure_dbo_usp_Customer_Details__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Diff_FF.TypedProcedure_dbo.usp_Customer_Details _schema = new Diff_FF.TypedProcedure_dbo.usp_Customer_Details();

        public __Diff_FF_TypedProcedure_dbo_usp_Customer_Details__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Diff_FF.TypedProcedure_dbo.usp_Customer_Details",
        new System.Type[]{
            typeof(Diff_FF.TypedProcedure_dbo.usp_Customer_Details)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Diff_FF_TypedProcedure_dbo_usp_Customer_Details__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#usp_Customer_Details"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Diff_FF_TypedProcedure_dbo_usp_Customer_Details__ part;

        private void __CreatePartWrappers()
        {
            part = new __Diff_FF_TypedProcedure_dbo_usp_Customer_Details__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_Details(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse _schema = new Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse();

        public __Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse",
        new System.Type[]{
            typeof(Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#usp_Customer_DetailsResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Diff_FF_TypedProcedure_dbo_usp_Customer_DetailsResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Diff_FF_Status__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Diff_FF.Status _schema = new Diff_FF.Status();

        public __Diff_FF_Status__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Diff_FF.Status",
        new System.Type[]{
            typeof(Diff_FF.Status)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Diff_FF_Status__)
        },
        0,
        @"http://Diff_FF.Status#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Diff_FF_Status : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Diff_FF_Status__ part;

        private void __CreatePartWrappers()
        {
            part = new __Diff_FF_Status__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Diff_FF_Status(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
