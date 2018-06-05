
#pragma warning disable 162

namespace Count_comparision
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Count_comparision.__messagetype_Count_comparision_Incoming_orders)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class In_orders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public In_orders(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public In_orders(In_orders p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            In_orders p = new In_orders(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(In_orders),
            typeof(__messagetype_Count_comparision_Incoming_orders),
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
            typeof(Count_comparision.__messagetype_Count_comparision_Control_count)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Ctl_orders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Ctl_orders(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Ctl_orders(Ctl_orders p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Ctl_orders p = new Ctl_orders(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Ctl_orders),
            typeof(__messagetype_Count_comparision_Control_count),
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
            typeof(Count_comparision.__messagetype_Count_comparision_outgoning_schema)
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
            typeof(__messagetype_Count_comparision_outgoning_schema),
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
            "BTS.ReceivePortName"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new BTS.ReceivePortName()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 354 "C:\AMP\env\Count_comparision\Count_comparision\Count_com.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "In", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Ctl", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Count_comparision.In_orders),
            typeof(Count_comparision.Ctl_orders),
            typeof(Count_comparision.PortType_1)
        },
        new System.String[] {
            "In",
            "Ctl",
            "Port_1"
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
    sealed internal class Count_com : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Count_com));
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

        static Count_com()
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
            _rootContext = new __Count_com_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Count_com(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Count_com", tracker)
        {
            ConstructorHelper();
        }

        public Count_com(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Count_com")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>99c308c2-5023-433f-a8f6-a925f543f399</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>dc549ccf-2f54-4056-a009-3908cee37efc</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>ccee2adf-630e-4149-a6fc-a6b5215468f7</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>177bc6e0-d58d-47d2-af0e-adf34ca642f9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>6322f5d9-ca98-4873-a9bd-d4854c44cb44</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>dfbdb865-df7a-40a4-aebc-ee6edca0957f</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>0b6e17df-c338-49bb-b254-b8ad0c74bf80</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f484bf34-3a2b-4e9b-8d3c-27f1c2e105d3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Get_Ctl_Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>6226fcb4-1d71-4f20-b42f-0579e7446380</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>ac839d1d-0ab3-4ced-aa53-62ec1cba07c4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c28188f4-d20d-4b8a-989f-cfd7e1322ea0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>dd2790b8-8110-4903-b76d-bba501396c12</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>01c8ad29-ac02-4e1e-a27a-9eaad0c23f57</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2cd9b048-4891-4ae8-87ce-2105edd6342d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2e9b7845-1b64-4ced-b9ca-916df38717eb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>44404914-e13f-4a9b-a161-4e24d816e669</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Count_to_outMsg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>6940c3a4-2ca2-4445-a903-4eb44bd599ab</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>843eae32-97f7-417e-a4ec-b5a2dc91f8ff</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>70dee166-f271-45ea-9ebc-9a00c847d204</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>75d1c43d-7a85-4e89-b7d7-6f73d3ed32c6</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Count_com'</ActionName><IsAtomic>0</IsAtomic><Line>354</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>372</Line><Position>13</Position><ShapeID>'dc549ccf-2f54-4056-a009-3908cee37efc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>377</Line><Position>30</Position><ShapeID>'177bc6e0-d58d-47d2-af0e-adf34ca642f9'</ShapeID>
<Messages>
	<MsgInfo><name>In_msg</name><part>part</part><schema>Count_comparision.Incoming_orders</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>379</Line><Position>34</Position><ShapeID>'6322f5d9-ca98-4873-a9bd-d4854c44cb44'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>384</Line><Position>30</Position><ShapeID>'0b6e17df-c338-49bb-b254-b8ad0c74bf80'</ShapeID>
<Messages>
	<MsgInfo><name>Ctl_msg</name><part>part</part><schema>Count_comparision.Control_count</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>387</Line><Position>34</Position><ShapeID>'f484bf34-3a2b-4e9b-8d3c-27f1c2e105d3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>399</Line><Position>13</Position><ShapeID>'6226fcb4-1d71-4f20-b42f-0579e7446380'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>402</Line><Position>17</Position><ShapeID>'c28188f4-d20d-4b8a-989f-cfd7e1322ea0'</ShapeID>
<Messages>
	<MsgInfo><name>Out_msg</name><part>part</part><schema>Count_comparision.outgoning_schema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>In_msg</name><part>part</part><schema>Count_comparision.Incoming_orders</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>408</Line><Position>17</Position><ShapeID>'44404914-e13f-4a9b-a161-4e24d816e669'</ShapeID>
<Messages>
	<MsgInfo><name>dummy_msg</name><part>part</part><schema>Count_comparision.outgoning_schema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>417</Line><Position>17</Position><ShapeID>'70dee166-f271-45ea-9ebc-9a00c847d204'</ShapeID>
<Messages>
	<MsgInfo><name>dummy_msg</name><part>part</part><schema>Count_comparision.outgoning_schema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='c412adc6-153b-42b3-9576-aa3e2f10345f' LowerBound='1.1' HigherBound='98.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Count_comparision' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='07006560-8a4a-4e56-8ff1-f80b9c15e041' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='In_orders' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ccea2eb3-5c6d-4e0a-a0b5-c0fb354a25a4' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='d466a65b-36d7-40e6-9717-58c9b59a412b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.28'>
                    <om:Property Name='Ref' Value='Count_comparision.Incoming_orders' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f7ea928d-ecd8-42f2-b864-d37071e5b336' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Ctl_orders' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6baf45e2-21ed-4254-8976-41a12c7d3329' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='a8b47607-83c5-40a4-95ee-b070eb3001c4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.26'>
                    <om:Property Name='Ref' Value='Count_comparision.Control_count' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='2e6c2c0b-ecff-4836-b469-d7261f8ef14a' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='feb620d9-2215-4899-b684-bec8e48b607e' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9b73b975-3572-4594-b3f6-97aad655345f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.29'>
                    <om:Property Name='Ref' Value='Count_comparision.outgoning_schema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='35f9b5fe-9a6f-42aa-8afc-83be0b0c83d5' ParentLink='Module_CorrelationType' LowerBound='25.1' HigherBound='29.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='2865dce0-8d90-474a-ac29-7ddb4f3a5f29' ParentLink='CorrelationType_PropertyRef' LowerBound='27.9' HigherBound='27.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='2d97a270-fbea-4ccf-b0f7-a5b89dcdcd73' ParentLink='Module_ServiceDeclaration' LowerBound='29.1' HigherBound='97.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Count_com' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='22ebb7d7-74b3-46e1-8c43-9929fd340feb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int64' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='In_Msg_count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9270ed24-cb3c-4b29-9974-4a1a1e4594e1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Ctl_ms_count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='a8bc661f-a643-4512-97f6-d9eb029234f7' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='Type' Value='Count_comparision.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='fd61162f-9e36-4d3a-a3dc-fadb0b52b0ef' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='60.65' HigherBound='60.89'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='0b6e17df-c338-49bb-b254-b8ad0c74bf80' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='f27bb9c8-8490-4261-8dbb-2c430a27917f' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='53.63' HigherBound='53.87'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='177bc6e0-d58d-47d2-af0e-adf34ca642f9' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='85ff6a56-2e0b-47c3-a9ab-b555537001ff' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='Type' Value='Count_comparision.Incoming_orders' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='In_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7681b480-112e-4d1c-9bb0-1df6f1219bb1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='Type' Value='Count_comparision.Control_count' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Ctl_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='eea56074-6773-4bd4-8dc2-2f7b746c73d9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='Count_comparision.outgoning_schema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dummy_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e839520a-8b50-48ae-bfde-97c35eb00ec1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='Count_comparision.outgoning_schema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Out_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='99c308c2-5023-433f-a8f6-a925f543f399' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Parallel' OID='dc549ccf-2f54-4056-a009-3908cee37efc' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='74.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ParallelActions_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ParallelBranch' OID='ccee2adf-630e-4149-a6fc-a6b5215468f7' ParentLink='ReallyComplexStatement_Branch' LowerBound='52.1' HigherBound='56.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='177bc6e0-d58d-47d2-af0e-adf34ca642f9' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='54.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='In' />
                            <om:Property Name='MessageName' Value='In_msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='6322f5d9-ca98-4873-a9bd-d4854c44cb44' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='56.1'>
                            <om:Property Name='Expression' Value='In_Msg_count = System.Convert.ToInt64(xpath(In_msg,&quot;count(/*[local-name()=&apos;Po&apos; and namespace-uri()=&apos;http://Count_comparision.Incoming_orders&apos;]/*[local-name()=&apos;Orders&apos; and namespace-uri()=&apos;&apos;])&quot;));' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='dfbdb865-df7a-40a4-aebc-ee6edca0957f' ParentLink='ReallyComplexStatement_Branch' LowerBound='59.1' HigherBound='72.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='0b6e17df-c338-49bb-b254-b8ad0c74bf80' ParentLink='ComplexStatement_Statement' LowerBound='59.1' HigherBound='61.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Ctl' />
                            <om:Property Name='MessageName' Value='Ctl_msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='f484bf34-3a2b-4e9b-8d3c-27f1c2e105d3' ParentLink='ComplexStatement_Statement' LowerBound='61.1' HigherBound='72.1'>
                            <om:Property Name='Expression' Value='&#xD;&#xA;Ctl_ms_count = xpath(Ctl_msg, &quot;string(/*[local-name()=&apos;ControlCount&apos; and namespace-uri()=&apos;http://Count_comparision.Control_count&apos;]/*[local-name()=&apos;Count&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Ctl_ms_count = xpath(Ctl_msg,&quot;number(/ControlCount/Count)&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Ctl_ms_count = Ctl_msg.Count;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Get_Ctl_Count' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='6226fcb4-1d71-4f20-b42f-0579e7446380' ParentLink='ServiceBody_Statement' LowerBound='74.1' HigherBound='95.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='ac839d1d-0ab3-4ced-aa53-62ec1cba07c4' ParentLink='ReallyComplexStatement_Branch' LowerBound='75.13' HigherBound='95.1'>
                        <om:Property Name='Expression' Value='In_Msg_count == Ctl_ms_count' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='c28188f4-d20d-4b8a-989f-cfd7e1322ea0' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='83.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='dd2790b8-8110-4903-b76d-bba501396c12' ParentLink='ComplexStatement_Statement' LowerBound='80.1' HigherBound='82.1'>
                                <om:Property Name='ClassName' Value='Count_comparision.Transform_2' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='01c8ad29-ac02-4e1e-a27a-9eaad0c23f57' ParentLink='Transform_InputMessagePartRef' LowerBound='81.74' HigherBound='81.80'>
                                    <om:Property Name='MessageRef' Value='In_msg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='2cd9b048-4891-4ae8-87ce-2105edd6342d' ParentLink='Transform_OutputMessagePartRef' LowerBound='81.32' HigherBound='81.39'>
                                    <om:Property Name='MessageRef' Value='Out_msg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='2e9b7845-1b64-4ced-b9ca-916df38717eb' ParentLink='Construct_MessageRef' LowerBound='78.27' HigherBound='78.34'>
                                <om:Property Name='Ref' Value='Out_msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Construct' OID='44404914-e13f-4a9b-a161-4e24d816e669' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='92.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Count_to_outMsg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='6940c3a4-2ca2-4445-a903-4eb44bd599ab' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='91.1'>
                                <om:Property Name='Expression' Value='dummy_msg = Out_msg;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;dummy_msg.OrderCount.count = Ctl_ms_count;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='843eae32-97f7-417e-a4ec-b5a2dc91f8ff' ParentLink='Construct_MessageRef' LowerBound='84.27' HigherBound='84.36'>
                                <om:Property Name='Ref' Value='dummy_msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='70dee166-f271-45ea-9ebc-9a00c847d204' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='94.1'>
                            <om:Property Name='PortName' Value='Port_1' />
                            <om:Property Name='MessageName' Value='dummy_msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='75d1c43d-7a85-4e89-b7d7-6f73d3ed32c6' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a00cf28e-c7a8-4e41-b263-883ddfdabe44' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Count_comparision.In_orders' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='In' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='52846088-f78f-4ebb-b176-188df8dfdad7' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='11a4bbd1-6f2a-401b-b3d9-d3f910a765ad' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='34.1' HigherBound='36.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Count_comparision.Ctl_orders' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Ctl' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='165d1148-65cc-4cf7-b041-74af35eaaf41' ParentLink='PortDeclaration_CLRAttribute' LowerBound='34.1' HigherBound='35.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ab7b6ed6-eb17-46c4-a1d0-c6de2773f0fc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Count_comparision.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9ace44a7-940d-4d27-9b1a-a875323af637' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Count_com_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Count_com_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Count_com")
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
                Count_com __svc__ = (Count_com)_service;
                __Count_com_root_0 __ctx0__ = (__Count_com_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.In != null)
                {
                    __svc__.In.Close(this, null);
                    __svc__.In = null;
                }
                if (__svc__.Ctl != null)
                {
                    __svc__.Ctl.Close(this, null);
                    __svc__.Ctl = null;
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
        public class __Count_com_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Count_com_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Count_com")
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
                Count_com __svc__ = (Count_com)_service;
                __Count_com_1 __ctx1__ = (__Count_com_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__In_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_msg);
                    __ctx1__.__In_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Ctl_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Ctl_msg);
                    __ctx1__.__Ctl_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__dummy_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__dummy_msg);
                    __ctx1__.__dummy_msg = null;
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

            [Microsoft.XLANGs.Core.UserVariableAttribute("In_msg")]
            public __messagetype_Count_comparision_Incoming_orders __In_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Ctl_msg")]
            public __messagetype_Count_comparision_Control_count __Ctl_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dummy_msg")]
            public __messagetype_Count_comparision_outgoning_schema __dummy_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Out_msg")]
            public __messagetype_Count_comparision_outgoning_schema __Out_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("In_Msg_count")]
            internal System.Int64 __In_Msg_count;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Ctl_ms_count")]
            internal System.Int32 __Ctl_ms_count;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("In")]
        internal In_orders In;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Ctl")]
        internal Ctl_orders Ctl;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {In_orders.Operation_1},
                                               typeof(Count_com).GetField("In", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Count_com), "In"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Ctl_orders.Operation_1},
                                               typeof(Count_com).GetField("Ctl", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Count_com), "Ctl"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(Count_com).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Count_com), "Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "dc549ccf-2f54-4056-a009-3908cee37efc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "dc549ccf-2f54-4056-a009-3908cee37efc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "177bc6e0-d58d-47d2-af0e-adf34ca642f9", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "177bc6e0-d58d-47d2-af0e-adf34ca642f9", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "6322f5d9-ca98-4873-a9bd-d4854c44cb44", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "6322f5d9-ca98-4873-a9bd-d4854c44cb44", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0b6e17df-c338-49bb-b254-b8ad0c74bf80", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "0b6e17df-c338-49bb-b254-b8ad0c74bf80", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f484bf34-3a2b-4e9b-8d3c-27f1c2e105d3", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "f484bf34-3a2b-4e9b-8d3c-27f1c2e105d3", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "6226fcb4-1d71-4f20-b42f-0579e7446380", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "c28188f4-d20d-4b8a-989f-cfd7e1322ea0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "c28188f4-d20d-4b8a-989f-cfd7e1322ea0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "44404914-e13f-4a9b-a161-4e24d816e669", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "44404914-e13f-4a9b-a161-4e24d816e669", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "70dee166-f271-45ea-9ebc-9a00c847d204", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "70dee166-f271-45ea-9ebc-9a00c847d204", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "6226fcb4-1d71-4f20-b42f-0579e7446380", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,19,19,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,3,2,2,11,11,12,12,13,14,14,15,16,16,16,17,18,19,19,19,19,};
        public static int[] __progressLocation2 = new int[] { 3,3,4,5,5,6,2,};
        public static int[] __progressLocation3 = new int[] { 7,7,8,9,9,10,2,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Count_com_1 __ctx1__ = (__Count_com_1)_stateMgrs[1];
            __Count_com_root_0 __ctx0__ = (__Count_com_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                In = new In_orders(0, this);
                Ctl = new Ctl_orders(1, this);
                Port_1 = new PortType_1(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], In, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Ctl, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Count_com_1(this);
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
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Count_com_1 __ctx1__ = (__Count_com_1)_stateMgrs[1];
            __Count_com_root_0 __ctx0__ = (__Count_com_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__In_Msg_count = default(System.Int64);
                __ctx1__.__Ctl_ms_count = default(System.Int32);
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
                if (Ctl != null)
                {
                    Ctl.Close(__ctx1__, __seg__);
                    Ctl = null;
                }
                if (In != null)
                {
                    In.Close(__ctx1__, __seg__);
                    In = null;
                }
                Tracker.FireEvent(__eventLocations[2],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = __ctx1__.__In_Msg_count == __ctx1__.__Ctl_ms_count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 18;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_Count_comparision_outgoning_schema __Out_msg = new __messagetype_Count_comparision_outgoning_schema("Out_msg", __ctx1__);

                    ApplyTransform(typeof(Count_comparision.Transform_2), new object[] {__Out_msg.part}, new object[] {__ctx1__.__In_msg.part});

                    if (__ctx1__.__Out_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Out_msg);
                    __ctx1__.__Out_msg = __Out_msg;
                    __ctx1__.RefMessage(__ctx1__.__Out_msg);
                }
                __ctx1__.__Out_msg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Out_msg);
                    __edata.Messages.Add(__ctx1__.__In_msg);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_Count_comparision_outgoning_schema __dummy_msg = new __messagetype_Count_comparision_outgoning_schema("dummy_msg", __ctx1__);

                    __dummy_msg.CopyFrom(__ctx1__.__Out_msg);
                    if (__ctx1__ != null && __ctx1__.__Out_msg != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Out_msg);
                        __ctx1__.__Out_msg = null;
                    }
                    __dummy_msg.part.SetDistinguishedField("OrderCount.count", __ctx1__.__Ctl_ms_count);

                    if (__ctx1__.__dummy_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__dummy_msg);
                    __ctx1__.__dummy_msg = __dummy_msg;
                    __ctx1__.RefMessage(__ctx1__.__dummy_msg);
                }
                __ctx1__.__dummy_msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__dummy_msg);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_1.SendMessage(0, __ctx1__.__dummy_msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__dummy_msg);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__dummy_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__dummy_msg);
                    __ctx1__.__dummy_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__In_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_msg);
                    __ctx1__.__In_msg = null;
                }
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                Tracker.FireEvent(__eventLocations[18],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[10],_stateMgrs[1].TrackDataStream );
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

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Count_com_1 __ctx1__ = (__Count_com_1)_stateMgrs[1];
            __Count_com_root_0 __ctx0__ = (__Count_com_root_0)_stateMgrs[0];

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
                if (!In.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__In_msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__In_msg);
                __ctx1__.__In_msg = new __messagetype_Count_comparision_Incoming_orders("In_msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__In_msg);
                In.ReceiveMessage(0, __msgEnv__, __ctx1__.__In_msg, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__In_msg);
                    __edata.PortName = @"In";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__In_Msg_count = System.Convert.ToInt64(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__In_msg.part, "count(/*[local-name()='Po' and namespace-uri()='http://Count_comparision.Incoming_orders']/*[local-name()='Orders' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
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
            __Count_com_1 __ctx1__ = (__Count_com_1)_stateMgrs[1];
            __Count_com_root_0 __ctx0__ = (__Count_com_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!Ctl.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Ctl_msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Ctl_msg);
                __ctx1__.__Ctl_msg = new __messagetype_Count_comparision_Control_count("Ctl_msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Ctl_msg);
                Ctl.ReceiveMessage(0, __msgEnv__, __ctx1__.__Ctl_msg, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Ctl_msg);
                    __edata.PortName = @"Ctl";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__Ctl_ms_count = (System.Int32)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__Ctl_msg.part, "string(/*[local-name()='ControlCount' and namespace-uri()='http://Count_comparision.Control_count']/*[local-name()='Count' and namespace-uri()=''])", typeof(System.Int32));
                if (__ctx1__ != null && __ctx1__.__Ctl_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Ctl_msg);
                    __ctx1__.__Ctl_msg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Count_comparision_Incoming_orders__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Count_comparision.Incoming_orders _schema = new Count_comparision.Incoming_orders();

        public __Count_comparision_Incoming_orders__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Count_comparision.Incoming_orders",
        new System.Type[]{
            typeof(Count_comparision.Incoming_orders)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Count_comparision_Incoming_orders__)
        },
        0,
        @"http://Count_comparision.Incoming_orders#Po"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Count_comparision_Incoming_orders : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Count_comparision_Incoming_orders__ part;

        private void __CreatePartWrappers()
        {
            part = new __Count_comparision_Incoming_orders__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Count_comparision_Incoming_orders(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Count_comparision_Control_count__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Count_comparision.Control_count _schema = new Count_comparision.Control_count();

        public __Count_comparision_Control_count__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Count_comparision.Control_count",
        new System.Type[]{
            typeof(Count_comparision.Control_count)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Count_comparision_Control_count__)
        },
        0,
        @"http://Count_comparision.Control_count#ControlCount"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Count_comparision_Control_count : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Count_comparision_Control_count__ part;

        private void __CreatePartWrappers()
        {
            part = new __Count_comparision_Control_count__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Count_comparision_Control_count(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Count_comparision_outgoning_schema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Count_comparision.outgoning_schema _schema = new Count_comparision.outgoning_schema();

        public __Count_comparision_outgoning_schema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Count_comparision.outgoning_schema",
        new System.Type[]{
            typeof(Count_comparision.outgoning_schema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Count_comparision_outgoning_schema__)
        },
        0,
        @"http://record_count.outgoning_schema#PurchaseOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Count_comparision_outgoning_schema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Count_comparision_outgoning_schema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Count_comparision_outgoning_schema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Count_comparision_outgoning_schema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
