namespace Book_Store
{
	
//
//    Filename: Default.cs
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
    ///    Summary description for Default.
    /// </summary>

	public partial class Default : System.Web.UI.Page
	
    { 



//Default CustomIncludes begin
		protected CCUtility Utility;
		
		//Search form Search variables and controls declarations
		
		//Grid form Recommended variables and controls declarations
		protected string Recommended_sSQL;
		protected string Recommended_sCountSQL;
		protected int Recommended_CountPage;
		protected int i_Recommended_curpage=1;	
	
		//Grid form What variables and controls declarations
		protected string What_sSQL;
		protected string What_sCountSQL;
		protected int What_CountPage;
		
		protected int i_What_curpage=1;	
	
		//Grid form Categories variables and controls declarations
		protected string Categories_sSQL;
		protected string Categories_sCountSQL;
		protected int Categories_CountPage;
		
		protected int i_Categories_curpage=1;	
	
		//Grid form New variables and controls declarations
		protected string New_sSQL;
		protected string New_sCountSQL;
		protected int New_CountPage;
		
		protected int i_New_curpage=1;	
	
		//Grid form Weekly variables and controls declarations
		protected string Weekly_sSQL;
		protected string Weekly_sCountSQL;
		protected int Weekly_CountPage;
		
		protected int i_Weekly_curpage=1;	
	
		//Grid form Specials variables and controls declarations
		protected string Specials_sSQL;
		protected string Specials_sCountSQL;
		protected int Specials_CountPage;
		
		protected int i_Specials_curpage=1;	
	
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="Books.aspx?";
		
		// For each AdvMenu form hiddens for PK's,List of Values and Actions
		protected string AdvMenu_FormAction=".aspx?";
		
		// For each Recommended form hiddens for PK's,List of Values and Actions
		protected string Recommended_FormAction=".aspx?";
		
		// For each What form hiddens for PK's,List of Values and Actions
		protected string What_FormAction=".aspx?";
		
		// For each Categories form hiddens for PK's,List of Values and Actions
		protected string Categories_FormAction=".aspx?";
		
		// For each New form hiddens for PK's,List of Values and Actions
		protected string New_FormAction=".aspx?";
		
		// For each Weekly form hiddens for PK's,List of Values and Actions
		protected string Weekly_FormAction=".aspx?";
		
		// For each Specials form hiddens for PK's,List of Values and Actions
		protected string Specials_FormAction=".aspx?";
		

	
	public Default()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// Default CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// Default Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// Default Open Event begin
// Default Open Event end
		//===============================
		
		//===============================
// Default OpenAnyPage Event begin
// Default OpenAnyPage Event end
		//===============================
		//
		//===============================
		// Default PageSecurity begin
		// Default PageSecurity end
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
		
		
		Recommended_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.Recommended_pager_navigate_completed);
		
		
		
		
		
		
		
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
		AdvMenu_Show();
		Recommended_Bind();
		What_Bind();
		Categories_Bind();
		New_Bind();
		Weekly_Bind();
		Specials_Bind();
		
        }



// Default Show end

// End of Login form 







void Search_Show() {
	
// Search Open Event begin
// Search Open Event end

	// Search Show begin
	Utility.buildListBox(Search_category_id.Items,"select category_id,name from categories order by 2","category_id","name","All","");


	string s;
	
	s=Utility.GetParam("category_id");
	
	try {Search_category_id.SelectedIndex=Search_category_id.Items.IndexOf(Search_category_id.Items.FindByValue(s));
	}catch{}
	
	s=Utility.GetParam("name");
	Search_name.Text = s;
	
// Search Show Event begin
// Search Show Event end

	// Search Show end
	
// Search Close Event begin
// Search Close Event end
}

void Search_search_Click(Object Src, EventArgs E) {
	string sURL = Search_FormAction + "category_id="+Search_category_id.SelectedItem.Value+"&"
	 + "name="+Search_name.Text+"&"
	;
	// Transit
	sURL += "";
	Response.Redirect(sURL);
}



// End of Login form 






	protected void AdvMenu_Show(){
	  
// AdvMenu Open Event begin
// AdvMenu Open Event end

	  // AdvMenu Show begin				
	  
// AdvMenu BeforeShow Event begin
// AdvMenu BeforeShow Event end

	  // AdvMenu Show end
	  
	}


// End of Login form 








const int Recommended_PAGENUM = 5;




