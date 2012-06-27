namespace Book_Store
{
	
//
//    Filename: EditorialCatGrid.cs
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
    ///    Summary description for EditorialCatGrid.
    /// </summary>

	public partial class EditorialCatGrid : System.Web.UI.Page
	
    { 



//EditorialCatGrid CustomIncludes begin
		protected CCUtility Utility;
		
		//Grid form editorial_categories variables and controls declarations
		protected string editorial_categories_sSQL;
		protected string editorial_categories_sCountSQL;
		protected int editorial_categories_CountPage;
//protected System.Web.UI.WebControls.LinkButton editorial_categories_insert;
		protected int i_editorial_categories_curpage=1;	
	
		// For each editorial_categories form hiddens for PK's,List of Values and Actions
		protected string editorial_categories_FormAction="EditorialCatRecord.aspx?";

	
	public EditorialCatGrid()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// EditorialCatGrid CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// EditorialCatGrid Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// EditorialCatGrid Open Event begin
// EditorialCatGrid Open Event end
		//===============================
		
		//===============================
// EditorialCatGrid OpenAnyPage Event begin
// EditorialCatGrid OpenAnyPage Event end
		//===============================
		//
		//===============================
		// EditorialCatGrid PageSecurity begin
		Utility.CheckSecurity(2);
		// EditorialCatGrid PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_editorial_categories_editorial_cat_id.Value = Utility.GetParam("editorial_cat_id");Page_Show(sender, e);
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
		editorial_categories_insert.Click += new System.EventHandler (this.editorial_categories_insert_Click);
		editorial_categories_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.editorial_categories_pager_navigate_completed);
		
		
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
		editorial_categories_Bind();
		
        }



// EditorialCatGrid Show end

// End of Login form 








const int editorial_categories_PAGENUM = 20;




public void editorial_categories_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// editorial_categories Show Event begin
// editorial_categories Show Event end
}


ICollection editorial_categories_CreateDataSource() {

       
       // editorial_categories Show begin
	editorial_categories_sSQL = "";
	editorial_categories_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by e.editorial_cat_name Asc";
	if(Utility.GetParam("Formeditorial_categories_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("Formeditorial_categories_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	editorial_categories_sSQL = "select [e].[editorial_cat_id] as e_editorial_cat_id, " +
    "[e].[editorial_cat_name] as e_editorial_cat_name " +
    " from [editorial_categories] e ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  editorial_categories_sSQL = editorial_categories_sSQL + sWhere + sOrder;
	  if (editorial_categories_sCountSQL.Length== 0) {
	    int iTmpI = editorial_categories_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = editorial_categories_sSQL.ToLower().LastIndexOf(" from ")-1;
	    editorial_categories_sCountSQL = editorial_categories_sSQL.Replace(editorial_categories_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = editorial_categories_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) editorial_categories_sCountSQL = editorial_categories_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(editorial_categories_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_editorial_categories_curpage - 1) * editorial_categories_PAGENUM, editorial_categories_PAGENUM,"editorial_categories");
	OleDbCommand ccommand = new OleDbCommand(editorial_categories_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	editorial_categories_Pager.MaxPage=(PageTemp%editorial_categories_PAGENUM)>0?(int)(PageTemp/editorial_categories_PAGENUM)+1:(int)(PageTemp/editorial_categories_PAGENUM);
	bool AllowScroller=editorial_categories_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			editorial_categories_no_records.Visible = true;
			AllowScroller=false;}
		else
			{editorial_categories_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		editorial_categories_Pager.Visible=AllowScroller;
		return Source;
		// editorial_categories Show end
		
	}
	

	protected void editorial_categories_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_editorial_categories_curpage=CurrPage;
			
// editorial_categories CustomNavigation Event begin
// editorial_categories CustomNavigation Event end
editorial_categories_Bind();
		}
	

	void editorial_categories_Bind() {
		editorial_categories_Repeater.DataSource = editorial_categories_CreateDataSource();
		editorial_categories_Repeater.DataBind();
		
	}

	void editorial_categories_insert_Click(Object Src, EventArgs E) {
		string sURL = editorial_categories_FormAction+"";
		Response.Redirect(sURL);
	}

	protected void editorial_categories_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		editorial_categories_Bind();
	}



    }
}