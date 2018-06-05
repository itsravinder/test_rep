
#pragma warning disable 162

namespace batching_map
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(batching_map.__messagetype_batching_map_Schema1)
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
            typeof(__messagetype_batching_map_Schema1),
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
            typeof(batching_map.__messagetype_batching_map_Schema2)
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
            typeof(__messagetype_batching_map_Schema2),
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
            typeof(batching_map.__messagetype_batching_map_outxsd)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_3 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_3(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_3(PortType_3 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_3 p = new PortType_3(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_3),
            typeof(__messagetype_batching_map_outxsd),
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
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "batching_map.PropertySchema.City"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new batching_map.PropertySchema.City()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 291 "C:\AMP\env\batching_map\batching_map\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Sc_1", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Sc_2", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(batching_map.PortType_1),
            typeof(batching_map.PortType_2),
            typeof(batching_map.PortType_3)
        },
        new System.String[] {
            "Sc_1",
            "Sc_2",
            "Out"
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
    sealed internal class BizTalk_Orchestration1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 1, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 1, 3)
            };

            _Locks = 0;
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
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
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>8255787f-f25a-45a2-8fb1-f20d634bf1ae</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>4c35b0e6-df1d-4e9a-ac0f-f8ac8b111869</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>3d7a9595-19b7-4b34-91fe-6b820ac3884b</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>200f389f-0ace-406a-a629-df62cd4ef94b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>9490470c-b73d-4c98-86be-3c0bcdc72463</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>d0d35824-218c-42ca-a8ab-45e216725e6a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a55702b7-385c-40b7-863c-c0face711072</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>3ce92923-5830-4694-9c26-44ae01bc3335</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7935522e-014c-4425-9be5-594992ac9720</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1678dae8-8570-4d2d-9438-e947b61999f3</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a8dd0d32-c472-4240-a467-26a9904b4878</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7811ab3e-7fc0-4258-b58f-df4e5bf57d62</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>3e3d9e6e-8ea3-49f4-8fed-6d0448340659</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>291</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>306</Line><Position>13</Position><ShapeID>'4c35b0e6-df1d-4e9a-ac0f-f8ac8b111869'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>311</Line><Position>30</Position><ShapeID>'200f389f-0ace-406a-a629-df62cd4ef94b'</ShapeID>
<Messages>
	<MsgInfo><name>Schema_1</name><part>part</part><schema>batching_map.Schema1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>316</Line><Position>30</Position><ShapeID>'d0d35824-218c-42ca-a8ab-45e216725e6a'</ShapeID>
<Messages>
	<MsgInfo><name>Schema_2</name><part>part</part><schema>batching_map.Schema2</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>320</Line><Position>13</Position><ShapeID>'a55702b7-385c-40b7-863c-c0face711072'</ShapeID>
<Messages>
	<MsgInfo><name>Out_msg</name><part>part</part><schema>batching_map.outxsd</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Schema_1</name><part>part</part><schema>batching_map.Schema1</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Schema_2</name><part>part</part><schema>batching_map.Schema2</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>326</Line><Position>13</Position><ShapeID>'3e3d9e6e-8ea3-49f4-8fed-6d0448340659'</ShapeID>
