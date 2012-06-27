namespace Book_Store
{
	
//
//    Filename: Books.cs
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
    ///    Summary description for Books.
    /// </summary>

	public partial class Books : System.Web.UI.Page
	
    { 



//Books CustomIncludes begin
		protected CCUtility Utility;
		
		//Grid form Results variables and controls declarations
		protected string Results_sSQL;
		protected string Results_sCountSQL;
		protected int Results_CountPage;
		protected int i_Results_curpage=1;	
	
		//Search form Search variables and controls declarations
		
		//Grid form Total variables and controls declarations
		protected string Total_sSQL;
		protected string Total_sCountSQL;
		protected int Total_CountPage;
		
		protected int i_Total_curpage=1;	
	
		// For each Results form hiddens for PK's,List of Values and Actions
		protected string Results_FormAction=".aspx?";
		
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="Books.aspx?";
		
		// For each AdvMenu form hiddens for PK's,List of Values and Actions
		protected string AdvMenu_FormAction=".aspx?";
		
		// For each Total form hiddens for PK's,List of Values and Actions
		protected string Total_FormAction=".aspx?";

	
	public Books()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// Books CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// Books Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// Books Open Event begin
// Books Open Event end
		//===============================
		
		//===============================
// Books OpenAnyPage Event begin
// Books OpenAnyPage Event end
		//===============================
		//
		//===============================
		// Books PageSecurity begin
		// Books PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Total_item_id.Value = Utility.GetParam("item_id");Page_Show(sender, e);
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
		Results_Pager.NavigateCompleted+=new NavigateCompletedHandler(this.Results_pager_navigate_completed);
		
		Search_search_button.Click += new System.EventHandler (this.Search_search_Click);
		
		
		
		
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
		Results_Bind();
		Search_Show();
		AdvMenu_Show();
		Total_Bind();
		
        }



// Books Show end

// End of Login form 








const int Results_PAGENUM = 20;




public void Results_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Results Show Event begin
if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
   ((HyperLink)e.Item.FindControl("Results_name")).Text ="<img border=\"0\" src=\"" + ((DataRowView)e.Item.DataItem )["i_image_url"].ToString() + "\"></td><td valign=\"top\" width=\"100%\"><table ><tr><td style=\"background-color: #FFFFFF; border-style: inset; border-width: 0\"><font style=\"font-size: 10pt; color: #CE7E00; font-weight: bold\"><b>" + ((DataRowView)e.Item.DataItem )["i_name"].ToString() + "</b>";
}
// Results Show Event end
}


