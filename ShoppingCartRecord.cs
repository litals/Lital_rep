namespace Book_Store
{
	
//
//    Filename: ShoppingCartRecord.cs
//    Generated with CodeCharge 2.0.5
//    ASP.NET C#.ccp build 03/07/2002
//
//-------------------------------
//

    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Web;
    using System.Web.SessionState;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;

    /// <summary>
    ///    Summary description for ShoppingCartRecord.
    /// </summary>

	public partial class ShoppingCartRecord : System.Web.UI.Page
	
    { 



//ShoppingCartRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form ShoppingCartRecord variables and controls declarations
		
		// For each ShoppingCartRecord form hiddens for PK's,List of Values and Actions
		protected string ShoppingCartRecord_FormAction="ShoppingCart.aspx?";

	
	public ShoppingCartRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// ShoppingCartRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// ShoppingCartRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// ShoppingCartRecord Open Event begin
// ShoppingCartRecord Open Event end
		//===============================
		
		//===============================
// ShoppingCartRecord OpenAnyPage Event begin
// ShoppingCartRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// ShoppingCartRecord PageSecurity begin
		Utility.CheckSecurity(1);
		// ShoppingCartRecord PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_ShoppingCartRecord_order_id.Value = Utility.GetParam("order_id");Page_Show(sender, e);
		}
	}

	protected void Page_Unload(object sender, EventArgs e)
	{
		//
		// CODEGEN: This call is required by the ASP+ Windows Form Designer.
		//
		if(Utility!=null) Utility.DBClose();
	}

	protected void Page_Init(object sender, EventArgs e)
	{
		//
		// CODEGEN: This call is required by the ASP+ Windows Form Designer.
		//
		InitializeComponent();
		ShoppingCartRecord_update.ServerClick += new System.EventHandler (this.ShoppingCartRecord_Action);
		ShoppingCartRecord_delete.ServerClick += new System.EventHandler (this.ShoppingCartRecord_Action);
		ShoppingCartRecord_cancel.ServerClick += new System.EventHandler (this.ShoppingCartRecord_Action);
		
		
	}

        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }


        protected void Page_Show(object sender, EventArgs e)
        {
		ShoppingCartRecord_Show();
		
        }



// ShoppingCartRecord Show end

// End of Login form 






private bool ShoppingCartRecord_Validate(){
	bool result=true;
	ShoppingCartRecord_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("ShoppingCartRecord")){
			if(!Page.Validators[i].IsValid){
				ShoppingCartRecord_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	ShoppingCartRecord_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void ShoppingCartRecord_Show() {
	
	// ShoppingCartRecord Show begin
	
	bool ActionInsert=true;
	
	if (p_ShoppingCartRecord_order_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "order_id=" + CCUtility.ToSQL(p_ShoppingCartRecord_order_id.Value, FieldTypes.Number);
		
// ShoppingCartRecord Open Event begin
// ShoppingCartRecord Open Event end
		string sSQL = "select * from orders where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "ShoppingCartRecord") > 0) {
		row = ds.Tables[0].Rows[0];
				
	ShoppingCartRecord_order_id.Value = CCUtility.GetValue(row, "order_id");
		

	ShoppingCartRecord_member_id.Value = CCUtility.GetValue(row, "member_id");
		

	ShoppingCartRecord_item_id.Text =Server.HtmlEncode(	Utility.Dlookup("items", "name", "item_id=" + CCUtility.ToSQL(CCUtility.GetValue(row, "item_id"), FieldTypes.Number)).ToString());
		
		
		

	ShoppingCartRecord_quantity.Text = CCUtility.GetValue(row, "quantity");
	
		ActionInsert=false;
		
// ShoppingCartRecord ShowEdit Event begin
// ShoppingCartRecord ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		if(Session["UserID"]!=null)
		pValue = Session["UserID"].ToString();
		else
		pValue="";ShoppingCartRecord_member_id.Value = pValue;ShoppingCartRecord_delete.Visible=false;
	ShoppingCartRecord_update.Visible=false;
	
// ShoppingCartRecord ShowInsert Event begin
// ShoppingCartRecord ShowInsert Event end

}



// ShoppingCartRecord Open Event begin
// ShoppingCartRecord Open Event end

// ShoppingCartRecord Show Event begin
// ShoppingCartRecord Show Event end

	// ShoppingCartRecord Show end
	
// ShoppingCartRecord Close Event begin
// ShoppingCartRecord Close Event end

	}
	
	// ShoppingCartRecord Action begin
	

	void ShoppingCartRecord_BeforeSQLExecute(string SQL,String Action){
	  
// ShoppingCartRecord BeforeExecute Event begin
// ShoppingCartRecord BeforeExecute Event end

	}

	
	bool ShoppingCartRecord_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=ShoppingCartRecord_Validate();
		if(bResult){
		
	        if (p_ShoppingCartRecord_order_id.Value.Length > 0) {
        	    sWhere = sWhere + "order_id=" + CCUtility.ToSQL(p_ShoppingCartRecord_order_id.Value, FieldTypes.Number);
		    }
		
// ShoppingCartRecord Check Event begin
// ShoppingCartRecord Check Event end

		if (bResult){
		
		sSQL = "update orders set " +
		"[member_id]=" +CCUtility.ToSQL(Utility.GetParam("ShoppingCartRecord_member_id"),FieldTypes.Number)  +
		",[quantity]=" +CCUtility.ToSQL(Utility.GetParam("ShoppingCartRecord_quantity"),FieldTypes.Number) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// ShoppingCartRecord Update Event begin
// ShoppingCartRecord Update Event end
ShoppingCartRecord_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				ShoppingCartRecord_ValidationSummary.Text += e.Message;
				ShoppingCartRecord_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// ShoppingCartRecord AfterUpdate Event begin
// ShoppingCartRecord AfterUpdate Event end
		}
		}
		return bResult;
	}

bool ShoppingCartRecord_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_ShoppingCartRecord_order_id.Value.Length > 0) {
		sWhere += "order_id=" + CCUtility.ToSQL(p_ShoppingCartRecord_order_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from orders where " + sWhere;
	
// ShoppingCartRecord Delete Event begin
// ShoppingCartRecord Delete Event end
ShoppingCartRecord_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		ShoppingCartRecord_ValidationSummary.Text += e.Message;
		ShoppingCartRecord_ValidationSummary.Visible = true;
		return false;
	}
	
// ShoppingCartRecord AfterDelete Event begin
// ShoppingCartRecord AfterDelete Event end
	return true;
}

bool ShoppingCartRecord_cancel_Click(Object Src, EventArgs E) {
        
// ShoppingCartRecord BeforeCancel Event begin
// ShoppingCartRecord BeforeCancel Event end

	return true;
	}

void ShoppingCartRecord_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=ShoppingCartRecord_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=ShoppingCartRecord_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=ShoppingCartRecord_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(ShoppingCartRecord_FormAction+"");
}
// ShoppingCartRecord Action end



    }
}