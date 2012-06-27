namespace Book_Store
{
	
//
//    Filename: CardTypesRecord.cs
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
    ///    Summary description for CardTypesRecord.
    /// </summary>

	public partial class CardTypesRecord : System.Web.UI.Page
	
    { 



//CardTypesRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form CardTypes variables and controls declarations
		
		// For each CardTypes form hiddens for PK's,List of Values and Actions
		protected string CardTypes_FormAction="CardTypesGrid.aspx?";

	
	public CardTypesRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// CardTypesRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// CardTypesRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// CardTypesRecord Open Event begin
// CardTypesRecord Open Event end
		//===============================
		
		//===============================
// CardTypesRecord OpenAnyPage Event begin
// CardTypesRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// CardTypesRecord PageSecurity begin
		Utility.CheckSecurity(2);
		// CardTypesRecord PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_CardTypes_card_type_id.Value = Utility.GetParam("card_type_id");Page_Show(sender, e);
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
		CardTypes_insert.ServerClick += new System.EventHandler (this.CardTypes_Action);
		CardTypes_update.ServerClick += new System.EventHandler (this.CardTypes_Action);
		CardTypes_delete.ServerClick += new System.EventHandler (this.CardTypes_Action);
		CardTypes_cancel.ServerClick += new System.EventHandler (this.CardTypes_Action);
		
		
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
		CardTypes_Show();
		
        }



// CardTypesRecord Show end

// End of Login form 






private bool CardTypes_Validate(){
	bool result=true;
	CardTypes_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("CardTypes")){
			if(!Page.Validators[i].IsValid){
				CardTypes_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	CardTypes_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void CardTypes_Show() {
	
	// CardTypes Show begin
	
	bool ActionInsert=true;
	
	if (p_CardTypes_card_type_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "card_type_id=" + CCUtility.ToSQL(p_CardTypes_card_type_id.Value, FieldTypes.Number);
		
// CardTypes Open Event begin
// CardTypes Open Event end
		string sSQL = "select * from card_types where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "CardTypes") > 0) {
		row = ds.Tables[0].Rows[0];
				
	CardTypes_card_type_id.Value = CCUtility.GetValue(row, "card_type_id");
		

	CardTypes_name.Text = CCUtility.GetValue(row, "name");
	CardTypes_insert.Visible=false;
		ActionInsert=false;
		
// CardTypes ShowEdit Event begin
// CardTypes ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("card_type_id");CardTypes_card_type_id.Value = pValue;CardTypes_delete.Visible=false;
	CardTypes_update.Visible=false;
	
// CardTypes ShowInsert Event begin
// CardTypes ShowInsert Event end

}



// CardTypes Open Event begin
// CardTypes Open Event end

// CardTypes Show Event begin
// CardTypes Show Event end

	// CardTypes Show end
	
// CardTypes Close Event begin
// CardTypes Close Event end

	}
	
	// CardTypes Action begin
	
bool CardTypes_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=CardTypes_Validate();
		
// CardTypes Check Event begin
// CardTypes Check Event end

		string p2_name=CCUtility.ToSQL(Utility.GetParam("CardTypes_name"), FieldTypes.Text) ;
// CardTypes Insert Event begin
// CardTypes Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into card_types (" +
				"name)" +
				" values (" +
				p2_name + ")";
			}
			CardTypes_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				CardTypes_ValidationSummary.Text += e.Message;
				CardTypes_ValidationSummary.Visible = true;
				return false;
			}
			
// CardTypes AfterInsert Event begin
// CardTypes AfterInsert Event end
		}
		return bResult;
	}


	void CardTypes_BeforeSQLExecute(string SQL,String Action){
	  
// CardTypes BeforeExecute Event begin
// CardTypes BeforeExecute Event end

	}

	
	bool CardTypes_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=CardTypes_Validate();
		if(bResult){
		
	        if (p_CardTypes_card_type_id.Value.Length > 0) {
        	    sWhere = sWhere + "card_type_id=" + CCUtility.ToSQL(p_CardTypes_card_type_id.Value, FieldTypes.Number);
		    }
		
// CardTypes Check Event begin
// CardTypes Check Event end

		if (bResult){
		
		sSQL = "update card_types set " +
		"[name]=" +CCUtility.ToSQL(Utility.GetParam("CardTypes_name"),FieldTypes.Text) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// CardTypes Update Event begin
// CardTypes Update Event end
CardTypes_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				CardTypes_ValidationSummary.Text += e.Message;
				CardTypes_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// CardTypes AfterUpdate Event begin
// CardTypes AfterUpdate Event end
		}
		}
		return bResult;
	}

bool CardTypes_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_CardTypes_card_type_id.Value.Length > 0) {
		sWhere += "card_type_id=" + CCUtility.ToSQL(p_CardTypes_card_type_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from card_types where " + sWhere;
	
// CardTypes Delete Event begin
// CardTypes Delete Event end
CardTypes_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		CardTypes_ValidationSummary.Text += e.Message;
		CardTypes_ValidationSummary.Visible = true;
		return false;
	}
	
// CardTypes AfterDelete Event begin
// CardTypes AfterDelete Event end
	return true;
}

bool CardTypes_cancel_Click(Object Src, EventArgs E) {
        
// CardTypes BeforeCancel Event begin
// CardTypes BeforeCancel Event end

	return true;
	}

void CardTypes_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=CardTypes_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=CardTypes_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=CardTypes_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=CardTypes_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(CardTypes_FormAction+"");
}
// CardTypes Action end



    }
}