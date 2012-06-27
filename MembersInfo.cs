namespace Book_Store
{
	
//
//    Filename: MembersInfo.cs
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
    ///    Summary description for MembersInfo.
    /// </summary>

	public partial class MembersInfo : System.Web.UI.Page
	
    { 



//MembersInfo CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Record variables and controls declarations
		
		//Grid form Orders variables and controls declarations
		protected string Orders_sSQL;
		protected string Orders_sCountSQL;
		protected int Orders_CountPage;
		
		protected int i_Orders_curpage=1;	
	
		// For each Record form hiddens for PK's,List of Values and Actions
		protected string Record_FormAction="AdminMenu.aspx?";
		// For each Orders form hiddens for PK's,List of Values and Actions
		protected string Orders_FormAction="AdminMenu.aspx?";

	
	public MembersInfo()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// MembersInfo CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// MembersInfo Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// MembersInfo Open Event begin
// MembersInfo Open Event end
		//===============================
		
		//===============================
// MembersInfo OpenAnyPage Event begin
// MembersInfo OpenAnyPage Event end
		//===============================
		//
		//===============================
		// MembersInfo PageSecurity begin
		Utility.CheckSecurity(2);
		// MembersInfo PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Record_member_id.Value = Utility.GetParam("member_id");
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
		Record_Show();
		Orders_Bind();
		
        }



// MembersInfo Show end

// End of Login form 






private bool Record_Validate(){
	bool result=true;
	Record_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Record")){
			if(!Page.Validators[i].IsValid){
				Record_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Record_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Record_Show() {
	
	// Record Show begin
	
	bool ActionInsert=true;
	
	if (p_Record_member_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "member_id=" + CCUtility.ToSQL(p_Record_member_id.Value, FieldTypes.Number);
		
// Record Open Event begin
// Record Open Event end
		string sSQL = "select * from members where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Record") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Record_member_id.Value = CCUtility.GetValue(row, "member_id");
		

	Record_member_login.Text =Server.HtmlEncode(CCUtility.GetValue(row, "member_login").ToString());
		
		Record_member_login.NavigateUrl="MembersRecord.aspx"+"?"+"member_id="+Server.UrlEncode(CCUtility.GetValue(row, "member_id").ToString()) +"&"+"";
		

	Record_member_level.Text =Server.HtmlEncode(CCUtility.GetValue(row, "member_level").ToString());
		
		
		

	Record_name.Text =Server.HtmlEncode(CCUtility.GetValue(row, "first_name").ToString());
		
		
		

	Record_last_name.Text =Server.HtmlEncode(CCUtility.GetValue(row, "last_name").ToString());
		
		
		

	Record_email.Text =Server.HtmlEncode(CCUtility.GetValue(row, "email").ToString());
		
		
		

	Record_phone.Text =Server.HtmlEncode(CCUtility.GetValue(row, "phone").ToString());
		
		
		

	Record_address.Text =Server.HtmlEncode(CCUtility.GetValue(row, "address").ToString());
		
		
		

	Record_notes.Text =Server.HtmlEncode(CCUtility.GetValue(row, "notes").ToString());
		
		
		

	
		ActionInsert=false;
		
// Record ShowEdit Event begin
// Record ShowEdit Event end

	}}

		if(ActionInsert){

// Record ShowInsert Event begin
// Record ShowInsert Event end

}



// Record Open Event begin
// Record Open Event end

// Record Show Event begin
// Record Show Event end

	// Record Show end
	
// Record Close Event begin
// Record Close Event end

	}
	
	// Record Action begin
	

	void Record_BeforeSQLExecute(string SQL,String Action){
	  
// Record BeforeExecute Event begin
// Record BeforeExecute Event end

	}

	

// End of Login form 








const int Orders_PAGENUM = 20;




public void Orders_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Orders Show Event begin
// Orders Show Event end
}


ICollection Orders_CreateDataSource() {

       
       // Orders Show begin
	Orders_sSQL = "";
	Orders_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool bReq = true;
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	if(Utility.GetParam("FormOrders_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("FormOrders_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("member_id")){
	string temp=Utility.GetParam("member_id");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("member_id",temp);}
	
	  if (Params["member_id"].Length>0) {
	    HasParam = true;
	    sWhere +="o.[member_id]=" + Params["member_id"];
	  }else{bReq = false;
	  }

	
	  if(HasParam)
	    sWhere = " AND (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Orders_sSQL = "select [o].[item_id] as o_item_id, " +
    "[o].[member_id] as o_member_id, " +
    "[o].[order_id] as o_order_id, " +
    "[o].[quantity] as o_quantity, " +
    "[i].[item_id] as i_item_id, " +
    "[i].[name] as i_name " +
    " from [orders] o, [items] i" +
    " where [i].[item_id]=o.[item_id]  ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Orders_sSQL = Orders_sSQL + sWhere + sOrder;
	//-------------------------------
	
	if(!bReq){
		Orders_no_records.Visible = true;
		
		return null;
	}
	OleDbDataAdapter command = new OleDbDataAdapter(Orders_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, Orders_PAGENUM, "Orders");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Orders_no_records.Visible = true;
			}
		else
			{Orders_no_records.Visible = false;
			}
		
		
		return Source;
		// Orders Show end
		
	}
	

	void Orders_Bind() {
		Orders_Repeater.DataSource = Orders_CreateDataSource();
		Orders_Repeater.DataBind();
		
	}

	protected void Orders_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		Orders_Bind();
	}



    }
}