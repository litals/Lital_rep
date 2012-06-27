namespace Book_Store
{
	
//
//    Filename: AdminBooks.cs
//    Generated with CodeCharge 2.0.5
//    ASP.NET C#.ccp build 03/07/2002
//
//--------------------------------
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
    ///    Summary description for AdminBooks.
    /// </summary>
	///

	public partial class AdminBooks : System.Web.UI.Page
	
    {


        //ToDO abc
        //ToDO abc

//AdminBooks CustomIncludes begin
        protected CCUtility Utility;
		
		//Search form Search variables and controls declarations
		
		//Grid form Items variables and controls declarations
		protected string Items_sSQL;
		protected string Items_sCountSQL;
		protected int Items_CountPage;
//protected System.Web.UI.WebControls.LinkButton Items_insert;
		protected int i_Items_curpage=1;	
	
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="AdminBooks.aspx?";
		protected String[] Search_is_recommended_lov = ";All;0;No;1;Yes".Split(new Char[] {';'});
		// For each Items form hiddens for PK's,List of Values and Actions
		protected string Items_FormAction="BookMaint.aspx?";
		protected String[] Items_is_recommended_lov = "0;No;1;Yes".Split(new Char[] {';'});

	
	public AdminBooks()
	{
        int i = 9;
	this.Init += new System.EventHandler(Page_Init);
	}
	
// AdminBooks CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// AdminBooks Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// AdminBooks Open Event begin
// AdminBooks Open Event end
		//===============================
		
		//===============================
// AdminBooks OpenAnyPage Event begin
// AdminBooks OpenAnyPage Event end
		//===============================
		//
		//===============================
		// AdminBooks PageSecurity begin
		Utility.CheckSecurity(2);
		// AdminBooks PageSecurity end
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
		
		Items_insert.Click += new System.EventHandler (this.Items_insert_Click);
		Items_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.Items_pager_navigate_completed);
		
		
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
		Items_Bind();
		
        }



// AdminBooks Show end

// End of Login form 







void Search_Show() {
	
// Search Open Event begin
// Search Open Event end

	// Search Show begin
	Utility.buildListBox(Search_category_id.Items,"select category_id,name from categories order by 2","category_id","name","All","");
Utility.buildListBox(Search_is_recommended.Items,Search_is_recommended_lov,null,"");


	string s;
	
	s=Utility.GetParam("category_id");
	
	try {Search_category_id.SelectedIndex=Search_category_id.Items.IndexOf(Search_category_id.Items.FindByValue(s));
	}catch{}
	
	s=Utility.GetParam("is_recommended");
	
	try {Search_is_recommended.SelectedIndex=Search_is_recommended.Items.IndexOf(Search_is_recommended.Items.FindByValue(s));
	}catch{}
	
// Search Show Event begin
// Search Show Event end

	// Search Show end
	
// Search Close Event begin
// Search Close Event end
}

void Search_search_Click(Object Src, EventArgs E) {
	string sURL = Search_FormAction + "category_id="+Search_category_id.SelectedItem.Value+"&"
	 + "is_recommended="+Search_is_recommended.SelectedItem.Value+"&"
	;
	// Transit
	sURL += "";
	Response.Redirect(sURL);
}



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

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	if(Utility.GetParam("FormItems_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("FormItems_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("category_id")){
	string temp=Utility.GetParam("category_id");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("category_id",temp);}
	
	if(!Params.ContainsKey("is_recommended")){
	string temp=Utility.GetParam("is_recommended");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("is_recommended",temp);}
	
	  if (Params["category_id"].Length>0) {
	    HasParam = true;
	    sWhere +="i.[category_id]=" + Params["category_id"];
	  }
	  if (Params["is_recommended"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[is_recommended]=" + Params["is_recommended"];
	  }

	
	  if(HasParam)
	    sWhere = " AND (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Items_sSQL = "select [i].[author] as i_author, " +
    "[i].[category_id] as i_category_id, " +
    "[i].[is_recommended] as i_is_recommended, " +
    "[i].[item_id] as i_item_id, " +
    "[i].[name] as i_name, " +
    "[i].[price] as i_price, " +
    "[c].[category_id] as c_category_id, " +
    "[c].[name] as c_name " +
    " from [items] i, [categories] c" +
    " where [c].[category_id]=i.[category_id]  ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Items_sSQL = Items_sSQL + sWhere + sOrder;
	  if (Items_sCountSQL.Length== 0) {
	    int iTmpI = Items_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = Items_sSQL.ToLower().LastIndexOf(" from ")-1;
	    Items_sCountSQL = Items_sSQL.Replace(Items_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = Items_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) Items_sCountSQL = Items_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Items_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_Items_curpage - 1) * Items_PAGENUM, Items_PAGENUM,"Items");
	OleDbCommand ccommand = new OleDbCommand(Items_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	Items_Pager.MaxPage=(PageTemp%Items_PAGENUM)>0?(int)(PageTemp/Items_PAGENUM)+1:(int)(PageTemp/Items_PAGENUM);
	bool AllowScroller=Items_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Items_no_records.Visible = true;
			AllowScroller=false;}
		else
			{Items_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		Items_Pager.Visible=AllowScroller;
		return Source;
		// Items Show end
		
	}
	

	protected void Items_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_Items_curpage=CurrPage;
			
// Items CustomNavigation Event begin
// Items CustomNavigation Event end
Items_Bind();
		}
	

	void Items_Bind() {
		Items_Repeater.DataSource = Items_CreateDataSource();
		Items_Repeater.DataBind();
		
	}

	void Items_insert_Click(Object Src, EventArgs E) {
		string sURL = Items_FormAction+"category_id=" + Server.UrlEncode(Utility.GetParam("category_id")) + "&is_recommended=" + Server.UrlEncode(Utility.GetParam("is_recommended")) + "&";
		Response.Redirect(sURL);
	}

	protected void Items_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		Items_Bind();
	}



    }
}