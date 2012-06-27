namespace Book_Store
{
	
//
//    Filename: BookMaint.cs
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
    ///    Summary description for BookMaint.
    /// </summary>

	public partial class BookMaint : System.Web.UI.Page
	
    { 



//BookMaint CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Book variables and controls declarations
		
		// For each Book form hiddens for PK's,List of Values and Actions
		protected string Book_FormAction="AdminBooks.aspx?";

	
	public BookMaint()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// BookMaint CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// BookMaint Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// BookMaint Open Event begin
// BookMaint Open Event end
		//===============================
		
		//===============================
// BookMaint OpenAnyPage Event begin
// BookMaint OpenAnyPage Event end
		//===============================
		//
		//===============================
		// BookMaint PageSecurity begin
		Utility.CheckSecurity(2);
		// BookMaint PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Book_item_id.Value = Utility.GetParam("item_id");Page_Show(sender, e);
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
		Book_insert.ServerClick += new System.EventHandler (this.Book_Action);
		Book_update.ServerClick += new System.EventHandler (this.Book_Action);
		Book_delete.ServerClick += new System.EventHandler (this.Book_Action);
		Book_cancel.ServerClick += new System.EventHandler (this.Book_Action);
		
		
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
		Book_Show();
		
        }



// BookMaint Show end

// End of Login form 






private bool Book_Validate(){
	bool result=true;
	Book_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Book")){
			if(!Page.Validators[i].IsValid){
				Book_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Book_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Book_Show() {
	
	// Book Show begin
	Utility.buildListBox(Book_category_id.Items,"select category_id,name from categories order by 2","category_id","name",null,"");

	bool ActionInsert=true;
	
	if (p_Book_item_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "item_id=" + CCUtility.ToSQL(p_Book_item_id.Value, FieldTypes.Number);
		
// Book Open Event begin
// Book Open Event end
		string sSQL = "select * from items where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Book") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Book_item_id.Value = CCUtility.GetValue(row, "item_id");
		

	Book_name.Text = CCUtility.GetValue(row, "name");
	Book_author.Text = CCUtility.GetValue(row, "author");
	
		{string s;
		s=CCUtility.GetValue(row, "category_id");
		
		try {Book_category_id.SelectedIndex=Book_category_id.Items.IndexOf(Book_category_id.Items.FindByValue(s));
		}catch{}}
		

	Book_price.Text = CCUtility.GetValue(row, "price");
	Book_product_url.Text = CCUtility.GetValue(row, "product_url");
	Book_image_url.Text = CCUtility.GetValue(row, "image_url");
	Book_notes.Text = CCUtility.GetValue(row, "notes");
		

	Book_is_recommended.Checked=CCUtility.GetValue(row, "is_recommended").ToLower().Equals("1".ToLower());
	
	Book_insert.Visible=false;
		ActionInsert=false;
		
// Book ShowEdit Event begin
// Book ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("item_id");Book_item_id.Value = pValue;
		pValue = Utility.GetParam("category_id");
		try {Book_category_id.SelectedIndex=Book_category_id.Items.IndexOf(Book_category_id.Items.FindByValue(pValue));
		}catch{}
	Book_delete.Visible=false;
	Book_update.Visible=false;
	
// Book ShowInsert Event begin
// Book ShowInsert Event end

}



// Book Open Event begin
// Book Open Event end

// Book Show Event begin
// Book Show Event end

	// Book Show end
	
// Book Close Event begin
// Book Close Event end

	}
	
	// Book Action begin
	
bool Book_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=Book_Validate();
		
// Book Check Event begin
// Book Check Event end

		string p2_name=CCUtility.ToSQL(Utility.GetParam("Book_name"), FieldTypes.Text) ;
		string p2_author=CCUtility.ToSQL(Utility.GetParam("Book_author"), FieldTypes.Text) ;
		string p2_category_id=CCUtility.ToSQL(Utility.GetParam("Book_category_id"), FieldTypes.Number) ;
		string p2_price=CCUtility.ToSQL(Utility.GetParam("Book_price"), FieldTypes.Number) ;
		string p2_product_url=CCUtility.ToSQL(Utility.GetParam("Book_product_url"), FieldTypes.Text) ;
		string p2_image_url=CCUtility.ToSQL(Utility.GetParam("Book_image_url"), FieldTypes.Text) ;
		string p2_notes=CCUtility.ToSQL(Utility.GetParam("Book_notes"), FieldTypes.Text) ;
		string c1_is_recommended=CCUtility.getCheckBoxValue(Utility.GetParam("Book_is_recommended"), "1", "0", FieldTypes.Number) ;
// Book Insert Event begin
// Book Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into items (" +
				"name," +
				"author," +
				"category_id," +
				"price," +
				"product_url," +
				"image_url," +
				"notes," +
				"is_recommended)" +
				" values (" +
				p2_name + "," + 
				p2_author + "," + 
				p2_category_id + "," + 
				p2_price + "," + 
				p2_product_url + "," + 
				p2_image_url + "," + 
				p2_notes + "," + 
				c1_is_recommended + ")";
			}
			Book_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Book_ValidationSummary.Text += e.Message;
				Book_ValidationSummary.Visible = true;
				return false;
			}
			
