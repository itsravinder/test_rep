
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using WcfService_application;

public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        if (composite.BoolValue)
        {
            composite.StringValue += "Suffix";
        }
        return composite;
    }
    //This function is used to get Userid from database.
    public DataSet GetUserId()
    {
        SqlConnection con = new SqlConnection("Data Source = Puru-SQLSERVER2005; Initial Catalog = Puru; User ID = sa; Password = wintellect;");
        string cmd = "select UserID from Registration";
        SqlDataAdapter da = new SqlDataAdapter(cmd, con);
        con.Open();
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        return ds;
    }
}