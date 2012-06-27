namespace Book_Store
{
	

//
//    Filename: BookDetail.cs
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
    ///    Summary description for BookDetail.
    /// </summary>

	public partial class BookDetail : System.Web.UI.Page
	
    { 



//BookDetail CustomIncludes begin
		protected CCUtility Utility;
		
		//Record form Detail variables and controls declarations
		
		//Record form Order variables and controls declarations
		
		//Record form Rating variables and controls declarations
		
		// For each Detail form hiddens for PK's,List of Values and Actions
		protected string Detail_FormAction="ShoppingCart.aspx?";
		// For each Order form hiddens for PK's,List of Values and Actions
		protected string Order_FormAction="ShoppingCart.aspx?";
		// For each Rating form hiddens for PK's,List of Values and Actions
		protected string Rating_FormAction="BookDetail.aspx?";
protected String[] Rating_rating_lov = "1;Deficient;2;Regular;3;Good;4;Very Good;5;Excellent".Split(new Char[] {';'});

	
	public BookDetail()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// BookDetail CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
//===============================
// BookDetail Show begin
        protected void Page_Load(object sender, EventArgs e)
        {	
		Utility=new CCUtility(this);
		//===============================
// BookDetail Open Event begin
// BookDetail Open Event end
		//===============================
		
		//===============================
// BookDetail OpenAnyPage Event begin
// BookDetail OpenAnyPage Event end
		//===============================
		//
		//===============================
		// BookDetail PageSecurity begin
		Utility.CheckSecurity(1);
		// BookDetail PageSecurity end
		//===============================

		if (!IsPostBack){
			
			p_Detail_item_id.Value = Utility.GetParam("item_id");
			p_Order_order_id.Value = Utility.GetParam("order_id");
			p_Rating_item_id.Value = Utility.GetParam("item_id");Page_Show(sender, e);
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
		
		Order_insert.ServerClick += new System.EventHandler (this.Order_Action);
		
		Rating_update.ServerClick += new System.EventHandler (this.Rating_Action);
		
		
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
		Detail_Show();
		Order_Show();
		Rating_Show();
		
        }



// BookDetail Show end

// End of Login form 






private bool Detail_Validate(){
	bool result=true;
	Detail_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Detail")){
			if(!Page.Validators[i].IsValid){
				Detail_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Detail_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Detail_Show() {
	
	// Detail Show begin
	
	bool ActionInsert=true;
	
	if (p_Detail_item_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "item_id=" + CCUtility.ToSQL(p_Detail_item_id.Value, FieldTypes.Number);
		
// Detail Open Event begin
// Detail Open Event end
		string sSQL = "select * from items where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Detail") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Detail_item_id.Value = CCUtility.GetValue(row, "item_id");
		

	Detail_name.Text =Server.HtmlEncode(CCUtility.GetValue(row, "name").ToString());
		
		
		

	Detail_author.Text =Server.HtmlEncode(CCUtility.GetValue(row, "author").ToString());
		
		
		

	Detail_category_id.Text =Server.HtmlEncode(	Utility.Dlookup("categories", "name", "category_id=" + CCUtility.ToSQL(CCUtility.GetValue(row, "category_id"), FieldTypes.Number)).ToString());
		
		
		

	Detail_price.Text =Server.HtmlEncode(CCUtility.GetValue(row, "price").ToString());
		
		
		

	Detail_image_url.Text =CCUtility.GetValue(row, "image_url");
		
		Detail_image_url.NavigateUrl=CCUtility.GetValue(row, "product_url")+"";
		

	Detail_notes.Text =CCUtility.GetValue(row, "notes");
		
		
		

	Detail_product_url.Text =Server.HtmlEncode(CCUtility.GetValue(row, "product_url").ToString());
		
		Detail_product_url.NavigateUrl=CCUtility.GetValue(row, "product_url")+"";
		

	
		ActionInsert=false;
		
// Detail ShowEdit Event begin
// Detail ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("item_id");Detail_item_id.Value = pValue;
// Detail ShowInsert Event begin
// Detail ShowInsert Event end

}



// Detail Open Event begin
// Detail Open Event end

// Detail Show Event begin
Detail_image_url.ImageUrl=Detail_image_url.Text;
Detail_product_url.Text="Review this book on Amazon.com";
// Detail Show Event end

	// Detail Show end
	
// Detail Close Event begin
// Detail Close Event end

	}
	
	// Detail Action begin
	

	void Detail_BeforeSQLExecute(string SQL,String Action){
	  
// Detail BeforeExecute Event begin
// Detail BeforeExecute Event end

	}

	

// End of Login form 






private bool Order_Validate(){
	bool result=true;
	Order_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Order")){
			if(!Page.Validators[i].IsValid){
				Order_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Order_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Order_Show() {
	
	// Order Show begin
	
	bool ActionInsert=true;
	
	if (p_Order_order_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "order_id=" + CCUtility.ToSQL(p_Order_order_id.Value, FieldTypes.Number);
		
// Order Open Event begin
// Order Open Event end
		string sSQL = "select * from orders where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Order") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Order_order_id.Value = CCUtility.GetValue(row, "order_id");
		

	Order_quantity.Text = CCUtility.GetValue(row, "quantity");
	Order_item_id.Value = CCUtility.GetValue(row, "item_id");
		

	Order_insert.Visible=false;
		ActionInsert=false;
		
// Order ShowEdit Event begin
// Order ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("item_id");Order_item_id.Value = pValue;
// Order ShowInsert Event begin
// Order ShowInsert Event end

}



// Order Open Event begin
// Order Open Event end

// Order Show Event begin
// Order Show Event end

	// Order Show end
	
// Order Close Event begin
// Order Close Event end

	}
	
	// Order Action begin
	
bool Order_insert_Click(Object Src, EventArgs E) {
		string sSQL="";
		bool bResult=Order_Validate();
		
// Order Check Event begin
// Order Check Event end

		string s1_UserID=CCUtility.ToSQL(Session["UserID"].ToString(), FieldTypes.Number); 
		string p2_quantity=CCUtility.ToSQL(Utility.GetParam("Order_quantity"), FieldTypes.Number) ;
		string p2_item_id=CCUtility.ToSQL(Utility.GetParam("Order_item_id"), FieldTypes.Number) ;
// Order Insert Event begin
// Order Insert Event end


		if(bResult){	
			
			if(sSQL.Length==0){
			sSQL = "insert into orders (" +
				"[member_id]," +
				"quantity," +
				"item_id)" +
				" values (" +
				s1_UserID + "," +
				p2_quantity + "," + 
				p2_item_id + ")";
			}
			Order_BeforeSQLExecute(sSQL,"Insert");
			OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Order_ValidationSummary.Text += e.Message;
				Order_ValidationSummary.Visible = true;
				return false;
			}
			
// Order AfterInsert Event begin
// Order AfterInsert Event end
		}
		return bResult;
	}


	void Order_BeforeSQLExecute(string SQL,String Action){
	  
// Order BeforeExecute Event begin
// Order BeforeExecute Event end

	}

	
void Order_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("insert")>0) bResult=Order_insert_Click(Src,E);
					

if(bResult)Response.Redirect(Order_FormAction+"");
}
// Order Action end


// End of Login form 






private bool Rating_Validate(){
	bool result=true;
	Rating_ValidationSummary.Text="";

	for(int i=0;i<Page.Validators.Count;i++){
		if(((System.Web.UI.WebControls.BaseValidator)Page.Validators[i]).ID.ToString().StartsWith("Rating")){
			if(!Page.Validators[i].IsValid){
				Rating_ValidationSummary.Text+=Page.Validators[i].ErrorMessage+"<br>";
				result=false;
			}
		}
	}

	Rating_ValidationSummary.Visible=(!result);
	return result;
}

/*===============================
 Display Record Form
-------------------------------*/


void Rating_Show() {
	
	// Rating Show begin
	Utility.buildListBox(Rating_rating.Items,Rating_rating_lov,null,"");

	bool ActionInsert=true;
	
	if (p_Rating_item_id.Value.Length > 0 ) {
		string sWhere = "";
		
		sWhere += "item_id=" + CCUtility.ToSQL(p_Rating_item_id.Value, FieldTypes.Number);
		
// Rating Open Event begin
// Rating Open Event end
		string sSQL = "select * from items where " + sWhere;
		OleDbDataAdapter dsCommand = new OleDbDataAdapter(sSQL, Utility.Connection);
		DataSet ds = new DataSet();
		DataRow row;

		if (dsCommand.Fill(ds, 0, 1, "Rating") > 0) {
		row = ds.Tables[0].Rows[0];
				
	Rating_item_id.Value = CCUtility.GetValue(row, "item_id");
		

	Rating_rating_view.Text =CCUtility.GetValue(row, "rating");
		
		
		

	Rating_rating_count_view.Text =Server.HtmlEncode(CCUtility.GetValue(row, "rating_count").ToString());
		
		
		

	
		{string s;
		s=CCUtility.GetValue(row, "rating");
		
		try {Rating_rating.SelectedIndex=Rating_rating.Items.IndexOf(Rating_rating.Items.FindByValue(s));
		}catch{}}
		

	Rating_rating_count.Value = CCUtility.GetValue(row, "rating_count");
		

	
		ActionInsert=false;
		
// Rating ShowEdit Event begin
// Rating ShowEdit Event end

	}}

		if(ActionInsert){

		String pValue;

		pValue = Utility.GetParam("item_id");Rating_item_id.Value = pValue;Rating_update.Visible=false;
	
// Rating ShowInsert Event begin
// Rating ShowInsert Event end

}



// Rating Open Event begin
// Rating Open Event end

// Rating Show Event begin
if (Int16.Parse(Rating_rating_view.Text)==0){
  Rating_rating_view.Text="Not rated yet";
  Rating_rating_count_view.Text="";
}else{
  Rating_rating_view.Text="<img src=images/" + System.Math.Round(Double.Parse(Rating_rating.SelectedItem.Value)/Double.Parse(Rating_rating_count.Value)) + "stars.gif>";
}
// Rating Show Event end

	// Rating Show end
	
// Rating Close Event begin
// Rating Close Event end

	}
	
	// Rating Action begin
	

	void Rating_BeforeSQLExecute(string SQL,String Action){
	  
// Rating BeforeExecute Event begin
// Rating BeforeExecute Event end

	}

	
	bool Rating_update_Click(Object Src, EventArgs E) {
	    string sWhere = "";
		string sSQL ="";
		
		bool bResult=Rating_Validate();
		if(bResult){
		
	        if (p_Rating_item_id.Value.Length > 0) {
        	    sWhere = sWhere + "item_id=" + CCUtility.ToSQL(p_Rating_item_id.Value, FieldTypes.Number);
		    }
		
// Rating Check Event begin
// Rating Check Event end

		if (bResult){
		
		sSQL = "update items set " +
		"[rating]=" +CCUtility.ToSQL(Utility.GetParam("Rating_rating"),FieldTypes.Number)  +
		",[rating_count]=" +CCUtility.ToSQL(Utility.GetParam("Rating_rating_count"),FieldTypes.Number) ;

		
	        sSQL = sSQL + " where " + sWhere;
		
// Rating Update Event begin
sSQL="update items set rating=rating+" + Rating_rating.SelectedItem.Value + ", rating_count=rating_count+1 where item_id=" + Rating_item_id.Value;
// Rating Update Event end
Rating_BeforeSQLExecute(sSQL,"Update");
		OleDbCommand cmd = new OleDbCommand(sSQL, Utility.Connection);
			try {
				cmd.ExecuteNonQuery();
			} catch(Exception e) {
				Rating_ValidationSummary.Text += e.Message;
				Rating_ValidationSummary.Visible = true;
				return false;
			}
		}
	        
		if (bResult){
// Rating AfterUpdate Event begin
// Rating AfterUpdate Event end
		}
		}
		return bResult;
	}

void Rating_Action(Object Src, EventArgs E) {
bool bResult=true;
if(((HtmlInputButton)Src).ID.IndexOf("update")>0) bResult=Rating_update_Click(Src,E);
					

if(bResult)Response.Redirect(Rating_FormAction+"item_id=" + Server.UrlEncode(Utility.GetParam("item_id")) + "&");
}
// Rating Action end



    }
}