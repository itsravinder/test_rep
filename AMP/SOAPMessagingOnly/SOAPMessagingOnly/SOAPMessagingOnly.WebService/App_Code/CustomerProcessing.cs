using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Web.Services.Description;
using System.Xml.Serialization;

[WebService(Namespace = "http://www.digitaldeposit.net/biztalk/samples")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class CustomerProcessing : System.Web.Services.WebService
{
    public CustomerProcessing () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public ProductInfo GetProductInfo(
        [XmlElement(ElementName = "CustomerInfo", Namespace = "http://www.digitaldeposit.net/biztalk/samples/Customer",IsNullable = false)]
        CustomerInfo customer
    ) 
    {
        ProductInfo prod = new ProductInfo();
        prod.ProductID = customer.CustomerID + "007";

        return prod;
    }

    [WebMethod]
    public ProductInfo GetProductInfoByAccountNumber(CustomerInfo customer, int accountNumber)
    {
        ProductInfo prod = new ProductInfo();
        prod.ProductID = customer.CustomerID + "007";

        return prod;
    }
}
