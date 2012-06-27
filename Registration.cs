namespace Book_Store
{
	
//
//    Filename: Registration.cs
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
    ///    Summary description for Registration.
    /// </summary>

	public partial class Registration : System.Web.UI.Page
	
    { 



//Registration CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Reg variables and controls declarations
		
		// For each Reg form hiddens for PK's,List of Values and Actions
		protected string Reg_FormAction="Default.aspx?";

	
	public Registration()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// Registration CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// Registration Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// Registration Open Event begin
// Registration Open Event end
		//===============================
		
		//===============================
// Registration OpenAnyPage Event begin
// Registration OpenAnyPage Event end
		//===============================
		//
		//===============================
		// Registration PageSecurity begin
		// Registration PageSecurity end
		//===============================

		if (!IsPostBack){
			
			if(Session["UserID"]!=null)
			p_Reg_member_id.Value = Session["UserID"].ToString();
			else
			p_Reg_member_id.Value="";
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
		Reg_insert.ServerClick += new System.EventHandler (this.Reg_Action);
		Reg_update.ServerClick += new System.EventHandler (this.Reg_Action);
		Reg_cancel.ServerClick += new System.EventHandler (this.Reg_Action);
		
		
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
		Reg_Show();
		
        }



// Registration Show end

// End of Login form 






private bool Reg_Validate(){
	bool result=true;
	Reg_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Reg")){
			if(!Page.Validators[i].IsValid){
				Reg_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Reg_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Reg_Show() {
	
	// Reg Show begin
	Utility.buildListBox(Reg_card_type_id.Items,"select card_type_id,name from card_types order by 2","card_type_id","name","","");

	bool ActionInsert=true;
	
	if (p_Reg_member_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "member_id=" + CCUtility.ToSQL(p_Reg_member_id.Value, FieldTypes.Number);
		
// Reg Open Event begin
// Reg Open Event end
		string sSQL = "select * from members where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Reg") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Reg_member_id.Value = CCUtility.GetValue(row, "member_id");
		

	Reg_member_login.Text = CCUtility.GetValue(row, "member_login");
	Reg_member_password.Text = CCUtility.GetValue(row, "member_password");
	
	Reg_first_name.Text = CCUtility.GetValue(row, "first_name");
	Reg_last_name.Text = CCUtility.GetValue(row, "last_name");
	Reg_email.Text = CCUtility.GetValue(row, "email");
	Reg_address.Text = CCUtility.GetValue(row, "address");
	Reg_phone.Text = CCUtility.GetValue(row, "phone");
	
		{string s;
		s=CCUtility.GetValue(row, "card_type_id");
		
		try {Reg_card_type_id.SelectedIndex=Reg_card_type_id.Items.IndexOf(Reg_card_type_id.Items.FindByValue(s));
		}catch{}}
		

	Reg_card_number.Text = CCUtility.GetValue(row, "card_number");
	Reg_insert.Visible=false;
		ActionInsert=false;
		
// Reg ShowEdit Event begin
// Reg ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		if(Session["UserID"]!=null)
		pValue = Session["UserID"].ToString();
		else
		pValue="";Reg_member_id.Value = pValue;Reg_update.Visible=false;
	
// Reg ShowInsert Event begin
// Reg ShowInsert Event end

}



// Reg Open Event begin
// Reg Open Event end

// Reg Show Event begin
// Reg Show Event end

	// Reg Show end
	
// Reg Close Event begin
// Reg Close Event end

	}
	
	// Reg Action begin
	
bool Reg_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=Reg_Validate();
		
		{int iCount = Utility.DlookupInt("members", "count(*)", "member_login=" + CCUtility.ToSQL(Utility.GetParam("Reg_member_login"), FieldTypes.Text));
		if (iCount!=0){
			Reg_ValidationSummary.Visible=true;
			Reg_ValidationSummary.Text+="The value in field Login* is already in database."+"<br>";
			bResult=false;}}
		
// Reg Check Event begin
if (Reg_member_password.Text != Reg_member_password2.Text){
Reg_ValidationSummary.Text+="Password and Confirm Password fields don't match"+"<br>";
Reg_ValidationSummary.Visible=true;
bResult=false;
}
// Reg Check Event end

		string p2_member_login=CCUtility.ToSQL(Utility.GetParam("Reg_member_login"), FieldTypes.Text) ;
		string p2_member_password=CCUtility.ToSQL(Utility.GetParam("Reg_member_password"), FieldTypes.Text) ;
		string p2_first_name=CCUtility.ToSQL(Utility.GetParam("Reg_first_name"), FieldTypes.Text) ;
		string p2_last_name=CCUtility.ToSQL(Utility.GetParam("Reg_last_name"), FieldTypes.Text) ;
		string p2_email=CCUtility.ToSQL(Utility.GetParam("Reg_email"), FieldTypes.Text) ;
		string p2_address=CCUtility.ToSQL(Utility.GetParam("Reg_address"), FieldTypes.Text) ;
		string p2_phone=CCUtility.ToSQL(Utility.GetParam("Reg_phone"), FieldTypes.Text) ;
		string p2_card_type_id=CCUtility.ToSQL(Utility.GetParam("Reg_card_type_id"), FieldTypes.Number) ;
		string p2_card_number=CCUtility.ToSQL(Utility.GetParam("Reg_card_number"), FieldTypes.Text) ;
// Reg Insert Event begin
// Reg Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into members (" +
				"member_login," +
				"member_password," +
				"first_name," +
				"last_name," +
				"email," +
				"address," +
				"phone," +
				"card_type_id," +
				"card_number)" +
				" values (" +
				p2_member_login + "," + 
				p2_member_password + "," + 
				p2_first_name + "," + 
				p2_last_name + "," + 
				p2_email + "," + 
				p2_address + "," + 
				p2_phone + "," + 
				p2_card_type_id + "," + 
				p2_card_number + ")";
			}
			Reg_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Reg_ValidationSummary.Text += e.Message;
				Reg_ValidationSummary.Visible = true;
				return false;
			}
			
// Reg AfterInsert Event begin
// Reg AfterInsert Event end
		}
		return bResult;
	}


	void Reg_BeforeSQLExecute(string SQL,String Action){
	  
// Reg BeforeExecute Event begin
// Reg BeforeExecute Event end

	}

	
	bool Reg_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Reg_Validate();
		if(bResult){
		
	        if (p_Reg_member_id.Value.Length > 0) {
        	    sWhere = sWhere + "member_id=" + CCUtility.ToSQL(p_Reg_member_id.Value, FieldTypes.Number);
		    }
		
	        {int iCount = Utility.DlookupInt("members", "count(*)", "member_login=" + CCUtility.ToSQL(Utility.GetParam("Reg_member_login"), FieldTypes.Text) + " and not(" + sWhere + ")");
		if (iCount!=0){
		    Reg_ValidationSummary.Visible=true;
		    Reg_ValidationSummary.Text+="The value in field Login* is already in database."+"<br>";
		    bResult=false;}}
		
// Reg Check Event begin
if (Reg_member_password.Text != Reg_member_password2.Text){
Reg_ValidationSummary.Text+="Password and Confirm Password fields don't match"+"<br>";
Reg_ValidationSummary.Visible=true;
bResult=false;
}
// Reg Check Event end

		if (bResult){
		
		sSQL = "update members set " +
		"[member_login]=" +CCUtility.ToSQL(Utility.GetParam("Reg_member_login"),FieldTypes.Text)  +
		",[member_password]=" +CCUtility.ToSQL(Utility.GetParam("Reg_member_password"),FieldTypes.Text)  +
		",[first_name]=" +CCUtility.ToSQL(Utility.GetParam("Reg_first_name"),FieldTypes.Text)  +
		",[last_name]=" +CCUtility.ToSQL(Utility.GetParam("Reg_last_name"),FieldTypes.Text)  +
		",[email]=" +CCUtility.ToSQL(Utility.GetParam("Reg_email"),FieldTypes.Text)  +
		",[address]=" +CCUtility.ToSQL(Utility.GetParam("Reg_address"),FieldTypes.Text)  +
		",[phone]=" +CCUtility.ToSQL(Utility.GetParam("Reg_phone"),FieldTypes.Text)  +
		",[card_type_id]=" +CCUtility.ToSQL(Utility.GetParam("Reg_card_type_id"),FieldTypes.Number)  +
		",[card_number]=" +CCUtility.ToSQL(Utility.GetParam("Reg_card_number"),FieldTypes.Text) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Reg Update Event begin
// Reg Update Event end
Reg_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Reg_ValidationSummary.Text += e.Message;
				Reg_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Reg AfterUpdate Event begin
// Reg AfterUpdate Event end
		}
		}
		return bResult;
	}

bool Reg_cancel_Click(Object Src, EventArgs E) {
        
// Reg BeforeCancel Event begin
// Reg BeforeCancel Event end

	return true;
	}

void Reg_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=Reg_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Reg_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=Reg_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(Reg_FormAction+"");
}
// Reg Action end



    }
}