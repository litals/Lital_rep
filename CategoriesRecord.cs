namespace Book_Store
{
	
//
//    Filename: CategoriesRecord.cs
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
    ///    Summary description for CategoriesRecord.
    /// </summary>

	public partial class CategoriesRecord : System.Web.UI.Page
	
    { 



//CategoriesRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Categories variables and controls declarations
		
		// For each Categories form hiddens for PK's,List of Values and Actions
		protected string Categories_FormAction="CategoriesGrid.aspx?";

	
	public CategoriesRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// CategoriesRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// CategoriesRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// CategoriesRecord Open Event begin
// CategoriesRecord Open Event end
		//===============================
		
		//===============================
// CategoriesRecord OpenAnyPage Event begin
// CategoriesRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// CategoriesRecord PageSecurity begin
		Utility.CheckSecurity(2);
		// CategoriesRecord PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Categories_category_id.Value = Utility.GetParam("category_id");Page_Show(sender, e);
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
		Categories_insert.ServerClick += new System.EventHandler (this.Categories_Action);
		Categories_update.ServerClick += new System.EventHandler (this.Categories_Action);
		Categories_delete.ServerClick += new System.EventHandler (this.Categories_Action);
		Categories_cancel.ServerClick += new System.EventHandler (this.Categories_Action);
		
		
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
		Categories_Show();
		
        }



// CategoriesRecord Show end

// End of Login form 






private bool Categories_Validate(){
	bool result=true;
	Categories_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Categories")){
			if(!Page.Validators[i].IsValid){
				Categories_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Categories_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Categories_Show() {
	
	// Categories Show begin
	
	bool ActionInsert=true;
	
	if (p_Categories_category_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "category_id=" + CCUtility.ToSQL(p_Categories_category_id.Value, FieldTypes.Number);
		
// Categories Open Event begin
// Categories Open Event end
		string sSQL = "select * from categories where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Categories") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Categories_category_id.Value = CCUtility.GetValue(row, "category_id");
		

	Categories_name.Text = CCUtility.GetValue(row, "name");
	Categories_insert.Visible=false;
		ActionInsert=false;
		
// Categories ShowEdit Event begin
// Categories ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("category_id");Categories_category_id.Value = pValue;Categories_delete.Visible=false;
	Categories_update.Visible=false;
	
// Categories ShowInsert Event begin
// Categories ShowInsert Event end

}



// Categories Open Event begin
// Categories Open Event end

// Categories Show Event begin
// Categories Show Event end

	// Categories Show end
	
// Categories Close Event begin
// Categories Close Event end

	}
	
	// Categories Action begin
	
bool Categories_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=Categories_Validate();
		
// Categories Check Event begin
// Categories Check Event end

		string p2_name=CCUtility.ToSQL(Utility.GetParam("Categories_name"), FieldTypes.Text) ;
// Categories Insert Event begin
// Categories Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into categories (" +
				"name)" +
				" values (" +
				p2_name + ")";
			}
			Categories_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Categories_ValidationSummary.Text += e.Message;
				Categories_ValidationSummary.Visible = true;
				return false;
			}
			
// Categories AfterInsert Event begin
// Categories AfterInsert Event end
		}
		return bResult;
	}


	void Categories_BeforeSQLExecute(string SQL,String Action){
	  
// Categories BeforeExecute Event begin
// Categories BeforeExecute Event end

	}

	
	bool Categories_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Categories_Validate();
		if(bResult){
		
	        if (p_Categories_category_id.Value.Length > 0) {
        	    sWhere = sWhere + "category_id=" + CCUtility.ToSQL(p_Categories_category_id.Value, FieldTypes.Number);
		    }
		
// Categories Check Event begin
// Categories Check Event end

		if (bResult){
		
		sSQL = "update categories set " +
		"[name]=" +CCUtility.ToSQL(Utility.GetParam("Categories_name"),FieldTypes.Text) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Categories Update Event begin
// Categories Update Event end
Categories_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Categories_ValidationSummary.Text += e.Message;
				Categories_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Categories AfterUpdate Event begin
// Categories AfterUpdate Event end
		}
		}
		return bResult;
	}

bool Categories_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_Categories_category_id.Value.Length > 0) {
		sWhere += "category_id=" + CCUtility.ToSQL(p_Categories_category_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from categories where " + sWhere;
	
// Categories Delete Event begin
// Categories Delete Event end
Categories_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		Categories_ValidationSummary.Text += e.Message;
		Categories_ValidationSummary.Visible = true;
		return false;
	}
	
// Categories AfterDelete Event begin
// Categories AfterDelete Event end
	return true;
}

bool Categories_cancel_Click(Object Src, EventArgs E) {
        
// Categories BeforeCancel Event begin
// Categories BeforeCancel Event end

	return true;
	}

void Categories_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=Categories_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Categories_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=Categories_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=Categories_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(Categories_FormAction+"");
}
// Categories Action end



    }
}