// Book AfterInsert Event begin
// Book AfterInsert Event end
		}
		return bResult;
	}


	void Book_BeforeSQLExecute(string SQL,String Action){
	  
// Book BeforeExecute Event begin
// Book BeforeExecute Event end

	}

	
	bool Book_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Book_Validate();
		if(bResult){
		
	        if (p_Book_item_id.Value.Length > 0) {
        	    sWhere = sWhere + "item_id=" + CCUtility.ToSQL(p_Book_item_id.Value, FieldTypes.Number);
		    }
		
// Book Check Event begin
// Book Check Event end

		if (bResult){
		
		sSQL = "update items set " +
		"[name]=" +CCUtility.ToSQL(Utility.GetParam("Book_name"),FieldTypes.Text)  +
		",[author]=" +CCUtility.ToSQL(Utility.GetParam("Book_author"),FieldTypes.Text)  +
		",[category_id]=" +CCUtility.ToSQL(Utility.GetParam("Book_category_id"),FieldTypes.Number)  +
		",[price]=" +CCUtility.ToSQL(Utility.GetParam("Book_price"),FieldTypes.Number)  +
		",[product_url]=" +CCUtility.ToSQL(Utility.GetParam("Book_product_url"),FieldTypes.Text)  +
		",[image_url]=" +CCUtility.ToSQL(Utility.GetParam("Book_image_url"),FieldTypes.Text)  +
		",[notes]=" +CCUtility.ToSQL(Utility.GetParam("Book_notes"),FieldTypes.Text)  +
		",[is_recommended]=" +CCUtility.getCheckBoxValue(Utility.GetParam("Book_is_recommended"),"1","0",FieldTypes.Number) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Book Update Event begin
// Book Update Event end
Book_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Book_ValidationSummary.Text += e.Message;
				Book_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Book AfterUpdate Event begin
// Book AfterUpdate Event end
		}
		}
		return bResult;
	}

bool Book_delete_Click(Object Src, EventArgs E) {
	string sWhere = "";
	
	if (p_Book_item_id.Value.Length > 0) {
		sWhere += "item_id=" + CCUtility.ToSQL(p_Book_item_id.Value, FieldTypes.Number);
	}
	
	string sSQL = "delete from items where " + sWhere;
	
// Book Delete Event begin
// Book Delete Event end
Book_BeforeSQLExecute(sSQL,"Delete");
	OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
	try {
		cmd.ExecuteNonQuery();
	} catch(Exception e) {
		Book_ValidationSummary.Text += e.Message;
		Book_ValidationSummary.Visible = true;
		return false;
	}
	
// Book AfterDelete Event begin
// Book AfterDelete Event end
	return true;
}

bool Book_cancel_Click(Object Src, EventArgs E) {
        
// Book BeforeCancel Event begin
// Book BeforeCancel Event end

	return true;
	}

void Book_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=Book_insert_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Book_update_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("delete")>0) bResult=Book_delete_Click(Src,E);
if(((HtmlInputButton)Src).ID.IndexOf("cancel")>0) bResult=Book_cancel_Click(Src,E);
					

if(bResult)Response.Redirect(Book_FormAction+"category_id=" + Server.UrlEncode(Utility.GetParam("category_id")) + "&");
}
// Book Action end



    }
}