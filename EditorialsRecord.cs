namespace Book_Store
{
	
//
//    Filename: EditorialsRecord.cs
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
    ///    Summary description for EditorialsRecord.
    /// </summary>

	public partial class EditorialsRecord : System.Web.UI.Page
	
    { 



//EditorialsRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form editorials variables and controls declarations
		
		// For each editorials form hiddens for PK's,List of Values and Actions
		protected string editorials_FormAction="EditorialsGrid.aspx?";

	
	public EditorialsRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// EditorialsRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// EditorialsRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// EditorialsRecord Open Event begin
// EditorialsRecord Open Event end
		//===============================
		
		//===============================
// EditorialsRecord OpenAnyPage Event begin
// EditorialsRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// EditorialsRecord PageSecurity begin
		Utility.CheckSecurity(2);
		// EditorialsRecord PageSecurity end
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
		editorials_insert.ServerClick += new System.EventHandler (this.editorials_Action);
		editorials_update.ServerClick += new System.EventHandler (this.editorials_Action);
		editorials_delete.ServerClick += new System.EventHandler (this.editorials_Action);
		editorials_cancel.ServerClick += new System.EventHandler (this.editorials_Action);
		
		
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
		editorials_Show();
		
        }



// EditorialsRecord Show end

// End of Login form 






private bool editorials_Validate(){
	bool result=true;
	editorials_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("editorials")){
			if(!Page.Validators[i].IsValid){
				editorials_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	editorials_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void editorials_Show() {
	
	// editorials Show begin
	Utility.buildListBox(editorials_editorial_cat_id.Items,"select editorial_cat_id,editorial_cat_name from editorial_categories order by 2","editorial_cat_id","editorial_cat_name",null,"");
Utility.buildListBox(editorials_item_id.Items,"select item_id,name from items order by 2","item_id","name","","");

	bool ActionInsert=true;
	
	if (p_editorials_article_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "article_id=" + CCUtility.ToSQL(p_editorials_article_id.Value, FieldTypes.Number);
		
// editorials Open Event begin
// editorials Open Event end
		string sSQL = "select * from editorials where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "editorials") > 0) {
		row = ds.Tables[0].Rows[0];
				
	editorials_article_id.Value = CCUtility.GetValue(row, "article_id");
		

	editorials_article_desc.Text = CCUtility.GetValue(row, "article_desc");
	editorials_article_title.Text = CCUtility.GetValue(row, "article_title");
	
		{string s;
		s=CCUtility.GetValue(row, "editorial_cat_id");
		
		try {editorials_editorial_cat_id.SelectedIndex=editorials_editorial_cat_id.Items.IndexOf(editorials_editorial_cat_id.Items.FindByValue(s));
		}catch{}}
		

	
		{string s;
		s=CCUtility.GetValue(row, "item_id");
		
		try {editorials_item_id.SelectedIndex=editorials_item_id.Items.IndexOf(editorials_item_id.Items.FindByValue(s));
		}catch{}}
		

	editorials_insert.Visible=false;
		ActionInsert=false;
		
// editorials ShowEdit Event begin
// editorials ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("article_id");editorials_article_id.Value = pValue;editorials_delete.Visible=false;
	editorials_update.Visible=false;
	
// editorials ShowInsert Event begin
// editorials ShowInsert Event end

}



// editorials Open Event begin
// editorials Open Event end

// editorials Show Event begin
// editorials Show Event end

	// editorials Show end
	
// editorials Close Event begin
// editorials Close Event end

	}
	
	// editorials Action begin
	
bool editorials_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=editorials_Validate();
		
// editorials Check Event begin
// editorials Check Event end

		string p2_article_desc=CCUtility.ToSQL(Utility.GetParam("editorials_article_desc"), FieldTypes.Text) ;
		string p2_article_title=CCUtility.ToSQL(Utility.GetParam("editorials_article_title"), FieldTypes.Text) ;
		string p2_editorial_cat_id=CCUtility.ToSQL(Utility.GetParam("editorials_editorial_cat_id"), FieldTypes.Number) ;
		string p2_item_id=CCUtility.ToSQL(Utility.GetParam("editorials_item_id"), FieldTypes.Number) ;
// editorials Insert Event begin
// editorials Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into editorials (" +
				"article_desc," +
				"article_title," +
				"editorial_cat_id," +
				"item_id)" +
				" values (" +
				p2_article_desc + "," + 
				p2_article_title + "," + 
				p2_editorial_cat_id + "," + 
				p2_item_id + ")";
			}
			editorials_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				editorials_ValidationSummary.Text += e.Message;
				editorials_ValidationSummary.Visible = true;
				return false;
			}
			
// editorials AfterInsert Event begin
// editorials AfterInsert Event end
		}
		return bResult;
	}


	void editorials_BeforeSQLExecute(string SQL,String Action){
	  
// editorials BeforeExecute Event begin
// editorials BeforeExecute Event end

	}

	
	bool editorials_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=editorials_Validate();
		if(bResult){
		
	        if (p_editorials_article_id.Value.Length > 0) {
        	    sWhere = sWhere + "article_id=" + CCUtility.ToSQL(p_editorials_article_id.Value, FieldTypes.Number);
		    }
		
// editorials Check Event begin
// editorials Check Event end

		if (bResult){
		
		sSQL = "update editorials set " +
		"[article_desc]=" +CCUtility.ToSQL(Utility.GetParam("editorials_article_desc"),FieldTypes.Text)  +
		",[article_title]=" +CCUtility.ToSQL(Utility.GetParam("editorials_article_title"),FieldTypes.Text)  +
		",[editorial_cat_id]=" +CCUtility.ToSQL(Utility.GetParam("editorials_editorial_cat_id"),FieldTypes.Number)  +
		",[item_id]=" +CCUtility.ToSQL(Utility.GetParam("editorials_item_id"),FieldTypes.Number) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// editorials Update Event begin
// editorials Update Event end
editorials_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				editorials_ValidationSummary.Text += e.Message;
				editorials_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// editorials AfterUpdate Event begin
// editorials AfterUpdate Event end
		}
		}
		return bResult;
	}

bool editorials_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_editorials_article_id.Value.Length > 0) {
		sWhere += "article_id=" + CCUtility.ToSQL(p_editorials_article_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from editorials where " + sWhere;
	
// editorials Delete Event begin
// editorials Delete Event end
editorials_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		editorials_ValidationSummary.Text += e.Message;
		editorials_ValidationSummary.Visible = true;
		return false;
	}
	
// editorials AfterDelete Event begin
// editorials AfterDelete Event end
	return true;
}

bool editorials_cancel_Click(Object Src, EventArgs E) {
        
// editorials BeforeCancel Event begin
// editorials BeforeCancel Event end

	return true;
	}

void editorials_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=editorials_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=editorials_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=editorials_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=editorials_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(editorials_FormAction+"");
}
// editorials Action end



    }
}