namespace Book_Store
{
	
//
//    Filename: EditorialCatRecord.cs
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
    ///    Summary description for EditorialCatRecord.
    /// </summary>

	public partial class EditorialCatRecord : System.Web.UI.Page
	
    { 



//EditorialCatRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form editorial_categories variables and controls declarations
		
		// For each editorial_categories form hiddens for PK's,List of Values and Actions
		protected string editorial_categories_FormAction="EditorialCatGrid.aspx?";

	
	public EditorialCatRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// EditorialCatRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// EditorialCatRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// EditorialCatRecord Open Event begin
// EditorialCatRecord Open Event end
		//===============================
		
		//===============================
// EditorialCatRecord OpenAnyPage Event begin
// EditorialCatRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// EditorialCatRecord PageSecurity begin
		Utility.CheckSecurity(2);
		// EditorialCatRecord PageSecurity end
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
		editorial_categories_insert.ServerClick += new System.EventHandler (this.editorial_categories_Action);
		editorial_categories_update.ServerClick += new System.EventHandler (this.editorial_categories_Action);
		editorial_categories_delete.ServerClick += new System.EventHandler (this.editorial_categories_Action);
		editorial_categories_cancel.ServerClick += new System.EventHandler (this.editorial_categories_Action);
		
		
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
		editorial_categories_Show();
		
        }



// EditorialCatRecord Show end

// End of Login form 






private bool editorial_categories_Validate(){
	bool result=true;
	editorial_categories_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("editorial_categories")){
			if(!Page.Validators[i].IsValid){
				editorial_categories_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	editorial_categories_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void editorial_categories_Show() {
	
	// editorial_categories Show begin
	
	bool ActionInsert=true;
	
	if (p_editorial_categories_editorial_cat_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "editorial_cat_id=" + CCUtility.ToSQL(p_editorial_categories_editorial_cat_id.Value, FieldTypes.Number);
		
// editorial_categories Open Event begin
// editorial_categories Open Event end
		string sSQL = "select * from editorial_categories where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "editorial_categories") > 0) {
		row = ds.Tables[0].Rows[0];
				
	editorial_categories_editorial_cat_id.Value = CCUtility.GetValue(row, "editorial_cat_id");
		

	editorial_categories_editorial_cat_name.Text = CCUtility.GetValue(row, "editorial_cat_name");
	editorial_categories_insert.Visible=false;
		ActionInsert=false;
		
// editorial_categories ShowEdit Event begin
// editorial_categories ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("editorial_cat_id");editorial_categories_editorial_cat_id.Value = pValue;editorial_categories_delete.Visible=false;
	editorial_categories_update.Visible=false;
	
// editorial_categories ShowInsert Event begin
// editorial_categories ShowInsert Event end

}



// editorial_categories Open Event begin
// editorial_categories Open Event end

// editorial_categories Show Event begin
// editorial_categories Show Event end

	// editorial_categories Show end
	
// editorial_categories Close Event begin
// editorial_categories Close Event end

	}
	
	// editorial_categories Action begin
	
bool editorial_categories_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=editorial_categories_Validate();
		
// editorial_categories Check Event begin
// editorial_categories Check Event end

		string p2_editorial_cat_name=CCUtility.ToSQL(Utility.GetParam("editorial_categories_editorial_cat_name"), FieldTypes.Text) ;
// editorial_categories Insert Event begin
// editorial_categories Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into editorial_categories (" +
				"editorial_cat_name)" +
				" values (" +
				p2_editorial_cat_name + ")";
			}
			editorial_categories_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				editorial_categories_ValidationSummary.Text += e.Message;
				editorial_categories_ValidationSummary.Visible = true;
				return false;
			}
			
// editorial_categories AfterInsert Event begin
// editorial_categories AfterInsert Event end
		}
		return bResult;
	}


	void editorial_categories_BeforeSQLExecute(string SQL,String Action){
	  
// editorial_categories BeforeExecute Event begin
// editorial_categories BeforeExecute Event end

	}

	
	bool editorial_categories_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=editorial_categories_Validate();
		if(bResult){
		
	        if (p_editorial_categories_editorial_cat_id.Value.Length > 0) {
        	    sWhere = sWhere + "editorial_cat_id=" + CCUtility.ToSQL(p_editorial_categories_editorial_cat_id.Value, FieldTypes.Number);
		    }
		
// editorial_categories Check Event begin
// editorial_categories Check Event end

		if (bResult){
		
		sSQL = "update editorial_categories set " +
		"[editorial_cat_name]=" +CCUtility.ToSQL(Utility.GetParam("editorial_categories_editorial_cat_name"),FieldTypes.Text) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// editorial_categories Update Event begin
// editorial_categories Update Event end
editorial_categories_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				editorial_categories_ValidationSummary.Text += e.Message;
				editorial_categories_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// editorial_categories AfterUpdate Event begin
// editorial_categories AfterUpdate Event end
		}
		}
		return bResult;
	}

bool editorial_categories_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_editorial_categories_editorial_cat_id.Value.Length > 0) {
		sWhere += "editorial_cat_id=" + CCUtility.ToSQL(p_editorial_categories_editorial_cat_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from editorial_categories where " + sWhere;
	
// editorial_categories Delete Event begin
// editorial_categories Delete Event end
editorial_categories_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		editorial_categories_ValidationSummary.Text += e.Message;
		editorial_categories_ValidationSummary.Visible = true;
		return false;
	}
	
// editorial_categories AfterDelete Event begin
// editorial_categories AfterDelete Event end
	return true;
}

bool editorial_categories_cancel_Click(Object Src, EventArgs E) {
        
// editorial_categories BeforeCancel Event begin
// editorial_categories BeforeCancel Event end

	return true;
	}

void editorial_categories_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=editorial_categories_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=editorial_categories_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=editorial_categories_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=editorial_categories_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(editorial_categories_FormAction+"");
}
// editorial_categories Action end



    }
}