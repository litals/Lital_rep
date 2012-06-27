namespace Book_Store
{
	
//
//    Filename: EditorialsGrid.cs
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
    ///    Summary description for EditorialsGrid.
    /// </summary>

	public partial class EditorialsGrid : System.Web.UI.Page
	
    { 



//EditorialsGrid CustomIncludes begin
		protected CCUtility Utility;
		
		//Grid form editorials variables and controls declarations
		protected string editorials_sSQL;
		protected string editorials_sCountSQL;
		protected int editorials_CountPage;
//protected System.Web.UI.WebControls.LinkButton editorials_insert;
		protected int i_editorials_curpage=1;	
	
		// For each editorials form hiddens for PK's,List of Values and Actions
		protected string editorials_FormAction="EditorialsRecord.aspx?";

	
	public EditorialsGrid()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// EditorialsGrid CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// EditorialsGrid Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// EditorialsGrid Open Event begin
// EditorialsGrid Open Event end
		//===============================
		
		//===============================
// EditorialsGrid OpenAnyPage Event begin
// EditorialsGrid OpenAnyPage Event end
		//===============================
		//
		//===============================
		// EditorialsGrid PageSecurity begin
		Utility.CheckSecurity(2);
		// EditorialsGrid PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_editorials_article_id.Value = Utility.GetParam("article_id");Page_Show(sender, e);
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
		editorials_insert.Click += new System.EventHandler (this.editorials_insert_Click);
		editorials_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.editorials_pager_navigate_completed);
		
		
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
		editorials_Bind();
		
        }



// EditorialsGrid Show end

// End of Login form 








const int editorials_PAGENUM = 20;




public void editorials_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// editorials Show Event begin
// editorials Show Event end
}


ICollection editorials_CreateDataSource() {

       
       // editorials Show begin
	editorials_sSQL = "";
	editorials_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by e.article_title Asc";
	if(Utility.GetParam("Formeditorials_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("Formeditorials_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	editorials_sSQL = "select [e].[article_id] as e_article_id, " +
    "[e].[article_title] as e_article_title, " +
    "[e].[editorial_cat_id] as e_editorial_cat_id, " +
    "[e].[item_id] as e_item_id, " +
    "[e1].[editorial_cat_id] as e1_editorial_cat_id, " +
    "[e1].[editorial_cat_name] as e1_editorial_cat_name, " +
    "[i].[item_id] as i_item_id, " +
    "[i].[name] as i_name " +
    " from [editorials] e, [editorial_categories] e1, [items] i" +
    " where [e1].[editorial_cat_id]=e.[editorial_cat_id] and [i].[item_id]=e.[item_id]  ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  editorials_sSQL = editorials_sSQL + sWhere + sOrder;
	  if (editorials_sCountSQL.Length== 0) {
	    int iTmpI = editorials_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = editorials_sSQL.ToLower().LastIndexOf(" from ")-1;
	    editorials_sCountSQL = editorials_sSQL.Replace(editorials_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = editorials_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) editorials_sCountSQL = editorials_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(editorials_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_editorials_curpage - 1) * editorials_PAGENUM, editorials_PAGENUM,"editorials");
	OleDbCommand ccommand = new OleDbCommand(editorials_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	editorials_Pager.MaxPage=(PageTemp%editorials_PAGENUM)>0?(int)(PageTemp/editorials_PAGENUM)+1:(int)(PageTemp/editorials_PAGENUM);
	bool AllowScroller=editorials_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			editorials_no_records.Visible = true;
			AllowScroller=false;}
		else
			{editorials_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		editorials_Pager.Visible=AllowScroller;
		return Source;
		// editorials Show end
		
	}
	

	protected void editorials_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_editorials_curpage=CurrPage;
			
// editorials CustomNavigation Event begin
// editorials CustomNavigation Event end
editorials_Bind();
		}
	

	void editorials_Bind() {
		editorials_Repeater.DataSource = editorials_CreateDataSource();
		editorials_Repeater.DataBind();
		
	}

	void editorials_insert_Click(Object Src, EventArgs E) {
		string sURL = editorials_FormAction+"";
		Response.Redirect(sURL);
	}

	protected void editorials_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		editorials_Bind();
	}



    }
}