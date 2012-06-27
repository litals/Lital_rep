namespace Book_Store
{
	
//
//    Filename: ShoppingCart.cs
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
    ///    Summary description for ShoppingCart.
    /// </summary>

	public partial class ShoppingCart : System.Web.UI.Page
	
    { 



//ShoppingCart CustomIncludes begin
		protected CCUtility Utility;
		
		//Grid form Items variables and controls declarations
		protected string Items_sSQL;
		protected string Items_sCountSQL;
		protected int Items_CountPage;
		
		protected int i_Items_curpage=1;	
	
		//Grid form Total variables and controls declarations
		protected string Total_sSQL;
		protected string Total_sCountSQL;
		protected int Total_CountPage;
		
		protected int i_Total_curpage=1;	
	
		//Record form Member variables and controls declarations
		
		// For each Items form hiddens for PK's,List of Values and Actions
		protected string Items_FormAction=".aspx?";
		// For each Total form hiddens for PK's,List of Values and Actions
		protected string Total_FormAction="Default.aspx?";
		
		// For each Member form hiddens for PK's,List of Values and Actions
		protected string Member_FormAction="AdminMenu.aspx?";

	
	public ShoppingCart()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// ShoppingCart CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// ShoppingCart Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// ShoppingCart Open Event begin
// ShoppingCart Open Event end
		//===============================
		
		//===============================
// ShoppingCart OpenAnyPage Event begin
// ShoppingCart OpenAnyPage Event end
		//===============================
		//
		//===============================
		// ShoppingCart PageSecurity begin
		Utility.CheckSecurity(1);
		// ShoppingCart PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Items_order_id.Value = Utility.GetParam("order_id");
			if(Session["UserID"]!=null)
			p_Member_member_id.Value = Session["UserID"].ToString();
			else
			p_Member_member_id.Value="";
			Page_Show(sender, e);
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
		Items_Bind();
		Total_Bind();
		Member_Show();
		
        }



// ShoppingCart Show end

// End of Login form 








const int Items_PAGENUM = 20;




public void Items_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Items Show Event begin
// Items Show Event end
}


ICollection Items_CreateDataSource() {

       
       // Items Show begin
	Items_sSQL = "";
	Items_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool bReq = true;
	bool HasParam = false;
	
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("UserID")){
	object Temp=Session["UserID"];
	string temp;
	if(Temp==null)temp=""; else temp=Temp.ToString();
	
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("UserID",temp);}
	
	  if (Params["UserID"].Length>0) {
	    HasParam = true;
	    sWhere +="[member_id]=" + Params["UserID"];
	  }else{bReq = false;
	  }

	
	  if(HasParam)
	    sWhere = " AND (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Items_sSQL = "SELECT order_id, name, price, quantity, member_id, quantity*price as sub_total FROM items, orders WHERE orders.item_id=items.item_id";
  sOrder = " ORDER BY order_id";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Items_sSQL = Items_sSQL + sWhere + sOrder;
	//-------------------------------
	
	if(!bReq){
		Items_no_records.Visible = true;
		
		return null;
	}
	OleDbDataAdapter command = new OleDbDataAdapter(Items_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, Items_PAGENUM, "Items");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Items_no_records.Visible = true;
			}
		else
			{Items_no_records.Visible = false;
			}
		
		
		return Source;
		// Items Show end
		
	}
	

	void Items_Bind() {
		Items_Repeater.DataSource = Items_CreateDataSource();
		Items_Repeater.DataBind();
		
	}


// End of Login form 








const int Total_PAGENUM = 20;




public void Total_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Total Show Event begin
// Total Show Event end
}


ICollection Total_CreateDataSource() {

       
       // Total Show begin
	Total_sSQL = "";
	Total_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool bReq = true;
	bool HasParam = false;
	
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("UserID")){
	object Temp=Session["UserID"];
	string temp;
	if(Temp==null)temp=""; else temp=Temp.ToString();
	
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("UserID",temp);}
	
	  if (Params["UserID"].Length>0) {
	    HasParam = true;
	    sWhere +="[member_id]=" + Params["UserID"];
	  }else{bReq = false;
	  }

	
	  if(HasParam)
	    sWhere = " AND (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Total_sSQL = "SELECT member_id, sum(quantity*price) as sub_total FROM items, orders WHERE orders.item_id=items.item_id";
  sOrder = " GROUP BY member_id";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Total_sSQL = Total_sSQL + sWhere + sOrder;
	//-------------------------------
	
	if(!bReq){
		Total_no_records.Visible = true;
		
		return null;
	}
	OleDbDataAdapter command = new OleDbDataAdapter(Total_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, Total_PAGENUM, "Total");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Total_no_records.Visible = true;
			}
		else
			{Total_no_records.Visible = false;
			}
		
		
		return Source;
		// Total Show end
		
	}
	

	void Total_Bind() {
		Total_Repeater.DataSource = Total_CreateDataSource();
		Total_Repeater.DataBind();
		
	}


// End of Login form 






private bool Member_Validate(){
	bool result=true;
	Member_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Member")){
			if(!Page.Validators[i].IsValid){
				Member_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Member_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Member_Show() {
	
	// Member Show begin
	
	bool ActionInsert=true;
	
	if (p_Member_member_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "member_id=" + CCUtility.ToSQL(p_Member_member_id.Value, FieldTypes.Number);
		
// Member Open Event begin
// Member Open Event end
		string sSQL = "select * from members where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Member") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Member_member_id.Value = CCUtility.GetValue(row, "member_id");
		

	Member_member_login.Text =Server.HtmlEncode(CCUtility.GetValue(row, "member_login").ToString());
		
		Member_member_login.NavigateUrl="MyInfo.aspx"+"?"+"";
		

	Member_name.Text =Server.HtmlEncode(CCUtility.GetValue(row, "first_name").ToString());
		
		
		

	Member_last_name.Text =Server.HtmlEncode(CCUtility.GetValue(row, "last_name").ToString());
		
		
		

	Member_address.Text =Server.HtmlEncode(CCUtility.GetValue(row, "address").ToString());
		
		
		

	Member_email.Text =Server.HtmlEncode(CCUtility.GetValue(row, "email").ToString());
		
		
		

	Member_phone.Text =Server.HtmlEncode(CCUtility.GetValue(row, "phone").ToString());
		
		
		

	
		ActionInsert=false;
		
// Member ShowEdit Event begin
// Member ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		if(Session["UserID"]!=null)
		pValue = Session["UserID"].ToString();
		else
		pValue="";Member_member_id.Value = pValue;
// Member ShowInsert Event begin
// Member ShowInsert Event end

}



// Member Open Event begin
// Member Open Event end

// Member Show Event begin
// Member Show Event end

	// Member Show end
	
// Member Close Event begin
// Member Close Event end

	}
	
	// Member Action begin
	

	void Member_BeforeSQLExecute(string SQL,String Action){
	  
// Member BeforeExecute Event begin
// Member BeforeExecute Event end

	}

	


    }
}