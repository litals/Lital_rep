namespace Book_Store
{
	
//
//    Filename: MembersRecord.cs
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
    ///    Summary description for MembersRecord.
    /// </summary>

	public partial class MembersRecord : System.Web.UI.Page
	
    { 



//MembersRecord CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Members variables and controls declarations
		
		// For each Members form hiddens for PK's,List of Values and Actions
		protected string Members_FormAction="MembersGrid.aspx?";
protected String[] Members_member_level_lov = "1;Member;2;Administrator".Split(new Char[] {';'});

	
	public MembersRecord()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// MembersRecord CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// MembersRecord Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// MembersRecord Open Event begin
// MembersRecord Open Event end
		//===============================
		
		//===============================
// MembersRecord OpenAnyPage Event begin
// MembersRecord OpenAnyPage Event end
		//===============================
		//
		//===============================
		// MembersRecord PageSecurity begin
		Utility.CheckSecurity(2);
		// MembersRecord PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Members_member_id.Value = Utility.GetParam("member_id");Page_Show(sender, e);
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
		Members_insert.ServerClick += new System.EventHandler (this.Members_Action);
		Members_update.ServerClick += new System.EventHandler (this.Members_Action);
		Members_delete.ServerClick += new System.EventHandler (this.Members_Action);
		Members_cancel.ServerClick += new System.EventHandler (this.Members_Action);
		
		
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
		Members_Show();
		
        }



// MembersRecord Show end

// End of Login form 






private bool Members_Validate(){
	bool result=true;
	Members_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Members")){
			if(!Page.Validators[i].IsValid){
				Members_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Members_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Members_Show() {
	
	// Members Show begin
	Utility.buildListBox(Members_member_level.Items,Members_member_level_lov,null,"");
Utility.buildListBox(Members_card_type_id.Items,"select card_type_id,name from card_types order by 2","card_type_id","name","","");

	bool ActionInsert=true;
	
	if (p_Members_member_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "member_id=" + CCUtility.ToSQL(p_Members_member_id.Value, FieldTypes.Number);
		
// Members Open Event begin
// Members Open Event end
		string sSQL = "select * from members where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Members") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Members_member_id.Value = CCUtility.GetValue(row, "member_id");
		

	Members_member_login.Text = CCUtility.GetValue(row, "member_login");
	Members_member_password.Text = CCUtility.GetValue(row, "member_password");
	
		{string s;
		s=CCUtility.GetValue(row, "member_level");
		
		try {Members_member_level.SelectedIndex=Members_member_level.Items.IndexOf(Members_member_level.Items.FindByValue(s));
		}catch{}}
		

	Members_name.Text = CCUtility.GetValue(row, "first_name");
	Members_last_name.Text = CCUtility.GetValue(row, "last_name");
	Members_email.Text = CCUtility.GetValue(row, "email");
	Members_phone.Text = CCUtility.GetValue(row, "phone");
	Members_address.Text = CCUtility.GetValue(row, "address");
	Members_notes.Text = CCUtility.GetValue(row, "notes");
		

	
		{string s;
		s=CCUtility.GetValue(row, "card_type_id");
		
		try {Members_card_type_id.SelectedIndex=Members_card_type_id.Items.IndexOf(Members_card_type_id.Items.FindByValue(s));
		}catch{}}
		

	Members_card_number.Text = CCUtility.GetValue(row, "card_number");
	Members_insert.Visible=false;
		ActionInsert=false;
		
// Members ShowEdit Event begin
// Members ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("member_id");Members_member_id.Value = pValue;
		pValue = Utility.GetParam("member_login");Members_member_login.Text = pValue;Members_delete.Visible=false;
	Members_update.Visible=false;
	
// Members ShowInsert Event begin
// Members ShowInsert Event end

}



// Members Open Event begin
// Members Open Event end

// Members Show Event begin
// Members Show Event end

	// Members Show end
	
// Members Close Event begin
// Members Close Event end

	}
	
	// Members Action begin
	
bool Members_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=Members_Validate();
		
		{int iCount = Utility.DlookupInt("members", "count(*)", "member_login=" + CCUtility.ToSQL(Utility.GetParam("Members_member_login"), FieldTypes.Text));
		if (iCount!=0){
			Members_ValidationSummary.Visible=true;
			Members_ValidationSummary.Text+="The value in field Login* is already in database."+"<br>";
			bResult=false;}}
		
// Members Check Event begin
// Members Check Event end

		string p2_member_login=CCUtility.ToSQL(Utility.GetParam("Members_member_login"), FieldTypes.Text) ;
		string p2_member_password=CCUtility.ToSQL(Utility.GetParam("Members_member_password"), FieldTypes.Text) ;
		string p2_member_level=CCUtility.ToSQL(Utility.GetParam("Members_member_level"), FieldTypes.Number) ;
		string p2_name=CCUtility.ToSQL(Utility.GetParam("Members_name"), FieldTypes.Text) ;
		string p2_last_name=CCUtility.ToSQL(Utility.GetParam("Members_last_name"), FieldTypes.Text) ;
		string p2_email=CCUtility.ToSQL(Utility.GetParam("Members_email"), FieldTypes.Text) ;
		string p2_phone=CCUtility.ToSQL(Utility.GetParam("Members_phone"), FieldTypes.Text) ;
		string p2_address=CCUtility.ToSQL(Utility.GetParam("Members_address"), FieldTypes.Text) ;
		string p2_notes=CCUtility.ToSQL(Utility.GetParam("Members_notes"), FieldTypes.Text) ;
		string p2_card_type_id=CCUtility.ToSQL(Utility.GetParam("Members_card_type_id"), FieldTypes.Number) ;
		string p2_card_number=CCUtility.ToSQL(Utility.GetParam("Members_card_number"), FieldTypes.Text) ;
// Members Insert Event begin
// Members Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into members (" +
				"member_login," +
				"member_password," +
				"member_level," +
				"first_name," +
				"last_name," +
				"email," +
				"phone," +
				"address," +
				"notes," +
				"card_type_id," +
				"card_number)" +
				" values (" +
				p2_member_login + "," + 
				p2_member_password + "," + 
				p2_member_level + "," + 
				p2_name + "," + 
				p2_last_name + "," + 
				p2_email + "," + 
				p2_phone + "," + 
				p2_address + "," + 
				p2_notes + "," + 
				p2_card_type_id + "," + 
				p2_card_number + ")";
			}
			Members_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Members_ValidationSummary.Text += e.Message;
				Members_ValidationSummary.Visible = true;
				return false;
			}
			
