namespace Book_Store
{
	
//
//    Filename: MembersGrid.cs
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
    ///    Summary description for MembersGrid.
    /// </summary>

	public partial class MembersGrid : System.Web.UI.Page
	
    { 



//MembersGrid CustomIncludes begin
		protected CCUtility Utility;
		
		//Search form Search variables and controls declarations
		
		//Grid form Members variables and controls declarations
		protected string Members_sSQL;
		protected string Members_sCountSQL;
		protected int Members_CountPage;
//protected System.Web.UI.WebControls.LinkButton Members_insert;
		protected int i_Members_curpage=1;	
	
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="MembersGrid.aspx?";
		
		// For each Members form hiddens for PK's,List of Values and Actions
		protected string Members_FormAction="MembersRecord.aspx?";
		protected String[] Members_member_level_lov = "1;Member;2;Administrator".Split(new Char[] {';'});

	
	public MembersGrid()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// MembersGrid CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// MembersGrid Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// MembersGrid Open Event begin
// MembersGrid Open Event end
		//===============================
		
		//===============================
// MembersGrid OpenAnyPage Event begin
// MembersGrid OpenAnyPage Event end
		//===============================
		//
		//===============================
		// MembersGrid PageSecurity begin
		Utility.CheckSecurity(2);
		// MembersGrid PageSecurity end
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
		
		Members_insert.Click += new System.EventHandler (this.Members_insert_Click);
		Members_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.Members_pager_navigate_completed);
		
		
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
		Members_Bind();
		
        }



// MembersGrid Show end

// End of Login form 







void Search_Show() {
	
// Search Open Event begin
// Search Open Event end

	// Search Show begin
	

	string s;
	
	s=Utility.GetParam("name");
	Search_name.Text = s;
	
// Search Show Event begin
// Search Show Event end

	// Search Show end
	
// Search Close Event begin
// Search Close Event end
}

void Search_search_Click(Object Src, EventArgs E) {
	string sURL = Search_FormAction + "name="+Search_name.Text+"&"
	;
	// Transit
	sURL += "";
	Response.Redirect(sURL);
}



// End of Login form 








const int Members_PAGENUM = 20;




public void Members_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Members Show Event begin
// Members Show Event end
}


ICollection Members_CreateDataSource() {

       
       // Members Show begin
	Members_sSQL = "";
	Members_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by m.member_login Asc";
	if(Utility.GetParam("FormMembers_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("FormMembers_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("name")){
	string temp=Utility.GetParam("name");
	Params.Add("name",temp);}
	
	if(!Params.ContainsKey("name")){
	string temp=Utility.GetParam("name");
	Params.Add("name",temp);}
	
	if(!Params.ContainsKey("name")){
	string temp=Utility.GetParam("name");
	Params.Add("name",temp);}
		
	  if (Params["name"].Length>0) {
	    HasParam = true;
	    sWhere = "m.[member_login] like '%" + Params["name"].Replace( "'", "''") +  "%'" + " or " + "m.[first_name] like '%" + Params["name"].Replace( "'", "''") +  "%'" + " or " + "m.[last_name] like '%" + Params["name"].Replace( "'", "''") +  "%'";
	  }

	
	  if(HasParam)
	    sWhere = " WHERE (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Members_sSQL = "select [m].[first_name] as m_first_name, " +
    "[m].[last_name] as m_last_name, " +
    "[m].[member_id] as m_member_id, " +
    "[m].[member_level] as m_member_level, " +
    "[m].[member_login] as m_member_login " +
    " from [members] m ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Members_sSQL = Members_sSQL + sWhere + sOrder;
	  if (Members_sCountSQL.Length== 0) {
	    int iTmpI = Members_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = Members_sSQL.ToLower().LastIndexOf(" from ")-1;
	    Members_sCountSQL = Members_sSQL.Replace(Members_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = Members_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) Members_sCountSQL = Members_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Members_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_Members_curpage - 1) * Members_PAGENUM, Members_PAGENUM,"Members");
	OleDbCommand ccommand = new OleDbCommand(Members_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	Members_Pager.MaxPage=(PageTemp%Members_PAGENUM)>0?(int)(PageTemp/Members_PAGENUM)+1:(int)(PageTemp/Members_PAGENUM);
	bool AllowScroller=Members_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Members_no_records.Visible = true;
			AllowScroller=false;}
		else
			{Members_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		Members_Pager.Visible=AllowScroller;
		return Source;
		// Members Show end
		
	}
	

	protected void Members_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_Members_curpage=CurrPage;
			
// Members CustomNavigation Event begin
// Members CustomNavigation Event end
Members_Bind();
		}
	

	void Members_Bind() {
		Members_Repeater.DataSource = Members_CreateDataSource();
		Members_Repeater.DataBind();
		
	}

	void Members_insert_Click(Object Src, EventArgs E) {
		string sURL = Members_FormAction+"name=" + Server.UrlEncode(Utility.GetParam("name")) + "&";
		Response.Redirect(sURL);
	}

	protected void Members_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		Members_Bind();
	}



    }
}