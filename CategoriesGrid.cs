namespace Book_Store
{
	
//
//    Filename: CategoriesGrid.cs
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
    ///    Summary description for CategoriesGrid.
    /// </summary>

	public partial class CategoriesGrid : System.Web.UI.Page
	
    { 



//CategoriesGrid CustomIncludes begin
		protected CCUtility Utility;
		
		//Grid form Categories variables and controls declarations
		protected string Categories_sSQL;
		protected string Categories_sCountSQL;
		protected int Categories_CountPage;
//protected System.Web.UI.WebControls.LinkButton Categories_insert;
		protected int i_Categories_curpage=1;	
	
		// For each Categories form hiddens for PK's,List of Values and Actions
		protected string Categories_FormAction="CategoriesRecord.aspx?";
		

	
	public CategoriesGrid()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// CategoriesGrid CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// CategoriesGrid Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// CategoriesGrid Open Event begin
// CategoriesGrid Open Event end
		//===============================
		
		//===============================
// CategoriesGrid OpenAnyPage Event begin
// CategoriesGrid OpenAnyPage Event end
		//===============================
		//
		//===============================
		// CategoriesGrid PageSecurity begin
		Utility.CheckSecurity(2);
		// CategoriesGrid PageSecurity end
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
		Categories_insert.Click += new System.EventHandler (this.Categories_insert_Click);
		Categories_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.Categories_pager_navigate_completed);
		
		
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
		Categories_Bind();
		
        }



// CategoriesGrid Show end

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
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by c.name Asc";
	if(Utility.GetParam("FormCategories_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("FormCategories_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
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
	  if (Categories_sCountSQL.Length== 0) {
	    int iTmpI = Categories_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = Categories_sSQL.ToLower().LastIndexOf(" from ")-1;
	    Categories_sCountSQL = Categories_sSQL.Replace(Categories_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = Categories_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) Categories_sCountSQL = Categories_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Categories_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_Categories_curpage - 1) * Categories_PAGENUM, Categories_PAGENUM,"Categories");
	OleDbCommand ccommand = new OleDbCommand(Categories_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	Categories_Pager.MaxPage=(PageTemp%Categories_PAGENUM)>0?(int)(PageTemp/Categories_PAGENUM)+1:(int)(PageTemp/Categories_PAGENUM);
	bool AllowScroller=Categories_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Categories_no_records.Visible = true;
			AllowScroller=false;}
		else
			{Categories_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		Categories_Pager.Visible=AllowScroller;
		return Source;
		// Categories Show end
		
	}
	

	protected void Categories_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_Categories_curpage=CurrPage;
			
// Categories CustomNavigation Event begin
// Categories CustomNavigation Event end
Categories_Bind();
		}
	

	void Categories_Bind() {
		Categories_Repeater.DataSource = Categories_CreateDataSource();
		Categories_Repeater.DataBind();
		
	}

	void Categories_insert_Click(Object Src, EventArgs E) {
		string sURL = Categories_FormAction+"";
		Response.Redirect(sURL);
	}

	protected void Categories_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		Categories_Bind();
	}



    }
}