// Members AfterInsert Event begin
// Members AfterInsert Event end
		}
		return bResult;
	}


	void Members_BeforeSQLExecute(string SQL,String Action){
	  
// Members BeforeExecute Event begin
// Members BeforeExecute Event end

	}

	
	bool Members_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Members_Validate();
		if(bResult){
		
	        if (p_Members_member_id.Value.Length > 0) {
        	    sWhere = sWhere + "member_id=" + CCUtility.ToSQL(p_Members_member_id.Value, FieldTypes.Number);
		    }
		
	        {int iCount = Utility.DlookupInt("members", "count(*)", "member_login=" + CCUtility.ToSQL(Utility.GetParam("Members_member_login"), FieldTypes.Text) + " and not(" + sWhere + ")");
		if (iCount!=0){
		    Members_ValidationSummary.Visible=true;
		    Members_ValidationSummary.Text+="The value in field Login* is already in database."+"<br>";
		    bResult=false;}}
		
// Members Check Event begin
// Members Check Event end

		if (bResult){
		
		sSQL = "update members set " +
		"[member_login]=" +CCUtility.ToSQL(Utility.GetParam("Members_member_login"),FieldTypes.Text)  +
		",[member_password]=" +CCUtility.ToSQL(Utility.GetParam("Members_member_password"),FieldTypes.Text)  +
		",[member_level]=" +CCUtility.ToSQL(Utility.GetParam("Members_member_level"),FieldTypes.Number)  +
		",[first_name]=" +CCUtility.ToSQL(Utility.GetParam("Members_name"),FieldTypes.Text)  +
		",[last_name]=" +CCUtility.ToSQL(Utility.GetParam("Members_last_name"),FieldTypes.Text)  +
		",[email]=" +CCUtility.ToSQL(Utility.GetParam("Members_email"),FieldTypes.Text)  +
		",[phone]=" +CCUtility.ToSQL(Utility.GetParam("Members_phone"),FieldTypes.Text)  +
		",[address]=" +CCUtility.ToSQL(Utility.GetParam("Members_address"),FieldTypes.Text)  +
		",[notes]=" +CCUtility.ToSQL(Utility.GetParam("Members_notes"),FieldTypes.Text)  +
		",[card_type_id]=" +CCUtility.ToSQL(Utility.GetParam("Members_card_type_id"),FieldTypes.Number)  +
		",[card_number]=" +CCUtility.ToSQL(Utility.GetParam("Members_card_number"),FieldTypes.Text) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Members Update Event begin
// Members Update Event end
Members_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Members_ValidationSummary.Text += e.Message;
				Members_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Members AfterUpdate Event begin
// Members AfterUpdate Event end
		}
		}
		return bResult;
	}

bool Members_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_Members_member_id.Value.Length > 0) {
		sWhere += "member_id=" + CCUtility.ToSQL(p_Members_member_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from members where " + sWhere;
	
// Members Delete Event begin
// Members Delete Event end
Members_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		Members_ValidationSummary.Text += e.Message;
		Members_ValidationSummary.Visible = true;
		return false;
	}
	
// Members AfterDelete Event begin
// Members AfterDelete Event end
	return true;
}

bool Members_cancel_Click(Object Src, EventArgs E) {
        
// Members BeforeCancel Event begin
// Members BeforeCancel Event end

	return true;
	}

void Members_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=Members_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Members_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=Members_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=Members_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(Members_FormAction+"member_login=" + Server.UrlEncode(Utility.GetParam("member_login")) + "&");
}
// Members Action end



    }
}