public void Recommended_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Recommended Show Event begin
if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
   ((HyperLink)e.Item.FindControl("Recommended_name")).Text ="<img border=\"0\" src=\"" + ((DataRowView)e.Item.DataItem )["i_image_url"].ToString() + "\"></td><td valign=\"top\"><table width=\"100%\" style=\"width:100%\"><tr><td style=\"background-color: #FFFFFF; border-style: inset; border-width: 0\"><font style=\"font-size: 10pt; color: #CE7E00; font-weight: bold\"><b>" + ((DataRowView)e.Item.DataItem )["i_name"].ToString() + "</b>";
}
// Recommended Show Event end
}


ICollection Recommended_CreateDataSource() {

       
       // Recommended Show begin
	Recommended_sSQL = "";
	Recommended_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	
	  sWhere = " WHERE is_recommended=1";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Recommended_sSQL = "select [i].[author] as i_author, " +
    "[i].[image_url] as i_image_url, " +
    "[i].[item_id] as i_item_id, " +
    "[i].[name] as i_name, " +
    "[i].[price] as i_price " +
    " from [items] i ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Recommended_sSQL = Recommended_sSQL + sWhere + sOrder;
	  if (Recommended_sCountSQL.Length== 0) {
	    int iTmpI = Recommended_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = Recommended_sSQL.ToLower().LastIndexOf(" from ")-1;
	    Recommended_sCountSQL = Recommended_sSQL.Replace(Recommended_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = Recommended_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) Recommended_sCountSQL = Recommended_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Recommended_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_Recommended_curpage - 1) * Recommended_PAGENUM, Recommended_PAGENUM,"Recommended");
	OleDbCommand ccommand = new OleDbCommand(Recommended_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	Recommended_Pager.MaxPage=(PageTemp%Recommended_PAGENUM)>0?(int)(PageTemp/Recommended_PAGENUM)+1:(int)(PageTemp/Recommended_PAGENUM);
	bool AllowScroller=Recommended_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Recommended_no_records.Visible = true;
			AllowScroller=false;}
		else
			{Recommended_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		Recommended_Pager.Visible=AllowScroller;
		return Source;
		// Recommended Show end
		
	}
	

	protected void Recommended_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_Recommended_curpage=CurrPage;
			
// Recommended CustomNavigation Event begin
// Recommended CustomNavigation Event end
Recommended_Bind();
		}
	

	void Recommended_Bind() {
		Recommended_Repeater.DataSource = Recommended_CreateDataSource();
		Recommended_Repeater.DataBind();
		
	}


// End of Login form 








const int What_PAGENUM = 20;




public void What_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// What Show Event begin
if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
   ((HyperLink)e.Item.FindControl("What_article_title")).Text ="<b>"+((DataRowView)e.Item.DataItem )["e_article_title"].ToString()+"<b>";
   ((Label)e.Item.FindControl("What_article_desc")).Text="<img align=\"left\" border=\"0\" src=\"" + Utility.Dlookup("items","image_url","item_id=" + ((DataRowView)e.Item.DataItem )["e_item_id"].ToString()) + "\">" + ((DataRowView)e.Item.DataItem )["e_article_desc"].ToString();
}
// What Show Event end
}


ICollection What_CreateDataSource() {

       
       // What Show begin
	What_sSQL = "";
	What_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	
	  sWhere = " WHERE editorial_cat_id=1";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	What_sSQL = "select [e].[article_desc] as e_article_desc, " +
    "[e].[article_title] as e_article_title, " +
    "[e].[item_id] as e_item_id " +
    " from [editorials] e ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  What_sSQL = What_sSQL + sWhere + sOrder;
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(What_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, What_PAGENUM, "What");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			What_no_records.Visible = true;
			}
		else
			{What_no_records.Visible = false;
			}
		
		
		return Source;
		// What Show end
		
	}
	

	void What_Bind() {
		What_Repeater.DataSource = What_CreateDataSource();
		What_Repeater.DataBind();
		
	}


// End of Login form 








const int Categories_PAGENUM = 20;




public void Categories_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Categories Show Event begin
// Categories Show Event end
}


