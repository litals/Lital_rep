namespace Book_Store
{
	
//
//    Filename: OrdersGrid.cs
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
    ///    Summary description for OrdersGrid.
    /// </summary>

	public partial class OrdersGrid : System.Web.UI.Page
	
    { 



//OrdersGrid CustomIncludes begin
		protected CCUtility Utility;
		
		//Search form Search variables and controls declarations
		
		//Grid form Orders variables and controls declarations
		protected string Orders_sSQL;
		protected string Orders_sCountSQL;
		protected int Orders_CountPage;
//protected System.Web.UI.WebControls.LinkButton Orders_insert;
		protected int i_Orders_curpage=1;	
	
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="OrdersGrid.aspx?";
		
		// For each Orders form hiddens for PK's,List of Values and Actions
		protected string Orders_FormAction="OrdersRecord.aspx?";
		

	
	public OrdersGrid()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// OrdersGrid CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// OrdersGrid Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// OrdersGrid Open Event begin
// OrdersGrid Open Event end
		//===============================
		
		//===============================
// OrdersGrid OpenAnyPage Event begin
// OrdersGrid OpenAnyPage Event end
		//===============================
		//
		//===============================
		// OrdersGrid PageSecurity begin
		Utility.CheckSecurity(2);
		// OrdersGrid PageSecurity end
		//===============================

		if (!IsPostBack){
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
		Search_search_button.Click += new System.EventHandler (this.Search_search_Click);
		
		Orders_insert.Click += new System.EventHandler (this.Orders_insert_Click);
		Orders_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.Orders_pager_navigate_completed);
		
		
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
		Search_Show();
		Orders_Bind();
		
        }



// OrdersGrid Show end

// End of Login form 







void Search_Show() {
	
// Search Open Event begin
// Search Open Event end

	// Search Show begin
	Utility.buildListBox(Search_item_id.Items,"select item_id,name from items order by 2","item_id","name","All","");
Utility.buildListBox(Search_member_id.Items,"select member_id,member_login from members order by 2","member_id","member_login","All","");


	string s;
	
	s=Utility.GetParam("item_id");
	
	try {Search_item_id.SelectedIndex=Search_item_id.Items.IndexOf(Search_item_id.Items.FindByValue(s));
	}catch{}
	
	s=Utility.GetParam("member_id");
	
	try {Search_member_id.SelectedIndex=Search_member_id.Items.IndexOf(Search_member_id.Items.FindByValue(s));
	}catch{}
	
// Search Show Event begin
// Search Show Event end

	// Search Show end
	
// Search Close Event begin
// Search Close Event end
}

void Search_search_Click(Object Src, EventArgs E) {
	string sURL = Search_FormAction + "item_id="+Search_item_id.SelectedItem.Value+"&"
	 + "member_id="+Search_member_id.SelectedItem.Value+"&"
	;
	// Transit
	sURL += "";
	Response.Redirect(sURL);
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

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by o.order_id Asc";
	if(Utility.GetParam("FormOrders_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("FormOrders_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("item_id")){
	string temp=Utility.GetParam("item_id");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("item_id",temp);}
	
	if(!Params.ContainsKey("member_id")){
	string temp=Utility.GetParam("member_id");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("member_id",temp);}
	
	  if (Params["item_id"].Length>0) {
	    HasParam = true;
	    sWhere +="o.[item_id]=" + Params["item_id"];
	  }
	  if (Params["member_id"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="o.[member_id]=" + Params["member_id"];
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
    "[i].[name] as i_name, " +
    "[m].[member_id] as m_member_id, " +
    "[m].[member_login] as m_member_login " +
    " from [orders] o, [items] i, [members] m" +
    " where [i].[item_id]=o.[item_id] and [m].[member_id]=o.[member_id]  ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Orders_sSQL = Orders_sSQL + sWhere + sOrder;
	  if (Orders_sCountSQL.Length== 0) {
	    int iTmpI = Orders_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = Orders_sSQL.ToLower().LastIndexOf(" from ")-1;
	    Orders_sCountSQL = Orders_sSQL.Replace(Orders_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = Orders_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) Orders_sCountSQL = Orders_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Orders_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_Orders_curpage - 1) * Orders_PAGENUM, Orders_PAGENUM,"Orders");
	OleDbCommand ccommand = new OleDbCommand(Orders_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	Orders_Pager.MaxPage=(PageTemp%Orders_PAGENUM)>0?(int)(PageTemp/Orders_PAGENUM)+1:(int)(PageTemp/Orders_PAGENUM);
	bool AllowScroller=Orders_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Orders_no_records.Visible = true;
			AllowScroller=false;}
		else
			{Orders_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		Orders_Pager.Visible=AllowScroller;
		return Source;
		// Orders Show end
		
	}
	

	protected void Orders_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_Orders_curpage=CurrPage;
			
// Orders CustomNavigation Event begin
// Orders CustomNavigation Event end
Orders_Bind();
		}
	

	void Orders_Bind() {
		Orders_Repeater.DataSource = Orders_CreateDataSource();
		Orders_Repeater.DataBind();
		
	}

	void Orders_insert_Click(Object Src, EventArgs E) {
		string sURL = Orders_FormAction+"item_id=" + Server.UrlEncode(Utility.GetParam("item_id")) + "&member_id=" + Server.UrlEncode(Utility.GetParam("member_id")) + "&";
		Response.Redirect(sURL);
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