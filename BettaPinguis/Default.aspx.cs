using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;


namespace BettaPinguis
{
    public partial class Default : System.Web.UI.Page
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "wVUUvMVKPct3GfwHbV4noVdfDpmnVm6XPkpxfTXt",
            BasePath = "https://bettapinguis-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);
                FirebaseResponse res = client.Get("/");
                Dictionary<string, Ships> data = JsonConvert.DeserializeObject<Dictionary<string, Ships>>(res.Body.ToString());
                WriteData(data);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error message:" + ex);
            }
        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get("/");
            Dictionary<string, Ships> data = JsonConvert.DeserializeObject<Dictionary<string, Ships>>(res.Body.ToString());
            WriteData(data);
        }

        void WriteData(Dictionary<string, Ships> record)
        {
            ltrList.Text = "";
            foreach (var item in record)
            {
                ltrList.Text += "<tr>"+
                        "<td>"+ item.Value.captain +"</td>"+
                        "<td>"+ item.Key +"</td>"+
                        "<td>"+ item.Value.shipName + "</td>"+
                        "<td>"+ item.Value.location + "</td>"+
                        "<td>"+ item.Value.depth + "</td>"+
                        "<td>"+ item.Value.temperature + "</td>"+
                        "</tr>";
            }
        }
    }
}