ICollection Results_CreateDataSource() {

       
       // Results Show begin
	Results_sSQL = "";
	Results_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by i.name Asc";
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("author")){
	string temp=Utility.GetParam("author");
	Params.Add("author",temp);}
	
	if(!Params.ContainsKey("category_id")){
	string temp=Utility.GetParam("category_id");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("category_id",temp);}
	
	if(!Params.ContainsKey("name")){
	string temp=Utility.GetParam("name");
	Params.Add("name",temp);}
	
	if(!Params.ContainsKey("pricemax")){
	string temp=Utility.GetParam("pricemax");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("pricemax",temp);}
	
	if(!Params.ContainsKey("pricemin")){
	string temp=Utility.GetParam("pricemin");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("pricemin",temp);}
	
	  if (Params["author"].Length>0) {
	    HasParam = true;
	    sWhere +="i.[author] like '%" + Params["author"].Replace( "'", "''") +  "%'";
	  }
	  if (Params["category_id"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[category_id]=" + Params["category_id"];
	  }
	  if (Params["name"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[name] like '%" + Params["name"].Replace( "'", "''") +  "%'";
	  }
	  if (Params["pricemax"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[price]<" + Params["pricemax"];
	  }
	  if (Params["pricemin"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[price]>" + Params["pricemin"];
	  }

	
	  if(HasParam)
	    sWhere = " AND (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Results_sSQL = "select [i].[author] as i_author, " +
    "[i].[category_id] as i_category_id, " +
    "[i].[image_url] as i_image_url, " +
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



	  Results_sSQL = Results_sSQL + sWhere + sOrder;
	  if (Results_sCountSQL.Length== 0) {
	    int iTmpI = Results_sSQL.ToLower().IndexOf("select ");
	    int iTmpJ = Results_sSQL.ToLower().LastIndexOf(" from ")-1;
	    Results_sCountSQL = Results_sSQL.Replace(Results_sSQL.Substring(iTmpI + 7, iTmpJ-6), " count(*) ");
	    iTmpI = Results_sCountSQL.ToLower().IndexOf(" order by");
	    if (iTmpI > 1) Results_sCountSQL = Results_sCountSQL.Substring(0, iTmpI);
	  }
	  
	  
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(Results_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	
	command.Fill(ds, (i_Results_curpage - 1) * Results_PAGENUM, Results_PAGENUM,"Results");
	OleDbCommand ccommand = new OleDbCommand(Results_sCountSQL, Utility.Connection);
	int PageTemp=(int)ccommand.ExecuteScalar();
	Results_Pager.MaxPage=(PageTemp%Results_PAGENUM)>0?(int)(PageTemp/Results_PAGENUM)+1:(int)(PageTemp/Results_PAGENUM);
	bool AllowScroller=Results_Pager.MaxPage==1?false:true;
	
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			Results_no_records.Visible = true;
			AllowScroller=false;}
		else
			{Results_no_records.Visible = false;
			AllowScroller=AllowScroller&&true;}
		
		Results_Pager.Visible=AllowScroller;
		return Source;
		// Results Show end
		
	}
	

	protected void Results_pager_navigate_completed(Object Src, int CurrPage)
		{
			i_Results_curpage=CurrPage;
			
// Results CustomNavigation Event begin
// Results CustomNavigation Event end
Results_Bind();
		}
	

	void Results_Bind() {
		Results_Repeater.DataSource = Results_CreateDataSource();
		Results_Repeater.DataBind();
		
	}


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








const int Total_PAGENUM = 20;




public void Total_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// Total Show Event begin
// Total Show Event end
}
public void Total_Open(ref string sWhere, ref string sOrder){
	
// Total Open Event begin
Total_sSQL="select count(item_id) as i_item_id from items as i";
// Total Open Event end
}


ICollection Total_CreateDataSource() {

       
       // Total Show begin
	Total_sSQL = "";
	Total_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build WHERE statement
	//-------------------------------
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	
	if(!Params.ContainsKey("author")){
	string temp=Utility.GetParam("author");
	Params.Add("author",temp);}
	
	if(!Params.ContainsKey("category_id")){
	string temp=Utility.GetParam("category_id");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("category_id",temp);}
	
	if(!Params.ContainsKey("name")){
	string temp=Utility.GetParam("name");
	Params.Add("name",temp);}
	
	if(!Params.ContainsKey("pricemax")){
	string temp=Utility.GetParam("pricemax");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("pricemax",temp);}
	
	if(!Params.ContainsKey("pricemin")){
	string temp=Utility.GetParam("pricemin");
	if (Utility.IsNumeric(null,temp) && temp.Length>0) { temp = CCUtility.ToSQL(temp, FieldTypes.Number);} else {temp = "";}
	Params.Add("pricemin",temp);}
	
	  if (Params["author"].Length>0) {
	    HasParam = true;
	    sWhere +="i.[author] like '%" + Params["author"].Replace( "'", "''") +  "%'";
	  }
	  if (Params["category_id"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[category_id]=" + Params["category_id"];
	  }
	  if (Params["name"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[name] like '%" + Params["name"].Replace( "'", "''") +  "%'";
	  }
	  if (Params["pricemax"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[price]<=" + Params["pricemax"];
	  }
	  if (Params["pricemin"].Length>0) {
	    if (sWhere.Length >0) sWhere +=" and ";
	    HasParam = true;
	    sWhere +="i.[price]>=" + Params["pricemin"];
	  }

	
	  if(HasParam)
	    sWhere = " WHERE (" + sWhere + ")";

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	Total_sSQL = "select [i].[author] as i_author, " +
    "[i].[category_id] as i_category_id, " +
    "[i].[item_id] as i_item_id, " +
    "[i].[name] as i_name, " +
    "[i].[price] as i_price " +
    " from [items] i ";
	
	//-------------------------------
	//-------------------------------
	
Total_Open(ref sWhere, ref sOrder);
	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  Total_sSQL = Total_sSQL + sWhere + sOrder;
	//-------------------------------
	
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



    }
}