<Messages>
	<MsgInfo><name>Out_msg</name><part>part</part><schema>batching_map.outxsd</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='33490e19-469d-4282-8904-73aabc4d2dac' LowerBound='1.1' HigherBound='69.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='batching_map' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5d59d537-f4fb-4ede-8bf7-95cf0afb696e' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='39ec9a92-1a19-4a72-ba42-9f965d445ad1' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='950bedb2-53fe-43fe-b341-a6ff3c9ae5e2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.20'>
                    <om:Property Name='Ref' Value='batching_map.Schema1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='75ba5d83-35d1-4685-aeb6-1b6e4f1d3cb9' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='85f4528b-1244-420d-8cb2-9dca928cf767' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0f75b10e-51f6-4214-9f30-4c22a9dd651d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.20'>
                    <om:Property Name='Ref' Value='batching_map.Schema2' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='40f46746-ccd9-4a04-92a9-299815431036' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_3' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e33f41f8-308e-46f9-9f87-357440aa6b9d' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='75b4dae7-5795-4275-b277-8f7bc8b4b0da' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.19'>
                    <om:Property Name='Ref' Value='batching_map.outxsd' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='fedfa7ca-b215-40bc-920b-344dac02beda' ParentLink='Module_ServiceDeclaration' LowerBound='29.1' HigherBound='68.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='8255787f-f25a-45a2-8fb1-f20d634bf1ae' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Parallel' OID='4c35b0e6-df1d-4e9a-ac0f-f8ac8b111869' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='58.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ParallelActions_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ParallelBranch' OID='3d7a9595-19b7-4b34-91fe-6b820ac3884b' ParentLink='ReallyComplexStatement_Branch' LowerBound='49.1' HigherBound='51.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='200f389f-0ace-406a-a629-df62cd4ef94b' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='51.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Sc_1' />
                            <om:Property Name='MessageName' Value='Schema_1' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='9490470c-b73d-4c98-86be-3c0bcdc72463' ParentLink='ReallyComplexStatement_Branch' LowerBound='54.1' HigherBound='56.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='d0d35824-218c-42ca-a8ab-45e216725e6a' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='56.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Sc_2' />
                            <om:Property Name='MessageName' Value='Schema_2' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='a55702b7-385c-40b7-863c-c0face711072' ParentLink='ServiceBody_Statement' LowerBound='58.1' HigherBound='64.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='3ce92923-5830-4694-9c26-44ae01bc3335' ParentLink='ComplexStatement_Statement' LowerBound='61.1' HigherBound='63.1'>
                        <om:Property Name='ClassName' Value='batching_map.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='7935522e-014c-4425-9be5-594992ac9720' ParentLink='Transform_InputMessagePartRef' LowerBound='62.65' HigherBound='62.73'>
                            <om:Property Name='MessageRef' Value='Schema_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='1678dae8-8570-4d2d-9438-e947b61999f3' ParentLink='Transform_InputMessagePartRef' LowerBound='62.75' HigherBound='62.83'>
                            <om:Property Name='MessageRef' Value='Schema_2' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='a8dd0d32-c472-4240-a467-26a9904b4878' ParentLink='Transform_OutputMessagePartRef' LowerBound='62.28' HigherBound='62.35'>
                            <om:Property Name='MessageRef' Value='Out_msg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='7811ab3e-7fc0-4258-b58f-df4e5bf57d62' ParentLink='Construct_MessageRef' LowerBound='59.23' HigherBound='59.30'>
                        <om:Property Name='Ref' Value='Out_msg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='3e3d9e6e-8ea3-49f4-8fed-6d0448340659' ParentLink='ServiceBody_Statement' LowerBound='64.1' HigherBound='66.1'>
                    <om:Property Name='PortName' Value='Out' />
                    <om:Property Name='MessageName' Value='Out_msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='88b32ea3-18cf-4c6f-ade0-59eaed232ffe' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='batching_map.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Sc_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8b167593-1103-42c8-a357-181058584fc5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b6e7397c-7faa-4f94-b05e-4ce647c570f9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='34.1' HigherBound='36.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='batching_map.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Sc_2' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7c9f544a-a187-4b8f-81c8-0af878200b1b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='34.1' HigherBound='35.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='646d1f8a-9738-4923-b044-85a94c836d44' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='batching_map.PortType_3' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Out' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='704dac55-bb83-4804-b24f-3d06bd8b4436' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='07e9ac7f-901c-43c9-8026-16fb68d8d154' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='Type' Value='batching_map.Schema1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Schema_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7204449e-7dc3-4bf9-a9e0-2ebdc572d164' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='Type' Value='batching_map.Schema2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Schema_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='82406231-e44c-4c0a-bddc-64f0b652de26' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='batching_map.outxsd' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Out_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='e40e62d4-4399-4575-b642-504ef8a56ee2' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='Type' Value='batching_map.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='abdc005d-7b38-401f-9314-7e843808e3b1' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='50.67' HigherBound='50.91'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='200f389f-0ace-406a-a629-df62cd4ef94b' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='9227f12f-0c55-4d83-9ec9-29bf1c3aeb73' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='55.67' HigherBound='55.91'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='d0d35824-218c-42ca-a8ab-45e216725e6a' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='ff591ab3-fe83-40a0-8be7-80dc6305fc5c' ParentLink='Module_CorrelationType' LowerBound='25.1' HigherBound='29.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='0444f42a-95fd-4712-a89f-876fd2ff9a88' ParentLink='CorrelationType_PropertyRef' LowerBound='27.9' HigherBound='27.28'>
                <om:Property Name='Ref' Value='batching_map.PropertySchema.City' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
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

                if (__svc__.Sc_1 != null)
                {
                    __svc__.Sc_1.Close(this, null);
                    __svc__.Sc_1 = null;
                }
                if (__svc__.Sc_2 != null)
                {
                    __svc__.Sc_2.Close(this, null);
                    __svc__.Sc_2 = null;
                }
                if (__svc__.Out != null)
                {
                    __svc__.Out.Close(this, null);
                    __svc__.Out = null;
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

                if (__ctx1__ != null && __ctx1__.__Schema_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Schema_1);
                    __ctx1__.__Schema_1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Schema_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Schema_2);
                    __ctx1__.__Schema_2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Out_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Out_msg);
                    __ctx1__.__Out_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Schema_1")]
            public __messagetype_batching_map_Schema1 __Schema_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Schema_2")]
            public __messagetype_batching_map_Schema2 __Schema_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Out_msg")]
            public __messagetype_batching_map_outxsd __Out_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationType_1() };
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
                return new object[] {
                    new Microsoft.XLANGs.Core.CorrelationType[] { _correlationTypes[0] }
                };
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Sc_1")]
        internal PortType_1 Sc_1;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Sc_2")]
        internal PortType_2 Sc_2;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Out")]
        internal PortType_3 Out;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Sc_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Sc_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Sc_2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Sc_2"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_3.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Out", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Out"),
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
                return new object[2]{
                     new object[5] { _portInfo[0], 0, null , 0, true }
                    , new object[5] { _portInfo[1], 0, null , 0, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "4c35b0e6-df1d-4e9a-ac0f-f8ac8b111869", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "4c35b0e6-df1d-4e9a-ac0f-f8ac8b111869", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "200f389f-0ace-406a-a629-df62cd4ef94b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "200f389f-0ace-406a-a629-df62cd4ef94b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "d0d35824-218c-42ca-a8ab-45e216725e6a", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "d0d35824-218c-42ca-a8ab-45e216725e6a", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "a55702b7-385c-40b7-863c-c0face711072", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "a55702b7-385c-40b7-863c-c0face711072", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "3e3d9e6e-8ea3-49f4-8fed-6d0448340659", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "3e3d9e6e-8ea3-49f4-8fed-6d0448340659", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,3,2,2,7,7,8,9,9,9,10,11,11,11,11,};
        public static int[] __progressLocation2 = new int[] { 3,3,4,2,};
        public static int[] __progressLocation3 = new int[] { 5,5,6,2,};

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
                Sc_1 = new PortType_1(0, this);
                Sc_2 = new PortType_2(1, this);
                Out = new PortType_3(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Sc_1, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Sc_2, this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

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
                __ctx1__.__Correlation_1 = new Microsoft.XLANGs.Core.Correlation(this, 0, 0);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (Sc_2 != null)
                {
                    Sc_2.Close(__ctx1__, __seg__);
                    Sc_2 = null;
                }
                if (Sc_1 != null)
                {
                    Sc_1.Close(__ctx1__, __seg__);
                    Sc_1 = null;
                }
                Tracker.FireEvent(__eventLocations[2],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_batching_map_outxsd __Out_msg = new __messagetype_batching_map_outxsd("Out_msg", __ctx1__);

                    ApplyTransform(typeof(batching_map.Transform_1), new object[] {__Out_msg.part}, new object[] {__ctx1__.__Schema_1.part, __ctx1__.__Schema_2.part});

                    if (__ctx1__.__Out_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Out_msg);
                    __ctx1__.__Out_msg = __Out_msg;
                    __ctx1__.RefMessage(__ctx1__.__Out_msg);
                }
                __ctx1__.__Out_msg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Out_msg);
                    __edata.Messages.Add(__ctx1__.__Schema_1);
                    __edata.Messages.Add(__ctx1__.__Schema_2);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Schema_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Schema_2);
                    __ctx1__.__Schema_2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Schema_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Schema_1);
                    __ctx1__.__Schema_1 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Out.SendMessage(0, __ctx1__.__Out_msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Out != null)
                {
                    Out.Close(__ctx1__, __seg__);
                    Out = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Out_msg);
                    __edata.PortName = @"Out";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Out_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Out_msg);
                    __ctx1__.__Out_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 16;
            case 16:
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
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!Sc_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Schema_1 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Schema_1);
                __ctx1__.__Schema_1 = new __messagetype_batching_map_Schema1("Schema_1", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Schema_1);
                Sc_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__Schema_1, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Schema_1);
                    __edata.PortName = @"Sc_1";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!Sc_2.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Schema_2 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Schema_2);
                __ctx1__.__Schema_2 = new __messagetype_batching_map_Schema2("Schema_2", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Schema_2);
                Sc_2.ReceiveMessage(0, __msgEnv__, __ctx1__.__Schema_2, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Schema_2);
                    __edata.PortName = @"Sc_2";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __batching_map_Schema1__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static batching_map.Schema1 _schema = new batching_map.Schema1();

        public __batching_map_Schema1__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "batching_map.Schema1",
        new System.Type[]{
            typeof(batching_map.Schema1)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__batching_map_Schema1__)
        },
        0,
        @"http://batching_map.Schema1#Schema_one"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_batching_map_Schema1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __batching_map_Schema1__ part;

        private void __CreatePartWrappers()
        {
            part = new __batching_map_Schema1__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_batching_map_Schema1(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __batching_map_Schema2__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static batching_map.Schema2 _schema = new batching_map.Schema2();

        public __batching_map_Schema2__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "batching_map.Schema2",
        new System.Type[]{
            typeof(batching_map.Schema2)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__batching_map_Schema2__)
        },
        0,
        @"http://batching_map.Schema2#Schema_two"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_batching_map_Schema2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __batching_map_Schema2__ part;

        private void __CreatePartWrappers()
        {
            part = new __batching_map_Schema2__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_batching_map_Schema2(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __batching_map_outxsd__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static batching_map.outxsd _schema = new batching_map.outxsd();

        public __batching_map_outxsd__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "batching_map.outxsd",
        new System.Type[]{
            typeof(batching_map.outxsd)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__batching_map_outxsd__)
        },
        0,
        @"http://batching_map.outxsd#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_batching_map_outxsd : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __batching_map_outxsd__ part;

        private void __CreatePartWrappers()
        {
            part = new __batching_map_outxsd__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_batching_map_outxsd(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
