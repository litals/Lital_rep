namespace Book_Store
{
	
//
//    Filename: MyInfo.cs
//    Generated with CodeCharge 2.0.5
//    aASP.NET C#.ccp build 03/07/2002
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
    ///    Summary description for MyInfo.
    /// </summary>

	public partial class MyInfo : System.Web.UI.Page
	
    { 



//MyInfo CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Form variables and controls declarations
		
		// For each Form form hiddens for PK's,List of Values and Actions
		protected string Form_FormAction="ShoppingCart.aspx?";

	
	public MyInfo()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// MyInfo CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// MyInfo Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// MyInfo Open Event begin
// MyInfo Open Event end
		//===============================
		
		//===============================
// MyInfo OpenAnyPage Event begin
// MyInfo OpenAnyPage Event end
		//===============================
		//
		//===============================
		// MyInfo PageSecurity begin
		Utility.CheckSecurity(1);
		// MyInfo PageSecurity end
		//===============================

		if (!IsPostBack){
			
			if(Session["UserID"]!=null)
			p_Form_member_id.Value = Session["UserID"].ToString();
			else
			p_Form_member_id.Value="";
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
		Form_update.ServerClick += new System.EventHandler (this.Form_Action);
		Form_cancel.ServerClick += new System.EventHandler (this.Form_Action);
		
		
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
		Form_Show();
		
        }



// MyInfo Show end

// End of Login form 






private bool Form_Validate(){
	bool result=true;
	Form_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Form")){
			if(!Page.Validators[i].IsValid){
				Form_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Form_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Form_Show() {
	
	// Form Show begin
	Utility.buildListBox(Form_card_type_id.Items,"select card_type_id,name from card_types order by 2","card_type_id","name","","");

	bool ActionInsert=true;
	
	if (p_Form_member_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "member_id=" + CCUtility.ToSQL(p_Form_member_id.Value, FieldTypes.Number);
		
// Form Open Event begin
// Form Open Event end
		string sSQL = "select * from members where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Form") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Form_member_id.Value = CCUtility.GetValue(row, "member_id");
		

	Form_member_login.Text =Server.HtmlEncode(CCUtility.GetValue(row, "member_login").ToString());
		
		
		

	Form_member_password.Text = CCUtility.GetValue(row, "member_password");
	Form_name.Text = CCUtility.GetValue(row, "first_name");
	Form_last_name.Text = CCUtility.GetValue(row, "last_name");
	Form_email.Text = CCUtility.GetValue(row, "email");
	Form_address.Text = CCUtility.GetValue(row, "address");
	Form_phone.Text = CCUtility.GetValue(row, "phone");
	Form_notes.Text = CCUtility.GetValue(row, "notes");
		

	
		{string s;
		s=CCUtility.GetValue(row, "card_type_id");
		
		try {Form_card_type_id.SelectedIndex=Form_card_type_id.Items.IndexOf(Form_card_type_id.Items.FindByValue(s));
		}catch{}}
		

	Form_card_number.Text = CCUtility.GetValue(row, "card_number");
	
		ActionInsert=false;
		
// Form ShowEdit Event begin
// Form ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		if(Session["UserID"]!=null)
		pValue = Session["UserID"].ToString();
		else
		pValue="";Form_member_id.Value = pValue;Form_update.Visible=false;
	
// Form ShowInsert Event begin
// Form ShowInsert Event end

}



// Form Open Event begin
// Form Open Event end

// Form Show Event begin
// Form Show Event end

	// Form Show end
	
// Form Close Event begin
// Form Close Event end

	}
	
	// Form Action begin
	

	void Form_BeforeSQLExecute(string SQL,String Action){
	  
// Form BeforeExecute Event begin
// Form BeforeExecute Event end

	}

	
	bool Form_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Form_Validate();
		if(bResult){
		
	        if (p_Form_member_id.Value.Length > 0) {
        	    sWhere = sWhere + "member_id=" + CCUtility.ToSQL(p_Form_member_id.Value, FieldTypes.Number);
		    }
		
// Form Check Event begin
// Form Check Event end

		if (bResult){
		
		sSQL = "update members set " +
		"[member_password]=" +CCUtility.ToSQL(Utility.GetParam("Form_member_password"),FieldTypes.Text)  +
		",[first_name]=" +CCUtility.ToSQL(Utility.GetParam("Form_name"),FieldTypes.Text)  +
		",[last_name]=" +CCUtility.ToSQL(Utility.GetParam("Form_last_name"),FieldTypes.Text)  +
		",[email]=" +CCUtility.ToSQL(Utility.GetParam("Form_email"),FieldTypes.Text)  +
		",[address]=" +CCUtility.ToSQL(Utility.GetParam("Form_address"),FieldTypes.Text)  +
		",[phone]=" +CCUtility.ToSQL(Utility.GetParam("Form_phone"),FieldTypes.Text)  +
		",[notes]=" +CCUtility.ToSQL(Utility.GetParam("Form_notes"),FieldTypes.Text)  +
		",[card_type_id]=" +CCUtility.ToSQL(Utility.GetParam("Form_card_type_id"),FieldTypes.Number)  +
		",[card_number]=" +CCUtility.ToSQL(Utility.GetParam("Form_card_number"),FieldTypes.Text) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Form Update Event begin
// Form Update Event end
Form_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Form_ValidationSummary.Text += e.Message;
				Form_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Form AfterUpdate Event begin
// Form AfterUpdate Event end
		}
		}
		return bResult;
	}

bool Form_cancel_Click(Object Src, EventArgs E) {
        
// Form BeforeCancel Event begin
// Form BeforeCancel Event end

	return true;
	}

void Form_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Form_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=Form_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(Form_FormAction+"");
}
// Form Action end



    }
}