
#pragma warning disable 162

namespace Complete_mapping
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Complete_mapping.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Dynamic_Send_port : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Dynamic_Send_port(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Dynamic_Send_port(Dynamic_Send_port p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Dynamic_Send_port p = new Dynamic_Send_port(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Dynamic_Send_port),
            typeof(__messagetype_System_Xml_XmlDocument),
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
            typeof(Complete_mapping.__messagetype_Temp_Map_GenericSchema)
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
            typeof(__messagetype_Temp_Map_GenericSchema),
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
    //#line 253 "C:\AMP\env\Complete_mapping\Complete_mapping\OrchestrationForDynamicMaps.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(Complete_mapping.PortType_1),
            typeof(Complete_mapping.Dynamic_Send_port)
        },
        new System.String[] {
            "Port_1",
            "Dymanic_Send"
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
    sealed internal class OrchestrationForDynamicMaps : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(OrchestrationForDynamicMaps));
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

        static OrchestrationForDynamicMaps()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 1;
            _rootContext = new __OrchestrationForDynamicMaps_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public OrchestrationForDynamicMaps(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "OrchestrationForDynamicMaps", tracker)
        {
            ConstructorHelper();
        }

        public OrchestrationForDynamicMaps(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "OrchestrationForDynamicMaps")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>128647d6-ddf7-4f89-a0c7-9db071833f70</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f7fbe619-168f-48da-847d-6962aa65cabf</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8bc6c370-2731-4211-b23f-c62074bfe8cb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Identify Subscriber</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>27450807-e098-44ec-84d4-4d43e8fa1f46</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>d2689ef3-70d1-420d-a45f-c6043574891e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ABC</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0a92c1ea-ee43-457f-8a85-3a28cb63897d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8be1aaf0-5db9-419a-9e00-a1012cc6e30a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_ABC</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>e1470cdb-d77f-44b7-ad0c-47f155943d68</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>8e5feaca-8fd5-404e-99cf-1b7dbdab86e5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SetDestination</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>60b614ab-95cf-415f-bae8-bd717d09ae6f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>389684b4-623c-40fb-b96c-89dbd7d7f468</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>c5fecd1a-fc1e-45e4-9398-b7cf578d54e2</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>XYZ</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7d77f1ea-51d5-4763-abc0-1a235989fc2a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>ff94396b-4de9-4872-997f-c904cc44f602</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_XYZ_out</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>97d32c9c-378f-4981-9243-4d6b81eb7ba1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_XYZ</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>388f4105-a331-4bc0-b78d-81e948ab6eef</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'OrchestrationForDynamicMaps'</ActionName><IsAtomic>0</IsAtomic><Line>253</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>267</Line><Position>22</Position><ShapeID>'f7fbe619-168f-48da-847d-6962aa65cabf'</ShapeID>
<Messages>
	<MsgInfo><name>Generic_In</name><part>part</part><schema>Temp_Map.GenericSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>271</Line><Position>35</Position><ShapeID>'8bc6c370-2731-4211-b23f-c62074bfe8cb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>274</Line><Position>13</Position><ShapeID>'27450807-e098-44ec-84d4-4d43e8fa1f46'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>277</Line><Position>22</Position><ShapeID>'0a92c1ea-ee43-457f-8a85-3a28cb63897d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>279</Line><Position>17</Position><ShapeID>'8be1aaf0-5db9-419a-9e00-a1012cc6e30a'</ShapeID>
<Messages>
	<MsgInfo><name>Generic_In</name><part>part</part><schema>Temp_Map.GenericSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>290</Line><Position>17</Position><ShapeID>'389684b4-623c-40fb-b96c-89dbd7d7f468'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>295</Line><Position>22</Position><ShapeID>'7d77f1ea-51d5-4763-abc0-1a235989fc2a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>297</Line><Position>17</Position><ShapeID>'ff94396b-4de9-4872-997f-c904cc44f602'</ShapeID>
<Messages>
	<MsgInfo><name>Generic_In</name><part>part</part><schema>Temp_Map.GenericSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>303</Line><Position>17</Position><ShapeID>'97d32c9c-378f-4981-9243-4d6b81eb7ba1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='6a9fa47f-27a4-42b1-aa7c-793eee57b117' LowerBound='1.1' HigherBound='74.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Complete_mapping' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='c18259d0-1ded-4da3-9097-1cc7e552211d' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Dynamic_Send_port' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2d23aecb-222b-4875-be70-179bedeea88c' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c07c1dc9-f7a8-4e5f-a7c7-3116c9c15b3c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f6c0b677-f58f-45d2-95d4-a98c57d7b0dc' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3a71d5e5-6893-4edb-b779-f743bcef1128' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='2c84d6b8-7c76-4b14-a47b-70c78bff9852' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.35'>
                    <om:Property Name='Ref' Value='Temp_Map.GenericSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='dda63e71-bff8-43b7-9a83-625d7eb32d16' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='73.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrchestrationForDynamicMaps' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='282851ee-2b8a-4570-89d1-8f13511bda7c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SubscriberInformation' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f4ca05f8-356a-459d-941f-f8b5a099ddb8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmap' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='27059a01-4ca5-4824-9c00-47896e0592a5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ErrorMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ba8f4a4d-1ef1-49f6-afe5-ab5ae280ae1a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Temp_Map.GenericSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Generic_In' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d44ba0d9-d90f-42f5-bfad-34ba5d75cc0f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_Out' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='128647d6-ddf7-4f89-a0c7-9db071833f70' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='f7fbe619-168f-48da-847d-6962aa65cabf' ParentLink='ServiceBody_Statement' LowerBound='32.1' HigherBound='36.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='Generic_In' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='8bc6c370-2731-4211-b23f-c62074bfe8cb' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='39.1'>
                    <om:Property Name='Expression' Value='SubscriberInformation = &#xD;&#xA;   Generic_In(Temp_Map.PropertySchema.SubscriberInfo );' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Identify Subscriber' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='27450807-e098-44ec-84d4-4d43e8fa1f46' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='71.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='d2689ef3-70d1-420d-a45f-c6043574891e' ParentLink='ReallyComplexStatement_Branch' LowerBound='40.13' HigherBound='58.1'>
                        <om:Property Name='Expression' Value='SubscriberInformation == &quot;ABC&quot; ' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ABC' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='0a92c1ea-ee43-457f-8a85-3a28cb63897d' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='44.1'>
                            <om:Property Name='Expression' Value='tmap = System.Type.GetType(&quot;Temp_Map.Map_ABC,Temp_Map, Version=1.0.0.0, Culture=neutral, PublicKeyToken=eee1b17b814de0bd&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Construct' OID='8be1aaf0-5db9-419a-9e00-a1012cc6e30a' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='55.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_ABC' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='e1470cdb-d77f-44b7-ad0c-47f155943d68' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='52.1'>
                                <om:Property Name='Expression' Value='transform (Message_Out) = tmap(Generic_In);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='8e5feaca-8fd5-404e-99cf-1b7dbdab86e5' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='54.1'>
                                <om:Property Name='Expression' Value='Dymanic_Send(Microsoft.XLANGs.BaseTypes.Address) =  &quot;FILE://C:\\Users\\rr272807\\Desktop\\Biztalk location\\Dyn_maps\\send\\ABC\\%MessageID%.xml&quot; ;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='SetDestination' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='60b614ab-95cf-415f-bae8-bd717d09ae6f' ParentLink='Construct_MessageRef' LowerBound='45.27' HigherBound='45.38'>
                                <om:Property Name='Ref' Value='Message_Out' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='389684b4-623c-40fb-b96c-89dbd7d7f468' ParentLink='ComplexStatement_Statement' LowerBound='55.1' HigherBound='57.1'>
                            <om:Property Name='PortName' Value='Dymanic_Send' />
                            <om:Property Name='MessageName' Value='Message_Out' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='c5fecd1a-fc1e-45e4-9398-b7cf578d54e2' ParentLink='ReallyComplexStatement_Branch' LowerBound='58.18' HigherBound='71.1'>
                        <om:Property Name='Expression' Value='SubscriberInformation == &quot;XYZ&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='XYZ' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='7d77f1ea-51d5-4763-abc0-1a235989fc2a' ParentLink='ComplexStatement_Statement' LowerBound='60.1' HigherBound='62.1'>
                            <om:Property Name='Expression' Value='tmap = System.Type.GetType(&quot;Temp_Map.Ma_XYZ,Temp_Map, Version=1.0.0.0, Culture=neutral, PublicKeyToken=eee1b17b814de0bd&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='ff94396b-4de9-4872-997f-c904cc44f602' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='68.1'>
                            <om:Property Name='Expression' Value='construct Message_Out&#xD;&#xA;{&#xD;&#xA;    transform (Message_Out) = tmap(Generic_In);&#xD;&#xA;    Dymanic_Send(Microsoft.XLANGs.BaseTypes.Address) =  &quot;FILE://C:\\Users\\rr272807\\Desktop\\Biztalk location\\Dyn_maps\\send\\XYZ\\%MessageID%.xml&quot; ;&#xD;&#xA;}' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct_XYZ_out' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Send' OID='97d32c9c-378f-4981-9243-4d6b81eb7ba1' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='70.1'>
                            <om:Property Name='PortName' Value='Dymanic_Send' />
                            <om:Property Name='MessageName' Value='Message_Out' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_XYZ' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='388f4105-a331-4bc0-b78d-81e948ab6eef' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c9e3f411-74b2-4038-b421-0e55a0e6c418' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Complete_mapping.Dynamic_Send_port' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Dymanic_Send' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='8d93a538-072f-482c-b581-2d328ddca305' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5d7f535f-5e31-4736-96d3-e7a756132048' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Complete_mapping.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='60fe99c2-bfb1-4309-96da-29524d151377' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __OrchestrationForDynamicMaps_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __OrchestrationForDynamicMaps_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchestrationForDynamicMaps")
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
                OrchestrationForDynamicMaps __svc__ = (OrchestrationForDynamicMaps)_service;
                __OrchestrationForDynamicMaps_root_0 __ctx0__ = (__OrchestrationForDynamicMaps_root_0)(__svc__._stateMgrs[0]);

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
        public class __OrchestrationForDynamicMaps_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __OrchestrationForDynamicMaps_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchestrationForDynamicMaps")
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
                OrchestrationForDynamicMaps __svc__ = (OrchestrationForDynamicMaps)_service;
                __OrchestrationForDynamicMaps_root_0 __ctx0__ = (__OrchestrationForDynamicMaps_root_0)(__svc__._stateMgrs[0]);
                __OrchestrationForDynamicMaps_1 __ctx1__ = (__OrchestrationForDynamicMaps_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Message_Out != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Out);
                    __ctx1__.__Message_Out = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ErrorMessage = null;
                if (__ctx1__ != null && __ctx1__.__Generic_In != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Generic_In);
                    __ctx1__.__Generic_In = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SubscriberInformation = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmap = null;
                if (__svc__.Dymanic_Send != null)
                {
                    __svc__.Dymanic_Send.Close(this, null);
                    __svc__.Dymanic_Send = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Generic_In")]
            public __messagetype_Temp_Map_GenericSchema __Generic_In;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_Out")]
            public __messagetype_System_Xml_XmlDocument __Message_Out;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SubscriberInformation")]
            internal System.String __SubscriberInformation;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmap")]
            internal System.Type __tmap;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ErrorMessage")]
            internal System.String __ErrorMessage;
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
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Dymanic_Send")]
        internal Dynamic_Send_port Dymanic_Send;  // lock index = 0

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(OrchestrationForDynamicMaps).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchestrationForDynamicMaps), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Dynamic_Send_port.Operation_1},
                                               typeof(OrchestrationForDynamicMaps).GetField("Dymanic_Send", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchestrationForDynamicMaps), "Dymanic_Send"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "f7fbe619-168f-48da-847d-6962aa65cabf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f7fbe619-168f-48da-847d-6962aa65cabf", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "8bc6c370-2731-4211-b23f-c62074bfe8cb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "8bc6c370-2731-4211-b23f-c62074bfe8cb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "27450807-e098-44ec-84d4-4d43e8fa1f46", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0a92c1ea-ee43-457f-8a85-3a28cb63897d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "0a92c1ea-ee43-457f-8a85-3a28cb63897d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "8be1aaf0-5db9-419a-9e00-a1012cc6e30a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "8be1aaf0-5db9-419a-9e00-a1012cc6e30a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "389684b4-623c-40fb-b96c-89dbd7d7f468", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "389684b4-623c-40fb-b96c-89dbd7d7f468", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "7d77f1ea-51d5-4763-abc0-1a235989fc2a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "7d77f1ea-51d5-4763-abc0-1a235989fc2a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "ff94396b-4de9-4872-997f-c904cc44f602", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "ff94396b-4de9-4872-997f-c904cc44f602", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "97d32c9c-378f-4981-9243-4d6b81eb7ba1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "97d32c9c-378f-4981-9243-4d6b81eb7ba1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "27450807-e098-44ec-84d4-4d43e8fa1f46", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,6,6,7,7,8,9,9,10,11,11,11,12,6,6,6,13,13,14,15,15,16,17,17,17,18,18,19,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __OrchestrationForDynamicMaps_root_0 __ctx0__ = (__OrchestrationForDynamicMaps_root_0)_stateMgrs[0];
            __OrchestrationForDynamicMaps_1 __ctx1__ = (__OrchestrationForDynamicMaps_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Dymanic_Send = new Dynamic_Send_port(1, this);
                Port_1 = new PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __OrchestrationForDynamicMaps_1(this);
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
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __OrchestrationForDynamicMaps_root_0 __ctx0__ = (__OrchestrationForDynamicMaps_root_0)_stateMgrs[0];
            __OrchestrationForDynamicMaps_1 __ctx1__ = (__OrchestrationForDynamicMaps_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__SubscriberInformation = default(System.String);
                __ctx1__.__tmap = default(System.Type);
                __ctx1__.__ErrorMessage = default(System.String);
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
                if (__ctx1__.__Generic_In != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Generic_In);
                __ctx1__.__Generic_In = new __messagetype_Temp_Map_GenericSchema("Generic_In", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Generic_In);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__Generic_In, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__Generic_In);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__SubscriberInformation = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ErrorMessage = "";
                if (__ctx1__ != null)
                    __ctx1__.__ErrorMessage = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx1__.__SubscriberInformation = (System.String)__ctx1__.__Generic_In.GetPropertyValueThrows(typeof(Temp_Map.PropertySchema.SubscriberInfo));
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __condition__ = __ctx1__.__SubscriberInformation == "ABC";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 23;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx1__.__tmap = System.Type.GetType("Temp_Map.Map_ABC,Temp_Map, Version=1.0.0.0, Culture=neutral, PublicKeyToken=eee1b17b814de0bd");
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                {
                    __messagetype_System_Xml_XmlDocument __Message_Out = new __messagetype_System_Xml_XmlDocument("Message_Out", __ctx1__);

                    ApplyTransform(__ctx1__.__tmap, new object[] {__Message_Out.part}, new object[] {__ctx1__.__Generic_In.part});
                    Dymanic_Send.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), "FILE://C:\\Users\\rr272807\\Desktop\\Biztalk location\\Dyn_maps\\send\\ABC\\%MessageID%.xml");

                    if (__ctx1__.__Message_Out != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_Out);
                    __ctx1__.__Message_Out = __Message_Out;
                    __ctx1__.RefMessage(__ctx1__.__Message_Out);
                }
                __ctx1__.__Message_Out.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_Out);
                    __edata.Messages.Add(__ctx1__.__Generic_In);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Dymanic_Send.SendMessage(0, __ctx1__.__Message_Out, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_Out);
                    __edata.PortName = @"Dymanic_Send";
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                __condition__ = __ctx1__.__SubscriberInformation == "XYZ";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 35;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx1__.__tmap = System.Type.GetType("Temp_Map.Ma_XYZ,Temp_Map, Version=1.0.0.0, Culture=neutral, PublicKeyToken=eee1b17b814de0bd");
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                {
                    __messagetype_System_Xml_XmlDocument __Message_Out = new __messagetype_System_Xml_XmlDocument("Message_Out", __ctx1__);

                    ApplyTransform(__ctx1__.__tmap, new object[] {__Message_Out.part}, new object[] {__ctx1__.__Generic_In.part});
                    Dymanic_Send.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), "FILE://C:\\Users\\rr272807\\Desktop\\Biztalk location\\Dyn_maps\\send\\XYZ\\%MessageID%.xml");

                    if (__ctx1__.__Message_Out != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_Out);
                    __ctx1__.__Message_Out = __Message_Out;
                    __ctx1__.RefMessage(__ctx1__.__Message_Out);
                }
                __ctx1__.__Message_Out.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_Out);
                    __edata.Messages.Add(__ctx1__.__Generic_In);
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Dymanic_Send.SendMessage(0, __ctx1__.__Message_Out, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_Out);
                    __edata.PortName = @"Dymanic_Send";
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__tmap = null;
                if (__ctx1__ != null)
                    __ctx1__.__SubscriberInformation = null;
                if (__ctx1__ != null && __ctx1__.__Message_Out != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_Out);
                    __ctx1__.__Message_Out = null;
                }
                if (__ctx1__ != null && __ctx1__.__Generic_In != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Generic_In);
                    __ctx1__.__Generic_In = null;
                }
                if (Dymanic_Send != null)
                {
                    Dymanic_Send.Close(__ctx1__, __seg__);
                    Dymanic_Send = null;
                }
                Tracker.FireEvent(__eventLocations[19],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 40;
            case 40:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Temp_Map_GenericSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Temp_Map.GenericSchema _schema = new Temp_Map.GenericSchema();

        public __Temp_Map_GenericSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Temp_Map.GenericSchema",
        new System.Type[]{
            typeof(Temp_Map.GenericSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Temp_Map_GenericSchema__)
        },
        0,
        @"http://Temp_Map.GenericSchema#GenericMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Temp_Map_GenericSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Temp_Map_GenericSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Temp_Map_GenericSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Temp_Map_GenericSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
