namespace Book_Store
{
	
//
//    Filename: CardTypesGrid.cs
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
    ///    Summary description for CardTypesGrid.
    /// </summary>

	public partial class CardTypesGrid : System.Web.UI.Page
	
    { 



//CardTypesGrid CustomIncludes begin
		protected CCUtility Utility;
		
		//Grid form CardTypes variables and controls declarations
		protected string CardTypes_sSQL;
		protected string CardTypes_sCountSQL;
		protected int CardTypes_CountPage;
		protected int i_CardTypes_curpage=1;	
	
		// For each CardTypes form hiddens for PK's,List of Values and Actions
		protected string CardTypes_FormAction="CardTypesRecord.aspx?";
		

	
	public CardTypesGrid()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// CardTypesGrid CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// CardTypesGrid Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// CardTypesGrid Open Event begin
// CardTypesGrid Open Event end
		//===============================
		
		//===============================
// CardTypesGrid OpenAnyPage Event begin
// CardTypesGrid OpenAnyPage Event end
		//===============================
		//
		//===============================
		// CardTypesGrid PageSecurity begin
		Utility.CheckSecurity(2);
		// CardTypesGrid PageSecurity end
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
		CardTypes_insert.Click += new System.EventHandler (this.CardTypes_insert_Click);
		
		
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
		CardTypes_Bind();
		
        }



// CardTypesGrid Show end

// End of Login form 








const int CardTypes_PAGENUM = 20;




public void CardTypes_Repeater_ItemDataBound(Object Sender, RepeaterItemEventArgs e){
	
// CardTypes Show Event begin
// CardTypes Show Event end
}


ICollection CardTypes_CreateDataSource() {

       
       // CardTypes Show begin
	CardTypes_sSQL = "";
	CardTypes_sCountSQL = "";

	string sWhere = "", sOrder = "";

	
	bool HasParam = false;
	
	
	//-------------------------------
	// Build ORDER BY statement
	//-------------------------------
	sOrder = " order by c.name Asc";
	if(Utility.GetParam("FormCardTypes_Sorting").Length>0&&!IsPostBack)
	{ViewState["SortColumn"]=Utility.GetParam("FormCardTypes_Sorting");
	 ViewState["SortDir"]="ASC";}
	if(ViewState["SortColumn"]!=null) sOrder = " ORDER BY " + ViewState["SortColumn"].ToString()+" "+ViewState["SortDir"].ToString();
	
	System.Collections.Specialized.StringDictionary Params =new System.Collections.Specialized.StringDictionary();
	
	

	

	//-------------------------------
	// Build base SQL statement
	//-------------------------------


	CardTypes_sSQL = "select [c].[card_type_id] as c_card_type_id, " +
    "[c].[name] as c_name " +
    " from [card_types] c ";
	
	//-------------------------------
	//-------------------------------
	

	//-------------------------------

	//-------------------------------
	// Assemble full SQL statement
	//-------------------------------



	  CardTypes_sSQL = CardTypes_sSQL + sWhere + sOrder;
	//-------------------------------
	
	OleDbDataAdapter command = new OleDbDataAdapter(CardTypes_sSQL, Utility.Connection);
	DataSet ds = new DataSet();
	 	
	command.Fill(ds, 0, CardTypes_PAGENUM, "CardTypes");
	DataView Source;
        Source = new DataView(ds.Tables[0]);

		if (ds.Tables[0].Rows.Count == 0){
			CardTypes_no_records.Visible = true;
			}
		else
			{CardTypes_no_records.Visible = false;
			}
		
		
		return Source;
		// CardTypes Show end
		
	}
	

	void CardTypes_Bind() {
		CardTypes_Repeater.DataSource = CardTypes_CreateDataSource();
		CardTypes_Repeater.DataBind();
		
	}

	void CardTypes_insert_Click(Object Src, EventArgs E) {
		string sURL = CardTypes_FormAction+"";
		Response.Redirect(sURL);
	}

	protected void CardTypes_SortChange(Object Src, EventArgs E) {
		if(ViewState["SortColumn"]==null || ViewState["SortColumn"].ToString()!=((LinkButton)Src).CommandArgument){
			ViewState["SortColumn"]=((LinkButton)Src).CommandArgument; 
			ViewState["SortDir"]="ASC";
		}else{
			ViewState["SortDir"]=ViewState["SortDir"].ToString()=="ASC"?"DESC":"ASC";
		}
		CardTypes_Bind();
	}



    }
}