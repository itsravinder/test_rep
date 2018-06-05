
#pragma warning disable 162

namespace Try_email
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Try_email.__messagetype_Try_email_Product_cat)
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
            typeof(__messagetype_Try_email_Product_cat),
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
            typeof(Try_email.__messagetype_Try_email_Product_cat)
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
            typeof(__messagetype_Try_email_Product_cat),
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
    //#line 381 "C:\AMP\Email\try_email\Try_email\Try.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Try_email.PortType_1),
            typeof(Try_email.PortType_2)
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
    sealed internal class Try : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Try));
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

        static Try()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2)
            };

            _Locks = 0;
            _rootContext = new __Try_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Try(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Try", tracker)
        {
            ConstructorHelper();
        }

        public Try(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Try")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>70cf3346-b218-413f-96f5-06b0a6de63f0</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>6e8365c3-841a-48c6-83a0-4b976d5ce6aa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>dc96c638-3cba-4804-8c8e-51d0fe1100ce</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>c2335bfd-3185-4e6c-84cc-fa3bbca07d00</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>8d8adc47-7db4-4d62-86ee-043f70d01bbc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>a8fdca90-2301-4a09-8498-88e364694a67</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c9c16340-2c73-420f-bc60-07722d269e4d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>0c012440-6511-4ccc-9abf-3d76b3bac872</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a8ec5971-32cb-4c24-9d0f-eb84e9a199bc</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>b9ba78ab-1568-44ea-8f4a-501823f539c3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>a877bc3d-465b-41eb-a169-8e4d9d85b97f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b0e86922-c38d-4abb-af8f-303a17699b24</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5721b974-447c-44de-bf4f-3945d6588f5d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e6a02854-b9ec-4122-abae-564edc7dcbfb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>57a0d94b-9864-46d1-bb43-6dff4bc5da97</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>ce7c7b5e-d3a5-44c5-949f-ba2e34e998c6</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>1d53ce96-69c5-4b69-bbc5-f5b8961aba88</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7748ad8f-edb6-4e63-92f6-0b5d7993cdba</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>710a5fd5-3366-4cfa-aff9-0ad38a2f95d1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e44c9619-5591-4c4f-b317-9fe7fe5207d6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d711a700-8236-472b-95ac-c9d045fc390e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c5a986ea-3083-49b1-b4ae-ae481d9f2323</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6fe47b4b-77e7-4078-92ea-ee91b47e5db3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ExecShape</shapeType>      <ShapeID>00760bb9-4b98-4759-8544-1b8e442c29a7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>StartOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>7d95c3f9-8d12-48b1-ad95-f743ce6564f5</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailHostMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>af00cb52-f9a0-40fa-b12f-fe5a96b4f524</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailToMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b93b80fe-9798-47af-889d-4edb08c43104</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>46cb34e2-c945-40b7-87c5-985d0073d0de</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailSubjectMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c814c826-603a-42fb-a1ef-00d66f31dff5</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailFromMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Try'</ActionName><IsAtomic>0</IsAtomic><Line>381</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>404</Line><Position>22</Position><ShapeID>'6e8365c3-841a-48c6-83a0-4b976d5ce6aa'</ShapeID>
<Messages>
	<MsgInfo><name>input</name><part>part</part><schema>Try_email.Product_cat</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>412</Line><Position>17</Position><ShapeID>'dc96c638-3cba-4804-8c8e-51d0fe1100ce'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>414</Line><Position>13</Position><ShapeID>'c2335bfd-3185-4e6c-84cc-fa3bbca07d00'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>419</Line><Position>21</Position><ShapeID>'8d8adc47-7db4-4d62-86ee-043f70d01bbc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>422</Line><Position>25</Position><ShapeID>'c9c16340-2c73-420f-bc60-07722d269e4d'</ShapeID>
<Messages>
	<MsgInfo><name>dummy</name><part>part</part><schema>Try_email.Product_cat</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>428</Line><Position>25</Position><ShapeID>'b9ba78ab-1568-44ea-8f4a-501823f539c3'</ShapeID>
<Messages>
	<MsgInfo><name>dummy_data</name><part>part</part><schema>Try_email.Product_cat</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>dummy</name><part>part</part><schema>Try_email.Product_cat</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>434</Line><Position>25</Position><ShapeID>'57a0d94b-9864-46d1-bb43-6dff4bc5da97'</ShapeID>
<Messages>
	<MsgInfo><name>dummy_data</name><part>part</part><schema>Try_email.Product_cat</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>439</Line><Position>25</Position><ShapeID>'1d53ce96-69c5-4b69-bbc5-f5b8961aba88'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>469</Line><Position>59</Position><ShapeID>'00760bb9-4b98-4759-8544-1b8e442c29a7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='7b4f562f-4a31-41ce-8f23-cbec6d7c09dd' LowerBound='1.1' HigherBound='114.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Try_email' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='179a86aa-23f0-4697-b11e-eb71431b99e7' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='60f65066-144d-41aa-aaf3-bc296517a34d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='462cde30-b0e0-43af-82c9-f5b10e59ae46' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.24'>
                    <om:Property Name='Ref' Value='Try_email.Product_cat' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d4595689-b22d-402f-bd57-b90c51633974' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='86610eb1-107b-415a-99bd-e515828ae8a3' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0c664d7b-e2dd-45d7-b97d-127bb1b60405' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.24'>
                    <om:Property Name='Ref' Value='Try_email.Product_cat' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='b65d1a00-8eb6-4854-8d67-a95b0fd440e9' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='113.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Try' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='70b06191-ca94-42a6-b22b-2eccbf50386e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Cat' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='24894b71-99b2-465f-9a7d-00e04a4e3d38' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strEmail' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0670c35a-281f-4832-a4ef-cf895b81d5e3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strSubject' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f14750a6-3e1c-413a-9e94-09bd2451c610' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strHost' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3dd0bd68-f919-4db0-a6ba-e0a9ea5a5c19' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strFrom' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='deba8084-518d-4e6b-9b8d-e4699feb897c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strEmailTo' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='bf436ed6-e6ce-4ab0-bd49-a8237cf2fe29' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Try_email.Product_cat' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='input' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='800d2ce0-8f53-4081-af69-0d258c6948bd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Try_email.Product_cat' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dummy' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4d48e5d3-5dfa-411e-b20e-58006389b92e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Try_email.Product_cat' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dummy_data' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d76d1e7f-29a4-4bc1-8989-ec5079e6c2a7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailBodyMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='992702e2-ea53-4bc6-9b57-564d856b99af' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailHostMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='21d18516-f8ed-4221-9ebc-6c6e9550f72b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailFromMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='57042315-afe7-4147-8b9d-5fff6d85d0ea' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailToMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cbcd9589-e2ce-40f7-911d-888d22a2aafa' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailSubjectMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='70cf3346-b218-413f-96f5-06b0a6de63f0' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='6e8365c3-841a-48c6-83a0-4b976d5ce6aa' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='49.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='input' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='dc96c638-3cba-4804-8c8e-51d0fe1100ce' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='51.1'>
                    <om:Property Name='Expression' Value='Cat = input.Type;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='c2335bfd-3185-4e6c-84cc-fa3bbca07d00' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='111.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Decision' OID='8d8adc47-7db4-4d62-86ee-043f70d01bbc' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='109.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='DecisionBranch' OID='a8fdca90-2301-4a09-8498-88e364694a67' ParentLink='ReallyComplexStatement_Branch' LowerBound='57.21' HigherBound='74.1'>
                            <om:Property Name='Expression' Value='Cat == &quot;phone&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='c9c16340-2c73-420f-bc60-07722d269e4d' ParentLink='ComplexStatement_Statement' LowerBound='59.1' HigherBound='65.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='0c012440-6511-4ccc-9abf-3d76b3bac872' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='64.1'>
                                    <om:Property Name='Expression' Value='dummy = input;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='a8ec5971-32cb-4c24-9d0f-eb84e9a199bc' ParentLink='Construct_MessageRef' LowerBound='60.35' HigherBound='60.40'>
                                    <om:Property Name='Ref' Value='dummy' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='b9ba78ab-1568-44ea-8f4a-501823f539c3' ParentLink='ComplexStatement_Statement' LowerBound='65.1' HigherBound='71.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Transform' OID='a877bc3d-465b-41eb-a169-8e4d9d85b97f' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='70.1'>
                                    <om:Property Name='ClassName' Value='Try_email.Transform_1' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='b0e86922-c38d-4abb-af8f-303a17699b24' ParentLink='Transform_InputMessagePartRef' LowerBound='69.77' HigherBound='69.82'>
                                        <om:Property Name='MessageRef' Value='dummy' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='5721b974-447c-44de-bf4f-3945d6588f5d' ParentLink='Transform_OutputMessagePartRef' LowerBound='69.40' HigherBound='69.50'>
                                        <om:Property Name='MessageRef' Value='dummy_data' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='e6a02854-b9ec-4122-abae-564edc7dcbfb' ParentLink='Construct_MessageRef' LowerBound='66.35' HigherBound='66.45'>
                                    <om:Property Name='Ref' Value='dummy_data' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='57a0d94b-9864-46d1-bb43-6dff4bc5da97' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                                <om:Property Name='PortName' Value='Port_2' />
                                <om:Property Name='MessageName' Value='dummy_data' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='ce7c7b5e-d3a5-44c5-949f-ba2e34e998c6' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='1d53ce96-69c5-4b69-bbc5-f5b8961aba88' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='106.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_3' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='7748ad8f-edb6-4e63-92f6-0b5d7993cdba' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='105.1'>
                                    <om:Property Name='Expression' Value='EmailBodyMsg= System.String.Empty;&#xD;&#xA;EmailFromMsg = System.String.Empty;&#xD;&#xA;EmailHostMsg = System.String.Empty;&#xD;&#xA;EmailSubjectMsg = System.String.Empty;&#xD;&#xA;EmailToMsg = System.String.Empty;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Getting data form SSO&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;strEmail = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailBody&quot;);&#xD;&#xA;strSubject = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_subject&quot;);&#xD;&#xA;strHost = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailHost&quot;);&#xD;&#xA;strFrom = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailFrom&quot;);&#xD;&#xA;strEmailTo = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailTo&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Assign_data&#xD;&#xA;                           &#xD;&#xA;//Assign Parameters to Messages                                &#xD;&#xA;EmailBodyMsg=strEmail;&#xD;&#xA;EmailSubjectMsg = strSubject;&#xD;&#xA;EmailHostMsg = strHost;&#xD;&#xA;EmailFromMsg = strFrom;&#xD;&#xA;EmailToMsg = strEmailTo;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_2' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='710a5fd5-3366-4cfa-aff9-0ad38a2f95d1' ParentLink='Construct_MessageRef' LowerBound='77.35' HigherBound='77.47'>
                                    <om:Property Name='Ref' Value='EmailBodyMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='e44c9619-5591-4c4f-b317-9fe7fe5207d6' ParentLink='Construct_MessageRef' LowerBound='77.49' HigherBound='77.61'>
                                    <om:Property Name='Ref' Value='EmailFromMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='d711a700-8236-472b-95ac-c9d045fc390e' ParentLink='Construct_MessageRef' LowerBound='77.63' HigherBound='77.75'>
                                    <om:Property Name='Ref' Value='EmailHostMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='c5a986ea-3083-49b1-b4ae-ae481d9f2323' ParentLink='Construct_MessageRef' LowerBound='77.77' HigherBound='77.92'>
                                    <om:Property Name='Ref' Value='EmailSubjectMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='6fe47b4b-77e7-4078-92ea-ee91b47e5db3' ParentLink='Construct_MessageRef' LowerBound='77.94' HigherBound='77.104'>
                                    <om:Property Name='Ref' Value='EmailToMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Exec' OID='00760bb9-4b98-4759-8544-1b8e442c29a7' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='108.1'>
                                <om:Property Name='Invokee' Value='Email_Notification.Email_Not' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='StartOrchestration_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Parameter' OID='7d95c3f9-8d12-48b1-ad95-f743ce6564f5' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailHostMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='af00cb52-f9a0-40fa-b12f-fe5a96b4f524' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailToMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='b93b80fe-9798-47af-889d-4edb08c43104' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailBodyMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='46cb34e2-c945-40b7-87c5-985d0073d0de' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailSubjectMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='c814c826-603a-42fb-a1ef-00d66f31dff5' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailFromMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='21218a0b-603c-4cef-ac66-a083425ec647' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Try_email.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='08c7e843-614a-4ae2-a489-1b950d5a6b64' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f40450c5-f2f2-4e31-b8f5-2cf486ae9911' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Try_email.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_2' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='cfa50621-0527-4d83-b85d-df115399497f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Try_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Try_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Try")
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
                Try __svc__ = (Try)_service;
                __Try_root_0 __ctx0__ = (__Try_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                if (__svc__.Port_2 != null)
                {
                    __svc__.Port_2.Close(this, null);
                    __svc__.Port_2 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __Try_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Try_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Try")
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
                Try __svc__ = (Try)_service;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("input")]
            public __messagetype_Try_email_Product_cat __input;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dummy")]
            public __messagetype_Try_email_Product_cat __dummy;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dummy_data")]
            public __messagetype_Try_email_Product_cat __dummy_data;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailBodyMsg")]
            public __messagetype_System_String __EmailBodyMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailHostMsg")]
            public __messagetype_System_String __EmailHostMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailFromMsg")]
            public __messagetype_System_String __EmailFromMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailToMsg")]
            public __messagetype_System_String __EmailToMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailSubjectMsg")]
            public __messagetype_System_String __EmailSubjectMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Cat")]
            internal System.String __Cat;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strEmail")]
            internal System.String __strEmail;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strSubject")]
            internal System.String __strSubject;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strHost")]
            internal System.String __strHost;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strFrom")]
            internal System.String __strFrom;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strEmailTo")]
            internal System.String __strEmailTo;
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
                Finally();
                return false;
            }

            public override void Finally()
            {
                Try __svc__ = (Try)_service;
                __Try_1 __ctx1__ = (__Try_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__input);
                    __ctx1__.__input = null;
                }
                if (__ctx1__ != null && __ctx1__.__dummy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__dummy);
                    __ctx1__.__dummy = null;
                }
                if (__ctx1__ != null && __ctx1__.__dummy_data != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__dummy_data);
                    __ctx1__.__dummy_data = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailBodyMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailHostMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailFromMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailToMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailToMsg);
                    __ctx1__.__EmailToMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailSubjectMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Cat = null;
                if (__ctx1__ != null)
                    __ctx1__.__strEmail = null;
                if (__ctx1__ != null)
                    __ctx1__.__strSubject = null;
                if (__ctx1__ != null)
                    __ctx1__.__strHost = null;
                if (__ctx1__ != null)
                    __ctx1__.__strFrom = null;
                if (__ctx1__ != null)
                    __ctx1__.__strEmailTo = null;
                base.Finally();
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
                                               typeof(Try).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Try), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(Try).GetField("Port_2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Try), "Port_2"),
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
                    typeof(Email_Notification.Email_Not)                    
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "6e8365c3-841a-48c6-83a0-4b976d5ce6aa", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "6e8365c3-841a-48c6-83a0-4b976d5ce6aa", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "dc96c638-3cba-4804-8c8e-51d0fe1100ce", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "dc96c638-3cba-4804-8c8e-51d0fe1100ce", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c2335bfd-3185-4e6c-84cc-fa3bbca07d00", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "8d8adc47-7db4-4d62-86ee-043f70d01bbc", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "c9c16340-2c73-420f-bc60-07722d269e4d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "c9c16340-2c73-420f-bc60-07722d269e4d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "b9ba78ab-1568-44ea-8f4a-501823f539c3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "b9ba78ab-1568-44ea-8f4a-501823f539c3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "57a0d94b-9864-46d1-bb43-6dff4bc5da97", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "57a0d94b-9864-46d1-bb43-6dff4bc5da97", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "1d53ce96-69c5-4b69-bbc5-f5b8961aba88", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "1d53ce96-69c5-4b69-bbc5-f5b8961aba88", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00760bb9-4b98-4759-8544-1b8e442c29a7", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00760bb9-4b98-4759-8544-1b8e442c29a7", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "8d8adc47-7db4-4d62-86ee-043f70d01bbc", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "c2335bfd-3185-4e6c-84cc-fa3bbca07d00", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Exec),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Exec),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,4,4,5,6,6,6,20,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 8,8,8,9,9,10,11,11,12,13,13,13,14,8,15,15,16,17,17,18,18,19,19,19,19,};

        public static int[][] __progressLocations = new int[3] [] {__progressLocation0,__progressLocation1,__progressLocation2};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Try_root_0 __ctx0__ = (__Try_root_0)_stateMgrs[0];
            __Try_1 __ctx1__ = (__Try_1)_stateMgrs[1];

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
                __ctx1__ = new __Try_1(this);
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
            __Try_root_0 __ctx0__ = (__Try_root_0)_stateMgrs[0];
            __Try_1 __ctx1__ = (__Try_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Cat = default(System.String);
                __ctx1__.__strEmail = default(System.String);
                __ctx1__.__strSubject = default(System.String);
                __ctx1__.__strHost = default(System.String);
                __ctx1__.__strFrom = default(System.String);
                __ctx1__.__strEmailTo = default(System.String);
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
                if (__ctx1__.__input != null)
                    __ctx1__.UnrefMessage(__ctx1__.__input);
                __ctx1__.__input = new __messagetype_Try_email_Product_cat("input", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__input);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__input, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__input);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__Cat = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__strEmail = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__strSubject = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__strHost = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__strFrom = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__strEmailTo = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__Cat = (System.String)__ctx1__.__input.part.GetDistinguishedField("Type");
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[11],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 21;
            case 21:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Try_root_0 __ctx0__ = (__Try_root_0)_stateMgrs[0];
            __Try_1 __ctx1__ = (__Try_1)_stateMgrs[1];
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
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __condition__ = __ctx1__.__Cat == "phone";
                if (__ctx1__ != null)
                    __ctx1__.__Cat = null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 14;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                {
                    __messagetype_Try_email_Product_cat __dummy = new __messagetype_Try_email_Product_cat("dummy", __ctx1__);

                    __dummy.CopyFrom(__ctx1__.__input);

                    if (__ctx1__.__dummy != null)
                        __ctx1__.UnrefMessage(__ctx1__.__dummy);
                    __ctx1__.__dummy = __dummy;
                    __ctx1__.RefMessage(__ctx1__.__dummy);
                }
                __ctx1__.__dummy.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__dummy);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_Try_email_Product_cat __dummy_data = new __messagetype_Try_email_Product_cat("dummy_data", __ctx1__);

                    ApplyTransform(typeof(Try_email.Transform_1), new object[] {__dummy_data.part}, new object[] {__ctx1__.__dummy.part});

                    if (__ctx1__.__dummy_data != null)
                        __ctx1__.UnrefMessage(__ctx1__.__dummy_data);
                    __ctx1__.__dummy_data = __dummy_data;
                    __ctx1__.RefMessage(__ctx1__.__dummy_data);
                }
                __ctx1__.__dummy_data.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__dummy_data);
                    __edata.Messages.Add(__ctx1__.__dummy);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__dummy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__dummy);
                    __ctx1__.__dummy = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_2.SendMessage(0, __ctx1__.__dummy_data, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__dummy_data);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__dummy_data != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__dummy_data);
                    __ctx1__.__dummy_data = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                {
                    __messagetype_System_String __EmailBodyMsg = new __messagetype_System_String("EmailBodyMsg", __ctx1__);
                    __messagetype_System_String __EmailFromMsg = new __messagetype_System_String("EmailFromMsg", __ctx1__);
                    __messagetype_System_String __EmailHostMsg = new __messagetype_System_String("EmailHostMsg", __ctx1__);
                    __messagetype_System_String __EmailSubjectMsg = new __messagetype_System_String("EmailSubjectMsg", __ctx1__);
                    __messagetype_System_String __EmailToMsg = new __messagetype_System_String("EmailToMsg", __ctx1__);

                    __EmailBodyMsg.part.LoadFrom(System.String.Empty);
                    __EmailFromMsg.part.LoadFrom(System.String.Empty);
                    __EmailHostMsg.part.LoadFrom(System.String.Empty);
                    __EmailSubjectMsg.part.LoadFrom(System.String.Empty);
                    __EmailToMsg.part.LoadFrom(System.String.Empty);
                    __ctx1__.__strEmail = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailBody");
                    __ctx1__.__strSubject = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_subject");
                    __ctx1__.__strHost = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailHost");
                    __ctx1__.__strFrom = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailFrom");
                    __ctx1__.__strEmailTo = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailTo");
                    __EmailBodyMsg.part.LoadFrom(__ctx1__.__strEmail);
                    __EmailSubjectMsg.part.LoadFrom(__ctx1__.__strSubject);
                    __EmailHostMsg.part.LoadFrom(__ctx1__.__strHost);
                    __EmailFromMsg.part.LoadFrom(__ctx1__.__strFrom);
                    __EmailToMsg.part.LoadFrom(__ctx1__.__strEmailTo);

                    if (__ctx1__.__EmailBodyMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = __EmailBodyMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailBodyMsg);
                    if (__ctx1__.__EmailFromMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = __EmailFromMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailFromMsg);
                    if (__ctx1__.__EmailHostMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = __EmailHostMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailHostMsg);
                    if (__ctx1__.__EmailSubjectMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = __EmailSubjectMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailSubjectMsg);
                    if (__ctx1__.__EmailToMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailToMsg);
                    __ctx1__.__EmailToMsg = __EmailToMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailToMsg);
                }
                __ctx1__.__EmailBodyMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailFromMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailHostMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailSubjectMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailToMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailFromMsg);
                    __edata.Messages.Add(__ctx1__.__EmailHostMsg);
                    __edata.Messages.Add(__ctx1__.__EmailSubjectMsg);
                    __edata.Messages.Add(__ctx1__.__EmailToMsg);
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ExecService(__ctx2__, typeof(Email_Notification.Email_Not), new object[] {__ctx1__.__EmailHostMsg, __ctx1__.__EmailToMsg, __ctx1__.__EmailBodyMsg, __ctx1__.__EmailSubjectMsg, __ctx1__.__EmailFromMsg});
                goto case 20;
            case 20:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Exec);
                    __edata.Messages.Add(__ctx1__.__EmailHostMsg);
                    __edata.Messages.Add(__ctx1__.__EmailToMsg);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailSubjectMsg);
                    __edata.Messages.Add(__ctx1__.__EmailFromMsg);
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__EmailSubjectMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailToMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailToMsg);
                    __ctx1__.__EmailToMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailFromMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailHostMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailBodyMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__strEmailTo = null;
                if (__ctx1__ != null)
                    __ctx1__.__strFrom = null;
                if (__ctx1__ != null)
                    __ctx1__.__strHost = null;
                if (__ctx1__ != null)
                    __ctx1__.__strSubject = null;
                if (__ctx1__ != null)
                    __ctx1__.__strEmail = null;
                if (__ctx1__ != null && __ctx1__.__input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__input);
                    __ctx1__.__input = null;
                }
                if (Port_2 != null)
                {
                    Port_2.Close(__ctx2__, __seg__);
                    Port_2 = null;
                }
                Tracker.FireEvent(__eventLocations[19],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 24;
            case 24:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Try_email_Product_cat__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Try_email.Product_cat _schema = new Try_email.Product_cat();

        public __Try_email_Product_cat__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Try_email.Product_cat",
        new System.Type[]{
            typeof(Try_email.Product_cat)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Try_email_Product_cat__)
        },
        0,
        @"http://Try_email.Product_cat#Product"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Try_email_Product_cat : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Try_email_Product_cat__ part;

        private void __CreatePartWrappers()
        {
            part = new __Try_email_Product_cat__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Try_email_Product_cat(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_4.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.String' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='string' nillable='true' type='xs:string' />
</xs:schema>",
        @"string",
        null,
        typeof(System.String),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_String__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_String__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.String); } }
        public System.String TypedValue { get { return (System.String) this.RetrieveAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        public System.String WriteableTypedValue { get { return (System.String) this.RetrieveForWriteAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.String); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.String",
        new System.Type[]{
            typeof(System.String)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__System_String__)
        },
        0,
        @"string"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_String : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_String__ part;

        private void __CreatePartWrappers()
        {
            part = new __System_String__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_String(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