ICollection Categories_CreateDataSource() {

       
       // Categories Show begin
	Categories_sSQL = "";
	Categories_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Categories_sSQL = "select [c].[category_id] as c_category_id, " +
    "[c].[name] as c_name " +
    " from [categories] c ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Categories_sSQL = Categories_sSQL + sWhere + sOrder;
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Categories_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, Categories_PAGENUM, "Categories");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Categories_no_records.Visible = true;
			}
		else
			{Categories_no_records.Visible = false;
			}
		
		
		return Source;
		// Categories Show end
		
	}
	

	void Categories_Bind() {
		Categories_Repeater.DataSource = Categories_CreateDataSource();
		Categories_Repeater.DataBind();
		
	}


// End of Login form 








const int New_PAGENUM = 20;




public void New_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// New Show Event begin
if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
   ((HyperLink)e.Item.FindControl("New_article_title")).Text ="<b>"+((DataRowView)e.Item.DataItem )["e_article_title"].ToString()+"<b>";
 ((Label)e.Item.FindControl("New_article_desc")).Text="<img align=\"left\" border=\"0\" src=\"" + Utility.Dlookup("items","image_url","item_id=" + ((DataRowView)e.Item.DataItem )["e_item_id"].ToString()) + "\">" + ((DataRowView)e.Item.DataItem )["e_article_desc"].ToString();

}
// New Show Event end
}


ICollection New_CreateDataSource() {

       
       // New Show begin
	New_sSQL = "";
	New_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	
	  sWhere = " WHERE editorial_cat_id=2";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	New_sSQL = "select [e].[article_desc] as e_article_desc, " +
    "[e].[article_title] as e_article_title, " +
    "[e].[item_id] as e_item_id " +
    " from [editorials] e ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  New_sSQL = New_sSQL + sWhere + sOrder;
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(New_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, New_PAGENUM, "New");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			New_no_records.Visible = true;
			}
		else
			{New_no_records.Visible = false;
			}
		
		
		return Source;
		// New Show end
		
	}
	

	void New_Bind() {
		New_Repeater.DataSource = New_CreateDataSource();
		New_Repeater.DataBind();
		
	}


// End of Login form 








const int Weekly_PAGENUM = 20;




public void Weekly_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Weekly Show Event begin
if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
   ((HyperLink)e.Item.FindControl("Weekly_article_title")).Text ="<b>"+((DataRowView)e.Item.DataItem )["e_article_title"].ToString()+"<b>";
   ((Label)e.Item.FindControl("Weekly_article_desc")).Text="<img align=\"left\" border=\"0\" src=\"" + Utility.Dlookup("items","image_url","item_id=" + ((DataRowView)e.Item.DataItem )["e_item_id"].ToString()) + "\">" + ((DataRowView)e.Item.DataItem )["e_article_desc"].ToString();
}
// Weekly Show Event end
}


ICollection Weekly_CreateDataSource() {

       
       // Weekly Show begin
	Weekly_sSQL = "";
	Weekly_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	
	  sWhere = " WHERE editorial_cat_id=3";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Weekly_sSQL = "select [e].[article_desc] as e_article_desc, " +
    "[e].[article_title] as e_article_title, " +
    "[e].[item_id] as e_item_id " +
    " from [editorials] e ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Weekly_sSQL = Weekly_sSQL + sWhere + sOrder;
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Weekly_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, Weekly_PAGENUM, "Weekly");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Weekly_no_records.Visible = true;
			}
		else
			{Weekly_no_records.Visible = false;
			}
		
		
		return Source;
		// Weekly Show end
		
	}
	

	void Weekly_Bind() {
		Weekly_Repeater.DataSource = Weekly_CreateDataSource();
		Weekly_Repeater.DataBind();
		
	}


// End of Login form 








const int Specials_PAGENUM = 20;




public void Specials_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Specials Show Event begin
// Specials Show Event end
}


ICollection Specials_CreateDataSource() {

       
       // Specials Show begin
	Specials_sSQL = "";
	Specials_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	
	  sWhere = " WHERE editorial_cat_id=4";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Specials_sSQL = "select [e].[article_desc] as e_article_desc, " +
    "[e].[article_title] as e_article_title " +
    " from [editorials] e ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Specials_sSQL = Specials_sSQL + sWhere + sOrder;
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Specials_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, Specials_PAGENUM, "Specials");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Specials_no_records.Visible = true;
			}
		else
			{Specials_no_records.Visible = false;
			}
		
		
		return Source;
		// Specials Show end
		
	}
	

	void Specials_Bind() {
		Specials_Repeater.DataSource = Specials_CreateDataSource();
		Specials_Repeater.DataBind();
		
	}



    }
}