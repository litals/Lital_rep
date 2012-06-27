namespace Book_Store
{
	
//
//    Filename: OrdersRecord.cs
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
    ///    Summary description for OrdersRecord.
    /// </summary>

	public partial class OrdersRecord : System.Web.UI.Page
	
    { 



//OrdersRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Orders variables and controls declarations
		
		// For each Orders form hiddens for PK's,List of Values and Actions
		protected string Orders_FormAction="OrdersGrid.aspx?";

	
	public OrdersRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// OrdersRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// OrdersRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// OrdersRecord Open Event begin
// OrdersRecord Open Event end
		//===============================
		
		//===============================
// OrdersRecord OpenAnyPage Event begin
// OrdersRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// OrdersRecord PageSecurity begin
		Utility.CheckSecurity(2);
		// OrdersRecord PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Orders_order_id.Value = Utility.GetParam("order_id");Page_Show(sender, e);
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
		Orders_insert.ServerClick += new System.EventHandler (this.Orders_Action);
		Orders_update.ServerClick += new System.EventHandler (this.Orders_Action);
		Orders_delete.ServerClick += new System.EventHandler (this.Orders_Action);
		Orders_cancel.ServerClick += new System.EventHandler (this.Orders_Action);
		
		
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
		Orders_Show();
		
        }



// OrdersRecord Show end

// End of Login form 






private bool Orders_Validate(){
	bool result=true;
	Orders_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Orders")){
			if(!Page.Validators[i].IsValid){
				Orders_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Orders_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Orders_Show() {
	
	// Orders Show begin
	Utility.buildListBox(Orders_member_id.Items,"select member_id,member_login from members order by 2","member_id","member_login",null,"");
Utility.buildListBox(Orders_item_id.Items,"select item_id,name from items order by 2","item_id","name",null,"");

	bool ActionInsert=true;
	
	if (p_Orders_order_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "order_id=" + CCUtility.ToSQL(p_Orders_order_id.Value, FieldTypes.Number);
		
// Orders Open Event begin
// Orders Open Event end
		string sSQL = "select * from orders where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Orders") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Orders_order_id.Text =Server.HtmlEncode(CCUtility.GetValue(row, "order_id").ToString());
		
		
		

	
		{string s;
		s=CCUtility.GetValue(row, "member_id");
		
		try {Orders_member_id.SelectedIndex=Orders_member_id.Items.IndexOf(Orders_member_id.Items.FindByValue(s));
		}catch{}}
		

	
		{string s;
		s=CCUtility.GetValue(row, "item_id");
		
		try {Orders_item_id.SelectedIndex=Orders_item_id.Items.IndexOf(Orders_item_id.Items.FindByValue(s));
		}catch{}}
		

	Orders_quantity.Text = CCUtility.GetValue(row, "quantity");
	Orders_insert.Visible=false;
		ActionInsert=false;
		
// Orders ShowEdit Event begin
// Orders ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("order_id");Orders_order_id.Text = pValue;
		pValue = Utility.GetParam("member_id");
		try {Orders_member_id.SelectedIndex=Orders_member_id.Items.IndexOf(Orders_member_id.Items.FindByValue(pValue));
		}catch{}
	
		pValue = Utility.GetParam("item_id");
		try {Orders_item_id.SelectedIndex=Orders_item_id.Items.IndexOf(Orders_item_id.Items.FindByValue(pValue));
		}catch{}
	Orders_delete.Visible=false;
	Orders_update.Visible=false;
	
// Orders ShowInsert Event begin
// Orders ShowInsert Event end

}



// Orders Open Event begin
// Orders Open Event end

// Orders Show Event begin
// Orders Show Event end

	// Orders Show end
	
// Orders Close Event begin
// Orders Close Event end

	}
	
	// Orders Action begin
	
bool Orders_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=Orders_Validate();
		
// Orders Check Event begin
// Orders Check Event end

		string p2_member_id=CCUtility.ToSQL(Utility.GetParam("Orders_member_id"), FieldTypes.Number) ;
		string p2_item_id=CCUtility.ToSQL(Utility.GetParam("Orders_item_id"), FieldTypes.Number) ;
		string p2_quantity=CCUtility.ToSQL(Utility.GetParam("Orders_quantity"), FieldTypes.Number) ;
// Orders Insert Event begin
// Orders Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into orders (" +
				"member_id," +
				"item_id," +
				"quantity)" +
				" values (" +
				p2_member_id + "," + 
				p2_item_id + "," + 
				p2_quantity + ")";
			}
			Orders_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Orders_ValidationSummary.Text += e.Message;
				Orders_ValidationSummary.Visible = true;
				return false;
			}
			
// Orders AfterInsert Event begin
// Orders AfterInsert Event end
		}
		return bResult;
	}


	void Orders_BeforeSQLExecute(string SQL,String Action){
	  
// Orders BeforeExecute Event begin
// Orders BeforeExecute Event end

	}

	
	bool Orders_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Orders_Validate();
		if(bResult){
		
	        if (p_Orders_order_id.Value.Length > 0) {
        	    sWhere = sWhere + "order_id=" + CCUtility.ToSQL(p_Orders_order_id.Value, FieldTypes.Number);
		    }
		
// Orders Check Event begin
// Orders Check Event end

		if (bResult){
		
		sSQL = "update orders set " +
		"[member_id]=" +CCUtility.ToSQL(Utility.GetParam("Orders_member_id"),FieldTypes.Number)  +
		",[item_id]=" +CCUtility.ToSQL(Utility.GetParam("Orders_item_id"),FieldTypes.Number)  +
		",[quantity]=" +CCUtility.ToSQL(Utility.GetParam("Orders_quantity"),FieldTypes.Number) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Orders Update Event begin
// Orders Update Event end
Orders_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Orders_ValidationSummary.Text += e.Message;
				Orders_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Orders AfterUpdate Event begin
// Orders AfterUpdate Event end
		}
		}
		return bResult;
	}

bool Orders_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_Orders_order_id.Value.Length > 0) {
		sWhere += "order_id=" + CCUtility.ToSQL(p_Orders_order_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from orders where " + sWhere;
	
// Orders Delete Event begin
// Orders Delete Event end
Orders_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		Orders_ValidationSummary.Text += e.Message;
		Orders_ValidationSummary.Visible = true;
		return false;
	}
	
// Orders AfterDelete Event begin
// Orders AfterDelete Event end
	return true;
}

bool Orders_cancel_Click(Object Src, EventArgs E) {
        
// Orders BeforeCancel Event begin
// Orders BeforeCancel Event end

	return true;
	}

void Orders_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=Orders_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Orders_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=Orders_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=Orders_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(Orders_FormAction+"item_id=" + Server.UrlEncode(Utility.GetParam("item_id")) + "&member_id=" + Server.UrlEncode(Utility.GetParam("member_id")) + "&");
}
// Orders Action end



    }
}